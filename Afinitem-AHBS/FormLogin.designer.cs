namespace Sunum
{
	partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.panelLogo = new System.Windows.Forms.Panel();
            this.linkpass = new System.Windows.Forms.LinkLabel();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.toggleGeziciHizmetModu = new Sunum.AfiControls.AfiToggleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSifre = new Sunum.AfiControls.AfiTextBox1();
            this.tbKullaniciAdi = new Sunum.AfiControls.AfiTextBox1();
            this.btnGiris = new Sunum.AfiControls.AfiButton();
            this.elipseControl1 = new ElipseToolDemo.ElipseControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toggleDoktorHemsire = new Sunum.AfiControls.AfiToggleButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.Black;
            this.panelLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLogo.BackgroundImage")));
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(229, 380);
            this.panelLogo.TabIndex = 0;
            this.panelLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // linkpass
            // 
            this.linkpass.ActiveLinkColor = System.Drawing.Color.White;
            this.linkpass.AutoSize = true;
            this.linkpass.BackColor = System.Drawing.Color.Transparent;
            this.linkpass.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F);
            this.linkpass.LinkColor = System.Drawing.Color.Black;
            this.linkpass.Location = new System.Drawing.Point(399, 324);
            this.linkpass.Name = "linkpass";
            this.linkpass.Size = new System.Drawing.Size(137, 17);
            this.linkpass.TabIndex = 0;
            this.linkpass.TabStop = true;
            this.linkpass.Text = "Giriş Yapamıyor musun?";
            this.linkpass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkpass_LinkClicked);
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.AutoSize = true;
            this.lblErrorMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblErrorMessage.ForeColor = System.Drawing.Color.DarkGray;
            this.lblErrorMessage.Image = ((System.Drawing.Image)(resources.GetObject("lblErrorMessage.Image")));
            this.lblErrorMessage.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblErrorMessage.Location = new System.Drawing.Point(320, 247);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(101, 17);
            this.lblErrorMessage.TabIndex = 12;
            this.lblErrorMessage.Text = "Error Message";
            this.lblErrorMessage.Visible = false;
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(712, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(17, 16);
            this.btnMinimize.TabIndex = 11;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(735, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(16, 16);
            this.btnExit.TabIndex = 10;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(290, 123);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(290, 187);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Location = new System.Drawing.Point(625, 127);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 24);
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.Location = new System.Drawing.Point(696, 127);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(24, 24);
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.toggleGeziciHizmetModu);
            this.panel3.Location = new System.Drawing.Point(320, 222);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(45, 22);
            this.panel3.TabIndex = 20;
            // 
            // toggleGeziciHizmetModu
            // 
            this.toggleGeziciHizmetModu.AutoSize = true;
            this.toggleGeziciHizmetModu.FlatAppearance.BorderSize = 0;
            this.toggleGeziciHizmetModu.Location = new System.Drawing.Point(0, 0);
            this.toggleGeziciHizmetModu.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggleGeziciHizmetModu.Name = "toggleGeziciHizmetModu";
            this.toggleGeziciHizmetModu.OffBackColor = System.Drawing.Color.DarkRed;
            this.toggleGeziciHizmetModu.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.toggleGeziciHizmetModu.OnBackColor = System.Drawing.Color.LimeGreen;
            this.toggleGeziciHizmetModu.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.toggleGeziciHizmetModu.Size = new System.Drawing.Size(45, 22);
            this.toggleGeziciHizmetModu.TabIndex = 0;
            this.toggleGeziciHizmetModu.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F);
            this.label2.Location = new System.Drawing.Point(370, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Gezici Hizmet Modu";
            // 
            // tbSifre
            // 
            this.tbSifre.BackColor = System.Drawing.Color.AliceBlue;
            this.tbSifre.BorderColor = System.Drawing.Color.Transparent;
            this.tbSifre.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbSifre.BorderRadius = 15;
            this.tbSifre.BorderSize = 2;
            this.tbSifre.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F);
            this.tbSifre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(102)))), ((int)(((byte)(131)))));
            this.tbSifre.Konum = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSifre.Location = new System.Drawing.Point(321, 180);
            this.tbSifre.Margin = new System.Windows.Forms.Padding(4);
            this.tbSifre.Multiline = false;
            this.tbSifre.Name = "tbSifre";
            this.tbSifre.Padding = new System.Windows.Forms.Padding(7);
            this.tbSifre.PasswordChar = false;
            this.tbSifre.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbSifre.PlaceholderText = "";
            this.tbSifre.Size = new System.Drawing.Size(289, 36);
            this.tbSifre.TabIndex = 26;
            this.tbSifre.Texts = "******";
            this.tbSifre.UnderlinedStyle = false;
            this.tbSifre.Enter += new System.EventHandler(this.txtPass_Enter_1);
            // 
            // tbKullaniciAdi
            // 
            this.tbKullaniciAdi.BackColor = System.Drawing.Color.AliceBlue;
            this.tbKullaniciAdi.BorderColor = System.Drawing.Color.Transparent;
            this.tbKullaniciAdi.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbKullaniciAdi.BorderRadius = 15;
            this.tbKullaniciAdi.BorderSize = 2;
            this.tbKullaniciAdi.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKullaniciAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(102)))), ((int)(((byte)(131)))));
            this.tbKullaniciAdi.Konum = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbKullaniciAdi.Location = new System.Drawing.Point(320, 120);
            this.tbKullaniciAdi.Margin = new System.Windows.Forms.Padding(4);
            this.tbKullaniciAdi.Multiline = false;
            this.tbKullaniciAdi.Name = "tbKullaniciAdi";
            this.tbKullaniciAdi.Padding = new System.Windows.Forms.Padding(7);
            this.tbKullaniciAdi.PasswordChar = false;
            this.tbKullaniciAdi.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbKullaniciAdi.PlaceholderText = "";
            this.tbKullaniciAdi.Size = new System.Drawing.Size(289, 36);
            this.tbKullaniciAdi.TabIndex = 25;
            this.tbKullaniciAdi.Texts = "Dr. Kullanıcı Adı";
            this.tbKullaniciAdi.UnderlinedStyle = false;
            this.tbKullaniciAdi.Enter += new System.EventHandler(this.txtUser_Enter_1);
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.Transparent;
            this.btnGiris.BackGroundColor = System.Drawing.Color.Transparent;
            this.btnGiris.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(102)))), ((int)(((byte)(131)))));
            this.btnGiris.BorderRadius = 25;
            this.btnGiris.BorderSize = 3;
            this.btnGiris.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGiris.FlatAppearance.BorderSize = 0;
            this.btnGiris.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(69)))), ((int)(((byte)(105)))));
            this.btnGiris.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiris.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11F);
            this.btnGiris.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(102)))), ((int)(((byte)(131)))));
            this.btnGiris.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGiris.Location = new System.Drawing.Point(320, 277);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(286, 35);
            this.btnGiris.TabIndex = 22;
            this.btnGiris.Text = "Giriş ";
            this.btnGiris.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(102)))), ((int)(((byte)(131)))));
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // elipseControl1
            // 
            this.elipseControl1.CornerRadius = 70;
            this.elipseControl1.TargetControl = this;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.toggleDoktorHemsire);
            this.panel2.Location = new System.Drawing.Point(650, 128);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(45, 22);
            this.panel2.TabIndex = 19;
            // 
            // toggleDoktorHemsire
            // 
            this.toggleDoktorHemsire.Location = new System.Drawing.Point(0, 0);
            this.toggleDoktorHemsire.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggleDoktorHemsire.Name = "toggleDoktorHemsire";
            this.toggleDoktorHemsire.OffBackColor = System.Drawing.Color.LimeGreen;
            this.toggleDoktorHemsire.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.toggleDoktorHemsire.OnBackColor = System.Drawing.Color.DarkRed;
            this.toggleDoktorHemsire.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.toggleDoktorHemsire.Size = new System.Drawing.Size(45, 22);
            this.toggleDoktorHemsire.TabIndex = 18;
            this.toggleDoktorHemsire.UseVisualStyleBackColor = true;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 380);
            this.Controls.Add(this.tbSifre);
            this.Controls.Add(this.tbKullaniciAdi);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblErrorMessage);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.linkpass);
            this.Controls.Add(this.panelLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormLogin_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panelLogo;
		private System.Windows.Forms.LinkLabel linkpass;
		private System.Windows.Forms.PictureBox btnExit;
		private System.Windows.Forms.PictureBox btnMinimize;
		private System.Windows.Forms.Label lblErrorMessage;
        private AfiControls.AfiButton afiButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel3;
        private AfiControls.AfiToggleButton toggleGeziciHizmetModu;
        private System.Windows.Forms.Label label2;
        private ElipseToolDemo.ElipseControl elipseControl1;
        private AfiControls.AfiButton btnGiris;
        private AfiControls.AfiTextBox1 tbKullaniciAdi;
        private AfiControls.AfiTextBox1 tbSifre;
        private System.Windows.Forms.Panel panel2;
        private AfiControls.AfiToggleButton toggleDoktorHemsire;
    }
}

