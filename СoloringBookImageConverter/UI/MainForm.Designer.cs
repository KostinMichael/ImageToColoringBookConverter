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
            this.trbPaletteSize = new System.Windows.Forms.TrackBar();
            this.labelPaletteSize = new System.Windows.Forms.Label();
            this.pbOriginal = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.trbPBCr = new System.Windows.Forms.TrackBar();
            this.trbPBCg = new System.Windows.Forms.TrackBar();
            this.trbPBCb = new System.Windows.Forms.TrackBar();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbQuantize = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pbResult = new System.Windows.Forms.PictureBox();
            this.labelBlur = new System.Windows.Forms.Label();
            this.trbBlur = new System.Windows.Forms.TrackBar();
            this.labelLineThickness = new System.Windows.Forms.Label();
            this.trbLineThickness = new System.Windows.Forms.TrackBar();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.trbMinSquare = new System.Windows.Forms.TrackBar();
            this.labelMinSquare = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.palette = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBoxMouseColor = new System.Windows.Forms.PictureBox();
            this.checkBoxUseDatPalette = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.labelPBCb = new System.Windows.Forms.Label();
            this.labelPBCg = new System.Windows.Forms.Label();
            this.labelPBCr = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.openImageTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.quantizedImageTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.resultImageTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.paletteImageTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.конвертироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.конвертироватьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьЛинииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьОбластиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.trbPaletteSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOriginal)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbPBCr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbPBCg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbPBCb)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuantize)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbBlur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbLineThickness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbMinSquare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMouseColor)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // trbPaletteSize
            // 
            this.trbPaletteSize.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.trbPaletteSize.LargeChange = 2;
            this.trbPaletteSize.Location = new System.Drawing.Point(6, 23);
            this.trbPaletteSize.Maximum = 100;
            this.trbPaletteSize.Minimum = 1;
            this.trbPaletteSize.Name = "trbPaletteSize";
            this.trbPaletteSize.Size = new System.Drawing.Size(200, 45);
            this.trbPaletteSize.TabIndex = 3;
            this.trbPaletteSize.TickFrequency = 10;
            this.trbPaletteSize.Value = 16;
            this.trbPaletteSize.ValueChanged += new System.EventHandler(this.trbPaletteSize_ValueChanged);
            // 
            // labelPaletteSize
            // 
            this.labelPaletteSize.AutoSize = true;
            this.labelPaletteSize.Location = new System.Drawing.Point(6, 7);
            this.labelPaletteSize.Name = "labelPaletteSize";
            this.labelPaletteSize.Size = new System.Drawing.Size(150, 13);
            this.labelPaletteSize.TabIndex = 5;
            this.labelPaletteSize.Text = "Кол-во цветов в палитре: 16";
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
            this.panel1.Location = new System.Drawing.Point(12, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 210);
            this.panel1.TabIndex = 7;
            // 
            // trbPBCr
            // 
            this.trbPBCr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.trbPBCr.Location = new System.Drawing.Point(9, 98);
            this.trbPBCr.Maximum = 100;
            this.trbPBCr.Minimum = 1;
            this.trbPBCr.Name = "trbPBCr";
            this.trbPBCr.Size = new System.Drawing.Size(127, 45);
            this.trbPBCr.TabIndex = 8;
            this.trbPBCr.TickFrequency = 10;
            this.trbPBCr.Value = 30;
            this.trbPBCr.ValueChanged += new System.EventHandler(this.trbPCBr_ValueChanged);
            // 
            // trbPBCg
            // 
            this.trbPBCg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.trbPBCg.Location = new System.Drawing.Point(145, 98);
            this.trbPBCg.Maximum = 100;
            this.trbPBCg.Minimum = 1;
            this.trbPBCg.Name = "trbPBCg";
            this.trbPBCg.Size = new System.Drawing.Size(127, 45);
            this.trbPBCg.TabIndex = 9;
            this.trbPBCg.TickFrequency = 10;
            this.trbPBCg.Value = 59;
            this.trbPBCg.ValueChanged += new System.EventHandler(this.trbPCBg_ValueChanged);
            // 
            // trbPBCb
            // 
            this.trbPBCb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.trbPBCb.Location = new System.Drawing.Point(281, 98);
            this.trbPBCb.Maximum = 100;
            this.trbPBCb.Minimum = 1;
            this.trbPBCb.Name = "trbPBCb";
            this.trbPBCb.Size = new System.Drawing.Size(127, 45);
            this.trbPBCb.TabIndex = 10;
            this.trbPBCb.TickFrequency = 10;
            this.trbPBCb.Value = 11;
            this.trbPBCb.ValueChanged += new System.EventHandler(this.trbPCBb_ValueChanged);
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
            this.panel2.Location = new System.Drawing.Point(229, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(210, 210);
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
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel3.Controls.Add(this.pbResult);
            this.panel3.Location = new System.Drawing.Point(444, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(500, 500);
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
            // labelBlur
            // 
            this.labelBlur.AutoSize = true;
            this.labelBlur.Location = new System.Drawing.Point(207, 7);
            this.labelBlur.Name = "labelBlur";
            this.labelBlur.Size = new System.Drawing.Size(164, 13);
            this.labelBlur.TabIndex = 20;
            this.labelBlur.Text = "Предварительное размытие: 0";
            // 
            // trbBlur
            // 
            this.trbBlur.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.trbBlur.LargeChange = 2;
            this.trbBlur.Location = new System.Drawing.Point(210, 23);
            this.trbBlur.Maximum = 50;
            this.trbBlur.Name = "trbBlur";
            this.trbBlur.Size = new System.Drawing.Size(200, 45);
            this.trbBlur.TabIndex = 18;
            this.trbBlur.TickFrequency = 10;
            this.trbBlur.ValueChanged += new System.EventHandler(this.trbBlur_ValueChanged);
            // 
            // labelLineThickness
            // 
            this.labelLineThickness.AutoSize = true;
            this.labelLineThickness.Location = new System.Drawing.Point(207, 156);
            this.labelLineThickness.Name = "labelLineThickness";
            this.labelLineThickness.Size = new System.Drawing.Size(104, 13);
            this.labelLineThickness.TabIndex = 23;
            this.labelLineThickness.Text = "Толщина линий: 10";
            // 
            // trbLineThickness
            // 
            this.trbLineThickness.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.trbLineThickness.LargeChange = 2;
            this.trbLineThickness.Location = new System.Drawing.Point(210, 172);
            this.trbLineThickness.Maximum = 50;
            this.trbLineThickness.Minimum = 1;
            this.trbLineThickness.Name = "trbLineThickness";
            this.trbLineThickness.Size = new System.Drawing.Size(200, 45);
            this.trbLineThickness.TabIndex = 21;
            this.trbLineThickness.TickFrequency = 10;
            this.trbLineThickness.Value = 10;
            this.trbLineThickness.ValueChanged += new System.EventHandler(this.trbLineThickness_ValueChanged);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(444, 555);
            this.progressBar.Maximum = 6;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(500, 14);
            this.progressBar.TabIndex = 26;
            // 
            // trbMinSquare
            // 
            this.trbMinSquare.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.trbMinSquare.Location = new System.Drawing.Point(6, 172);
            this.trbMinSquare.Maximum = 1000;
            this.trbMinSquare.Minimum = 1;
            this.trbMinSquare.Name = "trbMinSquare";
            this.trbMinSquare.Size = new System.Drawing.Size(200, 45);
            this.trbMinSquare.TabIndex = 28;
            this.trbMinSquare.TickFrequency = 100;
            this.trbMinSquare.Value = 5;
            this.trbMinSquare.ValueChanged += new System.EventHandler(this.trbMinSquare_ValueChanged);
            // 
            // labelMinSquare
            // 
            this.labelMinSquare.AutoSize = true;
            this.labelMinSquare.Location = new System.Drawing.Point(6, 156);
            this.labelMinSquare.Name = "labelMinSquare";
            this.labelMinSquare.Size = new System.Drawing.Size(180, 13);
            this.labelMinSquare.TabIndex = 6;
            this.labelMinSquare.Text = "Минимальный размер области: 5 ";
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
            this.dataGridView1.Size = new System.Drawing.Size(181, 305);
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
            this.label5.Size = new System.Drawing.Size(154, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Оригинальное изображение:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 265);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(427, 304);
            this.tabControl1.TabIndex = 36;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.labelPBCb);
            this.tabPage1.Controls.Add(this.labelPBCg);
            this.tabPage1.Controls.Add(this.labelMinSquare);
            this.tabPage1.Controls.Add(this.labelPBCr);
            this.tabPage1.Controls.Add(this.labelPaletteSize);
            this.tabPage1.Controls.Add(this.trbLineThickness);
            this.tabPage1.Controls.Add(this.trbPBCr);
            this.tabPage1.Controls.Add(this.trbMinSquare);
            this.tabPage1.Controls.Add(this.trbPaletteSize);
            this.tabPage1.Controls.Add(this.trbPBCg);
            this.tabPage1.Controls.Add(this.labelBlur);
            this.tabPage1.Controls.Add(this.labelLineThickness);
            this.tabPage1.Controls.Add(this.trbPBCb);
            this.tabPage1.Controls.Add(this.trbBlur);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(419, 278);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Параметры обработки";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // labelPBCb
            // 
            this.labelPBCb.AutoSize = true;
            this.labelPBCb.Location = new System.Drawing.Point(278, 82);
            this.labelPBCb.Name = "labelPBCb";
            this.labelPBCb.Size = new System.Drawing.Size(118, 13);
            this.labelPBCb.TabIndex = 23;
            this.labelPBCb.Text = "Коррекция синего: 11";
            // 
            // labelPBCg
            // 
            this.labelPBCg.AutoSize = true;
            this.labelPBCg.Location = new System.Drawing.Point(142, 82);
            this.labelPBCg.Name = "labelPBCg";
            this.labelPBCg.Size = new System.Drawing.Size(130, 13);
            this.labelPBCg.TabIndex = 22;
            this.labelPBCg.Text = "Коррекция зелёного: 59";
            // 
            // labelPBCr
            // 
            this.labelPBCr.AutoSize = true;
            this.labelPBCr.Location = new System.Drawing.Point(6, 82);
            this.labelPBCr.Name = "labelPBCr";
            this.labelPBCr.Size = new System.Drawing.Size(130, 13);
            this.labelPBCr.TabIndex = 21;
            this.labelPBCr.Text = "Коррекция красного: 30";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Controls.Add(this.pictureBoxMouseColor);
            this.tabPage3.Controls.Add(this.checkBoxUseDatPalette);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(419, 278);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "Ручная палитра";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileTSMI,
            this.конвертироватьToolStripMenuItem,
            this.aboutTSMI});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(954, 24);
            this.menuStrip1.TabIndex = 37;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileTSMI
            // 
            this.fileTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openImageTSMI,
            this.saveTSMI});
            this.fileTSMI.Name = "fileTSMI";
            this.fileTSMI.Size = new System.Drawing.Size(48, 20);
            this.fileTSMI.Text = "Файл";
            // 
            // openImageTSMI
            // 
            this.openImageTSMI.Name = "openImageTSMI";
            this.openImageTSMI.Size = new System.Drawing.Size(198, 22);
            this.openImageTSMI.Text = "Открыть изображение";
            this.openImageTSMI.Click += new System.EventHandler(this.openImageTSMI_Click);
            // 
            // saveTSMI
            // 
            this.saveTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quantizedImageTSMI,
            this.resultImageTSMI,
            this.paletteImageTSMI});
            this.saveTSMI.Name = "saveTSMI";
            this.saveTSMI.Size = new System.Drawing.Size(198, 22);
            this.saveTSMI.Text = "Сохранить";
            // 
            // quantizedImageTSMI
            // 
            this.quantizedImageTSMI.Name = "quantizedImageTSMI";
            this.quantizedImageTSMI.Size = new System.Drawing.Size(253, 22);
            this.quantizedImageTSMI.Text = "Упрощённое изображение";
            // 
            // resultImageTSMI
            // 
            this.resultImageTSMI.Name = "resultImageTSMI";
            this.resultImageTSMI.Size = new System.Drawing.Size(253, 22);
            this.resultImageTSMI.Text = "Результирующиее изображение";
            // 
            // paletteImageTSMI
            // 
            this.paletteImageTSMI.Name = "paletteImageTSMI";
            this.paletteImageTSMI.Size = new System.Drawing.Size(253, 22);
            this.paletteImageTSMI.Text = "Упрощённую палитру";
            // 
            // конвертироватьToolStripMenuItem
            // 
            this.конвертироватьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.конвертироватьToolStripMenuItem1,
            this.обновитьЛинииToolStripMenuItem,
            this.обновитьОбластиToolStripMenuItem});
            this.конвертироватьToolStripMenuItem.Name = "конвертироватьToolStripMenuItem";
            this.конвертироватьToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.конвертироватьToolStripMenuItem.Text = "Изображение";
            // 
            // конвертироватьToolStripMenuItem1
            // 
            this.конвертироватьToolStripMenuItem1.Name = "конвертироватьToolStripMenuItem1";
            this.конвертироватьToolStripMenuItem1.Size = new System.Drawing.Size(176, 22);
            this.конвертироватьToolStripMenuItem1.Text = "Конвертировать";
            this.конвертироватьToolStripMenuItem1.Click += new System.EventHandler(this.btnProcessImage_Click);
            // 
            // обновитьЛинииToolStripMenuItem
            // 
            this.обновитьЛинииToolStripMenuItem.Name = "обновитьЛинииToolStripMenuItem";
            this.обновитьЛинииToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.обновитьЛинииToolStripMenuItem.Text = "Обновить линии";
            // 
            // обновитьОбластиToolStripMenuItem
            // 
            this.обновитьОбластиToolStripMenuItem.Name = "обновитьОбластиToolStripMenuItem";
            this.обновитьОбластиToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.обновитьОбластиToolStripMenuItem.Text = "Обновить области";
            // 
            // aboutTSMI
            // 
            this.aboutTSMI.Name = "aboutTSMI";
            this.aboutTSMI.Size = new System.Drawing.Size(65, 20);
            this.aboutTSMI.Text = "Справка";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(226, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Упрощенное изображение:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(447, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Результат:";
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
            this.ClientSize = new System.Drawing.Size(954, 582);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trbPaletteSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOriginal)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbPBCr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbPBCg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbPBCb)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuantize)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbBlur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbLineThickness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbMinSquare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMouseColor)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TrackBar trbPaletteSize;
        private System.Windows.Forms.Label labelPaletteSize;
        private System.Windows.Forms.PictureBox pbOriginal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar trbPBCr;
        private System.Windows.Forms.TrackBar trbPBCg;
        private System.Windows.Forms.TrackBar trbPBCb;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbQuantize;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pbResult;
        private System.Windows.Forms.Label labelBlur;
        private System.Windows.Forms.TrackBar trbBlur;
        private System.Windows.Forms.Label labelLineThickness;
        private System.Windows.Forms.TrackBar trbLineThickness;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TrackBar trbMinSquare;
        private System.Windows.Forms.Label labelMinSquare;
        private System.Windows.Forms.PictureBox pictureBoxMouseColor;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox checkBoxUseDatPalette;
        private System.Windows.Forms.DataGridViewTextBoxColumn palette;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileTSMI;
        private System.Windows.Forms.ToolStripMenuItem openImageTSMI;
        private System.Windows.Forms.ToolStripMenuItem aboutTSMI;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripMenuItem saveTSMI;
        private System.Windows.Forms.ToolStripMenuItem quantizedImageTSMI;
        private System.Windows.Forms.ToolStripMenuItem resultImageTSMI;
        private System.Windows.Forms.ToolStripMenuItem paletteImageTSMI;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label labelPBCb;
        private System.Windows.Forms.Label labelPBCg;
        private System.Windows.Forms.Label labelPBCr;
        private System.Windows.Forms.ToolStripMenuItem конвертироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem конвертироватьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem обновитьЛинииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обновитьОбластиToolStripMenuItem;
    }
}

