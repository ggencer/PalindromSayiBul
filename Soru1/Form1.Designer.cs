namespace Soru1
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
            this.tbx_sayi1 = new System.Windows.Forms.TextBox();
            this.tbx_sayi2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.lbl_Sonuc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbx_sayi1
            // 
            this.tbx_sayi1.Location = new System.Drawing.Point(12, 54);
            this.tbx_sayi1.Name = "tbx_sayi1";
            this.tbx_sayi1.Size = new System.Drawing.Size(100, 20);
            this.tbx_sayi1.TabIndex = 0;
            this.tbx_sayi1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbx_sayi2
            // 
            this.tbx_sayi2.Location = new System.Drawing.Point(177, 54);
            this.tbx_sayi2.Name = "tbx_sayi2";
            this.tbx_sayi2.Size = new System.Drawing.Size(100, 20);
            this.tbx_sayi2.TabIndex = 1;
            this.tbx_sayi2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "1 - 4900 arasında iki sayı giriniz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Birinci Sayı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "İkinci Sayı";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(2, 131);
            this.listBox1.MultiColumn = true;
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(793, 303);
            this.listBox1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(332, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 39);
            this.button1.TabIndex = 6;
            this.button1.Text = "Palindrom Sayıları Bul";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(651, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "21911099 Gökhan GENCER";
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // lbl_Sonuc
            // 
            this.lbl_Sonuc.AutoSize = true;
            this.lbl_Sonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Sonuc.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_Sonuc.Location = new System.Drawing.Point(7, 88);
            this.lbl_Sonuc.Name = "lbl_Sonuc";
            this.lbl_Sonuc.Size = new System.Drawing.Size(85, 29);
            this.lbl_Sonuc.TabIndex = 8;
            this.lbl_Sonuc.Text = "label5";
            this.lbl_Sonuc.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 446);
            this.Controls.Add(this.lbl_Sonuc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_sayi2);
            this.Controls.Add(this.tbx_sayi1);
            this.Name = "Form1";
            this.Text = "Palindrom Sayıları Bul";
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_sayi1;
        private System.Windows.Forms.TextBox tbx_sayi2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.Label lbl_Sonuc;
    }
}

