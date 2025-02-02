namespace passwordmaker
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.numUzunluk = new System.Windows.Forms.NumericUpDown();
            this.btnOlustur = new System.Windows.Forms.Button();
            this.btnKopyala = new System.Windows.Forms.Button();
            this.txtParola = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numUzunluk)).BeginInit();
            this.SuspendLayout();
            // 
            // numUzunluk
            // 
            this.numUzunluk.Location = new System.Drawing.Point(326, 75);
            this.numUzunluk.Name = "numUzunluk";
            this.numUzunluk.Size = new System.Drawing.Size(120, 22);
            this.numUzunluk.TabIndex = 0;
            // 
            // btnOlustur
            // 
            this.btnOlustur.Location = new System.Drawing.Point(91, 180);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(75, 23);
            this.btnOlustur.TabIndex = 1;
            this.btnOlustur.Text = "Oluştur";
            this.btnOlustur.UseVisualStyleBackColor = true;
            this.btnOlustur.Click += new System.EventHandler(this.btnOlustur_Click);
            // 
            // btnKopyala
            // 
            this.btnKopyala.Location = new System.Drawing.Point(591, 180);
            this.btnKopyala.Name = "btnKopyala";
            this.btnKopyala.Size = new System.Drawing.Size(75, 23);
            this.btnKopyala.TabIndex = 2;
            this.btnKopyala.Text = "Kopyala";
            this.btnKopyala.UseVisualStyleBackColor = true;
            this.btnKopyala.Click += new System.EventHandler(this.btnKopyala_Click);
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(237, 180);
            this.txtParola.Name = "txtParola";
            this.txtParola.Size = new System.Drawing.Size(320, 22);
            this.txtParola.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.btnKopyala);
            this.Controls.Add(this.btnOlustur);
            this.Controls.Add(this.numUzunluk);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numUzunluk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numUzunluk;
        private System.Windows.Forms.Button btnOlustur;
        private System.Windows.Forms.Button btnKopyala;
        private System.Windows.Forms.TextBox txtParola;
    }
}

