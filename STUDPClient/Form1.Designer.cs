namespace STUDPClient
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
            this.button_p1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.textBox_interval = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button_p2 = new System.Windows.Forms.Button();
            this.button_test = new System.Windows.Forms.Button();
            this.button_auto = new System.Windows.Forms.Button();
            this.button_manual = new System.Windows.Forms.Button();
            this.button_setfps = new System.Windows.Forms.Button();
            this.textBox_fps = new System.Windows.Forms.TextBox();
            this.textBox_prg = new System.Windows.Forms.TextBox();
            this.button_prg = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_lednr = new System.Windows.Forms.TextBox();
            this.gb_type = new System.Windows.Forms.GroupBox();
            this.rb_rgb24_1 = new System.Windows.Forms.RadioButton();
            this.rb_rgb24_2 = new System.Windows.Forms.RadioButton();
            this.button_p3 = new System.Windows.Forms.Button();
            this.rb_rgb8 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.gb_type.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_p1
            // 
            this.button_p1.Location = new System.Drawing.Point(31, 31);
            this.button_p1.Name = "button_p1";
            this.button_p1.Size = new System.Drawing.Size(122, 23);
            this.button_p1.TabIndex = 0;
            this.button_p1.Text = "Start P1 - 3 colors";
            this.button_p1.UseVisualStyleBackColor = true;
            this.button_p1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(31, 138);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Stop";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox_interval
            // 
            this.textBox_interval.Location = new System.Drawing.Point(228, 31);
            this.textBox_interval.Name = "textBox_interval";
            this.textBox_interval.Size = new System.Drawing.Size(100, 20);
            this.textBox_interval.TabIndex = 3;
            this.textBox_interval.Text = "1000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Delay(ms)";
            // 
            // button_p2
            // 
            this.button_p2.Location = new System.Drawing.Point(31, 60);
            this.button_p2.Name = "button_p2";
            this.button_p2.Size = new System.Drawing.Size(122, 23);
            this.button_p2.TabIndex = 5;
            this.button_p2.Text = "Start P2 - WHITE";
            this.button_p2.UseVisualStyleBackColor = true;
            this.button_p2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_test
            // 
            this.button_test.Location = new System.Drawing.Point(443, 28);
            this.button_test.Name = "button_test";
            this.button_test.Size = new System.Drawing.Size(102, 23);
            this.button_test.TabIndex = 6;
            this.button_test.Text = "TEST Mode";
            this.button_test.UseVisualStyleBackColor = true;
            this.button_test.Click += new System.EventHandler(this.button_test_Click);
            // 
            // button_auto
            // 
            this.button_auto.Location = new System.Drawing.Point(443, 60);
            this.button_auto.Name = "button_auto";
            this.button_auto.Size = new System.Drawing.Size(102, 23);
            this.button_auto.TabIndex = 7;
            this.button_auto.Text = "AUTO Mode";
            this.button_auto.UseVisualStyleBackColor = true;
            this.button_auto.Click += new System.EventHandler(this.button_auto_Click);
            // 
            // button_manual
            // 
            this.button_manual.Location = new System.Drawing.Point(443, 99);
            this.button_manual.Name = "button_manual";
            this.button_manual.Size = new System.Drawing.Size(102, 23);
            this.button_manual.TabIndex = 8;
            this.button_manual.Text = "MANUAL Mode";
            this.button_manual.UseVisualStyleBackColor = true;
            this.button_manual.Click += new System.EventHandler(this.button_manual_Click);
            // 
            // button_setfps
            // 
            this.button_setfps.Location = new System.Drawing.Point(31, 338);
            this.button_setfps.Name = "button_setfps";
            this.button_setfps.Size = new System.Drawing.Size(75, 23);
            this.button_setfps.TabIndex = 9;
            this.button_setfps.Text = "Set fps";
            this.button_setfps.UseVisualStyleBackColor = true;
            this.button_setfps.Click += new System.EventHandler(this.button_setfps_Click);
            // 
            // textBox_fps
            // 
            this.textBox_fps.Location = new System.Drawing.Point(132, 341);
            this.textBox_fps.Name = "textBox_fps";
            this.textBox_fps.Size = new System.Drawing.Size(100, 20);
            this.textBox_fps.TabIndex = 10;
            this.textBox_fps.Text = "25";
            // 
            // textBox_prg
            // 
            this.textBox_prg.Location = new System.Drawing.Point(132, 300);
            this.textBox_prg.Name = "textBox_prg";
            this.textBox_prg.Size = new System.Drawing.Size(100, 20);
            this.textBox_prg.TabIndex = 11;
            this.textBox_prg.Text = "0";
            // 
            // button_prg
            // 
            this.button_prg.Location = new System.Drawing.Point(31, 297);
            this.button_prg.Name = "button_prg";
            this.button_prg.Size = new System.Drawing.Size(75, 23);
            this.button_prg.TabIndex = 12;
            this.button_prg.Text = "Set PRG";
            this.button_prg.UseVisualStyleBackColor = true;
            this.button_prg.Click += new System.EventHandler(this.button_prg_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(354, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Led number";
            // 
            // textBox_lednr
            // 
            this.textBox_lednr.Location = new System.Drawing.Point(445, 290);
            this.textBox_lednr.Name = "textBox_lednr";
            this.textBox_lednr.Size = new System.Drawing.Size(100, 20);
            this.textBox_lednr.TabIndex = 14;
            this.textBox_lednr.Text = "100";
            // 
            // gb_type
            // 
            this.gb_type.Controls.Add(this.rb_rgb8);
            this.gb_type.Controls.Add(this.rb_rgb24_2);
            this.gb_type.Controls.Add(this.rb_rgb24_1);
            this.gb_type.Location = new System.Drawing.Point(357, 316);
            this.gb_type.Name = "gb_type";
            this.gb_type.Size = new System.Drawing.Size(100, 102);
            this.gb_type.TabIndex = 17;
            this.gb_type.TabStop = false;
            this.gb_type.Text = "RGB24_type";
            // 
            // rb_rgb24_1
            // 
            this.rb_rgb24_1.AutoSize = true;
            this.rb_rgb24_1.Location = new System.Drawing.Point(6, 19);
            this.rb_rgb24_1.Name = "rb_rgb24_1";
            this.rb_rgb24_1.Size = new System.Drawing.Size(85, 17);
            this.rb_rgb24_1.TabIndex = 16;
            this.rb_rgb24_1.Text = "RGB24_strip";
            this.rb_rgb24_1.UseVisualStyleBackColor = true;
            // 
            // rb_rgb24_2
            // 
            this.rb_rgb24_2.AutoSize = true;
            this.rb_rgb24_2.Checked = true;
            this.rb_rgb24_2.Location = new System.Drawing.Point(6, 44);
            this.rb_rgb24_2.Name = "rb_rgb24_2";
            this.rb_rgb24_2.Size = new System.Drawing.Size(86, 17);
            this.rb_rgb24_2.TabIndex = 17;
            this.rb_rgb24_2.Text = "RGB24_bulb";
            this.rb_rgb24_2.UseVisualStyleBackColor = true;
            // 
            // button_p3
            // 
            this.button_p3.Location = new System.Drawing.Point(31, 89);
            this.button_p3.Name = "button_p3";
            this.button_p3.Size = new System.Drawing.Size(122, 23);
            this.button_p3.TabIndex = 18;
            this.button_p3.Text = "Start P3 - first 3B";
            this.button_p3.UseVisualStyleBackColor = true;
            this.button_p3.Click += new System.EventHandler(this.button_p3_Click);
            // 
            // rb_rgb8
            // 
            this.rb_rgb8.AutoSize = true;
            this.rb_rgb8.Location = new System.Drawing.Point(5, 67);
            this.rb_rgb8.Name = "rb_rgb8";
            this.rb_rgb8.Size = new System.Drawing.Size(54, 17);
            this.rb_rgb8.TabIndex = 18;
            this.rb_rgb8.Text = "RGB8";
            this.rb_rgb8.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 430);
            this.Controls.Add(this.button_p3);
            this.Controls.Add(this.gb_type);
            this.Controls.Add(this.textBox_lednr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_prg);
            this.Controls.Add(this.textBox_prg);
            this.Controls.Add(this.textBox_fps);
            this.Controls.Add(this.button_setfps);
            this.Controls.Add(this.button_manual);
            this.Controls.Add(this.button_auto);
            this.Controls.Add(this.button_test);
            this.Controls.Add(this.button_p2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_interval);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button_p1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.gb_type.ResumeLayout(false);
            this.gb_type.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_p1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox_interval;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button button_p2;
        private System.Windows.Forms.Button button_test;
        private System.Windows.Forms.Button button_auto;
        private System.Windows.Forms.Button button_manual;
        private System.Windows.Forms.Button button_setfps;
        private System.Windows.Forms.TextBox textBox_fps;
        private System.Windows.Forms.TextBox textBox_prg;
        private System.Windows.Forms.Button button_prg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_lednr;
        private System.Windows.Forms.GroupBox gb_type;
        private System.Windows.Forms.RadioButton rb_rgb24_2;
        private System.Windows.Forms.RadioButton rb_rgb24_1;
        private System.Windows.Forms.Button button_p3;
        private System.Windows.Forms.RadioButton rb_rgb8;
    }
}

