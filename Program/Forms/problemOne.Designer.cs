namespace Stungata.Forms
{
    partial class problemOne
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
            this.arrayOneTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.arrayTwoTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // arrayOneTB
            // 
            this.arrayOneTB.Location = new System.Drawing.Point(11, 29);
            this.arrayOneTB.Name = "arrayOneTB";
            this.arrayOneTB.Size = new System.Drawing.Size(224, 23);
            this.arrayOneTB.TabIndex = 0;
            this.arrayOneTB.TextChanged += new System.EventHandler(this.arrayOneTB_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Array 1";
            // 
            // arrayTwoTB
            // 
            this.arrayTwoTB.Location = new System.Drawing.Point(11, 83);
            this.arrayTwoTB.Name = "arrayTwoTB";
            this.arrayTwoTB.Size = new System.Drawing.Size(224, 23);
            this.arrayTwoTB.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Array 2";
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(11, 112);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(86, 31);
            this.checkButton.TabIndex = 5;
            this.checkButton.Text = "GO!";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Output:";
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.outputLabel.Location = new System.Drawing.Point(72, 162);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(0, 21);
            this.outputLabel.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(241, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 90);
            this.label5.TabIndex = 15;
            this.label5.Text = "Examples:\r\n\r\nInput: \r\nArray 1 = 11 1 13 21 3 7\r\nArray 2 = 11 3 7 1 \r\nOutput: Arra" +
    "y 2 is a subset of Array 1\r\n";
            // 
            // problemOne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 216);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.arrayTwoTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.arrayOneTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "problemOne";
            this.Text = "Hashing Problems";
            this.Load += new System.EventHandler(this.problemOne_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox arrayOneTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox arrayTwoTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label label5;
    }
}