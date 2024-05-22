namespace Barkod_One
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dataGridView1 = new DataGridView();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            comboBox2 = new ComboBox();
            label4 = new Label();
            dataGridView2 = new DataGridView();
            button3 = new Button();
            dateonay = new DateTimePicker();
            comboBox1 = new ComboBox();
            button2 = new Button();
            button1 = new Button();
            txtkdviztoplam = new TextBox();
            txttedarikci = new TextBox();
            txtbelgeno = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dtarih = new DateTimePicker();
            txtfis = new TextBox();
            Fason = new TabPage();
            Onaylayan = new ComboBox();
            fonaytarih = new DateTimePicker();
            fasontarih = new DateTimePicker();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            txtktutar = new TextBox();
            label13 = new Label();
            ftedarikci = new TextBox();
            label12 = new Label();
            txtfbelge = new TextBox();
            label11 = new Label();
            fasonara = new Button();
            label10 = new Label();
            txtfasonno = new TextBox();
            label9 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            Fason.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 353);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1539, 681);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(Fason);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(3, 33);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1539, 314);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.AutoScroll = true;
            tabPage1.Controls.Add(comboBox2);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(dataGridView2);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(dateonay);
            tabPage1.Controls.Add(comboBox1);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(txtkdviztoplam);
            tabPage1.Controls.Add(txttedarikci);
            tabPage1.Controls.Add(txtbelgeno);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(dtarih);
            tabPage1.Controls.Add(txtfis);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1531, 286);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Barkod";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Onaylandı", "Onaysız/Miktar", "Onaysız/Fiyat", "Onaysız/miktar/fiyat" });
            comboBox2.Location = new Point(156, 238);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(270, 23);
            comboBox2.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(27, 236);
            label4.Name = "label4";
            label4.Size = new Size(97, 25);
            label4.TabIndex = 23;
            label4.Text = " Durum :";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(816, 25);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(1045, 213);
            dataGridView2.TabIndex = 22;
            dataGridView2.VirtualMode = true;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // button3
            // 
            button3.BackgroundImage = Properties.Resources.CONVERT;
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Location = new Point(737, 163);
            button3.Name = "button3";
            button3.Size = new Size(73, 75);
            button3.TabIndex = 21;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // dateonay
            // 
            dateonay.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dateonay.Location = new Point(156, 157);
            dateonay.Name = "dateonay";
            dateonay.Size = new Size(270, 29);
            dateonay.TabIndex = 19;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Berk Bey ", "Tahsin Bey\t\t", "Kemal Lokman\t", "Resul Avşar", "Serkan Tutar" });
            comboBox1.Location = new Point(156, 205);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(270, 23);
            comboBox1.TabIndex = 18;
            // 
            // button2
            // 
            button2.Image = Properties.Resources.ARA1;
            button2.Location = new Point(432, 21);
            button2.Name = "button2";
            button2.Size = new Size(39, 31);
            button2.TabIndex = 17;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Image = Properties.Resources.BUTTONKAYIT;
            button1.Location = new Point(432, 161);
            button1.Name = "button1";
            button1.Size = new Size(294, 75);
            button1.TabIndex = 16;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtkdviztoplam
            // 
            txtkdviztoplam.Enabled = false;
            txtkdviztoplam.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtkdviztoplam.Location = new Point(603, 116);
            txtkdviztoplam.Name = "txtkdviztoplam";
            txtkdviztoplam.Size = new Size(207, 29);
            txtkdviztoplam.TabIndex = 13;
            // 
            // txttedarikci
            // 
            txttedarikci.Enabled = false;
            txttedarikci.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txttedarikci.Location = new Point(156, 111);
            txttedarikci.Name = "txttedarikci";
            txttedarikci.Size = new Size(270, 29);
            txttedarikci.TabIndex = 12;
            // 
            // txtbelgeno
            // 
            txtbelgeno.Enabled = false;
            txtbelgeno.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtbelgeno.Location = new Point(603, 61);
            txtbelgeno.Name = "txtbelgeno";
            txtbelgeno.Size = new Size(207, 29);
            txtbelgeno.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label8.Location = new Point(27, 204);
            label8.Name = "label8";
            label8.Size = new Size(123, 25);
            label8.TabIndex = 9;
            label8.Text = "Onaylayan :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label7.Location = new Point(76, 161);
            label7.Name = "label7";
            label7.Size = new Size(74, 25);
            label7.TabIndex = 8;
            label7.Text = "Onay :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label6.Location = new Point(434, 115);
            label6.Name = "label6";
            label6.Size = new Size(163, 25);
            label6.TabIndex = 7;
            label6.Text = "Kdv'siz Toplam :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.Location = new Point(40, 113);
            label5.Name = "label5";
            label5.Size = new Size(110, 25);
            label5.TabIndex = 6;
            label5.Text = "Tedarikçi :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(434, 67);
            label3.Name = "label3";
            label3.Size = new Size(110, 25);
            label3.TabIndex = 4;
            label3.Text = "Belge No :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(5, 65);
            label2.Name = "label2";
            label2.Size = new Size(145, 25);
            label2.TabIndex = 3;
            label2.Text = "Belge Tarihi  :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(67, 25);
            label1.Name = "label1";
            label1.Size = new Size(83, 25);
            label1.TabIndex = 2;
            label1.Text = "Fiş No :";
            // 
            // dtarih
            // 
            dtarih.Enabled = false;
            dtarih.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dtarih.Location = new Point(156, 63);
            dtarih.Name = "dtarih";
            dtarih.Size = new Size(270, 29);
            dtarih.TabIndex = 1;
            // 
            // txtfis
            // 
            txtfis.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtfis.ForeColor = Color.RoyalBlue;
            txtfis.Location = new Point(156, 23);
            txtfis.Name = "txtfis";
            txtfis.Size = new Size(270, 29);
            txtfis.TabIndex = 1;
            txtfis.Click += txtfis_Click;
            txtfis.TextChanged += txtfis_TextChanged;
            txtfis.KeyPress += txtfis_KeyPress;
            // 
            // Fason
            // 
            Fason.Controls.Add(Onaylayan);
            Fason.Controls.Add(fonaytarih);
            Fason.Controls.Add(fasontarih);
            Fason.Controls.Add(label16);
            Fason.Controls.Add(label15);
            Fason.Controls.Add(label14);
            Fason.Controls.Add(txtktutar);
            Fason.Controls.Add(label13);
            Fason.Controls.Add(ftedarikci);
            Fason.Controls.Add(label12);
            Fason.Controls.Add(txtfbelge);
            Fason.Controls.Add(label11);
            Fason.Controls.Add(fasonara);
            Fason.Controls.Add(label10);
            Fason.Controls.Add(txtfasonno);
            Fason.Location = new Point(4, 24);
            Fason.Name = "Fason";
            Fason.Padding = new Padding(3);
            Fason.Size = new Size(1531, 286);
            Fason.TabIndex = 1;
            Fason.Text = "Fason Barkod";
            Fason.UseVisualStyleBackColor = true;
            // 
            // Onaylayan
            // 
            Onaylayan.FormattingEnabled = true;
            Onaylayan.Items.AddRange(new object[] { "Berk Bey ", "Tahsin Bey\t\t", "Kemal Lokman\t", "Resul Avşar", "Serkan Tutar" });
            Onaylayan.Location = new Point(191, 241);
            Onaylayan.Name = "Onaylayan";
            Onaylayan.Size = new Size(270, 23);
            Onaylayan.TabIndex = 35;
            // 
            // fonaytarih
            // 
            fonaytarih.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            fonaytarih.Location = new Point(191, 202);
            fonaytarih.Name = "fonaytarih";
            fonaytarih.Size = new Size(270, 29);
            fonaytarih.TabIndex = 34;
            // 
            // fasontarih
            // 
            fasontarih.Enabled = false;
            fasontarih.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            fasontarih.Location = new Point(191, 64);
            fasontarih.Name = "fasontarih";
            fasontarih.Size = new Size(270, 29);
            fasontarih.TabIndex = 33;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label16.Location = new Point(34, 239);
            label16.Name = "label16";
            label16.Size = new Size(109, 25);
            label16.TabIndex = 32;
            label16.Text = "Onaylayan";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label15.Location = new Point(34, 204);
            label15.Name = "label15";
            label15.Size = new Size(134, 25);
            label15.TabIndex = 30;
            label15.Text = "Onay Tarihi :";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label14.Location = new Point(34, 169);
            label14.Name = "label14";
            label14.Size = new Size(149, 25);
            label14.TabIndex = 28;
            label14.Text = "KDV'siz Tutar :";
            // 
            // txtktutar
            // 
            txtktutar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtktutar.ForeColor = Color.RoyalBlue;
            txtktutar.Location = new Point(191, 165);
            txtktutar.Name = "txtktutar";
            txtktutar.Size = new Size(270, 29);
            txtktutar.TabIndex = 27;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label13.Location = new Point(34, 134);
            label13.Name = "label13";
            label13.Size = new Size(110, 25);
            label13.TabIndex = 26;
            label13.Text = "Tedarikçi :";
            // 
            // ftedarikci
            // 
            ftedarikci.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            ftedarikci.ForeColor = Color.RoyalBlue;
            ftedarikci.Location = new Point(191, 130);
            ftedarikci.Name = "ftedarikci";
            ftedarikci.Size = new Size(270, 29);
            ftedarikci.TabIndex = 25;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label12.Location = new Point(34, 99);
            label12.Name = "label12";
            label12.Size = new Size(110, 25);
            label12.TabIndex = 24;
            label12.Text = "Belge No :";
            // 
            // txtfbelge
            // 
            txtfbelge.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtfbelge.ForeColor = Color.RoyalBlue;
            txtfbelge.Location = new Point(191, 95);
            txtfbelge.Name = "txtfbelge";
            txtfbelge.Size = new Size(270, 29);
            txtfbelge.TabIndex = 23;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label11.Location = new Point(34, 64);
            label11.Name = "label11";
            label11.Size = new Size(146, 25);
            label11.TabIndex = 22;
            label11.Text = "Fatura Tarihi :";
            // 
            // fasonara
            // 
            fasonara.Image = Properties.Resources.ARA1;
            fasonara.Location = new Point(476, 23);
            fasonara.Name = "fasonara";
            fasonara.Size = new Size(39, 31);
            fasonara.TabIndex = 20;
            fasonara.UseVisualStyleBackColor = true;
            fasonara.Click += fasonara_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label10.Location = new Point(34, 29);
            label10.Name = "label10";
            label10.Size = new Size(123, 25);
            label10.TabIndex = 19;
            label10.Text = "Barkod No :";
            label10.Click += label10_Click;
            // 
            // txtfasonno
            // 
            txtfasonno.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtfasonno.ForeColor = Color.RoyalBlue;
            txtfasonno.Location = new Point(191, 25);
            txtfasonno.Name = "txtfasonno";
            txtfasonno.Size = new Size(270, 29);
            txtfasonno.TabIndex = 18;
            // 
            // label9
            // 
            label9.Dock = DockStyle.Fill;
            label9.Font = new Font("Yu Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(3, 0);
            label9.Name = "label9";
            label9.Size = new Size(1539, 30);
            label9.TabIndex = 21;
            label9.Text = "Copyright © 2024 Deniz Textile | Powered by Emir ŞAHİN  ";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            label9.Click += label9_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label9, 0, 0);
            tableLayoutPanel1.Controls.Add(tabControl1, 0, 1);
            tableLayoutPanel1.Controls.Add(dataGridView1, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.633094F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 91.3669052F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 686F));
            tableLayoutPanel1.Size = new Size(1545, 1037);
            tableLayoutPanel1.TabIndex = 22;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1545, 1037);
            Controls.Add(tableLayoutPanel1);
            HelpButton = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "Form1";
            Text = "Barkod.BRDV1.0";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            Fason.ResumeLayout(false);
            Fason.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private TabControl tabControl1;
        private Label label9;
        private TableLayoutPanel tableLayoutPanel1;
        private TabPage tabPage1;
        private DataGridView dataGridView2;
        private Button button3;
        private DateTimePicker dateonay;
        private ComboBox comboBox1;
        private Button button2;
        private Button button1;
        private TextBox txtkdviztoplam;
        private TextBox txttedarikci;
        private TextBox txtbelgeno;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dtarih;
        private TextBox txtfis;
        private ComboBox comboBox2;
        private Label label4;
        private TabPage Fason;
        private Button fasonara;
        private Label label10;
        private TextBox txtfasonno;
        private Label label12;
        private TextBox txtfbelge;
        private Label label11;
        private Label label16;
        private Label label15;
        private Label label14;
        private TextBox txtktutar;
        private Label label13;
        private TextBox ftedarikci;
        private ComboBox Onaylayan;
        private DateTimePicker fonaytarih;
        private DateTimePicker fasontarih;
    }
}
