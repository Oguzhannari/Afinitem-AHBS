namespace Sunum
{
	partial class FormRecoverPassword
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.tbAdİsteme = new System.Windows.Forms.TextBox();
            this.btnGonder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(85, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı adınızı veya mailinizi giriniz:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblResult.Location = new System.Drawing.Point(85, 149);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 17);
            this.lblResult.TabIndex = 1;
            // 
            // tbAdİsteme
            // 
            this.tbAdİsteme.Location = new System.Drawing.Point(88, 68);
            this.tbAdİsteme.Name = "tbAdİsteme";
            this.tbAdİsteme.Size = new System.Drawing.Size(285, 20);
            this.tbAdİsteme.TabIndex = 2;
            // 
            // btnGonder
            // 
            this.btnGonder.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnGonder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(69)))), ((int)(((byte)(105)))));
            this.btnGonder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnGonder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGonder.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnGonder.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGonder.Location = new System.Drawing.Point(280, 94);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(93, 32);
            this.btnGonder.TabIndex = 3;
            this.btnGonder.Text = "Gönder";
            this.btnGonder.UseVisualStyleBackColor = false;
            this.btnGonder.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // FormRecoverPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(54)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(858, 251);
            this.Controls.Add(this.btnGonder);
            this.Controls.Add(this.tbAdİsteme);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label1);
            this.Name = "FormRecoverPassword";
            this.Text = "FormRecoverPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblResult;
		private System.Windows.Forms.TextBox tbAdİsteme;
		private System.Windows.Forms.Button btnGonder;
	}
}