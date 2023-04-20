
namespace Stungata.Forms
{
    partial class recaman
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.outputLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(44, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 23);
            this.textBox1.TabIndex = 0;
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.outputLabel.Location = new System.Drawing.Point(67, 86);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(19, 21);
            this.outputLabel.TabIndex = 15;
            this.outputLabel.Text = "...";
            this.outputLabel.AutoSizeChanged += new System.EventHandler(this.outputLabel_AutoSizeChanged);
            this.outputLabel.SizeChanged += new System.EventHandler(this.outputLabel_SizeChanged);
            this.outputLabel.Click += new System.EventHandler(this.outputLabel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Output:";
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(13, 43);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(86, 31);
            this.checkButton.TabIndex = 16;
            this.checkButton.Text = "GO!";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "n =";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(266, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 120);
            this.label5.TabIndex = 18;
            this.label5.Text = "Examples:\r\n\r\nInput : n = 6\r\nOutput : 0, 1, 3, 6, 2, 7\r\n.\r\nInput  : n = 17\r\nOutput" +
    " : 0, 1, 3, 6, 2, 7, 13, 20, 12, 21, \r\n         11, 22, 10, 23, 9, 24, 8\r\n";
            // 
            // recaman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 182);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "recaman";
            this.Text = "Hashing Problems";
            this.Load += new System.EventHandler(this.recaman_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}