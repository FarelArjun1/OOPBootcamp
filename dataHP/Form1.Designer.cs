namespace dataHP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.id_hp = new System.Windows.Forms.TextBox();
            this.nama = new System.Windows.Forms.TextBox();
            this.jenis = new System.Windows.Forms.TextBox();
            this.stock = new System.Windows.Forms.TextBox();
            this.btn_simpan = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(370, 163);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(707, 439);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "id";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "nama";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "jenis";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "stock";
            // 
            // id_hp
            // 
            this.id_hp.BackColor = System.Drawing.Color.Tan;
            this.id_hp.Location = new System.Drawing.Point(154, 190);
            this.id_hp.Name = "id_hp";
            this.id_hp.Size = new System.Drawing.Size(149, 27);
            this.id_hp.TabIndex = 6;
            // 
            // nama
            // 
            this.nama.BackColor = System.Drawing.Color.Tan;
            this.nama.Location = new System.Drawing.Point(154, 254);
            this.nama.Name = "nama";
            this.nama.Size = new System.Drawing.Size(149, 27);
            this.nama.TabIndex = 7;
            // 
            // jenis
            // 
            this.jenis.BackColor = System.Drawing.Color.Tan;
            this.jenis.Location = new System.Drawing.Point(154, 320);
            this.jenis.Name = "jenis";
            this.jenis.Size = new System.Drawing.Size(149, 27);
            this.jenis.TabIndex = 8;
            // 
            // stock
            // 
            this.stock.BackColor = System.Drawing.Color.Tan;
            this.stock.Location = new System.Drawing.Point(154, 386);
            this.stock.Name = "stock";
            this.stock.Size = new System.Drawing.Size(149, 27);
            this.stock.TabIndex = 9;
            // 
            // btn_simpan
            // 
            this.btn_simpan.BackColor = System.Drawing.Color.SandyBrown;
            this.btn_simpan.Location = new System.Drawing.Point(39, 475);
            this.btn_simpan.Name = "btn_simpan";
            this.btn_simpan.Size = new System.Drawing.Size(107, 29);
            this.btn_simpan.TabIndex = 10;
            this.btn_simpan.Text = "simpan";
            this.btn_simpan.UseVisualStyleBackColor = false;
            this.btn_simpan.Click += new System.EventHandler(this.btn_simpan_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.SandyBrown;
            this.btn_update.Location = new System.Drawing.Point(196, 475);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(107, 29);
            this.btn_update.TabIndex = 11;
            this.btn_update.Text = "update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SandyBrown;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1106, 125);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(753, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 28);
            this.label5.TabIndex = 1;
            this.label5.Text = "Cari";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(808, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(269, 27);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("STXinwei", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(77, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(437, 43);
            this.label6.TabIndex = 2;
            this.label6.Text = "TOKO HANDPHONE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 614);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_simpan);
            this.Controls.Add(this.stock);
            this.Controls.Add(this.jenis);
            this.Controls.Add(this.nama);
            this.Controls.Add(this.id_hp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView dataGridView2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox id_hp;
        private TextBox nama;
        private TextBox jenis;
        private TextBox stock;
        private Button btn_simpan;
        private Button btn_update;
        private Panel panel1;
        private Label label5;
        private TextBox textBox1;
        private Label label6;
    }
}