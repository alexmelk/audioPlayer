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
    public partial class EQ : MetroFramework.Forms.MetroForm
    {
        public EQ()
        {
            InitializeComponent();
        }
        public TrackBar tr1 = new TrackBar();
        public TrackBar tr2 = new TrackBar();
        public TrackBar tr3 = new TrackBar();
        public TrackBar tr4 = new TrackBar();
        public TrackBar tr5 = new TrackBar();
        public TrackBar tr6 = new TrackBar();
        public TrackBar tr7 = new TrackBar();
        public TrackBar tr8 = new TrackBar();
        private void EQ_Load(object sender, EventArgs e)
        {
            tr1 = trackBar1;
            tr2 = trackBar2;
            tr3 = trackBar3;
            tr4 = trackBar4;
            tr5 = trackBar5;
            tr6 = trackBar6;
            tr7 = trackBar7;
            tr8 = trackBar8;

        }
        public void labelsUpdate()
        {
            label1.Text = (tr1.Value > 0 ? "+" + tr1.Value.ToString() : tr1.Value.ToString()) + " db";
            label2.Text = (tr2.Value > 0 ? "+" + tr2.Value.ToString() : tr2.Value.ToString()) + " db";
            label3.Text = (tr4.Value > 0 ? "+" + tr4.Value.ToString() : tr4.Value.ToString()) + " db";
            label4.Text = (tr3.Value > 0 ? "+" + tr3.Value.ToString() : tr3.Value.ToString()) + " db";
            label5.Text = (tr8.Value > 0 ? "+" + tr8.Value.ToString() : tr8.Value.ToString()) + " db";
            label6.Text = (tr7.Value > 0 ? "+" + tr7.Value.ToString() : tr7.Value.ToString()) + " db";
            label7.Text = (tr6.Value > 0 ? "+" + tr6.Value.ToString() : tr6.Value.ToString()) + " db";
            label8.Text = (tr5.Value > 0 ? "+" + tr5.Value.ToString() : tr5.Value.ToString()) + " db";

        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            try
            {
                Main_Form.Settings.bands[0].Gain = trackBar1.Value;
                Main_Form.Equalizer.Update();
                var value = trackBar1.Value;
                label1.Text = (value > 0 ? "+" + value.ToString() : value.ToString()) + " db";
                Main_Form.saveChanges();
            }
            catch { }
        }
        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            Main_Form.Settings.bands[1].Gain = trackBar2.Value;
            Main_Form.Equalizer.Update();
            var value = trackBar2.Value;
            label2.Text = (value > 0 ? "+" + value.ToString() : value.ToString()) + " db";
            Main_Form.saveChanges();
        }
        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            Main_Form.Settings.bands[2].Gain = trackBar4.Value;
            Main_Form.Equalizer.Update();
            var value = trackBar4.Value;
            label3.Text = (value > 0 ? "+" + value.ToString() : value.ToString()) + " db";
            Main_Form.saveChanges();
        }
        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            Main_Form.Settings.bands[3].Gain = trackBar3.Value;
            Main_Form.Equalizer.Update();
            var value = trackBar3.Value;
            label4.Text = (value > 0 ? "+" + value.ToString() : value.ToString()) + " db";
            Main_Form.saveChanges();
        }
        private void trackBar8_Scroll(object sender, EventArgs e)
        {
            Main_Form.Settings.bands[4].Gain = trackBar8.Value;
            Main_Form.Equalizer.Update();
            var value = trackBar8.Value;
            label5.Text = (value > 0 ? "+" + value.ToString() : value.ToString()) + " db";
            Main_Form.saveChanges();
        }
        private void trackBar7_Scroll(object sender, EventArgs e)
        {
            Main_Form.Settings.bands[5].Gain = trackBar7.Value;
            Main_Form.Equalizer.Update();
            var value = trackBar7.Value;
            label6.Text = (value > 0 ? "+" + value.ToString() : value.ToString()) + " db";
            Main_Form.saveChanges();
        }
        private void trackBar6_Scroll(object sender, EventArgs e)
        {
            Main_Form.Settings.bands[6].Gain = trackBar6.Value;
            Main_Form.Equalizer.Update();
            var value = trackBar6.Value;
            label7.Text = (value > 0 ? "+" + value.ToString() : value.ToString()) + " db";
            Main_Form.saveChanges();
        }
        private void trackBar5_Scroll(object sender, EventArgs e)
        {
            Main_Form.Settings.bands[7].Gain = trackBar5.Value;
            Main_Form.Equalizer.Update();
            var value = trackBar5.Value;
            label8.Text = (value > 0 ? "+" + value.ToString() : value.ToString()) + " db";
            Main_Form.saveChanges();
        }
    }
}
