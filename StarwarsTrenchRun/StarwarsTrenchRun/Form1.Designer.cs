namespace StarwarsTrenchRun
{
    partial class TrenchRun
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrenchRun));
            this.topSecretLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // topSecretLabel
            // 
            this.topSecretLabel.AutoSize = true;
            this.topSecretLabel.BackColor = System.Drawing.Color.Transparent;
            this.topSecretLabel.Font = new System.Drawing.Font("Arial Narrow", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topSecretLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.topSecretLabel.Location = new System.Drawing.Point(11, 9);
            this.topSecretLabel.Name = "topSecretLabel";
            this.topSecretLabel.Size = new System.Drawing.Size(250, 52);
            this.topSecretLabel.TabIndex = 0;
            this.topSecretLabel.Text = "TOP SECRET";
            // 
            // TrenchRun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(273, 255);
            this.Controls.Add(this.topSecretLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TrenchRun";
            this.Text = "Trench Run";
            this.Click += new System.EventHandler(this.TrenchRun_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label topSecretLabel;
    }
}

