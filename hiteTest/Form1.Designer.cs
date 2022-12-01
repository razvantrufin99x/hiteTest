namespace hiteTest
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.bara3 = new hiteTest.bara();
            this.bara4 = new hiteTest.bara();
            this.bara2 = new hiteTest.bara();
            this.bara1 = new hiteTest.bara();
            this.mingea1 = new hiteTest.mingea();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(296, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 48);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(296, 94);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(47, 50);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(143, 223);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(41, 47);
            this.button3.TabIndex = 8;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(450, 223);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(42, 48);
            this.button4.TabIndex = 6;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // bara3
            // 
            this.bara3.BackColor = System.Drawing.Color.Blue;
            this.bara3.Location = new System.Drawing.Point(190, 172);
            this.bara3.Name = "bara3";
            this.bara3.Size = new System.Drawing.Size(23, 144);
            this.bara3.TabIndex = 7;
            // 
            // bara4
            // 
            this.bara4.BackColor = System.Drawing.Color.Blue;
            this.bara4.Location = new System.Drawing.Point(419, 172);
            this.bara4.Name = "bara4";
            this.bara4.Size = new System.Drawing.Size(25, 144);
            this.bara4.TabIndex = 5;
            // 
            // bara2
            // 
            this.bara2.BackColor = System.Drawing.Color.Blue;
            this.bara2.Location = new System.Drawing.Point(213, 150);
            this.bara2.Name = "bara2";
            this.bara2.Size = new System.Drawing.Size(208, 21);
            this.bara2.TabIndex = 3;
            // 
            // bara1
            // 
            this.bara1.BackColor = System.Drawing.Color.Blue;
            this.bara1.Location = new System.Drawing.Point(213, 314);
            this.bara1.Name = "bara1";
            this.bara1.Size = new System.Drawing.Size(208, 21);
            this.bara1.TabIndex = 1;
            // 
            // mingea1
            // 
            this.mingea1.BackColor = System.Drawing.Color.Red;
            this.mingea1.Location = new System.Drawing.Point(310, 232);
            this.mingea1.Name = "mingea1";
            this.mingea1.Size = new System.Drawing.Size(23, 26);
            this.mingea1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 483);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.bara3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.bara4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bara2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bara1);
            this.Controls.Add(this.mingea1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private mingea mingea1;
        private bara bara1;
        private System.Windows.Forms.Button button1;
        private bara bara2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private bara bara3;
        private System.Windows.Forms.Button button4;
        private bara bara4;
    }
}

