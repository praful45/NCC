namespace Lab_4
{
    partial class LargestNumber
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
            this.number1 = new System.Windows.Forms.TextBox();
            this.btnLargest = new System.Windows.Forms.Button();
            this.number2 = new System.Windows.Forms.TextBox();
            this.num1 = new System.Windows.Forms.Label();
            this.num2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // number1
            // 
            this.number1.Location = new System.Drawing.Point(358, 70);
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(100, 22);
            this.number1.TabIndex = 0;
            // 
            // btnLargest
            // 
            this.btnLargest.Location = new System.Drawing.Point(313, 170);
            this.btnLargest.Name = "btnLargest";
            this.btnLargest.Size = new System.Drawing.Size(114, 29);
            this.btnLargest.TabIndex = 1;
            this.btnLargest.Text = "Find Largest";
            this.btnLargest.UseVisualStyleBackColor = true;
            this.btnLargest.Click += new System.EventHandler(this.btnLargest_Click);
            // 
            // number2
            // 
            this.number2.Location = new System.Drawing.Point(358, 112);
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(100, 22);
            this.number2.TabIndex = 0;
            // 
            // num1
            // 
            this.num1.AutoSize = true;
            this.num1.Location = new System.Drawing.Point(226, 76);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(83, 16);
            this.num1.TabIndex = 2;
            this.num1.Text = "First Number";
            // 
            // num2
            // 
            this.num2.AutoSize = true;
            this.num2.Location = new System.Drawing.Point(229, 115);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(105, 16);
            this.num2.TabIndex = 3;
            this.num2.Text = "Second Number";
            // 
            // LargestNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.btnLargest);
            this.Controls.Add(this.number2);
            this.Controls.Add(this.number1);
            this.Name = "LargestNumber";
            this.Text = "LargestNumber";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox number1;
        private System.Windows.Forms.Button btnLargest;
        private System.Windows.Forms.TextBox number2;
        private System.Windows.Forms.Label num1;
        private System.Windows.Forms.Label num2;
    }
}

