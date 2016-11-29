namespace Timer
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
            this.countTimer = new System.Windows.Forms.Timer(this.components);
            this.startButton = new System.Windows.Forms.Button();
            this.msLabel = new System.Windows.Forms.Label();
            this.secLabel = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // countTimer
            // 
            this.countTimer.Interval = 2;
            this.countTimer.Tick += new System.EventHandler(this.countTimer_Tick);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(96, 81);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(94, 79);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start/Stop";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // msLabel
            // 
            this.msLabel.AutoSize = true;
            this.msLabel.Location = new System.Drawing.Point(126, 27);
            this.msLabel.Name = "msLabel";
            this.msLabel.Size = new System.Drawing.Size(0, 13);
            this.msLabel.TabIndex = 1;
            // 
            // secLabel
            // 
            this.secLabel.AutoSize = true;
            this.secLabel.Location = new System.Drawing.Point(93, 27);
            this.secLabel.Name = "secLabel";
            this.secLabel.Size = new System.Drawing.Size(0, 13);
            this.secLabel.TabIndex = 2;
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Location = new System.Drawing.Point(38, 27);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(0, 13);
            this.minLabel.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.secLabel);
            this.Controls.Add(this.msLabel);
            this.Controls.Add(this.startButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer countTimer;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label msLabel;
        private System.Windows.Forms.Label secLabel;
        private System.Windows.Forms.Label minLabel;
    }
}

