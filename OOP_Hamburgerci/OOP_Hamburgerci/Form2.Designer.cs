
namespace OOP_Hamburgerci
{
    partial class Form2
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
            this.grpMenuEkle = new System.Windows.Forms.GroupBox();
            this.btnMenuKaydet = new System.Windows.Forms.Button();
            this.txtMenuAdi = new System.Windows.Forms.TextBox();
            this.nmrMenuFiyati = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpMenuEkle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrMenuFiyati)).BeginInit();
            this.SuspendLayout();
            // 
            // grpMenuEkle
            // 
            this.grpMenuEkle.Controls.Add(this.btnMenuKaydet);
            this.grpMenuEkle.Controls.Add(this.txtMenuAdi);
            this.grpMenuEkle.Controls.Add(this.nmrMenuFiyati);
            this.grpMenuEkle.Controls.Add(this.label2);
            this.grpMenuEkle.Controls.Add(this.label1);
            this.grpMenuEkle.Location = new System.Drawing.Point(13, 13);
            this.grpMenuEkle.Margin = new System.Windows.Forms.Padding(4);
            this.grpMenuEkle.Name = "grpMenuEkle";
            this.grpMenuEkle.Padding = new System.Windows.Forms.Padding(4);
            this.grpMenuEkle.Size = new System.Drawing.Size(288, 190);
            this.grpMenuEkle.TabIndex = 0;
            this.grpMenuEkle.TabStop = false;
            this.grpMenuEkle.Text = "Menü Ekle";
            this.grpMenuEkle.Enter += new System.EventHandler(this.grpMenuEkle_Enter);
            // 
            // btnMenuKaydet
            // 
            this.btnMenuKaydet.Location = new System.Drawing.Point(97, 106);
            this.btnMenuKaydet.Name = "btnMenuKaydet";
            this.btnMenuKaydet.Size = new System.Drawing.Size(168, 65);
            this.btnMenuKaydet.TabIndex = 4;
            this.btnMenuKaydet.Text = "KAYDET";
            this.btnMenuKaydet.UseVisualStyleBackColor = true;
            this.btnMenuKaydet.Click += new System.EventHandler(this.btnMenuKaydet_Click);
            // 
            // txtMenuAdi
            // 
            this.txtMenuAdi.Location = new System.Drawing.Point(97, 37);
            this.txtMenuAdi.Name = "txtMenuAdi";
            this.txtMenuAdi.Size = new System.Drawing.Size(168, 25);
            this.txtMenuAdi.TabIndex = 3;
            // 
            // nmrMenuFiyati
            // 
            this.nmrMenuFiyati.DecimalPlaces = 2;
            this.nmrMenuFiyati.Increment = new decimal(new int[] {
            50,
            0,
            0,
            131072});
            this.nmrMenuFiyati.Location = new System.Drawing.Point(97, 75);
            this.nmrMenuFiyati.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrMenuFiyati.Name = "nmrMenuFiyati";
            this.nmrMenuFiyati.Size = new System.Drawing.Size(168, 25);
            this.nmrMenuFiyati.TabIndex = 2;
            this.nmrMenuFiyati.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fiyatı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menü Adı:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 216);
            this.Controls.Add(this.grpMenuEkle);
            this.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.grpMenuEkle.ResumeLayout(false);
            this.grpMenuEkle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrMenuFiyati)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMenuEkle;
        private System.Windows.Forms.Button btnMenuKaydet;
        private System.Windows.Forms.TextBox txtMenuAdi;
        private System.Windows.Forms.NumericUpDown nmrMenuFiyati;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}