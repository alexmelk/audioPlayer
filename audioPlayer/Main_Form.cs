using NAudio.Dsp;
using NAudio.Wave;
using NAudioWpfDemo.EqualizationDemo;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace audioPlayer
{
    public partial class Main_Form : MetroFramework.Forms.MetroForm
    {
        public Main_Form()
        {
            InitializeComponent();
        }
        public static WaveOut Player = new WaveOut();
        public static AudioFileReader Stream;
        public static ProgramSettings Settings = new ProgramSettings();

        public NAudio.Wave.WasapiLoopbackCapture Capt;
        public static EQ Eq = new EQ();
        public static Equalizer Equalizer;
        public static CheckedListBox checkedSongs = new CheckedListBox();
        List<int> picks = new List<int>();
        public static Button btStart = new Button();

        public static ListBox PlayListBox = new ListBox();

        public static string runningLine { get; set; } = default;
        public static int counter { get; set; } = 0;
        public static string trackName { get; set; } = default;
        public static string playlist { get; set; } = default;

        public static TextBox NameTrack { get; set; } = new TextBox();
        public static TextBox Author { get; set; } = new TextBox();
        public static TextBox Date { get; set; } = new TextBox();
        public static TextBox Time { get; set; } = new TextBox();
        ///////////////////////////////////////////////////////////////Кнопки
        /// <summary>
        /// Нажали кнопку play/pause
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btPlay_Click(object sender, EventArgs e)
        {
            if(Player.PlaybackState == PlaybackState.Playing)
            {
                Player.Pause();
                btPlay.BackgroundImage = audioPlayer.Properties.Resources.play;
            }
            else if(Player.PlaybackState == PlaybackState.Paused)
            {
                btPlay.BackgroundImage = audioPlayer.Properties.Resources.pause;
                Player.Play();
            }
            else
            {
                if (trackName == null)
                {
                    if (Settings.songsList.Count != 0)
                    {
                        nextTrack();
                        btPlay.BackgroundImage = audioPlayer.Properties.Resources.pause;
                    }
                }
                else
                {
                    playAudio(trackName);
                }
            }
        }
        /// <summary>
        /// Нажали кнопку stop
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btStop_Click(object sender, EventArgs e)
        {
            if (Stream != null)
            {
                Player.Stop();
                Stream.Position = 0;
                btPlay.BackgroundImage = audioPlayer.Properties.Resources.play;
            }
        }
        /// <summary>
        /// Нажали кнопку следующий трек
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btNextTrack_Click(object sender, EventArgs e)
        {
            nextTrack();
        }
        /// <summary>
        /// Нажали кнопку предыдущий трек
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            lastTrack();
        }
        /// <summary>
        /// Нажали на перемотку
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void progressBar1_MouseClick(object sender, MouseEventArgs e)
        {
            Console.WriteLine(e.X);//344 - max
            Console.WriteLine(Stream.Position);
            var totalSeconds = Stream.TotalTime.TotalSeconds;
            Stream.Position = Convert.ToInt32(Convert.ToInt32((Stream.WaveFormat.BitsPerSample * Stream.WaveFormat.SampleRate * 2) / 8) * e.X * (totalSeconds / 344));
        }
        /// <summary>
        /// Открываем эквалайзер
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btEq_Click(object sender, EventArgs e)
        {
            Eq.Visible = !Eq.Visible;
        }
        /// <summary>
        /// Добавляем плейлист
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btAddPlayList_Click(object sender, EventArgs e)
        {
            addPlayList playList = new addPlayList();
            playList.Show();
            foreach (var el in Settings.songsList)
            {
                playList.listBox.Items.Add(el, false);
            }
        }
        /// <summary>
        /// Удаляем выбранный плейлист
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btRemove_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                Settings.selectedIndex = PlayListBox.SelectedIndex;
                var remove = new removePlayList(listBox1.SelectedItem.ToString());
                remove.Show();

            }
            else
            {
                MessageBox.Show("Выберите плейлист", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        ////////////////////////////////////////////////////////////////////Остальные контроллы
        /// <summary>
        /// Изменяем громкость
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void volumeSlider1_VolumeChanged(object sender, EventArgs e)
        {
            Player.Volume = volumeSlider1.Volume;
        }

        /// <summary>
        /// Начинаем DragAndDrop
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void flowLayoutPanel1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }
        /// <summary>
        /// Обрабатываем файлы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void flowLayoutPanel1_DragDrop(object sender, DragEventArgs e)
        {
            var list = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach(var el in list)
            {
                if (el.Contains(".mp3"))
                {
                    if (!Settings.songsList.Contains(el)) { Settings.songsList.Add(el); }
                }
                else
                {
                    MessageBox.Show("Неподходящий формат файла!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            if (metroToggle1.Checked)
            {
                showAllTracks();
            }
        }
        /// <summary>
        /// Выбор темы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void metroToggle2_CheckStateChanged(object sender, EventArgs e)
        {
            if (metroToggle2.Checked)
            {
                Settings.BlackMode = true;
                blackMode(this);
                blackMode(Eq);

            }
            else
            {
                Settings.BlackMode = false;
                lightMode(this);
                lightMode(Eq);
            }
        }
        /// <summary>
        /// Отображать ли все треки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void metroToggle1_CheckStateChanged(object sender, EventArgs e)
        {
            if (metroToggle1.Checked)
            {
                showAllTracks();
            }
            else
            {
                showAllChangedPlayListTracks();
            }
        }
        /// <summary>
        /// Выводим время трека
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Stream != null)
            {
                label1.Text = Stream.CurrentTime.ToString(@"mm\:ss");
                progressBar1.Maximum = Convert.ToInt32(Stream.TotalTime.TotalSeconds);
                progressBar1.Value = Convert.ToInt32(Stream.CurrentTime.TotalSeconds);
            }
        }
        /// <summary>
        /// Выбрали плейлист
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!metroToggle1.Checked)
            {
                showAllChangedPlayListTracks();
            }
            else
            {
                showAllTracks();
            }
        }
        ///////////////////////////////////////////////////////////////////////////События формы
        /// <summary>
        /// Cобытие после загрузки формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_Form_Load(object sender, EventArgs e)
        {
            Eq = new EQ();
            Eq.Show();
            Eq.Visible = false;

            btStart = btPlay;
            PlayListBox = listBox1;
            NameTrack = tbName;
            Author = tbAuthor;
            Date = tbDate;
            Time = tbTime;

            timer1.Start();
            timer2.Start();
            timer3.Start();

            loadChanges();

            Capt = new WasapiLoopbackCapture();
            Capt.DataAvailable += OnDataAvailable;
            Capt.StartRecording();
            

        }
        /// <summary>
        /// Событие после закрытия формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Capt.StopRecording();
            Settings.Location = this.Location;
            if (volumeSlider1.Volume != Settings.Volume)
            {
                Settings.Volume = volumeSlider1.Volume;
            }
            saveChanges();
        }
        /// <summary>
        /// Событие изменеия положения формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_Form_Move(object sender, EventArgs e)
        {
            var location = this.Location;
            location.X += 390;
            Eq.Location = location;
        }
        //////////////////////////////////////////////////////////////////////////События для графика
        /// <summary>
        /// Воспроизведение остановилось
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void Player_PlaybackStopped(object sender, StoppedEventArgs e)
        {
           if( Stream.TotalTime == Stream.CurrentTime)
            {
                nextTrack();
            }
        }
        /// <summary>
        /// Приняли данные для вывода на график
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void OnDataAvailable(object sender, WaveInEventArgs args)
        {

            float max = 0;
            var buffer = new WaveBuffer(args.Buffer);
            // interpret as 32 bit floating point audio
            List<int> buf = new List<int>();
            for (int index = 0; index < args.BytesRecorded / 4; index++)
            {
                var sample = buffer.FloatBuffer[index];

                // absolute value 
                if (sample < 0) sample = -sample;
                // is this the max value?
                if (sample > max) max = sample;
                buf.Add((int)(sample * 100));
            }
            picks.Clear();
            if (buf.Count != 0)
            {
                for (int i = 0; i < 7; i++)
                {
                    var pick = buf.GetRange(Convert.ToInt32(i * buf.Count/7), Convert.ToInt32(buf.Count / 7));
                    picks.Add(pick.Max());
                }
            }

        }
        /// <summary>
        /// Выводим график
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer3_Tick_1(object sender, EventArgs e)
        {
            try
            {
                chart1.Series[0].Points.Clear();
                chart1.Series[0].Points.Insert(0, new DataPoint(0, 0));
                for (int i = 1; i <= picks.Count; i++)
                {
                    chart1.Series[0].Points.Insert(i, new DataPoint(i, picks[i - 1]));
                }
            }
            catch { }
        }
        
        ////////////////////////////////////////////////////////////////////Пользовательские процедуры
        public static void playAudio(string name)
        {
            if ((name != null)&&(new FileInfo(name).Exists))
            {
                Player.Stop();
                Stream = new AudioFileReader(name);

                TagLib.File tagFile = TagLib.File.Create(name);
                try
                {
                    NameTrack.Text = tagFile.Tag.Title == null ? "Не заполнено" : tagFile.Tag.Title.ToString();
                    Author.Text = tagFile.Tag.FirstPerformer == null ? "Не заполнено" : tagFile.Tag.FirstPerformer.ToString();
                    Date.Text = tagFile.Tag.Year == 0 ? "Не заполнено" : tagFile.Tag.Year.ToString();
                    Time.Text = Stream.TotalTime.ToString(@"mm\:ss");
                    runningLine = string.Format("                       {0} - {1} / Дата: {2} / Длительность: {3} / ch: {4} / Sample Rate: {5} hz                  ", Author.Text, NameTrack.Text, Date.Text, Time.Text, Stream.WaveFormat.Channels,Stream.WaveFormat.SampleRate);
                }
                catch { }
                //var k = info.Attributes;
                Equalizer = new Equalizer(Stream, Settings.bands);
                Player = new WaveOut();
                Player.Init(Equalizer);
                Player.Play();
                btStart.BackgroundImage = audioPlayer.Properties.Resources.pause;
                Player.PlaybackStopped += Player_PlaybackStopped;
            }
        }
        public static void nextTrack()
        {
            if (playlist == default)
            {
                if (Settings.songsList.Count != 0)
                {
                    counter++;
                    if (counter >= Settings.songsList.Count) { counter = 0; }
                    trackName = Settings.songsList[counter];
                    playAudio(trackName);
                }
            }
            else
            {
                counter++;
                var songsList = Settings.playLists.Where(x => x.Name == playlist).FirstOrDefault().songsList;
                if (counter >= songsList.Count) { counter = 0; }
                if (songsList.Count == 0)
                { return; }
                trackName = songsList[counter];
                playAudio(trackName);
            }
        }
        public static void lastTrack()
        {
            if (playlist == default)
            {
                counter = (counter == 0) ? 0 : --counter;
                if (Settings.songsList.Count == 0)
                { return; }
                trackName = Settings.songsList[counter];
                playAudio(trackName);
            }
            else
            {
                counter = (counter == 0) ? 0 : --counter;
                var songsList = Settings.playLists.Where(x => x.Name == playlist).FirstOrDefault().songsList;
                if (songsList.Count == 0)
                { return; }
                trackName = songsList[counter];
                playAudio(trackName);
            }
        }
        public void showAllTracks()
        {
            if (Settings.songsList.Count != 0)
            {
                playlist = default;
                counter = 0;
                trackName = Settings.songsList[0];
                flowLayoutPanel1.Controls.Clear();
                bool remove = true;
                foreach (var song in Settings.songsList)
                {
                    var file = new FileInfo(song);
                    if (file.Exists)
                    {
                        var m = new TrackModel(song)
                        {
                            Margin = new Padding(14, 5, 0, 0),
                            Dock = DockStyle.None
                        };
                        remove = false;
                        flowLayoutPanel1.Controls.Add(m);
                    }
                }
                if (remove)
                {
                    Settings.songsList = Settings.songsList.Where(x => (new FileInfo(x).Exists)).ToList();

                    foreach (var el in Settings.playLists)
                    {
                        if (el.songsList.Contains(trackName))
                        {
                            el.songsList.Remove(trackName);
                        }
                    }
                    saveChanges();
                }
            }
        }
        public void showAllChangedPlayListTracks()
        {
            var playListName = (PlayListBox).SelectedItems.Cast<string>().FirstOrDefault();
            var playList = Settings.playLists.Where(x => x.Name == playListName).FirstOrDefault();
            if (playList != null)
            {
                Player.Stop();

                counter = 0;
                playlist = playListName;
                if (playList.songsList.Count == 0)
                { flowLayoutPanel1.Controls.Clear(); return; }

                trackName = playList.songsList[0];

                playAudio(trackName);

                flowLayoutPanel1.Controls.Clear();

                if (playList != null)
                {
                    foreach (var song in playList.songsList)
                    {
                        var m = new TrackModel(song)
                        {
                            Margin = new Padding(14, 5, 0, 0),
                            Dock = DockStyle.None
                        };

                        flowLayoutPanel1.Controls.Add(m);
                    }
                }
                else
                {
                    flowLayoutPanel1.Controls.Clear();
                }
            }
            else
            {
                flowLayoutPanel1.Controls.Clear();
            }
        }
        public static void updatePlayLists()
        {
            PlayListBox.Items.Clear();
            foreach (var el in Settings.playLists)
            {
                PlayListBox.Items.Add(el.Name);
            }
            if (Settings.playLists.Count != 0)
            {
                PlayListBox.SetSelected(Settings.selectedIndex, true);
            }
            saveChanges();
        }
        public void blackMode(MetroFramework.Forms.MetroForm form)
        {
            form.Theme = MetroFramework.MetroThemeStyle.Dark;
            form.Style = MetroFramework.MetroColorStyle.Blue;
            foreach (var el in form.Controls)
            {
                switch (el)
                {
                    case Label l:
                        {
                            l.ForeColor = Color.White;
                            break;
                        }
                    case TextBox l:
                        {
                            l.ForeColor = Color.White;
                            l.BackColor = Color.Black;
                            break;
                        }
                    case TrackBar l:
                        {
                            l.BackColor = Color.AliceBlue;
                            break;
                        }
                    case Button l:
                        {
                            l.BackColor = Color.White;
                            break;
                        }
                }
            }
            form.Refresh();
        }
        public void lightMode(MetroFramework.Forms.MetroForm form)
        {
            form.Theme = MetroFramework.MetroThemeStyle.Light;
            form.Style = MetroFramework.MetroColorStyle.Black;
            foreach (var el in form.Controls)
            {
                switch(el)
                {
                    case Label l:
                        {
                            l.ForeColor = Color.Black;
                            break;
                        }
                    case TextBox l:
                        {
                            l.ForeColor = Color.Black;
                            l.BackColor = Color.White;
                            break;
                        }
                    case TrackBar l:
                        {
                            l.BackColor = Color.Black;
                            break;
                        }
                }
            }
            form.Refresh();
        }
        private void loadChanges()
        {
            //Пробуем считать файл
            StreamReader stream;
            try
            {
                stream = new StreamReader("config.conf");
                string str = stream.ReadLine();
                //Преобразуем файл из текста в нужный нам список объектов;
                var t = JsonConvert.DeserializeObject(str, typeof(ProgramSettings));

                Settings.Location = (((ProgramSettings)t).Location == null) ? Settings.Location : ((ProgramSettings)t).Location;
                Settings.bands = (((ProgramSettings)t).bands == null) ? Settings.bands : ((ProgramSettings)t).bands;
                Settings.playLists = (((ProgramSettings)t).playLists == null) ? Settings.playLists : ((ProgramSettings)t).playLists;
                Settings.songsList = (((ProgramSettings)t).songsList == null) ? Settings.songsList : ((ProgramSettings)t).songsList;
                Settings.Volume = ((ProgramSettings)t).Volume;
                Settings.BlackMode = ((ProgramSettings)t).BlackMode;
                Settings.ListShow = ((ProgramSettings)t).ListShow;
                stream.Close();
            }
            catch { }
            if (Settings != null)
            {
                metroToggle2.Checked = Settings.BlackMode;

                if (Settings.bands != null)
                {
                    Eq.tr1.Value = (int)Settings.bands[0].Gain;
                    Eq.tr2.Value = (int)Settings.bands[1].Gain;
                    Eq.tr4.Value = (int)Settings.bands[2].Gain;
                    Eq.tr3.Value = (int)Settings.bands[3].Gain;
                    Eq.tr8.Value = (int)Settings.bands[4].Gain;
                    Eq.tr7.Value = (int)Settings.bands[5].Gain;
                    Eq.tr6.Value = (int)Settings.bands[6].Gain;
                    Eq.tr5.Value = (int)Settings.bands[7].Gain;
                }

                Location = Settings.Location;

                if (Location.IsEmpty) { CenterToScreen(); }

                volumeSlider1.Volume = Settings.Volume;
                Player.Volume = Settings.Volume;
                foreach (var el in Settings.playLists)
                {
                    listBox1.Items.Add(el.Name);
                }
                if (Settings.playLists.Count != 0)
                {
                    if (Settings.selectedIndex != null) { listBox1.SetSelected(Settings.selectedIndex, true); }
                }

                showAllTracks();

                metroToggle3.Checked =  Settings.ListShow;

            }
            Eq.labelsUpdate();
        }
        public static void saveChanges()
        {
            string Text = JsonConvert.SerializeObject(Settings);
            //Открываем файл на запись
            StreamWriter stream = new StreamWriter("config.conf");
            stream.WriteLine(Text);
            stream.Close();
        }
        public class ProgramSettings
        {
            public Point Location;
            public float Volume;

            public EqualizerBand[] bands = new EqualizerBand[]
            {
                        new EqualizerBand {Bandwidth = 0.8f, Frequency = 100, Gain = 0},
                        new EqualizerBand {Bandwidth = 0.8f, Frequency = 200, Gain = 0},
                        new EqualizerBand {Bandwidth = 0.8f, Frequency = 400, Gain = 0},
                        new EqualizerBand {Bandwidth = 0.8f, Frequency = 800, Gain = 0},
                        new EqualizerBand {Bandwidth = 0.8f, Frequency = 1200, Gain = 0},
                        new EqualizerBand {Bandwidth = 0.8f, Frequency = 2400, Gain = 0},
                        new EqualizerBand {Bandwidth = 0.8f, Frequency = 4800, Gain = 0},
                        new EqualizerBand {Bandwidth = 0.8f, Frequency = 9600, Gain = 0},
            };
            public List<string> songsList = new List<string>();
            public List<PlayList> playLists = new List<PlayList>();
            public int selectedIndex = 0;
            public bool BlackMode = false;
            public bool ListShow = false;
        }
        public class PlayList
        {
            public string Name;
            public List<string> songsList = new List<string>();
        }

        private void metroToggle3_CheckStateChanged(object sender, EventArgs e)
        {
            //384
            if(metroToggle3.Checked)
            {
                Size = new Size(Size.Width, 630);
                Settings.ListShow = true;
            }
            else
            {
                Size = new Size(Size.Width, 384);
                Settings.ListShow = false;
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if ((runningLine != null)&&(runningLine.Length != 0))
            {
                runningLine = runningLine.Substring(1) + runningLine[0];
                tbTrackAttr.Text = runningLine;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            var el = openFileDialog.FileName;
            if (el.Contains(".mp3"))
            {
                if (!Settings.songsList.Contains(el)) { Settings.songsList.Add(el); }
                showAllTracks();
            }
            else
            {
                MessageBox.Show("Неподходящий формат файла!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowDialog();
            if (dialog.SelectedPath != "")
            {
                overFlow = false;
                recursion(dialog.SelectedPath);
                showAllTracks();
            }

        }
        bool overFlow = false;
        void recursion(string directory)
        {
            if (counter == 1000)
            {
                MessageBox.Show("Слишком много файлов!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                overFlow = true;
                return;
            }
            counter++;
            var tracks = Directory.GetFiles(directory).Where(x => x.Contains(".mp3")).Where(x=>!Settings.songsList.Contains(x));
            if (tracks != null)
            {
                Settings.songsList.AddRange(tracks);
            }
            var dir = Directory.GetDirectories(directory);
            foreach (var el in dir)
            {
                if (!overFlow)
                {
                    recursion(el);
                }
            }


        }
    }

}
