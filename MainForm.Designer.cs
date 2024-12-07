namespace BassDetector
{
    partial class MainForm
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
            this.ledPictureBox = new System.Windows.Forms.PictureBox();
            this.playSound_Button = new System.Windows.Forms.Button();
            this.triggerThreshold_trackBar = new System.Windows.Forms.TrackBar();
            this.amplitudeThreshold_Label = new System.Windows.Forms.Label();
            this.led_Label = new System.Windows.Forms.Label();
            this.lowCutoff_trackBar = new System.Windows.Forms.TrackBar();
            this.lowCutoff_Label = new System.Windows.Forms.Label();
            this.lowCutoff_MaxLabel = new System.Windows.Forms.Label();
            this.lowCutoff_MinLabel = new System.Windows.Forms.Label();
            this.highCutoff_trackBar = new System.Windows.Forms.TrackBar();
            this.highCutoff_MinLabel = new System.Windows.Forms.Label();
            this.highCutoff_Label = new System.Windows.Forms.Label();
            this.highCutoff_MaxLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ledPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.triggerThreshold_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowCutoff_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.highCutoff_trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // ledPictureBox
            // 
            this.ledPictureBox.BackColor = System.Drawing.Color.Black;
            this.ledPictureBox.Location = new System.Drawing.Point(320, 25);
            this.ledPictureBox.Name = "ledPictureBox";
            this.ledPictureBox.Size = new System.Drawing.Size(100, 50);
            this.ledPictureBox.TabIndex = 0;
            this.ledPictureBox.TabStop = false;
            // 
            // playSound_Button
            // 
            this.playSound_Button.Location = new System.Drawing.Point(336, 196);
            this.playSound_Button.Name = "playSound_Button";
            this.playSound_Button.Size = new System.Drawing.Size(75, 23);
            this.playSound_Button.TabIndex = 1;
            this.playSound_Button.Text = "Play Sound";
            this.playSound_Button.UseVisualStyleBackColor = true;
            this.playSound_Button.Click += new System.EventHandler(this.playSound_ButtonClick);
            // 
            // triggerThreshold_trackBar
            // 
            this.triggerThreshold_trackBar.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.triggerThreshold_trackBar.Location = new System.Drawing.Point(38, 25);
            this.triggerThreshold_trackBar.Minimum = 1;
            this.triggerThreshold_trackBar.Name = "triggerThreshold_trackBar";
            this.triggerThreshold_trackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.triggerThreshold_trackBar.Size = new System.Drawing.Size(45, 201);
            this.triggerThreshold_trackBar.TabIndex = 2;
            this.triggerThreshold_trackBar.Value = 7;
            this.triggerThreshold_trackBar.ValueChanged += new System.EventHandler(this.triggerThreshold_trackBar_ValueChanged);
            // 
            // amplitudeThreshold_Label
            // 
            this.amplitudeThreshold_Label.AutoSize = true;
            this.amplitudeThreshold_Label.Location = new System.Drawing.Point(12, 9);
            this.amplitudeThreshold_Label.Name = "amplitudeThreshold_Label";
            this.amplitudeThreshold_Label.Size = new System.Drawing.Size(90, 13);
            this.amplitudeThreshold_Label.TabIndex = 3;
            this.amplitudeThreshold_Label.Text = "Trigger Threshold";
            // 
            // led_Label
            // 
            this.led_Label.AutoSize = true;
            this.led_Label.Location = new System.Drawing.Point(343, 9);
            this.led_Label.Name = "led_Label";
            this.led_Label.Size = new System.Drawing.Size(57, 13);
            this.led_Label.TabIndex = 4;
            this.led_Label.Text = "Trigger On";
            // 
            // lowCutoff_trackBar
            // 
            this.lowCutoff_trackBar.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.lowCutoff_trackBar.LargeChange = 10;
            this.lowCutoff_trackBar.Location = new System.Drawing.Point(135, 25);
            this.lowCutoff_trackBar.Maximum = 100;
            this.lowCutoff_trackBar.Minimum = 20;
            this.lowCutoff_trackBar.Name = "lowCutoff_trackBar";
            this.lowCutoff_trackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.lowCutoff_trackBar.Size = new System.Drawing.Size(45, 201);
            this.lowCutoff_trackBar.SmallChange = 5;
            this.lowCutoff_trackBar.TabIndex = 5;
            this.lowCutoff_trackBar.TickFrequency = 5;
            this.lowCutoff_trackBar.Value = 30;
            // 
            // lowCutoff_Label
            // 
            this.lowCutoff_Label.AutoSize = true;
            this.lowCutoff_Label.Location = new System.Drawing.Point(112, 9);
            this.lowCutoff_Label.Name = "lowCutoff_Label";
            this.lowCutoff_Label.Size = new System.Drawing.Size(68, 13);
            this.lowCutoff_Label.TabIndex = 6;
            this.lowCutoff_Label.Text = "Low Cut (Hz)";
            // 
            // lowCutoff_MaxLabel
            // 
            this.lowCutoff_MaxLabel.AutoSize = true;
            this.lowCutoff_MaxLabel.Location = new System.Drawing.Point(163, 32);
            this.lowCutoff_MaxLabel.Name = "lowCutoff_MaxLabel";
            this.lowCutoff_MaxLabel.Size = new System.Drawing.Size(25, 13);
            this.lowCutoff_MaxLabel.TabIndex = 7;
            this.lowCutoff_MaxLabel.Text = "100";
            this.lowCutoff_MaxLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lowCutoff_MinLabel
            // 
            this.lowCutoff_MinLabel.AutoSize = true;
            this.lowCutoff_MinLabel.Location = new System.Drawing.Point(163, 206);
            this.lowCutoff_MinLabel.Name = "lowCutoff_MinLabel";
            this.lowCutoff_MinLabel.Size = new System.Drawing.Size(19, 13);
            this.lowCutoff_MinLabel.TabIndex = 8;
            this.lowCutoff_MinLabel.Text = "20";
            this.lowCutoff_MinLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // highCutoff_trackBar
            // 
            this.highCutoff_trackBar.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.highCutoff_trackBar.LargeChange = 50;
            this.highCutoff_trackBar.Location = new System.Drawing.Point(221, 25);
            this.highCutoff_trackBar.Maximum = 300;
            this.highCutoff_trackBar.Minimum = 100;
            this.highCutoff_trackBar.Name = "highCutoff_trackBar";
            this.highCutoff_trackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.highCutoff_trackBar.Size = new System.Drawing.Size(45, 201);
            this.highCutoff_trackBar.SmallChange = 10;
            this.highCutoff_trackBar.TabIndex = 9;
            this.highCutoff_trackBar.TickFrequency = 10;
            this.highCutoff_trackBar.Value = 100;
            // 
            // highCutoff_MinLabel
            // 
            this.highCutoff_MinLabel.AutoSize = true;
            this.highCutoff_MinLabel.Location = new System.Drawing.Point(249, 206);
            this.highCutoff_MinLabel.Name = "highCutoff_MinLabel";
            this.highCutoff_MinLabel.Size = new System.Drawing.Size(25, 13);
            this.highCutoff_MinLabel.TabIndex = 10;
            this.highCutoff_MinLabel.Text = "100";
            this.highCutoff_MinLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // highCutoff_Label
            // 
            this.highCutoff_Label.AutoSize = true;
            this.highCutoff_Label.Location = new System.Drawing.Point(198, 9);
            this.highCutoff_Label.Name = "highCutoff_Label";
            this.highCutoff_Label.Size = new System.Drawing.Size(70, 13);
            this.highCutoff_Label.TabIndex = 11;
            this.highCutoff_Label.Text = "High Cut (Hz)";
            // 
            // highCutoff_MaxLabel
            // 
            this.highCutoff_MaxLabel.AutoSize = true;
            this.highCutoff_MaxLabel.Location = new System.Drawing.Point(251, 32);
            this.highCutoff_MaxLabel.Name = "highCutoff_MaxLabel";
            this.highCutoff_MaxLabel.Size = new System.Drawing.Size(25, 13);
            this.highCutoff_MaxLabel.TabIndex = 12;
            this.highCutoff_MaxLabel.Text = "300";
            this.highCutoff_MaxLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 238);
            this.Controls.Add(this.highCutoff_MaxLabel);
            this.Controls.Add(this.highCutoff_Label);
            this.Controls.Add(this.highCutoff_MinLabel);
            this.Controls.Add(this.highCutoff_trackBar);
            this.Controls.Add(this.lowCutoff_MinLabel);
            this.Controls.Add(this.lowCutoff_MaxLabel);
            this.Controls.Add(this.lowCutoff_Label);
            this.Controls.Add(this.lowCutoff_trackBar);
            this.Controls.Add(this.led_Label);
            this.Controls.Add(this.amplitudeThreshold_Label);
            this.Controls.Add(this.triggerThreshold_trackBar);
            this.Controls.Add(this.playSound_Button);
            this.Controls.Add(this.ledPictureBox);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ledPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.triggerThreshold_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowCutoff_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.highCutoff_trackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ledPictureBox;
        private System.Windows.Forms.Button playSound_Button;
        private System.Windows.Forms.TrackBar triggerThreshold_trackBar;
        private System.Windows.Forms.Label amplitudeThreshold_Label;
        private System.Windows.Forms.Label led_Label;
        private System.Windows.Forms.TrackBar lowCutoff_trackBar;
        private System.Windows.Forms.Label lowCutoff_Label;
        private System.Windows.Forms.Label lowCutoff_MaxLabel;
        private System.Windows.Forms.Label lowCutoff_MinLabel;
        private System.Windows.Forms.TrackBar highCutoff_trackBar;
        private System.Windows.Forms.Label highCutoff_MinLabel;
        private System.Windows.Forms.Label highCutoff_Label;
        private System.Windows.Forms.Label highCutoff_MaxLabel;
    }
}

