
namespace KirtasiyeSatis
{
    partial class Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            this.cstmrbox = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.customerdata = new System.Windows.Forms.DataGridView();
            this.customeradress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnccutomer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.customerphone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.customertc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.customersurname = new System.Windows.Forms.TextBox();
            this.customername = new System.Windows.Forms.TextBox();
            this.cstmrbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerdata)).BeginInit();
            this.SuspendLayout();
            // 
            // cstmrbox
            // 
            this.cstmrbox.Controls.Add(this.button1);
            this.cstmrbox.Controls.Add(this.customerdata);
            this.cstmrbox.Controls.Add(this.customeradress);
            this.cstmrbox.Controls.Add(this.label5);
            this.cstmrbox.Controls.Add(this.btnccutomer);
            this.cstmrbox.Controls.Add(this.label1);
            this.cstmrbox.Controls.Add(this.label2);
            this.cstmrbox.Controls.Add(this.customerphone);
            this.cstmrbox.Controls.Add(this.label3);
            this.cstmrbox.Controls.Add(this.customertc);
            this.cstmrbox.Controls.Add(this.label4);
            this.cstmrbox.Controls.Add(this.customersurname);
            this.cstmrbox.Controls.Add(this.customername);
            this.cstmrbox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cstmrbox.ForeColor = System.Drawing.Color.DarkViolet;
            this.cstmrbox.Location = new System.Drawing.Point(12, 12);
            this.cstmrbox.Name = "cstmrbox";
            this.cstmrbox.Size = new System.Drawing.Size(776, 268);
            this.cstmrbox.TabIndex = 14;
            this.cstmrbox.TabStop = false;
            this.cstmrbox.Text = "Müşteri ";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.DarkRed;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(181, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 36);
            this.button1.TabIndex = 16;
            this.button1.Text = "Sil     ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // customerdata
            // 
            this.customerdata.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.customerdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerdata.Location = new System.Drawing.Point(375, 20);
            this.customerdata.Name = "customerdata";
            this.customerdata.Size = new System.Drawing.Size(395, 237);
            this.customerdata.TabIndex = 15;
            // 
            // customeradress
            // 
            this.customeradress.BackColor = System.Drawing.SystemColors.Window;
            this.customeradress.Location = new System.Drawing.Point(166, 180);
            this.customeradress.Multiline = true;
            this.customeradress.Name = "customeradress";
            this.customeradress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.customeradress.Size = new System.Drawing.Size(203, 40);
            this.customeradress.TabIndex = 14;
            this.customeradress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(16, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 22);
            this.label5.TabIndex = 13;
            this.label5.Text = "Müşteri Adresi: ";
            // 
            // btnccutomer
            // 
            this.btnccutomer.ForeColor = System.Drawing.Color.Teal;
            this.btnccutomer.Image = ((System.Drawing.Image)(resources.GetObject("btnccutomer.Image")));
            this.btnccutomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnccutomer.Location = new System.Drawing.Point(278, 226);
            this.btnccutomer.Name = "btnccutomer";
            this.btnccutomer.Size = new System.Drawing.Size(91, 36);
            this.btnccutomer.TabIndex = 10;
            this.btnccutomer.Text = "Kaydet";
            this.btnccutomer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnccutomer.UseVisualStyleBackColor = true;
            this.btnccutomer.Click += new System.EventHandler(this.btnccutomer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri Adı: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(16, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Müşteri Soyadı: ";
            // 
            // customerphone
            // 
            this.customerphone.Location = new System.Drawing.Point(166, 140);
            this.customerphone.MaxLength = 11;
            this.customerphone.Multiline = true;
            this.customerphone.Name = "customerphone";
            this.customerphone.Size = new System.Drawing.Size(203, 34);
            this.customerphone.TabIndex = 11;
            this.customerphone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(16, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Müşteri TC: ";
            // 
            // customertc
            // 
            this.customertc.Location = new System.Drawing.Point(166, 100);
            this.customertc.MaxLength = 11;
            this.customertc.Multiline = true;
            this.customertc.Name = "customertc";
            this.customertc.Size = new System.Drawing.Size(203, 34);
            this.customertc.TabIndex = 10;
            this.customertc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(16, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Müşteri Telefon: ";
            // 
            // customersurname
            // 
            this.customersurname.Location = new System.Drawing.Point(166, 60);
            this.customersurname.Multiline = true;
            this.customersurname.Name = "customersurname";
            this.customersurname.Size = new System.Drawing.Size(203, 34);
            this.customersurname.TabIndex = 9;
            this.customersurname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // customername
            // 
            this.customername.Location = new System.Drawing.Point(166, 20);
            this.customername.Multiline = true;
            this.customername.Name = "customername";
            this.customername.Size = new System.Drawing.Size(203, 34);
            this.customername.TabIndex = 8;
            this.customername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 289);
            this.Controls.Add(this.cstmrbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Ekle";
            this.Load += new System.EventHandler(this.customer_Load);
            this.cstmrbox.ResumeLayout(false);
            this.cstmrbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerdata)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox cstmrbox;
        private System.Windows.Forms.Button btnccutomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox customerphone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox customertc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox customersurname;
        private System.Windows.Forms.TextBox customername;
        private System.Windows.Forms.TextBox customeradress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView customerdata;
        private System.Windows.Forms.Button button1;
    }
}