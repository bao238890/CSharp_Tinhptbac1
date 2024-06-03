namespace CSharp_Tinhptbac1
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
            this.a = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtB = new System.Windows.Forms.TextBox();
            this.b = new System.Windows.Forms.Label();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.lblKQ = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Location = new System.Drawing.Point(109, 47);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(42, 13);
            this.a.TabIndex = 0;
            this.a.Text = "Nhập a";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(178, 40);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 20);
            this.txtA.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(137, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "GIẢI PHƯƠNG TRÌNH";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(178, 82);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 20);
            this.txtB.TabIndex = 4;
            // 
            // b
            // 
            this.b.AutoSize = true;
            this.b.Location = new System.Drawing.Point(109, 89);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(42, 13);
            this.b.TabIndex = 3;
            this.b.Text = "Nhập b";
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(178, 126);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(100, 20);
            this.txtKQ.TabIndex = 5;
            // 
            // lblKQ
            // 
            this.lblKQ.AutoSize = true;
            this.lblKQ.Location = new System.Drawing.Point(175, 173);
            this.lblKQ.Name = "lblKQ";
            this.lblKQ.Size = new System.Drawing.Size(54, 13);
            this.lblKQ.TabIndex = 6;
            this.lblKQ.Text = "KẾT QUẢ";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(322, 47);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(455, 45);
            this.trackBar1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "GIẢI PHƯƠNG TRÌNH BẬC 1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.lblKQ);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.b);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.a);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label a;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label b;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.Label lblKQ;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
    }
}

