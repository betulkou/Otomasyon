
namespace OOP_Hamburgerci
{
    partial class Form3
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
            this.grpEsktraMalzemeEkle = new System.Windows.Forms.GroupBox();
            this.btnEkstraKaydet = new System.Windows.Forms.Button();
            this.txtEkstraAdi = new System.Windows.Forms.TextBox();
            this.nmrEkstraFiyati = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpEsktraMalzemeEkle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrEkstraFiyati)).BeginInit();
            this.SuspendLayout();
            // 
            // grpEsktraMalzemeEkle
            // 
            this.grpEsktraMalzemeEkle.Controls.Add(this.btnEkstraKaydet);
            this.grpEsktraMalzemeEkle.Controls.Add(this.txtEkstraAdi);
            this.grpEsktraMalzemeEkle.Controls.Add(this.nmrEkstraFiyati);
            this.grpEsktraMalzemeEkle.Controls.Add(this.label2);
            this.grpEsktraMalzemeEkle.Controls.Add(this.label1);
            this.grpEsktraMalzemeEkle.Location = new System.Drawing.Point(13, 13);
            this.grpEsktraMalzemeEkle.Margin = new System.Windows.Forms.Padding(4);
            this.grpEsktraMalzemeEkle.Name = "grpEsktraMalzemeEkle";
            this.grpEsktraMalzemeEkle.Padding = new System.Windows.Forms.Padding(4);
            this.grpEsktraMalzemeEkle.Size = new System.Drawing.Size(350, 181);
            this.grpEsktraMalzemeEkle.TabIndex = 1;
            this.grpEsktraMalzemeEkle.TabStop = false;
            this.grpEsktraMalzemeEkle.Text = "Ekstra Malzeme Ekle";
            this.grpEsktraMalzemeEkle.Enter += new System.EventHandler(this.grpEsktraMalzemeEkle_Enter);
            // 
            // btnEkstraKaydet
            // 
            this.btnEkstraKaydet.Location = new System.Drawing.Point(169, 106);
            this.btnEkstraKaydet.Name = "btnEkstraKaydet";
            this.btnEkstraKaydet.Size = new System.Drawing.Size(168, 65);
            this.btnEkstraKaydet.TabIndex = 4;
            this.btnEkstraKaydet.Text = "KAYDET";
            this.btnEkstraKaydet.UseVisualStyleBackColor = true;
            this.btnEkstraKaydet.Click += new System.EventHandler(this.btnEkstraKaydet_Click);
            // 
            // txtEkstraAdi
            // 
            this.txtEkstraAdi.Location = new System.Drawing.Point(169, 37);
            this.txtEkstraAdi.Name = "txtEkstraAdi";
            this.txtEkstraAdi.Size = new System.Drawing.Size(168, 25);
            this.txtEkstraAdi.TabIndex = 3;
            // 
            // nmrEkstraFiyati
            // 
            this.nmrEkstraFiyati.DecimalPlaces = 2;
            this.nmrEkstraFiyati.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.nmrEkstraFiyati.Location = new System.Drawing.Point(169, 75);
            this.nmrEkstraFiyati.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrEkstraFiyati.Name = "nmrEkstraFiyati";
            this.nmrEkstraFiyati.Size = new System.Drawing.Size(168, 25);
            this.nmrEkstraFiyati.TabIndex = 2;
            this.nmrEkstraFiyati.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 77);
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
            this.label1.Size = new System.Drawing.Size(145, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ekstra Malzeme Adı:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 199);
            this.Controls.Add(this.grpEsktraMalzemeEkle);
            this.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.grpEsktraMalzemeEkle.ResumeLayout(false);
            this.grpEsktraMalzemeEkle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrEkstraFiyati)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEsktraMalzemeEkle;
        private System.Windows.Forms.Button btnEkstraKaydet;
        private System.Windows.Forms.TextBox txtEkstraAdi;
        private System.Windows.Forms.NumericUpDown nmrEkstraFiyati;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}