namespace Temperature
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button_temperatureAdd = new System.Windows.Forms.Button();
            this.textBox_temperatureFrom = new System.Windows.Forms.TextBox();
            this.textBox_temperatureTo = new System.Windows.Forms.TextBox();
            this.textBox_temperatureAddrange = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Timer = new System.Windows.Forms.TextBox();
            this.label_Command = new System.Windows.Forms.Label();
            this.panelVideo = new System.Windows.Forms.PictureBox();
            this.comboBox_CameraDevice = new System.Windows.Forms.ComboBox();
            this.label_CameraDevice = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_CameraAudio = new System.Windows.Forms.ComboBox();
            this.timer_log = new System.Windows.Forms.Timer(this.components);
            this.numericUpDown_temperatureNow = new System.Windows.Forms.NumericUpDown();
            this.checkBox_Shot = new System.Windows.Forms.CheckBox();
            this.checkBox_Pause = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox_ch1 = new System.Windows.Forms.CheckBox();
            this.checkBox_ch2 = new System.Windows.Forms.CheckBox();
            this.checkBox_ch3 = new System.Windows.Forms.CheckBox();
            this.checkBox_ch4 = new System.Windows.Forms.CheckBox();
            this.checkBox_ch5 = new System.Windows.Forms.CheckBox();
            this.checkBox_ch6 = new System.Windows.Forms.CheckBox();
            this.checkBox_ch7 = new System.Windows.Forms.CheckBox();
            this.checkBox_ch8 = new System.Windows.Forms.CheckBox();
            this.checkBox_ch9 = new System.Windows.Forms.CheckBox();
            this.checkBox_cha = new System.Windows.Forms.CheckBox();
            this.checkBox_chb = new System.Windows.Forms.CheckBox();
            this.checkBox_chc = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox_Tempsymbol = new System.Windows.Forms.ComboBox();
            this.button_create = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.panelVideo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_temperatureNow)).BeginInit();
            this.SuspendLayout();
            // 
            // button_temperatureAdd
            // 
            this.button_temperatureAdd.Location = new System.Drawing.Point(180, 271);
            this.button_temperatureAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_temperatureAdd.Name = "button_temperatureAdd";
            this.button_temperatureAdd.Size = new System.Drawing.Size(100, 25);
            this.button_temperatureAdd.TabIndex = 1;
            this.button_temperatureAdd.Text = "Start";
            this.button_temperatureAdd.UseVisualStyleBackColor = true;
            this.button_temperatureAdd.Click += new System.EventHandler(this.button_temperatureAdd_Click);
            // 
            // textBox_temperatureFrom
            // 
            this.textBox_temperatureFrom.Location = new System.Drawing.Point(180, 95);
            this.textBox_temperatureFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_temperatureFrom.Name = "textBox_temperatureFrom";
            this.textBox_temperatureFrom.Size = new System.Drawing.Size(100, 25);
            this.textBox_temperatureFrom.TabIndex = 2;
            this.textBox_temperatureFrom.Text = "20";
            // 
            // textBox_temperatureTo
            // 
            this.textBox_temperatureTo.Location = new System.Drawing.Point(180, 141);
            this.textBox_temperatureTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_temperatureTo.Name = "textBox_temperatureTo";
            this.textBox_temperatureTo.Size = new System.Drawing.Size(100, 25);
            this.textBox_temperatureTo.TabIndex = 3;
            this.textBox_temperatureTo.Text = "40";
            // 
            // textBox_temperatureAddrange
            // 
            this.textBox_temperatureAddrange.Location = new System.Drawing.Point(180, 185);
            this.textBox_temperatureAddrange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_temperatureAddrange.Name = "textBox_temperatureAddrange";
            this.textBox_temperatureAddrange.Size = new System.Drawing.Size(100, 25);
            this.textBox_temperatureAddrange.TabIndex = 4;
            this.textBox_temperatureAddrange.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Temperature Form:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Temperature To:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Temperature Addrange:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Timer Setting:";
            // 
            // textBox_Timer
            // 
            this.textBox_Timer.Location = new System.Drawing.Point(180, 230);
            this.textBox_Timer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Timer.Name = "textBox_Timer";
            this.textBox_Timer.Size = new System.Drawing.Size(100, 25);
            this.textBox_Timer.TabIndex = 10;
            this.textBox_Timer.Text = "1m";
            // 
            // label_Command
            // 
            this.label_Command.AutoSize = true;
            this.label_Command.Location = new System.Drawing.Point(12, 365);
            this.label_Command.Name = "label_Command";
            this.label_Command.Size = new System.Drawing.Size(106, 15);
            this.label_Command.TabIndex = 12;
            this.label_Command.Text = "Picture command";
            // 
            // panelVideo
            // 
            this.panelVideo.Location = new System.Drawing.Point(180, 357);
            this.panelVideo.Margin = new System.Windows.Forms.Padding(4);
            this.panelVideo.Name = "panelVideo";
            this.panelVideo.Size = new System.Drawing.Size(100, 45);
            this.panelVideo.TabIndex = 13;
            this.panelVideo.TabStop = false;
            // 
            // comboBox_CameraDevice
            // 
            this.comboBox_CameraDevice.FormattingEnabled = true;
            this.comboBox_CameraDevice.Location = new System.Drawing.Point(68, 12);
            this.comboBox_CameraDevice.Name = "comboBox_CameraDevice";
            this.comboBox_CameraDevice.Size = new System.Drawing.Size(212, 23);
            this.comboBox_CameraDevice.TabIndex = 14;
            // 
            // label_CameraDevice
            // 
            this.label_CameraDevice.AutoSize = true;
            this.label_CameraDevice.Location = new System.Drawing.Point(12, 15);
            this.label_CameraDevice.Name = "label_CameraDevice";
            this.label_CameraDevice.Size = new System.Drawing.Size(50, 15);
            this.label_CameraDevice.TabIndex = 15;
            this.label_CameraDevice.Text = "Device:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Mic:";
            // 
            // comboBox_CameraAudio
            // 
            this.comboBox_CameraAudio.FormattingEnabled = true;
            this.comboBox_CameraAudio.Location = new System.Drawing.Point(68, 52);
            this.comboBox_CameraAudio.Name = "comboBox_CameraAudio";
            this.comboBox_CameraAudio.Size = new System.Drawing.Size(212, 23);
            this.comboBox_CameraAudio.TabIndex = 17;
            // 
            // timer_log
            // 
            this.timer_log.Tick += new System.EventHandler(this.timer_log_Tick);
            // 
            // numericUpDown_temperatureNow
            // 
            this.numericUpDown_temperatureNow.Location = new System.Drawing.Point(161, 315);
            this.numericUpDown_temperatureNow.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown_temperatureNow.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            -2147483648});
            this.numericUpDown_temperatureNow.Name = "numericUpDown_temperatureNow";
            this.numericUpDown_temperatureNow.Size = new System.Drawing.Size(120, 25);
            this.numericUpDown_temperatureNow.TabIndex = 18;
            this.numericUpDown_temperatureNow.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDown_temperatureNow.ValueChanged += new System.EventHandler(this.numericUpDown_temperatureNow_ValueChanged);
            // 
            // checkBox_Shot
            // 
            this.checkBox_Shot.AutoSize = true;
            this.checkBox_Shot.Location = new System.Drawing.Point(15, 275);
            this.checkBox_Shot.Name = "checkBox_Shot";
            this.checkBox_Shot.Size = new System.Drawing.Size(55, 19);
            this.checkBox_Shot.TabIndex = 19;
            this.checkBox_Shot.Text = "Shot";
            this.checkBox_Shot.UseVisualStyleBackColor = true;
            this.checkBox_Shot.CheckedChanged += new System.EventHandler(this.checkBox_Shot_CheckedChanged);
            // 
            // checkBox_Pause
            // 
            this.checkBox_Pause.AutoSize = true;
            this.checkBox_Pause.Location = new System.Drawing.Point(76, 275);
            this.checkBox_Pause.Name = "checkBox_Pause";
            this.checkBox_Pause.Size = new System.Drawing.Size(61, 19);
            this.checkBox_Pause.TabIndex = 20;
            this.checkBox_Pause.Text = "Pause";
            this.checkBox_Pause.UseVisualStyleBackColor = true;
            this.checkBox_Pause.CheckedChanged += new System.EventHandler(this.checkBox_Pause_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 15);
            this.label4.TabIndex = 21;
            this.label4.Text = "Temperature Now:";
            // 
            // checkBox_ch1
            // 
            this.checkBox_ch1.AutoSize = true;
            this.checkBox_ch1.Location = new System.Drawing.Point(305, 40);
            this.checkBox_ch1.Name = "checkBox_ch1";
            this.checkBox_ch1.Size = new System.Drawing.Size(52, 19);
            this.checkBox_ch1.TabIndex = 22;
            this.checkBox_ch1.Text = "Ch1";
            this.checkBox_ch1.UseVisualStyleBackColor = true;
            this.checkBox_ch1.CheckedChanged += new System.EventHandler(this.checkBox_ch1_CheckedChanged);
            // 
            // checkBox_ch2
            // 
            this.checkBox_ch2.AutoSize = true;
            this.checkBox_ch2.Location = new System.Drawing.Point(363, 40);
            this.checkBox_ch2.Name = "checkBox_ch2";
            this.checkBox_ch2.Size = new System.Drawing.Size(52, 19);
            this.checkBox_ch2.TabIndex = 23;
            this.checkBox_ch2.Text = "Ch2";
            this.checkBox_ch2.UseVisualStyleBackColor = true;
            this.checkBox_ch2.CheckedChanged += new System.EventHandler(this.checkBox_ch2_CheckedChanged);
            // 
            // checkBox_ch3
            // 
            this.checkBox_ch3.AutoSize = true;
            this.checkBox_ch3.Location = new System.Drawing.Point(421, 40);
            this.checkBox_ch3.Name = "checkBox_ch3";
            this.checkBox_ch3.Size = new System.Drawing.Size(52, 19);
            this.checkBox_ch3.TabIndex = 24;
            this.checkBox_ch3.Text = "Ch3";
            this.checkBox_ch3.UseVisualStyleBackColor = true;
            this.checkBox_ch3.CheckedChanged += new System.EventHandler(this.checkBox_ch3_CheckedChanged);
            // 
            // checkBox_ch4
            // 
            this.checkBox_ch4.AutoSize = true;
            this.checkBox_ch4.Location = new System.Drawing.Point(305, 65);
            this.checkBox_ch4.Name = "checkBox_ch4";
            this.checkBox_ch4.Size = new System.Drawing.Size(52, 19);
            this.checkBox_ch4.TabIndex = 25;
            this.checkBox_ch4.Text = "Ch4";
            this.checkBox_ch4.UseVisualStyleBackColor = true;
            this.checkBox_ch4.CheckedChanged += new System.EventHandler(this.checkBox_ch4_CheckedChanged);
            // 
            // checkBox_ch5
            // 
            this.checkBox_ch5.AutoSize = true;
            this.checkBox_ch5.Location = new System.Drawing.Point(363, 65);
            this.checkBox_ch5.Name = "checkBox_ch5";
            this.checkBox_ch5.Size = new System.Drawing.Size(52, 19);
            this.checkBox_ch5.TabIndex = 26;
            this.checkBox_ch5.Text = "Ch5";
            this.checkBox_ch5.UseVisualStyleBackColor = true;
            this.checkBox_ch5.CheckedChanged += new System.EventHandler(this.checkBox_ch5_CheckedChanged);
            // 
            // checkBox_ch6
            // 
            this.checkBox_ch6.AutoSize = true;
            this.checkBox_ch6.Location = new System.Drawing.Point(421, 65);
            this.checkBox_ch6.Name = "checkBox_ch6";
            this.checkBox_ch6.Size = new System.Drawing.Size(52, 19);
            this.checkBox_ch6.TabIndex = 27;
            this.checkBox_ch6.Text = "Ch6";
            this.checkBox_ch6.UseVisualStyleBackColor = true;
            this.checkBox_ch6.CheckedChanged += new System.EventHandler(this.checkBox_ch6_CheckedChanged);
            // 
            // checkBox_ch7
            // 
            this.checkBox_ch7.AutoSize = true;
            this.checkBox_ch7.Location = new System.Drawing.Point(305, 90);
            this.checkBox_ch7.Name = "checkBox_ch7";
            this.checkBox_ch7.Size = new System.Drawing.Size(52, 19);
            this.checkBox_ch7.TabIndex = 28;
            this.checkBox_ch7.Text = "Ch7";
            this.checkBox_ch7.UseVisualStyleBackColor = true;
            this.checkBox_ch7.CheckedChanged += new System.EventHandler(this.checkBox_ch7_CheckedChanged);
            // 
            // checkBox_ch8
            // 
            this.checkBox_ch8.AutoSize = true;
            this.checkBox_ch8.Location = new System.Drawing.Point(363, 90);
            this.checkBox_ch8.Name = "checkBox_ch8";
            this.checkBox_ch8.Size = new System.Drawing.Size(52, 19);
            this.checkBox_ch8.TabIndex = 29;
            this.checkBox_ch8.Text = "Ch8";
            this.checkBox_ch8.UseVisualStyleBackColor = true;
            this.checkBox_ch8.CheckedChanged += new System.EventHandler(this.checkBox_ch8_CheckedChanged);
            // 
            // checkBox_ch9
            // 
            this.checkBox_ch9.AutoSize = true;
            this.checkBox_ch9.Location = new System.Drawing.Point(421, 90);
            this.checkBox_ch9.Name = "checkBox_ch9";
            this.checkBox_ch9.Size = new System.Drawing.Size(52, 19);
            this.checkBox_ch9.TabIndex = 30;
            this.checkBox_ch9.Text = "Ch9";
            this.checkBox_ch9.UseVisualStyleBackColor = true;
            this.checkBox_ch9.CheckedChanged += new System.EventHandler(this.checkBox_ch9_CheckedChanged);
            // 
            // checkBox_cha
            // 
            this.checkBox_cha.AutoSize = true;
            this.checkBox_cha.Location = new System.Drawing.Point(305, 115);
            this.checkBox_cha.Name = "checkBox_cha";
            this.checkBox_cha.Size = new System.Drawing.Size(55, 19);
            this.checkBox_cha.TabIndex = 31;
            this.checkBox_cha.Text = "ChA";
            this.checkBox_cha.UseVisualStyleBackColor = true;
            this.checkBox_cha.CheckedChanged += new System.EventHandler(this.checkBox_cha_CheckedChanged);
            // 
            // checkBox_chb
            // 
            this.checkBox_chb.AutoSize = true;
            this.checkBox_chb.Location = new System.Drawing.Point(363, 115);
            this.checkBox_chb.Name = "checkBox_chb";
            this.checkBox_chb.Size = new System.Drawing.Size(54, 19);
            this.checkBox_chb.TabIndex = 32;
            this.checkBox_chb.Text = "ChB";
            this.checkBox_chb.UseVisualStyleBackColor = true;
            this.checkBox_chb.CheckedChanged += new System.EventHandler(this.checkBox_chb_CheckedChanged);
            // 
            // checkBox_chc
            // 
            this.checkBox_chc.AutoSize = true;
            this.checkBox_chc.Location = new System.Drawing.Point(421, 115);
            this.checkBox_chc.Name = "checkBox_chc";
            this.checkBox_chc.Size = new System.Drawing.Size(54, 19);
            this.checkBox_chc.TabIndex = 33;
            this.checkBox_chc.Text = "ChC";
            this.checkBox_chc.UseVisualStyleBackColor = true;
            this.checkBox_chc.CheckedChanged += new System.EventHandler(this.checkBox_chc_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(302, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 15);
            this.label7.TabIndex = 34;
            this.label7.Text = "Temperature Symbol:";
            // 
            // comboBox_Tempsymbol
            // 
            this.comboBox_Tempsymbol.FormattingEnabled = true;
            this.comboBox_Tempsymbol.Items.AddRange(new object[] {
            "C",
            "F"});
            this.comboBox_Tempsymbol.Location = new System.Drawing.Point(439, 147);
            this.comboBox_Tempsymbol.Name = "comboBox_Tempsymbol";
            this.comboBox_Tempsymbol.Size = new System.Drawing.Size(55, 23);
            this.comboBox_Tempsymbol.TabIndex = 35;
            this.comboBox_Tempsymbol.Tag = "";
            // 
            // button_create
            // 
            this.button_create.Location = new System.Drawing.Point(305, 185);
            this.button_create.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_create.Name = "button_create";
            this.button_create.Size = new System.Drawing.Size(100, 25);
            this.button_create.TabIndex = 36;
            this.button_create.Text = "Create";
            this.button_create.UseVisualStyleBackColor = true;
            this.button_create.Click += new System.EventHandler(this.button_create_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 420);
            this.Controls.Add(this.button_create);
            this.Controls.Add(this.comboBox_Tempsymbol);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.checkBox_chc);
            this.Controls.Add(this.checkBox_chb);
            this.Controls.Add(this.checkBox_cha);
            this.Controls.Add(this.checkBox_ch9);
            this.Controls.Add(this.checkBox_ch8);
            this.Controls.Add(this.checkBox_ch7);
            this.Controls.Add(this.checkBox_ch6);
            this.Controls.Add(this.checkBox_ch5);
            this.Controls.Add(this.checkBox_ch4);
            this.Controls.Add(this.checkBox_ch3);
            this.Controls.Add(this.checkBox_ch2);
            this.Controls.Add(this.checkBox_ch1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBox_Pause);
            this.Controls.Add(this.checkBox_Shot);
            this.Controls.Add(this.numericUpDown_temperatureNow);
            this.Controls.Add(this.comboBox_CameraAudio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label_CameraDevice);
            this.Controls.Add(this.comboBox_CameraDevice);
            this.Controls.Add(this.panelVideo);
            this.Controls.Add(this.label_Command);
            this.Controls.Add(this.textBox_Timer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_temperatureAddrange);
            this.Controls.Add(this.textBox_temperatureTo);
            this.Controls.Add(this.textBox_temperatureFrom);
            this.Controls.Add(this.button_temperatureAdd);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelVideo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_temperatureNow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_temperatureAdd;
        private System.Windows.Forms.TextBox textBox_temperatureFrom;
        private System.Windows.Forms.TextBox textBox_temperatureTo;
        private System.Windows.Forms.TextBox textBox_temperatureAddrange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Timer;
        private System.Windows.Forms.Label label_Command;
        private System.Windows.Forms.PictureBox panelVideo;
        private System.Windows.Forms.ComboBox comboBox_CameraDevice;
        private System.Windows.Forms.Label label_CameraDevice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_CameraAudio;
        private System.Windows.Forms.Timer timer_log;
        private System.Windows.Forms.NumericUpDown numericUpDown_temperatureNow;
        private System.Windows.Forms.CheckBox checkBox_Shot;
        private System.Windows.Forms.CheckBox checkBox_Pause;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox_ch1;
        private System.Windows.Forms.CheckBox checkBox_ch2;
        private System.Windows.Forms.CheckBox checkBox_ch3;
        private System.Windows.Forms.CheckBox checkBox_ch4;
        private System.Windows.Forms.CheckBox checkBox_ch5;
        private System.Windows.Forms.CheckBox checkBox_ch6;
        private System.Windows.Forms.CheckBox checkBox_ch7;
        private System.Windows.Forms.CheckBox checkBox_ch8;
        private System.Windows.Forms.CheckBox checkBox_ch9;
        private System.Windows.Forms.CheckBox checkBox_cha;
        private System.Windows.Forms.CheckBox checkBox_chb;
        private System.Windows.Forms.CheckBox checkBox_chc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox_Tempsymbol;
        private System.Windows.Forms.Button button_create;
    }
}

