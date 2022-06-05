
namespace KirtasiyeSatis
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.kullaniciLogin = new System.Windows.Forms.GroupBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.txtparola = new System.Windows.Forms.TextBox();
            this.txtkullanici = new System.Windows.Forms.TextBox();
            this.lblparola = new System.Windows.Forms.Label();
            this.lbladi = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.kullaniciLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kullaniciLogin
            // 
            this.kullaniciLogin.Controls.Add(this.btnOpen);
            this.kullaniciLogin.Controls.Add(this.txtparola);
            this.kullaniciLogin.Controls.Add(this.txtkullanici);
            this.kullaniciLogin.Controls.Add(this.lblparola);
            this.kullaniciLogin.Controls.Add(this.lbladi);
            this.kullaniciLogin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullaniciLogin.ForeColor = System.Drawing.Color.Teal;
            this.kullaniciLogin.Location = new System.Drawing.Point(177, 24);
            this.kullaniciLogin.Name = "kullaniciLogin";
            this.kullaniciLogin.Size = new System.Drawing.Size(308, 177);
            this.kullaniciLogin.TabIndex = 0;
            this.kullaniciLogin.TabStop = false;
            this.kullaniciLogin.Text = "Oturum Aç";
            this.kullaniciLogin.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnOpen
            // 
            this.btnOpen.Image = global::KirtasiyeSatis.Properties.Resources.icons8_login_501;
            this.btnOpen.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOpen.Location = new System.Drawing.Point(147, 130);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(135, 41);
            this.btnOpen.TabIndex = 4;
            this.btnOpen.Text = "Oturum Aç";
            this.btnOpen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // txtparola
            // 
            this.txtparola.Location = new System.Drawing.Point(122, 94);
            this.txtparola.Name = "txtparola";
            this.txtparola.PasswordChar = '*';
            this.txtparola.Size = new System.Drawing.Size(160, 26);
            this.txtparola.TabIndex = 3;
            // 
            // txtkullanici
            // 
            this.txtkullanici.Location = new System.Drawing.Point(122, 51);
            this.txtkullanici.Name = "txtkullanici";
            this.txtkullanici.Size = new System.Drawing.Size(160, 26);
            this.txtkullanici.TabIndex = 2;
            // 
            // lblparola
            // 
            this.lblparola.AutoSize = true;
            this.lblparola.Location = new System.Drawing.Point(6, 97);
            this.lblparola.Name = "lblparola";
            this.lblparola.Size = new System.Drawing.Size(120, 19);
            this.lblparola.TabIndex = 1;
            this.lblparola.Text = "Kullanıcı Parola:";
            // 
            // lbladi
            // 
            this.lbladi.AutoSize = true;
            this.lbladi.Location = new System.Drawing.Point(6, 54);
            this.lbladi.Name = "lbladi";
            this.lbladi.Size = new System.Drawing.Size(99, 19);
            this.lbladi.TabIndex = 0;
            this.lbladi.Text = "Kullanıcı Adı:";
            this.lbladi.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::KirtasiyeSatis.Properties.Resources._lock;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(27, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanıcı Adı: A Kullanıcı parola: 1";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 217);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.kullaniciLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(600, 256);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kırtasiye Satış ";
            this.Load += new System.EventHandler(this.Login_Load);
            this.kullaniciLogin.ResumeLayout(false);
            this.kullaniciLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox kullaniciLogin;
        private System.Windows.Forms.Label lbladi;
        private System.Windows.Forms.TextBox txtparola;
        private System.Windows.Forms.TextBox txtkullanici;
        private System.Windows.Forms.Label lblparola;
        private System.Windows.Forms.Button btnOpen;
        internal System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

