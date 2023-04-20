namespace Stungata.Forms
{
    partial class subsequence
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
            this.label5 = new System.Windows.Forms.Label();
            this.checkButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.inputTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(264, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 120);
            this.label5.TabIndex = 27;
            this.label5.Text = "Examples:\r\n\r\nInput :\r\n3, 10, 3, 11, 4, 5, 6, 7, 8, 12 \r\nOutput : 6 \r\n\r\nInput : 6," +
    " 7, 8, 3, 4, 5, 9, 10 \r\nOutput : 5 ";
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(12, 67);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(86, 31);
            this.checkButton.TabIndex = 26;
            this.checkButton.Text = "GO!";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.outputLabel.Location = new System.Drawing.Point(66, 110);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(0, 21);
            this.outputLabel.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "Output:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "Array";
            // 
            // inputTB
            // 
            this.inputTB.Location = new System.Drawing.Point(12, 29);
            this.inputTB.Name = "inputTB";
            this.inputTB.Size = new System.Drawing.Size(247, 23);
            this.inputTB.TabIndex = 22;
            // 
            // subsequence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 174);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "subsequence";
            this.Text = "Hashing Problems";
            this.Load += new System.EventHandler(this.subsequence_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputTB;
    }
}