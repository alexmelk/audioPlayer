namespace audioPlayer
{
    partial class Main_Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint7 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint8 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint9 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            this.volumeSlider1 = new NAudio.Gui.VolumeSlider();
            this.volumeSlider2 = new NAudio.Gui.VolumeSlider();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.metroToggle1 = new MetroFramework.Controls.MetroToggle();
            this.label3 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbAuthor = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.tbTime = new System.Windows.Forms.TextBox();
            this.btRemove = new System.Windows.Forms.Button();
            this.btAddPlayList = new System.Windows.Forms.Button();
            this.btLastTrack = new System.Windows.Forms.Button();
            this.btEq = new System.Windows.Forms.Button();
            this.btNextTrack = new System.Windows.Forms.Button();
            this.btStop = new System.Windows.Forms.Button();
            this.btPlay = new System.Windows.Forms.Button();
            this.metroToggle2 = new MetroFramework.Controls.MetroToggle();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.metroToggle3 = new MetroFramework.Controls.MetroToggle();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.tbTrackAttr = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // volumeSlider1
            // 
            this.volumeSlider1.Location = new System.Drawing.Point(153, 235);
            this.volumeSlider1.Name = "volumeSlider1";
            this.volumeSlider1.Size = new System.Drawing.Size(93, 26);
            this.volumeSlider1.TabIndex = 6;
            this.volumeSlider1.VolumeChanged += new System.EventHandler(this.volumeSlider1_VolumeChanged);
            // 
            // volumeSlider2
            // 
            this.volumeSlider2.Location = new System.Drawing.Point(-15, -15);
            this.volumeSlider2.Name = "volumeSlider2";
            this.volumeSlider2.Size = new System.Drawing.Size(96, 16);
            this.volumeSlider2.TabIndex = 9;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(271, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "00:00";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AllowDrop = true;
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 384);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(391, 202);
            this.flowLayoutPanel1.TabIndex = 12;
            this.flowLayoutPanel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.flowLayoutPanel1_DragDrop);
            this.flowLayoutPanel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.flowLayoutPanel1_DragEnter);
            // 
            // progressBar1
            // 
            this.progressBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.progressBar1.Location = new System.Drawing.Point(23, 196);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(345, 22);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 14;
            this.progressBar1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.progressBar1_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(7, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "Play List";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Location = new System.Drawing.Point(10, 357);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(169, 21);
            this.listBox1.TabIndex = 21;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // metroToggle1
            // 
            this.metroToggle1.AutoSize = true;
            this.metroToggle1.Checked = true;
            this.metroToggle1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.metroToggle1.Location = new System.Drawing.Point(258, 322);
            this.metroToggle1.Name = "metroToggle1";
            this.metroToggle1.Size = new System.Drawing.Size(80, 17);
            this.metroToggle1.TabIndex = 22;
            this.metroToggle1.Text = "On";
            this.metroToggle1.UseVisualStyleBackColor = true;
            this.metroToggle1.CheckStateChanged += new System.EventHandler(this.metroToggle1_CheckStateChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(255, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "Отобразить все треки";
            // 
            // chart1
            // 
            this.chart1.BorderlineColor = System.Drawing.Color.Black;
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea3.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea3.AxisX.Maximum = 8D;
            chartArea3.AxisX.Minimum = 0D;
            chartArea3.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea3.AxisY.Maximum = 100D;
            chartArea3.AxisY.Minimum = 0D;
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            this.chart1.Location = new System.Drawing.Point(23, 78);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Name = "Series1";
            series3.Points.Add(dataPoint7);
            series3.Points.Add(dataPoint8);
            series3.Points.Add(dataPoint9);
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(136, 112);
            this.chart1.TabIndex = 24;
            this.chart1.Text = "chart1";
            // 
            // timer3
            // 
            this.timer3.Interval = 1;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(165, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 25;
            this.label4.Text = "Название:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(165, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 26;
            this.label5.Text = "Автор:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(165, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 15);
            this.label6.TabIndex = 27;
            this.label6.Text = "Год:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(165, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 15);
            this.label7.TabIndex = 28;
            this.label7.Text = "Длительность:";
            // 
            // tbAuthor
            // 
            this.tbAuthor.BackColor = System.Drawing.Color.White;
            this.tbAuthor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAuthor.Location = new System.Drawing.Point(233, 109);
            this.tbAuthor.Name = "tbAuthor";
            this.tbAuthor.ReadOnly = true;
            this.tbAuthor.Size = new System.Drawing.Size(135, 13);
            this.tbAuthor.TabIndex = 29;
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.White;
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbName.Location = new System.Drawing.Point(233, 87);
            this.tbName.Multiline = true;
            this.tbName.Name = "tbName";
            this.tbName.ReadOnly = true;
            this.tbName.Size = new System.Drawing.Size(135, 20);
            this.tbName.TabIndex = 30;
            // 
            // tbDate
            // 
            this.tbDate.BackColor = System.Drawing.Color.White;
            this.tbDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDate.Location = new System.Drawing.Point(233, 131);
            this.tbDate.Name = "tbDate";
            this.tbDate.ReadOnly = true;
            this.tbDate.Size = new System.Drawing.Size(135, 13);
            this.tbDate.TabIndex = 31;
            // 
            // tbTime
            // 
            this.tbTime.BackColor = System.Drawing.Color.White;
            this.tbTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTime.Location = new System.Drawing.Point(258, 157);
            this.tbTime.Name = "tbTime";
            this.tbTime.ReadOnly = true;
            this.tbTime.Size = new System.Drawing.Size(110, 13);
            this.tbTime.TabIndex = 32;
            // 
            // btRemove
            // 
            this.btRemove.BackgroundImage = global::audioPlayer.Properties.Resources.remove;
            this.btRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btRemove.ForeColor = System.Drawing.Color.Transparent;
            this.btRemove.Location = new System.Drawing.Point(153, 334);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(20, 20);
            this.btRemove.TabIndex = 33;
            this.btRemove.UseVisualStyleBackColor = true;
            this.btRemove.Click += new System.EventHandler(this.btRemove_Click);
            // 
            // btAddPlayList
            // 
            this.btAddPlayList.BackgroundImage = global::audioPlayer.Properties.Resources.addPlayList;
            this.btAddPlayList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btAddPlayList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddPlayList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btAddPlayList.ForeColor = System.Drawing.Color.Transparent;
            this.btAddPlayList.Location = new System.Drawing.Point(127, 334);
            this.btAddPlayList.Name = "btAddPlayList";
            this.btAddPlayList.Size = new System.Drawing.Size(20, 20);
            this.btAddPlayList.TabIndex = 18;
            this.btAddPlayList.UseVisualStyleBackColor = true;
            this.btAddPlayList.Click += new System.EventHandler(this.btAddPlayList_Click);
            // 
            // btLastTrack
            // 
            this.btLastTrack.BackgroundImage = global::audioPlayer.Properties.Resources.lastTrack;
            this.btLastTrack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btLastTrack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLastTrack.ForeColor = System.Drawing.Color.White;
            this.btLastTrack.Location = new System.Drawing.Point(129, 267);
            this.btLastTrack.Name = "btLastTrack";
            this.btLastTrack.Size = new System.Drawing.Size(30, 30);
            this.btLastTrack.TabIndex = 4;
            this.btLastTrack.UseVisualStyleBackColor = true;
            this.btLastTrack.Click += new System.EventHandler(this.button5_Click);
            // 
            // btEq
            // 
            this.btEq.BackgroundImage = global::audioPlayer.Properties.Resources.eq;
            this.btEq.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btEq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEq.ForeColor = System.Drawing.Color.White;
            this.btEq.Location = new System.Drawing.Point(351, 29);
            this.btEq.Name = "btEq";
            this.btEq.Size = new System.Drawing.Size(30, 30);
            this.btEq.TabIndex = 3;
            this.btEq.UseVisualStyleBackColor = true;
            this.btEq.Click += new System.EventHandler(this.btEq_Click);
            // 
            // btNextTrack
            // 
            this.btNextTrack.BackgroundImage = global::audioPlayer.Properties.Resources.nextTrack;
            this.btNextTrack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btNextTrack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNextTrack.ForeColor = System.Drawing.Color.White;
            this.btNextTrack.Location = new System.Drawing.Point(237, 267);
            this.btNextTrack.Name = "btNextTrack";
            this.btNextTrack.Size = new System.Drawing.Size(30, 30);
            this.btNextTrack.TabIndex = 2;
            this.btNextTrack.UseVisualStyleBackColor = true;
            this.btNextTrack.Click += new System.EventHandler(this.btNextTrack_Click);
            // 
            // btStop
            // 
            this.btStop.BackgroundImage = global::audioPlayer.Properties.Resources.stop;
            this.btStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btStop.ForeColor = System.Drawing.Color.White;
            this.btStop.Location = new System.Drawing.Point(201, 267);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(30, 30);
            this.btStop.TabIndex = 1;
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // btPlay
            // 
            this.btPlay.BackgroundImage = global::audioPlayer.Properties.Resources.play;
            this.btPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPlay.ForeColor = System.Drawing.Color.White;
            this.btPlay.Location = new System.Drawing.Point(165, 267);
            this.btPlay.Name = "btPlay";
            this.btPlay.Size = new System.Drawing.Size(30, 30);
            this.btPlay.TabIndex = 0;
            this.btPlay.UseVisualStyleBackColor = true;
            this.btPlay.Click += new System.EventHandler(this.btPlay_Click);
            // 
            // metroToggle2
            // 
            this.metroToggle2.AutoSize = true;
            this.metroToggle2.Location = new System.Drawing.Point(258, 37);
            this.metroToggle2.Name = "metroToggle2";
            this.metroToggle2.Size = new System.Drawing.Size(80, 17);
            this.metroToggle2.TabIndex = 34;
            this.metroToggle2.Text = "Off";
            this.metroToggle2.UseVisualStyleBackColor = true;
            this.metroToggle2.CheckStateChanged += new System.EventHandler(this.metroToggle2_CheckStateChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(269, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 15);
            this.label8.TabIndex = 35;
            this.label8.Text = "Black mode";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(255, 342);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 15);
            this.label9.TabIndex = 37;
            this.label9.Text = "Показать список";
            // 
            // metroToggle3
            // 
            this.metroToggle3.AutoSize = true;
            this.metroToggle3.Checked = true;
            this.metroToggle3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.metroToggle3.Location = new System.Drawing.Point(258, 361);
            this.metroToggle3.Name = "metroToggle3";
            this.metroToggle3.Size = new System.Drawing.Size(80, 17);
            this.metroToggle3.TabIndex = 36;
            this.metroToggle3.Text = "On";
            this.metroToggle3.UseVisualStyleBackColor = true;
            this.metroToggle3.CheckStateChanged += new System.EventHandler(this.metroToggle3_CheckStateChanged);
            // 
            // timer2
            // 
            this.timer2.Interval = 150;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // tbTrackAttr
            // 
            this.tbTrackAttr.BackColor = System.Drawing.Color.White;
            this.tbTrackAttr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTrackAttr.Enabled = false;
            this.tbTrackAttr.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbTrackAttr.Location = new System.Drawing.Point(18, 54);
            this.tbTrackAttr.Name = "tbTrackAttr";
            this.tbTrackAttr.ReadOnly = true;
            this.tbTrackAttr.Size = new System.Drawing.Size(228, 18);
            this.tbTrackAttr.TabIndex = 38;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(10, 592);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 33);
            this.button1.TabIndex = 39;
            this.button1.Text = "Добавить папку";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(272, 592);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 33);
            this.button2.TabIndex = 40;
            this.button2.Text = "Добавить файл";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(391, 630);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbTrackAttr);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.metroToggle3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.metroToggle2);
            this.Controls.Add(this.btRemove);
            this.Controls.Add(this.tbTime);
            this.Controls.Add(this.tbDate);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbAuthor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.metroToggle1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btAddPlayList);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.volumeSlider2);
            this.Controls.Add(this.volumeSlider1);
            this.Controls.Add(this.btLastTrack);
            this.Controls.Add(this.btEq);
            this.Controls.Add(this.btNextTrack);
            this.Controls.Add(this.btStop);
            this.Controls.Add(this.btPlay);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main_Form";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.None;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "audioPlayer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_Form_FormClosed);
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.Move += new System.EventHandler(this.Main_Form_Move);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btPlay;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Button btNextTrack;
        private System.Windows.Forms.Button btEq;
        private System.Windows.Forms.Button btLastTrack;
        private NAudio.Gui.VolumeSlider volumeSlider1;
        private NAudio.Gui.VolumeSlider volumeSlider2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btAddPlayList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private MetroFramework.Controls.MetroToggle metroToggle1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbAuthor;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.TextBox tbTime;
        private System.Windows.Forms.Button btRemove;
        private MetroFramework.Controls.MetroToggle metroToggle2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private MetroFramework.Controls.MetroToggle metroToggle3;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TextBox tbTrackAttr;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

