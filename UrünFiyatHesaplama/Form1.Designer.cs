
namespace UrünFiyatHesaplama
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
            this.buttonGöster = new System.Windows.Forms.Button();
            this.buttonHesapla = new System.Windows.Forms.Button();
            this.labelUrün = new System.Windows.Forms.Label();
            this.labelMarka = new System.Windows.Forms.Label();
            this.labelModel = new System.Windows.Forms.Label();
            this.comboBoxUrün = new System.Windows.Forms.ComboBox();
            this.comboBoxMarka = new System.Windows.Forms.ComboBox();
            this.comboBoxModel = new System.Windows.Forms.ComboBox();
            this.labelFiyat = new System.Windows.Forms.Label();
            this.labelTaksitSayisi = new System.Windows.Forms.Label();
            this.labelTaksitTutari = new System.Windows.Forms.Label();
            this.textBoxFiyat = new System.Windows.Forms.TextBox();
            this.textBoxTaksitSayisi = new System.Windows.Forms.TextBox();
            this.textBoxTaksitTutari = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonGöster
            // 
            this.buttonGöster.BackColor = System.Drawing.Color.Teal;
            this.buttonGöster.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGöster.ForeColor = System.Drawing.Color.White;
            this.buttonGöster.Location = new System.Drawing.Point(254, 50);
            this.buttonGöster.Name = "buttonGöster";
            this.buttonGöster.Size = new System.Drawing.Size(75, 41);
            this.buttonGöster.TabIndex = 0;
            this.buttonGöster.Text = "Fiyatı Göster";
            this.buttonGöster.UseVisualStyleBackColor = false;
            this.buttonGöster.Click += new System.EventHandler(this.buttonGöster_Click);
            // 
            // buttonHesapla
            // 
            this.buttonHesapla.BackColor = System.Drawing.Color.Teal;
            this.buttonHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonHesapla.ForeColor = System.Drawing.Color.White;
            this.buttonHesapla.Location = new System.Drawing.Point(254, 112);
            this.buttonHesapla.Name = "buttonHesapla";
            this.buttonHesapla.Size = new System.Drawing.Size(75, 23);
            this.buttonHesapla.TabIndex = 0;
            this.buttonHesapla.Text = "Hesapla";
            this.buttonHesapla.UseVisualStyleBackColor = false;
            this.buttonHesapla.Click += new System.EventHandler(this.buttonHesapla_Click);
            // 
            // labelUrün
            // 
            this.labelUrün.AutoSize = true;
            this.labelUrün.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelUrün.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelUrün.Location = new System.Drawing.Point(41, 151);
            this.labelUrün.Name = "labelUrün";
            this.labelUrün.Size = new System.Drawing.Size(40, 16);
            this.labelUrün.TabIndex = 1;
            this.labelUrün.Text = "Ürün";
            // 
            // labelMarka
            // 
            this.labelMarka.AutoSize = true;
            this.labelMarka.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelMarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelMarka.Location = new System.Drawing.Point(41, 196);
            this.labelMarka.Name = "labelMarka";
            this.labelMarka.Size = new System.Drawing.Size(51, 16);
            this.labelMarka.TabIndex = 1;
            this.labelMarka.Text = "Marka";
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelModel.Location = new System.Drawing.Point(41, 238);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(51, 16);
            this.labelModel.TabIndex = 1;
            this.labelModel.Text = "Model";
            // 
            // comboBoxUrün
            // 
            this.comboBoxUrün.FormattingEnabled = true;
            this.comboBoxUrün.Location = new System.Drawing.Point(98, 150);
            this.comboBoxUrün.Name = "comboBoxUrün";
            this.comboBoxUrün.Size = new System.Drawing.Size(121, 21);
            this.comboBoxUrün.TabIndex = 2;
            this.comboBoxUrün.SelectedIndexChanged += new System.EventHandler(this.comboBoxUrün_SelectedIndexChanged);
            // 
            // comboBoxMarka
            // 
            this.comboBoxMarka.FormattingEnabled = true;
            this.comboBoxMarka.Location = new System.Drawing.Point(98, 191);
            this.comboBoxMarka.Name = "comboBoxMarka";
            this.comboBoxMarka.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMarka.TabIndex = 2;
            this.comboBoxMarka.SelectedIndexChanged += new System.EventHandler(this.comboBoxMarka_SelectedIndexChanged);
            // 
            // comboBoxModel
            // 
            this.comboBoxModel.FormattingEnabled = true;
            this.comboBoxModel.Location = new System.Drawing.Point(98, 237);
            this.comboBoxModel.Name = "comboBoxModel";
            this.comboBoxModel.Size = new System.Drawing.Size(121, 21);
            this.comboBoxModel.TabIndex = 2;
            this.comboBoxModel.SelectedIndexChanged += new System.EventHandler(this.comboBoxModel_SelectedIndexChanged);
            // 
            // labelFiyat
            // 
            this.labelFiyat.AutoSize = true;
            this.labelFiyat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelFiyat.Location = new System.Drawing.Point(356, 151);
            this.labelFiyat.Name = "labelFiyat";
            this.labelFiyat.Size = new System.Drawing.Size(42, 16);
            this.labelFiyat.TabIndex = 1;
            this.labelFiyat.Text = "Fiyat";
            // 
            // labelTaksitSayisi
            // 
            this.labelTaksitSayisi.AutoSize = true;
            this.labelTaksitSayisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelTaksitSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTaksitSayisi.Location = new System.Drawing.Point(356, 195);
            this.labelTaksitSayisi.Name = "labelTaksitSayisi";
            this.labelTaksitSayisi.Size = new System.Drawing.Size(98, 16);
            this.labelTaksitSayisi.TabIndex = 1;
            this.labelTaksitSayisi.Text = "Taksit Sayısı";
            // 
            // labelTaksitTutari
            // 
            this.labelTaksitTutari.AutoSize = true;
            this.labelTaksitTutari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelTaksitTutari.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTaksitTutari.Location = new System.Drawing.Point(359, 237);
            this.labelTaksitTutari.Name = "labelTaksitTutari";
            this.labelTaksitTutari.Size = new System.Drawing.Size(95, 16);
            this.labelTaksitTutari.TabIndex = 1;
            this.labelTaksitTutari.Text = "Taksit Tutarı";
            // 
            // textBoxFiyat
            // 
            this.textBoxFiyat.Location = new System.Drawing.Point(468, 149);
            this.textBoxFiyat.Name = "textBoxFiyat";
            this.textBoxFiyat.Size = new System.Drawing.Size(100, 20);
            this.textBoxFiyat.TabIndex = 3;
            // 
            // textBoxTaksitSayisi
            // 
            this.textBoxTaksitSayisi.Location = new System.Drawing.Point(468, 194);
            this.textBoxTaksitSayisi.Name = "textBoxTaksitSayisi";
            this.textBoxTaksitSayisi.Size = new System.Drawing.Size(100, 20);
            this.textBoxTaksitSayisi.TabIndex = 3;
            // 
            // textBoxTaksitTutari
            // 
            this.textBoxTaksitTutari.Location = new System.Drawing.Point(468, 234);
            this.textBoxTaksitTutari.Name = "textBoxTaksitTutari";
            this.textBoxTaksitTutari.Size = new System.Drawing.Size(100, 20);
            this.textBoxTaksitTutari.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(599, 322);
            this.Controls.Add(this.textBoxTaksitTutari);
            this.Controls.Add(this.textBoxTaksitSayisi);
            this.Controls.Add(this.textBoxFiyat);
            this.Controls.Add(this.comboBoxModel);
            this.Controls.Add(this.comboBoxMarka);
            this.Controls.Add(this.comboBoxUrün);
            this.Controls.Add(this.labelModel);
            this.Controls.Add(this.labelMarka);
            this.Controls.Add(this.labelTaksitTutari);
            this.Controls.Add(this.labelTaksitSayisi);
            this.Controls.Add(this.labelFiyat);
            this.Controls.Add(this.labelUrün);
            this.Controls.Add(this.buttonHesapla);
            this.Controls.Add(this.buttonGöster);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGöster;
        private System.Windows.Forms.Button buttonHesapla;
        private System.Windows.Forms.Label labelUrün;
        private System.Windows.Forms.Label labelMarka;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.ComboBox comboBoxUrün;
        private System.Windows.Forms.ComboBox comboBoxMarka;
        private System.Windows.Forms.ComboBox comboBoxModel;
        private System.Windows.Forms.Label labelFiyat;
        private System.Windows.Forms.Label labelTaksitSayisi;
        private System.Windows.Forms.Label labelTaksitTutari;
        private System.Windows.Forms.TextBox textBoxFiyat;
        private System.Windows.Forms.TextBox textBoxTaksitSayisi;
        private System.Windows.Forms.TextBox textBoxTaksitTutari;
    }
}

