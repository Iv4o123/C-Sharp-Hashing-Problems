namespace Stungata.Forms
{
    partial class largestSubarray
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
            this.inputTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputTB
            // 
            this.inputTB.Location = new System.Drawing.Point(12, 30);
            this.inputTB.Name = "inputTB";
            this.inputTB.Size = new System.Drawing.Size(247, 23);
            this.inputTB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Array";
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.outputLabel.Location = new System.Drawing.Point(66, 111);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(0, 21);
            this.outputLabel.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Output:";
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(12, 68);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(86, 31);
            this.checkButton.TabIndex = 12;
            this.checkButton.Text = "GO!";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(265, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 150);
            this.label5.TabIndex = 15;
            this.label5.Text = "Examples:\r\n\r\nInput:\r\n1 0 1 1 1 0 0\r\nOutput: 1 to 6 \r\n\r\n\r\nInput:\r\n1 1 1 1\r\nOutput:" +
    " No such subarray";
            // 
            // largestSubarray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 178);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "largestSubarray";
            this.Text = "Hashing Problems";
            this.Load += new System.EventHandler(this.largestSubarray_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Label label5;
    }
}