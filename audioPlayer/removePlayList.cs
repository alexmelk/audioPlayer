using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace audioPlayer
{
    public partial class removePlayList : MetroFramework.Forms.MetroForm
    {
        public string _playListName { get; set; }
        public removePlayList(string playListName)
        {
            InitializeComponent();
            _playListName = playListName;
        }

        /// <summary>
        /// Удаляем плейлист
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            Main_Form.Settings.selectedIndex = Main_Form.Settings.selectedIndex == 0 ? 0 : Main_Form.Settings.selectedIndex - 1;
            Main_Form.Settings.playLists.Remove(Main_Form.Settings.playLists.Where(x => x.Name == _playListName).FirstOrDefault());
            Main_Form.updatePlayLists();
            this.Dispose();
        }
        /// <summary>
        /// Инициализируем форму
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void removePlayList_Load(object sender, EventArgs e)
        {
            textBox1.Text = _playListName;
            var playList = Main_Form.Settings.playLists.Where(x => x.Name == _playListName).FirstOrDefault();
            foreach (var el in Main_Form.Settings.songsList)
            {
                if (playList != null)
                {
                    if (playList.songsList.Contains(el))
                    {
                        checkedListBox1.Items.Add(el, true);
                    }
                    else
                    {
                        checkedListBox1.Items.Add(el, false);
                    }
                }
                else
                {
                    checkedListBox1.Items.Add(el, false);
                }

            }
        }
        /// <summary>
        /// Изменяем плейлист
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            var playList = Main_Form.Settings.playLists.Where(x => x.Name == _playListName).FirstOrDefault();
            playList.songsList.Clear();
            playList.songsList.AddRange(checkedListBox1.CheckedItems.Cast<string>());
            Main_Form.updatePlayLists();
            this.Dispose();
        }
    }
}
