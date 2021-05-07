
namespace Lab8
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
            this.buttonYesNo = new System.Windows.Forms.Button();
            this.buttonBall = new System.Windows.Forms.Button();
            this.labelAns = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonYesNo
            // 
            this.buttonYesNo.Location = new System.Drawing.Point(97, 47);
            this.buttonYesNo.Name = "buttonYesNo";
            this.buttonYesNo.Size = new System.Drawing.Size(165, 69);
            this.buttonYesNo.TabIndex = 0;
            this.buttonYesNo.Text = "Yes/No";
            this.buttonYesNo.UseVisualStyleBackColor = true;
            this.buttonYesNo.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonBall
            // 
            this.buttonBall.Location = new System.Drawing.Point(745, 47);
            this.buttonBall.Name = "buttonBall";
            this.buttonBall.Size = new System.Drawing.Size(168, 69);
            this.buttonBall.TabIndex = 1;
            this.buttonBall.Text = "Ball";
            this.buttonBall.UseVisualStyleBackColor = true;
            this.buttonBall.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelAns
            // 
            this.labelAns.AutoSize = true;
            this.labelAns.Location = new System.Drawing.Point(404, 248);
            this.labelAns.Name = "labelAns";
            this.labelAns.Size = new System.Drawing.Size(225, 17);
            this.labelAns.TabIndex = 2;
            this.labelAns.Text = "Learn the future! Ask the question!";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(407, 210);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(222, 22);
            this.textBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 533);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelAns);
            this.Controls.Add(this.buttonBall);
            this.Controls.Add(this.buttonYesNo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonYesNo;
        private System.Windows.Forms.Button buttonBall;
        private System.Windows.Forms.Label labelAns;
        private System.Windows.Forms.TextBox textBox1;
    }
}

