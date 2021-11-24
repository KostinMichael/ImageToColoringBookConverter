namespace СoloringBookImageConverter.UI
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.trackBarPalette = new System.Windows.Forms.TrackBar();
            this.textBoxPaletteSize = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbOriginal = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.trackBarPBCr = new System.Windows.Forms.TrackBar();
            this.trackBarPBCg = new System.Windows.Forms.TrackBar();
            this.trackBarPBCb = new System.Windows.Forms.TrackBar();
            this.textBoxPBCr = new System.Windows.Forms.TextBox();
            this.textBoxPBCg = new System.Windows.Forms.TextBox();
            this.textBoxPBCb = new System.Windows.Forms.TextBox();
            this.btnProcessImage = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbQuantize = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pbResult = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.trackBarBlure = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxEdgesWight = new System.Windows.Forms.TextBox();
            this.trackBarEdgesWight = new System.Windows.Forms.TrackBar();
            this.textBoxInfo = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.trackBarRegionSize = new System.Windows.Forms.TrackBar();
            this.buttonRegions = new System.Windows.Forms.Button();
            this.buttonEdges = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxRegionSize = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.palette = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBoxMouseColor = new System.Windows.Forms.PictureBox();
            this.checkBoxUseDatPalette = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openImageTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPalette)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOriginal)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPBCr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPBCg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPBCb)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuantize)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarEdgesWight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRegionSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMouseColor)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // trackBarPalette
            // 
            this.trackBarPalette.BackColor = System.Drawing.SystemColors.HighlightText;
            this.trackBarPalette.LargeChange = 2;
            this.trackBarPalette.Location = new System.Drawing.Point(6, 23);
            this.trackBarPalette.Maximum = 50;
            this.trackBarPalette.Minimum = 1;
            this.trackBarPalette.Name = "trackBarPalette";
            this.trackBarPalette.Size = new System.Drawing.Size(274, 45);
            this.trackBarPalette.TabIndex = 3;
            this.trackBarPalette.TickFrequency = 10;
            this.trackBarPalette.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarPalette.Value = 16;
            this.trackBarPalette.ValueChanged += new System.EventHandler(this.trackBarPalette_ValueChanged);
            // 
            // textBoxPaletteSize
            // 
            this.textBoxPaletteSize.Location = new System.Drawing.Point(286, 23);
            this.textBoxPaletteSize.Name = "textBoxPaletteSize";
            this.textBoxPaletteSize.Size = new System.Drawing.Size(49, 20);
            this.textBoxPaletteSize.TabIndex = 4;
            this.textBoxPaletteSize.Text = "16";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Кол-во цветов в палитре";
            // 
            // pbOriginal
            // 
            this.pbOriginal.Location = new System.Drawing.Point(0, 0);
            this.pbOriginal.Name = "pbOriginal";
            this.pbOriginal.Size = new System.Drawing.Size(250, 208);
            this.pbOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbOriginal.TabIndex = 6;
            this.pbOriginal.TabStop = false;
            this.pbOriginal.Click += new System.EventHandler(this.pictureBoxOriginal_Click);
            this.pbOriginal.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxOriginal_MouseMove);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.Controls.Add(this.pbOriginal);
            this.panel1.Location = new System.Drawing.Point(15, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 300);
            this.panel1.TabIndex = 7;
            // 
            // trackBarPBCr
            // 
            this.trackBarPBCr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.trackBarPBCr.Location = new System.Drawing.Point(6, 74);
            this.trackBarPBCr.Maximum = 100;
            this.trackBarPBCr.Minimum = 1;
            this.trackBarPBCr.Name = "trackBarPBCr";
            this.trackBarPBCr.Size = new System.Drawing.Size(101, 45);
            this.trackBarPBCr.TabIndex = 8;
            this.trackBarPBCr.TickFrequency = 10;
            this.trackBarPBCr.Value = 30;
            this.trackBarPBCr.ValueChanged += new System.EventHandler(this.PBCtrackbarChange);
            // 
            // trackBarPBCg
            // 
            this.trackBarPBCg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.trackBarPBCg.Location = new System.Drawing.Point(6, 125);
            this.trackBarPBCg.Maximum = 100;
            this.trackBarPBCg.Minimum = 1;
            this.trackBarPBCg.Name = "trackBarPBCg";
            this.trackBarPBCg.Size = new System.Drawing.Size(101, 45);
            this.trackBarPBCg.TabIndex = 9;
            this.trackBarPBCg.TickFrequency = 10;
            this.trackBarPBCg.Value = 59;
            this.trackBarPBCg.ValueChanged += new System.EventHandler(this.PBCtrackbarChange);
            // 
            // trackBarPBCb
            // 
            this.trackBarPBCb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.trackBarPBCb.Location = new System.Drawing.Point(6, 176);
            this.trackBarPBCb.Maximum = 100;
            this.trackBarPBCb.Minimum = 1;
            this.trackBarPBCb.Name = "trackBarPBCb";
            this.trackBarPBCb.Size = new System.Drawing.Size(101, 45);
            this.trackBarPBCb.TabIndex = 10;
            this.trackBarPBCb.TickFrequency = 10;
            this.trackBarPBCb.Value = 11;
            this.trackBarPBCb.ValueChanged += new System.EventHandler(this.PBCtrackbarChange);
            // 
            // textBoxPBCr
            // 
            this.textBoxPBCr.Location = new System.Drawing.Point(113, 74);
            this.textBoxPBCr.Name = "textBoxPBCr";
            this.textBoxPBCr.Size = new System.Drawing.Size(35, 20);
            this.textBoxPBCr.TabIndex = 11;
            this.textBoxPBCr.Text = "30";
            // 
            // textBoxPBCg
            // 
            this.textBoxPBCg.Location = new System.Drawing.Point(113, 125);
            this.textBoxPBCg.Name = "textBoxPBCg";
            this.textBoxPBCg.Size = new System.Drawing.Size(35, 20);
            this.textBoxPBCg.TabIndex = 12;
            this.textBoxPBCg.Text = "59";
            // 
            // textBoxPBCb
            // 
            this.textBoxPBCb.Location = new System.Drawing.Point(113, 176);
            this.textBoxPBCb.Name = "textBoxPBCb";
            this.textBoxPBCb.Size = new System.Drawing.Size(35, 20);
            this.textBoxPBCb.TabIndex = 13;
            this.textBoxPBCb.Text = "11";
            // 
            // btnProcessImage
            // 
            this.btnProcessImage.Location = new System.Drawing.Point(436, 484);
            this.btnProcessImage.Name = "btnProcessImage";
            this.btnProcessImage.Size = new System.Drawing.Size(180, 28);
            this.btnProcessImage.TabIndex = 17;
            this.btnProcessImage.Text = "Квантование + границы";
            this.btnProcessImage.UseVisualStyleBackColor = true;
            this.btnProcessImage.Click += new System.EventHandler(this.btnProcessImage_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "Коэффициенты ф-ции поиска ближайшего цвета в палитре";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel2.Controls.Add(this.pbQuantize);
            this.panel2.Location = new System.Drawing.Point(271, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 300);
            this.panel2.TabIndex = 8;
            // 
            // pbQuantize
            // 
            this.pbQuantize.Location = new System.Drawing.Point(0, 0);
            this.pbQuantize.Name = "pbQuantize";
            this.pbQuantize.Size = new System.Drawing.Size(250, 208);
            this.pbQuantize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbQuantize.TabIndex = 6;
            this.pbQuantize.TabStop = false;
            this.pbQuantize.Click += new System.EventHandler(this.pictureBoxQuantize_Click);
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel3.Controls.Add(this.pbResult);
            this.panel3.Location = new System.Drawing.Point(527, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 300);
            this.panel3.TabIndex = 9;
            // 
            // pbResult
            // 
            this.pbResult.Location = new System.Drawing.Point(0, 0);
            this.pbResult.Name = "pbResult";
            this.pbResult.Size = new System.Drawing.Size(250, 208);
            this.pbResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbResult.TabIndex = 6;
            this.pbResult.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(439, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Предварительное размытие";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(732, 375);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(49, 20);
            this.textBox1.TabIndex = 19;
            this.textBox1.Text = "10";
            // 
            // trackBarBlure
            // 
            this.trackBarBlure.BackColor = System.Drawing.SystemColors.ControlLight;
            this.trackBarBlure.LargeChange = 2;
            this.trackBarBlure.Location = new System.Drawing.Point(436, 375);
            this.trackBarBlure.Maximum = 50;
            this.trackBarBlure.Minimum = 1;
            this.trackBarBlure.Name = "trackBarBlure";
            this.trackBarBlure.Size = new System.Drawing.Size(290, 45);
            this.trackBarBlure.TabIndex = 18;
            this.trackBarBlure.TickFrequency = 10;
            this.trackBarBlure.Value = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Толщина границ";
            // 
            // textBoxEdgesWight
            // 
            this.textBoxEdgesWight.Location = new System.Drawing.Point(266, 106);
            this.textBoxEdgesWight.Name = "textBoxEdgesWight";
            this.textBoxEdgesWight.Size = new System.Drawing.Size(72, 20);
            this.textBoxEdgesWight.TabIndex = 22;
            this.textBoxEdgesWight.Text = "10";
            // 
            // trackBarEdgesWight
            // 
            this.trackBarEdgesWight.BackColor = System.Drawing.SystemColors.HighlightText;
            this.trackBarEdgesWight.LargeChange = 2;
            this.trackBarEdgesWight.Location = new System.Drawing.Point(6, 106);
            this.trackBarEdgesWight.Maximum = 50;
            this.trackBarEdgesWight.Minimum = 1;
            this.trackBarEdgesWight.Name = "trackBarEdgesWight";
            this.trackBarEdgesWight.Size = new System.Drawing.Size(254, 45);
            this.trackBarEdgesWight.TabIndex = 21;
            this.trackBarEdgesWight.TickFrequency = 10;
            this.trackBarEdgesWight.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarEdgesWight.Value = 10;
            this.trackBarEdgesWight.ValueChanged += new System.EventHandler(this.trackBarEdgesWight_ValueChanged);
            // 
            // textBoxInfo
            // 
            this.textBoxInfo.Location = new System.Drawing.Point(435, 428);
            this.textBoxInfo.Name = "textBoxInfo";
            this.textBoxInfo.Size = new System.Drawing.Size(180, 20);
            this.textBoxInfo.TabIndex = 25;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(435, 451);
            this.progressBar.Maximum = 6;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(179, 23);
            this.progressBar.TabIndex = 26;
            // 
            // trackBarRegionSize
            // 
            this.trackBarRegionSize.BackColor = System.Drawing.SystemColors.HighlightText;
            this.trackBarRegionSize.Location = new System.Drawing.Point(6, 23);
            this.trackBarRegionSize.Maximum = 1000;
            this.trackBarRegionSize.Minimum = 1;
            this.trackBarRegionSize.Name = "trackBarRegionSize";
            this.trackBarRegionSize.Size = new System.Drawing.Size(254, 45);
            this.trackBarRegionSize.TabIndex = 28;
            this.trackBarRegionSize.TickFrequency = 100;
            this.trackBarRegionSize.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarRegionSize.Value = 5;
            this.trackBarRegionSize.ValueChanged += new System.EventHandler(this.trackBarRegionSize_ValueChanged);
            // 
            // buttonRegions
            // 
            this.buttonRegions.Location = new System.Drawing.Point(266, 47);
            this.buttonRegions.Name = "buttonRegions";
            this.buttonRegions.Size = new System.Drawing.Size(72, 53);
            this.buttonRegions.TabIndex = 29;
            this.buttonRegions.Text = "Удалить маленькие области";
            this.buttonRegions.UseVisualStyleBackColor = true;
            this.buttonRegions.Click += new System.EventHandler(this.buttonRegions_Click);
            // 
            // buttonEdges
            // 
            this.buttonEdges.Location = new System.Drawing.Point(266, 132);
            this.buttonEdges.Name = "buttonEdges";
            this.buttonEdges.Size = new System.Drawing.Size(72, 32);
            this.buttonEdges.TabIndex = 31;
            this.buttonEdges.Text = "Границы";
            this.buttonEdges.UseVisualStyleBackColor = true;
            this.buttonEdges.Click += new System.EventHandler(this.buttonEdges_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Минимальный размер области";
            // 
            // textBoxRegionSize
            // 
            this.textBoxRegionSize.Location = new System.Drawing.Point(266, 23);
            this.textBoxRegionSize.Name = "textBoxRegionSize";
            this.textBoxRegionSize.Size = new System.Drawing.Size(72, 20);
            this.textBoxRegionSize.TabIndex = 29;
            this.textBoxRegionSize.Text = "5";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.palette});
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 50;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(181, 196);
            this.dataGridView1.TabIndex = 32;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // palette
            // 
            this.palette.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.palette.HeaderText = "Палитра";
            this.palette.Name = "palette";
            this.palette.ReadOnly = true;
            this.palette.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // pictureBoxMouseColor
            // 
            this.pictureBoxMouseColor.Location = new System.Drawing.Point(193, 6);
            this.pictureBoxMouseColor.Name = "pictureBoxMouseColor";
            this.pictureBoxMouseColor.Size = new System.Drawing.Size(161, 68);
            this.pictureBoxMouseColor.TabIndex = 33;
            this.pictureBoxMouseColor.TabStop = false;
            // 
            // checkBoxUseDatPalette
            // 
            this.checkBoxUseDatPalette.AutoSize = true;
            this.checkBoxUseDatPalette.Location = new System.Drawing.Point(193, 75);
            this.checkBoxUseDatPalette.Name = "checkBoxUseDatPalette";
            this.checkBoxUseDatPalette.Size = new System.Drawing.Size(161, 17);
            this.checkBoxUseDatPalette.TabIndex = 34;
            this.checkBoxUseDatPalette.Text = "Использовать эту палитру";
            this.checkBoxUseDatPalette.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Оригинальное изображение";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(15, 355);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(415, 258);
            this.tabControl1.TabIndex = 36;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBoxPBCb);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.trackBarPBCr);
            this.tabPage1.Controls.Add(this.trackBarPalette);
            this.tabPage1.Controls.Add(this.trackBarPBCg);
            this.tabPage1.Controls.Add(this.textBoxPaletteSize);
            this.tabPage1.Controls.Add(this.textBoxPBCg);
            this.tabPage1.Controls.Add(this.trackBarPBCb);
            this.tabPage1.Controls.Add(this.textBoxPBCr);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(407, 232);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Настройка палитры";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonEdges);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.buttonRegions);
            this.tabPage2.Controls.Add(this.trackBarRegionSize);
            this.tabPage2.Controls.Add(this.trackBarEdgesWight);
            this.tabPage2.Controls.Add(this.textBoxRegionSize);
            this.tabPage2.Controls.Add(this.textBoxEdgesWight);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(407, 232);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Границы и области";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Controls.Add(this.pictureBoxMouseColor);
            this.tabPage3.Controls.Add(this.checkBoxUseDatPalette);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(407, 232);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "Ручная палитра";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(788, 24);
            this.menuStrip1.TabIndex = 37;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openImageTSMI});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // openImageTSMI
            // 
            this.openImageTSMI.Name = "openImageTSMI";
            this.openImageTSMI.Size = new System.Drawing.Size(198, 22);
            this.openImageTSMI.Text = "Открыть изображение";
            this.openImageTSMI.Click += new System.EventHandler(this.openImageTSMI_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(275, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Упрощение палитры";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(524, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Результат";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(788, 625);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.textBoxInfo);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnProcessImage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBarBlure);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPalette)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOriginal)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPBCr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPBCg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPBCb)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuantize)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarEdgesWight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRegionSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMouseColor)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TrackBar trackBarPalette;
        private System.Windows.Forms.TextBox textBoxPaletteSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbOriginal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar trackBarPBCr;
        private System.Windows.Forms.TrackBar trackBarPBCg;
        private System.Windows.Forms.TrackBar trackBarPBCb;
        private System.Windows.Forms.TextBox textBoxPBCr;
        private System.Windows.Forms.TextBox textBoxPBCg;
        private System.Windows.Forms.TextBox textBoxPBCb;
        private System.Windows.Forms.Button btnProcessImage;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbQuantize;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pbResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TrackBar trackBarBlure;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxEdgesWight;
        private System.Windows.Forms.TrackBar trackBarEdgesWight;
        private System.Windows.Forms.TextBox textBoxInfo;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TrackBar trackBarRegionSize;
        private System.Windows.Forms.Button buttonRegions;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxRegionSize;
        private System.Windows.Forms.Button buttonEdges;
        private System.Windows.Forms.PictureBox pictureBoxMouseColor;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox checkBoxUseDatPalette;
        private System.Windows.Forms.DataGridViewTextBoxColumn palette;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openImageTSMI;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

