namespace Sunum.Formlar.VeriIslemleri
{
	partial class FormVeriIslemleri_MernisTopluSorgulama
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
            this.pbMernis = new Sunum.AfiControls.AfiProgressBar();
            this.dgvMernis = new System.Windows.Forms.DataGridView();
            this.cbVarsayilanAdres = new System.Windows.Forms.CheckBox();
            this.cbAdresiOlmayan = new System.Windows.Forms.CheckBox();
            this.cbMernisSorgulama30Gun = new System.Windows.Forms.CheckBox();
            this.tbMernisOlu = new Sunum.AfiControls.AfiTextBox();
            this.btnMernisteOluGorunen = new Sunum.AfiControls.AfiButton();
            this.btnTemizle_Mernis = new Sunum.AfiControls.AfiButton();
            this.btnExceleAktar_Mernis = new Sunum.AfiControls.AfiButton();
            this.btnTCKimlikKazananYabanci = new Sunum.AfiControls.AfiButton();
            this.cbMernis = new Sunum.AfiControls.AfiComboBox();
            this.btnMernisKisiBilgileri = new Sunum.AfiControls.AfiButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMernis)).BeginInit();
            this.SuspendLayout();
            // 
            // pbMernis
            // 
            this.pbMernis.ChannelColor = System.Drawing.Color.LightSteelBlue;
            this.pbMernis.ChannelHeight = 6;
            this.pbMernis.ForeBackColor = System.Drawing.Color.RoyalBlue;
            this.pbMernis.ForeColor = System.Drawing.Color.White;
            this.pbMernis.Location = new System.Drawing.Point(355, 13);
            this.pbMernis.Name = "pbMernis";
            this.pbMernis.ShowMaximun = false;
            this.pbMernis.ShowValue = Sunum.AfiControls.TextPosition.Right;
            this.pbMernis.Size = new System.Drawing.Size(267, 39);
            this.pbMernis.SliderColor = System.Drawing.Color.RoyalBlue;
            this.pbMernis.SliderHeight = 6;
            this.pbMernis.SymbolAfter = "";
            this.pbMernis.SymbolBefore = "";
            this.pbMernis.TabIndex = 25;
            // 
            // dgvMernis
            // 
            this.dgvMernis.AllowUserToOrderColumns = true;
            this.dgvMernis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMernis.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvMernis.Location = new System.Drawing.Point(0, 105);
            this.dgvMernis.Name = "dgvMernis";
            this.dgvMernis.Size = new System.Drawing.Size(1280, 850);
            this.dgvMernis.TabIndex = 24;
            // 
            // cbVarsayilanAdres
            // 
            this.cbVarsayilanAdres.AutoSize = true;
            this.cbVarsayilanAdres.Location = new System.Drawing.Point(881, 71);
            this.cbVarsayilanAdres.Name = "cbVarsayilanAdres";
            this.cbVarsayilanAdres.Size = new System.Drawing.Size(126, 17);
            this.cbVarsayilanAdres.TabIndex = 23;
            this.cbVarsayilanAdres.Text = "Varsayılan Adres Yap";
            this.cbVarsayilanAdres.UseVisualStyleBackColor = true;
            // 
            // cbAdresiOlmayan
            // 
            this.cbAdresiOlmayan.AutoSize = true;
            this.cbAdresiOlmayan.Location = new System.Drawing.Point(671, 71);
            this.cbAdresiOlmayan.Name = "cbAdresiOlmayan";
            this.cbAdresiOlmayan.Size = new System.Drawing.Size(191, 17);
            this.cbAdresiOlmayan.TabIndex = 22;
            this.cbAdresiOlmayan.Text = "Sedece Adresi Olmayanları Sorgula";
            this.cbAdresiOlmayan.UseVisualStyleBackColor = true;
            // 
            // cbMernisSorgulama30Gun
            // 
            this.cbMernisSorgulama30Gun.AutoSize = true;
            this.cbMernisSorgulama30Gun.Location = new System.Drawing.Point(372, 71);
            this.cbMernisSorgulama30Gun.Name = "cbMernisSorgulama30Gun";
            this.cbMernisSorgulama30Gun.Size = new System.Drawing.Size(263, 17);
            this.cbMernisSorgulama30Gun.TabIndex = 21;
            this.cbMernisSorgulama30Gun.Text = "Mernis Sorgulama Zamanı 30 Günden Eski Olanlar";
            this.cbMernisSorgulama30Gun.UseVisualStyleBackColor = true;
            // 
            // tbMernisOlu
            // 
            this.tbMernisOlu.BackColor = System.Drawing.SystemColors.Window;
            this.tbMernisOlu.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tbMernisOlu.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbMernisOlu.BorderRadius = 0;
            this.tbMernisOlu.BorderSize = 2;
            this.tbMernisOlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbMernisOlu.ForeColor = System.Drawing.Color.DimGray;
            this.tbMernisOlu.Location = new System.Drawing.Point(184, 67);
            this.tbMernisOlu.Margin = new System.Windows.Forms.Padding(4);
            this.tbMernisOlu.Multiline = false;
            this.tbMernisOlu.Name = "tbMernisOlu";
            this.tbMernisOlu.Padding = new System.Windows.Forms.Padding(7);
            this.tbMernisOlu.PasswordChar = false;
            this.tbMernisOlu.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbMernisOlu.PlaceholderText = "";
            this.tbMernisOlu.Size = new System.Drawing.Size(150, 31);
            this.tbMernisOlu.TabIndex = 20;
            this.tbMernisOlu.Texts = "";
            this.tbMernisOlu.UnderlinedStyle = false;
            // 
            // btnMernisteOluGorunen
            // 
            this.btnMernisteOluGorunen.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnMernisteOluGorunen.BackGroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnMernisteOluGorunen.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnMernisteOluGorunen.BorderRadius = 40;
            this.btnMernisteOluGorunen.BorderSize = 0;
            this.btnMernisteOluGorunen.FlatAppearance.BorderSize = 0;
            this.btnMernisteOluGorunen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMernisteOluGorunen.ForeColor = System.Drawing.Color.White;
            this.btnMernisteOluGorunen.Location = new System.Drawing.Point(12, 58);
            this.btnMernisteOluGorunen.Name = "btnMernisteOluGorunen";
            this.btnMernisteOluGorunen.Size = new System.Drawing.Size(150, 40);
            this.btnMernisteOluGorunen.TabIndex = 19;
            this.btnMernisteOluGorunen.Text = "Merniste Ölü Görünen Kişileri Pasif Yap";
            this.btnMernisteOluGorunen.TextColor = System.Drawing.Color.White;
            this.btnMernisteOluGorunen.UseVisualStyleBackColor = false;
            // 
            // btnTemizle_Mernis
            // 
            this.btnTemizle_Mernis.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnTemizle_Mernis.BackGroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnTemizle_Mernis.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnTemizle_Mernis.BorderRadius = 40;
            this.btnTemizle_Mernis.BorderSize = 0;
            this.btnTemizle_Mernis.FlatAppearance.BorderSize = 0;
            this.btnTemizle_Mernis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemizle_Mernis.ForeColor = System.Drawing.Color.White;
            this.btnTemizle_Mernis.Location = new System.Drawing.Point(940, 12);
            this.btnTemizle_Mernis.Name = "btnTemizle_Mernis";
            this.btnTemizle_Mernis.Size = new System.Drawing.Size(150, 40);
            this.btnTemizle_Mernis.TabIndex = 18;
            this.btnTemizle_Mernis.Text = "Temizle";
            this.btnTemizle_Mernis.TextColor = System.Drawing.Color.White;
            this.btnTemizle_Mernis.UseVisualStyleBackColor = false;
            // 
            // btnExceleAktar_Mernis
            // 
            this.btnExceleAktar_Mernis.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnExceleAktar_Mernis.BackGroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnExceleAktar_Mernis.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnExceleAktar_Mernis.BorderRadius = 40;
            this.btnExceleAktar_Mernis.BorderSize = 0;
            this.btnExceleAktar_Mernis.FlatAppearance.BorderSize = 0;
            this.btnExceleAktar_Mernis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExceleAktar_Mernis.ForeColor = System.Drawing.Color.White;
            this.btnExceleAktar_Mernis.Location = new System.Drawing.Point(784, 12);
            this.btnExceleAktar_Mernis.Name = "btnExceleAktar_Mernis";
            this.btnExceleAktar_Mernis.Size = new System.Drawing.Size(150, 40);
            this.btnExceleAktar_Mernis.TabIndex = 17;
            this.btnExceleAktar_Mernis.Text = "Excel\'e Aktar";
            this.btnExceleAktar_Mernis.TextColor = System.Drawing.Color.White;
            this.btnExceleAktar_Mernis.UseVisualStyleBackColor = false;
            // 
            // btnTCKimlikKazananYabanci
            // 
            this.btnTCKimlikKazananYabanci.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnTCKimlikKazananYabanci.BackGroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnTCKimlikKazananYabanci.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnTCKimlikKazananYabanci.BorderRadius = 40;
            this.btnTCKimlikKazananYabanci.BorderSize = 0;
            this.btnTCKimlikKazananYabanci.FlatAppearance.BorderSize = 0;
            this.btnTCKimlikKazananYabanci.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTCKimlikKazananYabanci.ForeColor = System.Drawing.Color.White;
            this.btnTCKimlikKazananYabanci.Location = new System.Drawing.Point(628, 12);
            this.btnTCKimlikKazananYabanci.Name = "btnTCKimlikKazananYabanci";
            this.btnTCKimlikKazananYabanci.Size = new System.Drawing.Size(150, 40);
            this.btnTCKimlikKazananYabanci.TabIndex = 16;
            this.btnTCKimlikKazananYabanci.Text = "T.C Kimlik Numarası Kazanan Yabancı Kimlik Numaralı Kişi Sorgulama";
            this.btnTCKimlikKazananYabanci.TextColor = System.Drawing.Color.White;
            this.btnTCKimlikKazananYabanci.UseVisualStyleBackColor = false;
            // 
            // cbMernis
            // 
            this.cbMernis.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbMernis.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cbMernis.BorderSize = 1;
            this.cbMernis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbMernis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbMernis.ForeColor = System.Drawing.Color.DimGray;
            this.cbMernis.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbMernis.Items.AddRange(new object[] {
            "Kesin"});
            this.cbMernis.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbMernis.ListTextColor = System.Drawing.Color.DimGray;
            this.cbMernis.Location = new System.Drawing.Point(184, 12);
            this.cbMernis.MinimumSize = new System.Drawing.Size(50, 30);
            this.cbMernis.Name = "cbMernis";
            this.cbMernis.Padding = new System.Windows.Forms.Padding(1);
            this.cbMernis.Size = new System.Drawing.Size(150, 40);
            this.cbMernis.TabIndex = 15;
            this.cbMernis.Texts = "";
            // 
            // btnMernisKisiBilgileri
            // 
            this.btnMernisKisiBilgileri.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnMernisKisiBilgileri.BackGroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnMernisKisiBilgileri.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnMernisKisiBilgileri.BorderRadius = 40;
            this.btnMernisKisiBilgileri.BorderSize = 0;
            this.btnMernisKisiBilgileri.FlatAppearance.BorderSize = 0;
            this.btnMernisKisiBilgileri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMernisKisiBilgileri.ForeColor = System.Drawing.Color.White;
            this.btnMernisKisiBilgileri.Location = new System.Drawing.Point(12, 12);
            this.btnMernisKisiBilgileri.Name = "btnMernisKisiBilgileri";
            this.btnMernisKisiBilgileri.Size = new System.Drawing.Size(150, 40);
            this.btnMernisKisiBilgileri.TabIndex = 14;
            this.btnMernisKisiBilgileri.Text = "Mernis\'ten Kişi Bilgileri Çek";
            this.btnMernisKisiBilgileri.TextColor = System.Drawing.Color.White;
            this.btnMernisKisiBilgileri.UseVisualStyleBackColor = false;
            // 
            // FormVeriIslemleri_MernisTopluSorgulama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 955);
            this.Controls.Add(this.pbMernis);
            this.Controls.Add(this.dgvMernis);
            this.Controls.Add(this.cbVarsayilanAdres);
            this.Controls.Add(this.cbAdresiOlmayan);
            this.Controls.Add(this.cbMernisSorgulama30Gun);
            this.Controls.Add(this.tbMernisOlu);
            this.Controls.Add(this.btnMernisteOluGorunen);
            this.Controls.Add(this.btnTemizle_Mernis);
            this.Controls.Add(this.btnExceleAktar_Mernis);
            this.Controls.Add(this.btnTCKimlikKazananYabanci);
            this.Controls.Add(this.cbMernis);
            this.Controls.Add(this.btnMernisKisiBilgileri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVeriIslemleri_MernisTopluSorgulama";
            this.Text = "FormVeriIslemleri_MernisTopluSorgulama";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMernis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private AfiControls.AfiProgressBar pbMernis;
		private System.Windows.Forms.DataGridView dgvMernis;
		private System.Windows.Forms.CheckBox cbVarsayilanAdres;
		private System.Windows.Forms.CheckBox cbAdresiOlmayan;
		private System.Windows.Forms.CheckBox cbMernisSorgulama30Gun;
		private AfiControls.AfiTextBox tbMernisOlu;
		private AfiControls.AfiButton btnMernisteOluGorunen;
		private AfiControls.AfiButton btnTemizle_Mernis;
		private AfiControls.AfiButton btnExceleAktar_Mernis;
		private AfiControls.AfiButton btnTCKimlikKazananYabanci;
		private AfiControls.AfiComboBox cbMernis;
		private AfiControls.AfiButton btnMernisKisiBilgileri;
	}
}