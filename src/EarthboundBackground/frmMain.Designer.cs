namespace EarthboundBackground
{
    partial class frmMain
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
            this.btnOpenImage1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tmrDelta = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblDelta = new System.Windows.Forms.Label();
            this.btnPause = new System.Windows.Forms.Button();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.btnOpenImage2 = new System.Windows.Forms.Button();
            this.btnClearImages = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblFormula = new System.Windows.Forms.Label();
            this.trkCompression = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.trkScale = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.trkFrequency = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.trkAmplitude = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nudFramerate = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkCompression)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkFrequency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkAmplitude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFramerate)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpenImage1
            // 
            this.btnOpenImage1.Location = new System.Drawing.Point(565, 290);
            this.btnOpenImage1.Name = "btnOpenImage1";
            this.btnOpenImage1.Size = new System.Drawing.Size(78, 37);
            this.btnOpenImage1.TabIndex = 0;
            this.btnOpenImage1.Text = "Open Layer 1";
            this.btnOpenImage1.UseVisualStyleBackColor = true;
            this.btnOpenImage1.Click += new System.EventHandler(this.btnOpenImage_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(547, 401);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // tmrDelta
            // 
            this.tmrDelta.Interval = 1000;
            this.tmrDelta.Tick += new System.EventHandler(this.tmrDelta_Tick);
            // 
            // btnStart
            // 
            this.btnStart.Enabled = false;
            this.btnStart.Location = new System.Drawing.Point(568, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(568, 70);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblDelta
            // 
            this.lblDelta.AutoSize = true;
            this.lblDelta.Location = new System.Drawing.Point(565, 233);
            this.lblDelta.Name = "lblDelta";
            this.lblDelta.Size = new System.Drawing.Size(0, 13);
            this.lblDelta.TabIndex = 4;
            // 
            // btnPause
            // 
            this.btnPause.Enabled = false;
            this.btnPause.Location = new System.Drawing.Point(568, 41);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 23);
            this.btnPause.TabIndex = 5;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(565, 260);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(78, 24);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save Image";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(565, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Type:";
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.cmbType.Location = new System.Drawing.Point(568, 112);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(75, 21);
            this.cmbType.TabIndex = 8;
            this.cmbType.Text = "0";
            // 
            // btnOpenImage2
            // 
            this.btnOpenImage2.Location = new System.Drawing.Point(565, 333);
            this.btnOpenImage2.Name = "btnOpenImage2";
            this.btnOpenImage2.Size = new System.Drawing.Size(78, 37);
            this.btnOpenImage2.TabIndex = 9;
            this.btnOpenImage2.Text = "Open Layer 2";
            this.btnOpenImage2.UseVisualStyleBackColor = true;
            this.btnOpenImage2.Click += new System.EventHandler(this.btnOpenImage2_Click);
            // 
            // btnClearImages
            // 
            this.btnClearImages.Location = new System.Drawing.Point(565, 376);
            this.btnClearImages.Name = "btnClearImages";
            this.btnClearImages.Size = new System.Drawing.Size(78, 37);
            this.btnClearImages.TabIndex = 10;
            this.btnClearImages.Text = "Clear Images";
            this.btnClearImages.UseVisualStyleBackColor = true;
            this.btnClearImages.Click += new System.EventHandler(this.btnClearImages_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudFramerate);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblFormula);
            this.groupBox1.Controls.Add(this.trkCompression);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.trkScale);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.trkFrequency);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.trkAmplitude);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(649, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(436, 372);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fine Tuning";
            // 
            // lblFormula
            // 
            this.lblFormula.AutoSize = true;
            this.lblFormula.Location = new System.Drawing.Point(16, 347);
            this.lblFormula.Name = "lblFormula";
            this.lblFormula.Size = new System.Drawing.Size(0, 13);
            this.lblFormula.TabIndex = 12;
            // 
            // trkCompression
            // 
            this.trkCompression.Location = new System.Drawing.Point(9, 248);
            this.trkCompression.Maximum = 100;
            this.trkCompression.Minimum = 1;
            this.trkCompression.Name = "trkCompression";
            this.trkCompression.Size = new System.Drawing.Size(421, 45);
            this.trkCompression.TabIndex = 1;
            this.trkCompression.Value = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Compression (Only used in Type 2):";
            // 
            // trkScale
            // 
            this.trkScale.Location = new System.Drawing.Point(9, 173);
            this.trkScale.Maximum = 100;
            this.trkScale.Minimum = 1;
            this.trkScale.Name = "trkScale";
            this.trkScale.Size = new System.Drawing.Size(421, 45);
            this.trkScale.TabIndex = 1;
            this.trkScale.Value = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Scale:";
            // 
            // trkFrequency
            // 
            this.trkFrequency.Location = new System.Drawing.Point(9, 109);
            this.trkFrequency.Maximum = 100;
            this.trkFrequency.Minimum = 1;
            this.trkFrequency.Name = "trkFrequency";
            this.trkFrequency.Size = new System.Drawing.Size(421, 45);
            this.trkFrequency.TabIndex = 1;
            this.trkFrequency.Value = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Frequency:";
            // 
            // trkAmplitude
            // 
            this.trkAmplitude.Location = new System.Drawing.Point(9, 45);
            this.trkAmplitude.Maximum = 100;
            this.trkAmplitude.Minimum = 1;
            this.trkAmplitude.Name = "trkAmplitude";
            this.trkAmplitude.Size = new System.Drawing.Size(421, 45);
            this.trkAmplitude.TabIndex = 16;
            this.trkAmplitude.Value = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Amplitude:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Framerate";
            // 
            // nudFramerate
            // 
            this.nudFramerate.Location = new System.Drawing.Point(9, 324);
            this.nudFramerate.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudFramerate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFramerate.Name = "nudFramerate";
            this.nudFramerate.Size = new System.Drawing.Size(120, 20);
            this.nudFramerate.TabIndex = 18;
            this.nudFramerate.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 427);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClearImages);
            this.Controls.Add(this.btnOpenImage2);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.lblDelta);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnOpenImage1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMain";
            this.Text = "Earthbound Backgrounds";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkCompression)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkFrequency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkAmplitude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFramerate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenImage1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer tmrDelta;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblDelta;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Button btnOpenImage2;
        private System.Windows.Forms.Button btnClearImages;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trkAmplitude;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trkFrequency;
        private System.Windows.Forms.TrackBar trkScale;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar trkCompression;
        private System.Windows.Forms.Label lblFormula;
        private System.Windows.Forms.NumericUpDown nudFramerate;
        private System.Windows.Forms.Label label6;
    }
}

