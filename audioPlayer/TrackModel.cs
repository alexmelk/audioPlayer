using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;
using NAudioWpfDemo.EqualizationDemo;
using System.IO;

namespace audioPlayer
{
    public partial class TrackModel : UserControl
    {
        public TrackModel(string audioName)
        {
            InitializeComponent();
            AudioName = audioName;
        }
        public string AudioName { get; set; }
        public string TotalTime { get; set; }
        /// <summary>
        /// Загружаем карточку трека
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TrackModel_Load(object sender, EventArgs e)
        {
            textBox2.Text = AudioName;
            try
            {
                TagLib.File tagFile = TagLib.File.Create(AudioName);
                textBox2.Text = String.Format("{0} - {1}", tagFile.Tag.FirstPerformer, tagFile.Tag.Title);
                var t = new AudioFileReader(AudioName);

                textBox3.Text = String.Format("{0} hz : {1} ch : {2} с", t.WaveFormat.SampleRate, t.WaveFormat.Channels, t.TotalTime.ToString(@"mm\:ss"));
            }
            catch {
            }
        }
        /// <summary>
        /// Включаем трек по двойному нажатию
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TrackModel_DoubleClick(object sender, EventArgs e)
        {
            Main_Form.playAudio(AudioName);
        }
        /// <summary>
        /// Удаляем трек
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btRemove_Click(object sender, EventArgs e)
        {
            Main_Form.Settings.songsList.Remove(AudioName);

            foreach (var el in Main_Form.Settings.playLists)
            {
                if (el.songsList.Contains(AudioName))
                {
                    el.songsList.Remove(AudioName);
                }
            }
            Main_Form.saveChanges();
            this.Visible = false;
        }
    }
}
