namespace While_loop_formative_1
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
            this.startLabel = new System.Windows.Forms.Label();
            this.endLabel = new System.Windows.Forms.Label();
            this.startInput = new System.Windows.Forms.TextBox();
            this.endInput = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Location = new System.Drawing.Point(55, 49);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(114, 13);
            this.startLabel.TabIndex = 0;
            this.startLabel.Text = "Enter start value here: ";
            // 
            // endLabel
            // 
            this.endLabel.AutoSize = true;
            this.endLabel.Location = new System.Drawing.Point(57, 84);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(112, 13);
            this.endLabel.TabIndex = 1;
            this.endLabel.Text = "Enter end value here: ";
            // 
            // startInput
            // 
            this.startInput.Location = new System.Drawing.Point(172, 42);
            this.startInput.Name = "startInput";
            this.startInput.Size = new System.Drawing.Size(49, 20);
            this.startInput.TabIndex = 2;
            // 
            // endInput
            // 
            this.endInput.Location = new System.Drawing.Point(172, 84);
            this.endInput.Name = "endInput";
            this.endInput.Size = new System.Drawing.Size(49, 20);
            this.endInput.TabIndex = 3;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(172, 130);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(49, 23);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(12, 217);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(0, 13);
            this.outputLabel.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.endInput);
            this.Controls.Add(this.startInput);
            this.Controls.Add(this.endLabel);
            this.Controls.Add(this.startLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.Label endLabel;
        private System.Windows.Forms.TextBox startInput;
        private System.Windows.Forms.TextBox endInput;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label outputLabel;
    }
}

