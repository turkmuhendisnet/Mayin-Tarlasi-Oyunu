namespace MayınTarlası
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
            this.components = new System.ComponentModel.Container();
            this.FlpPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.tmrZaman = new System.Windows.Forms.Timer(this.components);
            this.btnYeniden = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FlpPanel
            // 
            this.FlpPanel.Location = new System.Drawing.Point(12, 12);
            this.FlpPanel.Name = "FlpPanel";
            this.FlpPanel.Size = new System.Drawing.Size(555, 407);
            this.FlpPanel.TabIndex = 0;
            // 
            // tmrZaman
            // 
            this.tmrZaman.Tick += new System.EventHandler(this.tmrZaman_Tick);
            // 
            // btnYeniden
            // 
            this.btnYeniden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnYeniden.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnYeniden.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniden.Location = new System.Drawing.Point(197, 439);
            this.btnYeniden.Name = "btnYeniden";
            this.btnYeniden.Size = new System.Drawing.Size(162, 34);
            this.btnYeniden.TabIndex = 1;
            this.btnYeniden.Text = "Yeniden Başla";
            this.btnYeniden.UseVisualStyleBackColor = false;
            this.btnYeniden.Click += new System.EventHandler(this.btnYeniden_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 485);
            this.Controls.Add(this.btnYeniden);
            this.Controls.Add(this.FlpPanel);
            this.Name = "Form1";
            this.Text = "Mayın Tarlası";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FlpPanel;
        private System.Windows.Forms.Timer tmrZaman;
        private System.Windows.Forms.Button btnYeniden;
    }
}

