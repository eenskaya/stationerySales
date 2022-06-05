
namespace KirtasiyeSatis
{
    partial class Sales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sales));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.customerSelect = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.totalprice = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.customerphone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.customername = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.prdctprice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.prdctcolor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.prdctcount = new System.Windows.Forms.TextBox();
            this.prdctname = new System.Windows.Forms.TextBox();
            this.salesdata = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesdata)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.customerSelect);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.totalprice);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.customerphone);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.customername);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.prdctprice);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.prdctcolor);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.prdctcount);
            this.groupBox2.Controls.Add(this.prdctname);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.CadetBlue;
            this.groupBox2.Location = new System.Drawing.Point(14, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(453, 352);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(19, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 22);
            this.label8.TabIndex = 20;
            this.label8.Text = "Müşteri Seç:";
            // 
            // customerSelect
            // 
            this.customerSelect.FormattingEnabled = true;
            this.customerSelect.Location = new System.Drawing.Point(211, 176);
            this.customerSelect.Name = "customerSelect";
            this.customerSelect.Size = new System.Drawing.Size(236, 27);
            this.customerSelect.TabIndex = 19;
            this.customerSelect.Text = "Müşteri Seçin";
            this.customerSelect.SelectedIndexChanged += new System.EventHandler(this.customerSelect_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(243, 310);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 36);
            this.button2.TabIndex = 18;
            this.button2.Text = "Hesapla";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // totalprice
            // 
            this.totalprice.AutoSize = true;
            this.totalprice.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.totalprice.Location = new System.Drawing.Point(156, 301);
            this.totalprice.Name = "totalprice";
            this.totalprice.Size = new System.Drawing.Size(0, 22);
            this.totalprice.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(19, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 22);
            this.label7.TabIndex = 16;
            this.label7.Text = "Toplam Tutar: ";
            // 
            // customerphone
            // 
            this.customerphone.Location = new System.Drawing.Point(211, 249);
            this.customerphone.Multiline = true;
            this.customerphone.Name = "customerphone";
            this.customerphone.Size = new System.Drawing.Size(236, 34);
            this.customerphone.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(19, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 22);
            this.label6.TabIndex = 14;
            this.label6.Text = "Müşteri Telefon: ";
            // 
            // customername
            // 
            this.customername.Location = new System.Drawing.Point(211, 209);
            this.customername.Multiline = true;
            this.customername.Name = "customername";
            this.customername.Size = new System.Drawing.Size(236, 34);
            this.customername.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(19, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "Müşteri Adı:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Teal;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(355, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 36);
            this.button1.TabIndex = 10;
            this.button1.Text = "Satış Yap";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(19, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adı: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(19, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ürün Adet: ";
            // 
            // prdctprice
            // 
            this.prdctprice.Location = new System.Drawing.Point(211, 136);
            this.prdctprice.Multiline = true;
            this.prdctprice.Name = "prdctprice";
            this.prdctprice.Size = new System.Drawing.Size(236, 34);
            this.prdctprice.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(19, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ürün Renk: ";
            // 
            // prdctcolor
            // 
            this.prdctcolor.Location = new System.Drawing.Point(211, 96);
            this.prdctcolor.Multiline = true;
            this.prdctcolor.Name = "prdctcolor";
            this.prdctcolor.Size = new System.Drawing.Size(236, 34);
            this.prdctcolor.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(19, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ürün Fiyatı: ";
            // 
            // prdctcount
            // 
            this.prdctcount.Location = new System.Drawing.Point(211, 56);
            this.prdctcount.Multiline = true;
            this.prdctcount.Name = "prdctcount";
            this.prdctcount.Size = new System.Drawing.Size(236, 34);
            this.prdctcount.TabIndex = 9;
            // 
            // prdctname
            // 
            this.prdctname.Location = new System.Drawing.Point(211, 16);
            this.prdctname.Multiline = true;
            this.prdctname.Name = "prdctname";
            this.prdctname.Size = new System.Drawing.Size(236, 34);
            this.prdctname.TabIndex = 8;
            // 
            // salesdata
            // 
            this.salesdata.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.salesdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesdata.Location = new System.Drawing.Point(474, 28);
            this.salesdata.Name = "salesdata";
            this.salesdata.Size = new System.Drawing.Size(448, 336);
            this.salesdata.TabIndex = 15;
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 371);
            this.Controls.Add(this.salesdata);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satış Ekranı";
            this.Load += new System.EventHandler(this.Sales_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesdata)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox customerphone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox customername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label totalprice;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox prdctprice;
        public System.Windows.Forms.TextBox prdctcolor;
        public System.Windows.Forms.TextBox prdctcount;
        public System.Windows.Forms.TextBox prdctname;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView salesdata;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox customerSelect;
    }
}