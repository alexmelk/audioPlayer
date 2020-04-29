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
    public partial class addPlayList : MetroFramework.Forms.MetroForm
    {
        public CheckedListBox listBox;
        public addPlayList()
        {
            InitializeComponent();
            listBox = checkedListBox1;
        }

        /// <summary>
        /// Добавляем плейлист
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            var check = (Main_Form.Settings.playLists.Where(x => x.Name == textBox1.Text)).Count() > 0 ? false : true;
            if (check)
            {
                var checkedV = checkedListBox1.CheckedItems.Cast<string>().ToList();
                if (checkedV.Count != 0)
                {
                    Main_Form.Settings.playLists.Add(new Main_Form.PlayList()
                    {
                        Name = textBox1.Text,
                        songsList = checkedV,

                    });
                    Main_Form.updatePlayLists();
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Не выбран ни один трек!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Такой плейлист уже существет!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
    }
}
