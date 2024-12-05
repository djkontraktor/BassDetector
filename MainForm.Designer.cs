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
            ((System.ComponentModel.ISupportInitialize)(this.ledPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ledPictureBox
            // 
            this.ledPictureBox.BackColor = System.Drawing.Color.Black;
            this.ledPictureBox.Location = new System.Drawing.Point(73, 40);
            this.ledPictureBox.Name = "ledPictureBox";
            this.ledPictureBox.Size = new System.Drawing.Size(100, 50);
            this.ledPictureBox.TabIndex = 0;
            this.ledPictureBox.TabStop = false;
            // 
            // playSound_Button
            // 
            this.playSound_Button.Location = new System.Drawing.Point(633, 358);
            this.playSound_Button.Name = "playSound_Button";
            this.playSound_Button.Size = new System.Drawing.Size(75, 23);
            this.playSound_Button.TabIndex = 1;
            this.playSound_Button.Text = "Play Sound";
            this.playSound_Button.UseVisualStyleBackColor = true;
            this.playSound_Button.Click += new System.EventHandler(this.playSound_ButtonClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.playSound_Button);
            this.Controls.Add(this.ledPictureBox);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ledPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ledPictureBox;
        private System.Windows.Forms.Button playSound_Button;
    }
}

