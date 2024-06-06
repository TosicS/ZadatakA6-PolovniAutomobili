namespace ZadatakA6_PolovniAutomobili
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonIzadji = new System.Windows.Forms.Button();
            this.buttonIzmeni = new System.Windows.Forms.Button();
            this.textBoxNaziv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxPrizovdjac = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxModeliAutomobila = new System.Windows.Forms.ListBox();
            this.buttonPrikazi = new System.Windows.Forms.Button();
            this.textBoxSifra = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonPrikaziF2 = new System.Windows.Forms.Button();
            this.numericUpDownDo = new System.Windows.Forms.NumericUpDown();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBoxKilometraza = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDownOd = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOd)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(4, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(799, 436);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.buttonIzadji);
            this.tabPage1.Controls.Add(this.buttonIzmeni);
            this.tabPage1.Controls.Add(this.textBoxNaziv);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.comboBoxPrizovdjac);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.listBoxModeliAutomobila);
            this.tabPage1.Controls.Add(this.buttonPrikazi);
            this.tabPage1.Controls.Add(this.textBoxSifra);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(791, 410);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Modeli automobila";
            // 
            // buttonIzadji
            // 
            this.buttonIzadji.BackColor = System.Drawing.Color.LightGray;
            this.buttonIzadji.Location = new System.Drawing.Point(131, 343);
            this.buttonIzadji.Name = "buttonIzadji";
            this.buttonIzadji.Size = new System.Drawing.Size(152, 45);
            this.buttonIzadji.TabIndex = 10;
            this.buttonIzadji.Text = "Izadji";
            this.buttonIzadji.UseVisualStyleBackColor = false;
            this.buttonIzadji.Click += new System.EventHandler(this.buttonIzadji_Click);
            // 
            // buttonIzmeni
            // 
            this.buttonIzmeni.BackColor = System.Drawing.Color.LightGray;
            this.buttonIzmeni.Location = new System.Drawing.Point(131, 276);
            this.buttonIzmeni.Name = "buttonIzmeni";
            this.buttonIzmeni.Size = new System.Drawing.Size(152, 45);
            this.buttonIzmeni.TabIndex = 9;
            this.buttonIzmeni.Text = "Izmeni";
            this.buttonIzmeni.UseVisualStyleBackColor = false;
            this.buttonIzmeni.Click += new System.EventHandler(this.buttonIzmeni_Click);
            // 
            // textBoxNaziv
            // 
            this.textBoxNaziv.Location = new System.Drawing.Point(131, 123);
            this.textBoxNaziv.Name = "textBoxNaziv";
            this.textBoxNaziv.Size = new System.Drawing.Size(152, 20);
            this.textBoxNaziv.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Naziv";
            // 
            // comboBoxPrizovdjac
            // 
            this.comboBoxPrizovdjac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPrizovdjac.FormattingEnabled = true;
            this.comboBoxPrizovdjac.Location = new System.Drawing.Point(131, 82);
            this.comboBoxPrizovdjac.Name = "comboBoxPrizovdjac";
            this.comboBoxPrizovdjac.Size = new System.Drawing.Size(152, 21);
            this.comboBoxPrizovdjac.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Proizvodjac";
            // 
            // listBoxModeliAutomobila
            // 
            this.listBoxModeliAutomobila.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxModeliAutomobila.FormattingEnabled = true;
            this.listBoxModeliAutomobila.ItemHeight = 14;
            this.listBoxModeliAutomobila.Location = new System.Drawing.Point(407, 85);
            this.listBoxModeliAutomobila.Name = "listBoxModeliAutomobila";
            this.listBoxModeliAutomobila.Size = new System.Drawing.Size(337, 298);
            this.listBoxModeliAutomobila.TabIndex = 4;
            this.listBoxModeliAutomobila.SelectedIndexChanged += new System.EventHandler(this.listBoxModeliAutomobila_SelectedIndexChanged);
            // 
            // buttonPrikazi
            // 
            this.buttonPrikazi.BackgroundImage = global::ZadatakA6_PolovniAutomobili.Properties.Resources.search__1_;
            this.buttonPrikazi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPrikazi.Location = new System.Drawing.Point(699, 19);
            this.buttonPrikazi.Name = "buttonPrikazi";
            this.buttonPrikazi.Size = new System.Drawing.Size(45, 48);
            this.buttonPrikazi.TabIndex = 3;
            this.buttonPrikazi.UseVisualStyleBackColor = true;
            this.buttonPrikazi.Click += new System.EventHandler(this.buttonPrikazi_Click);
            // 
            // textBoxSifra
            // 
            this.textBoxSifra.Location = new System.Drawing.Point(573, 34);
            this.textBoxSifra.Name = "textBoxSifra";
            this.textBoxSifra.Size = new System.Drawing.Size(100, 20);
            this.textBoxSifra.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(536, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Sifra:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(404, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Model:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.buttonPrikaziF2);
            this.tabPage2.Controls.Add(this.numericUpDownDo);
            this.tabPage2.Controls.Add(this.chart1);
            this.tabPage2.Controls.Add(this.textBoxKilometraza);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.listView1);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.numericUpDownOd);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(791, 410);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Broj raspolozivih vozila";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.Location = new System.Drawing.Point(190, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 45);
            this.button1.TabIndex = 14;
            this.button1.Text = "Izadji";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // buttonPrikaziF2
            // 
            this.buttonPrikaziF2.BackColor = System.Drawing.Color.LightGray;
            this.buttonPrikaziF2.Location = new System.Drawing.Point(18, 359);
            this.buttonPrikaziF2.Name = "buttonPrikaziF2";
            this.buttonPrikaziF2.Size = new System.Drawing.Size(112, 45);
            this.buttonPrikaziF2.TabIndex = 13;
            this.buttonPrikaziF2.Text = "Prikazi";
            this.buttonPrikaziF2.UseVisualStyleBackColor = false;
            this.buttonPrikaziF2.Click += new System.EventHandler(this.buttonPrikaziF2_Click);
            // 
            // numericUpDownDo
            // 
            this.numericUpDownDo.Location = new System.Drawing.Point(182, 82);
            this.numericUpDownDo.Maximum = new decimal(new int[] {
            2026,
            0,
            0,
            0});
            this.numericUpDownDo.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numericUpDownDo.Name = "numericUpDownDo";
            this.numericUpDownDo.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownDo.TabIndex = 12;
            this.numericUpDownDo.Value = new decimal(new int[] {
            2026,
            0,
            0,
            0});
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(377, 45);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(350, 337);
            this.chart1.TabIndex = 11;
            this.chart1.Text = "chart1";
            // 
            // textBoxKilometraza
            // 
            this.textBoxKilometraza.Location = new System.Drawing.Point(150, 136);
            this.textBoxKilometraza.Name = "textBoxKilometraza";
            this.textBoxKilometraza.Size = new System.Drawing.Size(152, 20);
            this.textBoxKilometraza.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(80, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Kilometraza:";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(18, 186);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(284, 144);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Proizvodjac";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Broj";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(152, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Do:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(152, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Od:";
            // 
            // numericUpDownOd
            // 
            this.numericUpDownOd.Location = new System.Drawing.Point(182, 45);
            this.numericUpDownOd.Maximum = new decimal(new int[] {
            2026,
            0,
            0,
            0});
            this.numericUpDownOd.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numericUpDownOd.Name = "numericUpDownOd";
            this.numericUpDownOd.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownOd.TabIndex = 1;
            this.numericUpDownOd.Value = new decimal(new int[] {
            2026,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Godiste";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.richTextBox1);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(791, 410);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Uputstvo";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(7, 7);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(778, 397);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(462, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Model";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOd)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBoxSifra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonIzmeni;
        private System.Windows.Forms.TextBox textBoxNaziv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxPrizovdjac;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxModeliAutomobila;
        private System.Windows.Forms.Button buttonPrikazi;
        private System.Windows.Forms.Button buttonIzadji;
        private System.Windows.Forms.Button buttonPrikaziF2;
        private System.Windows.Forms.NumericUpDown numericUpDownDo;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox textBoxKilometraza;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDownOd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

