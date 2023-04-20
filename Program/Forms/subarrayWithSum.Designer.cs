namespace Stungata.Forms
{
    partial class subarrayWithSum
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
            this.label5.Location = new System.Drawing.Point(444, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 120);
            this.label5.TabIndex = 21;
            this.label5.Text = "Examples:\r\n\r\nInput: \r\n15, -2, 2, -8, 1, 7, 10, 23\r\nOutput: 5\r\n\r\nInput: 1, 2, 3\r\nO" +
    "utput: 0";
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(8, 65);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(86, 31);
            this.checkButton.TabIndex = 20;
            this.checkButton.Text = "GO!";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.outputLabel.Location = new System.Drawing.Point(62, 108);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(0, 21);
            this.outputLabel.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "Output:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Array";
            // 
            // inputTB
            // 
            this.inputTB.Location = new System.Drawing.Point(8, 27);
            this.inputTB.Name = "inputTB";
            this.inputTB.Size = new System.Drawing.Size(247, 23);
            this.inputTB.TabIndex = 16;
            // 
            // subarrayWithSum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 171);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "subarrayWithSum";
            this.Text = "Hashing Problems";
            this.Load += new System.EventHandler(this.subarrayWithSum_Load);
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