namespace ImageQuantizer
{
    partial class Form1
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
            this.pictureBoxOriginal = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.trackBarPBCr = new System.Windows.Forms.TrackBar();
            this.trackBarPBCg = new System.Windows.Forms.TrackBar();
            this.trackBarPBCb = new System.Windows.Forms.TrackBar();
            this.textBoxPBCr = new System.Windows.Forms.TextBox();
            this.textBoxPBCg = new System.Windows.Forms.TextBox();
            this.textBoxPBCb = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonQuantize = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBoxQuantize = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBoxEdges = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.trackBarBlure = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxEdgesWight = new System.Windows.Forms.TextBox();
            this.trackBarEdgesWight = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxInfo = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.trackBarRegionSize = new System.Windows.Forms.TrackBar();
            this.buttonRegions = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonEdges = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxRegionSize = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.palette = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBoxMouseColor = new System.Windows.Forms.PictureBox();
            this.checkBoxUseDatPalette = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBoxMedian = new System.Windows.Forms.PictureBox();
            this.pictureBoxtest = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPalette)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPBCr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPBCg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPBCb)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQuantize)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEdges)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarEdgesWight)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRegionSize)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMouseColor)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMedian)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxtest)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBarPalette
            // 
            this.trackBarPalette.BackColor = System.Drawing.SystemColors.HighlightText;
            this.trackBarPalette.LargeChange = 2;
            this.trackBarPalette.Location = new System.Drawing.Point(9, 36);
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
            this.textBoxPaletteSize.Location = new System.Drawing.Point(289, 36);
            this.textBoxPaletteSize.Name = "textBoxPaletteSize";
            this.textBoxPaletteSize.Size = new System.Drawing.Size(49, 20);
            this.textBoxPaletteSize.TabIndex = 4;
            this.textBoxPaletteSize.Text = "16";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Размер палитры";
            // 
            // pictureBoxOriginal
            // 
            this.pictureBoxOriginal.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxOriginal.Name = "pictureBoxOriginal";
            this.pictureBoxOriginal.Size = new System.Drawing.Size(250, 208);
            this.pictureBoxOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxOriginal.TabIndex = 6;
            this.pictureBoxOriginal.TabStop = false;
            this.pictureBoxOriginal.Click += new System.EventHandler(this.pictureBoxOriginal_Click);
            this.pictureBoxOriginal.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxOriginal_MouseMove);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.Controls.Add(this.pictureBoxOriginal);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 311);
            this.panel1.TabIndex = 7;
            // 
            // trackBarPBCr
            // 
            this.trackBarPBCr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.trackBarPBCr.Location = new System.Drawing.Point(9, 19);
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
            this.trackBarPBCg.Location = new System.Drawing.Point(9, 70);
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
            this.trackBarPBCb.Location = new System.Drawing.Point(9, 121);
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
            this.textBoxPBCr.Location = new System.Drawing.Point(116, 19);
            this.textBoxPBCr.Name = "textBoxPBCr";
            this.textBoxPBCr.Size = new System.Drawing.Size(35, 20);
            this.textBoxPBCr.TabIndex = 11;
            this.textBoxPBCr.Text = "30";
            // 
            // textBoxPBCg
            // 
            this.textBoxPBCg.Location = new System.Drawing.Point(116, 70);
            this.textBoxPBCg.Name = "textBoxPBCg";
            this.textBoxPBCg.Size = new System.Drawing.Size(35, 20);
            this.textBoxPBCg.TabIndex = 12;
            this.textBoxPBCg.Text = "59";
            // 
            // textBoxPBCb
            // 
            this.textBoxPBCb.Location = new System.Drawing.Point(116, 121);
            this.textBoxPBCb.Name = "textBoxPBCb";
            this.textBoxPBCb.Size = new System.Drawing.Size(35, 20);
            this.textBoxPBCb.TabIndex = 13;
            this.textBoxPBCb.Text = "11";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.textBoxPBCb);
            this.groupBox1.Controls.Add(this.trackBarPBCr);
            this.groupBox1.Controls.Add(this.trackBarPBCg);
            this.groupBox1.Controls.Add(this.textBoxPBCg);
            this.groupBox1.Controls.Add(this.trackBarPBCb);
            this.groupBox1.Controls.Add(this.textBoxPBCr);
            this.groupBox1.Location = new System.Drawing.Point(366, 422);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(162, 174);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Коэф-ты ф-ции ПБЦ";
            // 
            // buttonQuantize
            // 
            this.buttonQuantize.Location = new System.Drawing.Point(535, 478);
            this.buttonQuantize.Name = "buttonQuantize";
            this.buttonQuantize.Size = new System.Drawing.Size(180, 28);
            this.buttonQuantize.TabIndex = 17;
            this.buttonQuantize.Text = "Квантование + границы";
            this.buttonQuantize.UseVisualStyleBackColor = true;
            this.buttonQuantize.Click += new System.EventHandler(this.buttonQuantize_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "Коэффициенты ф-ции поиска ближайшего цвета в палитре";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel2.Controls.Add(this.pictureBoxQuantize);
            this.panel2.Location = new System.Drawing.Point(366, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(348, 311);
            this.panel2.TabIndex = 8;
            // 
            // pictureBoxQuantize
            // 
            this.pictureBoxQuantize.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxQuantize.Name = "pictureBoxQuantize";
            this.pictureBoxQuantize.Size = new System.Drawing.Size(250, 208);
            this.pictureBoxQuantize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxQuantize.TabIndex = 6;
            this.pictureBoxQuantize.TabStop = false;
            this.pictureBoxQuantize.Click += new System.EventHandler(this.pictureBoxQuantize_Click);
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel3.Controls.Add(this.pictureBoxEdges);
            this.panel3.Location = new System.Drawing.Point(1074, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(348, 311);
            this.panel3.TabIndex = 9;
            // 
            // pictureBoxEdges
            // 
            this.pictureBoxEdges.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxEdges.Name = "pictureBoxEdges";
            this.pictureBoxEdges.Size = new System.Drawing.Size(250, 208);
            this.pictureBoxEdges.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxEdges.TabIndex = 6;
            this.pictureBoxEdges.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Предварительное размытие";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(311, 349);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(49, 20);
            this.textBox1.TabIndex = 19;
            this.textBox1.Text = "10";
            // 
            // trackBarBlure
            // 
            this.trackBarBlure.BackColor = System.Drawing.SystemColors.ControlLight;
            this.trackBarBlure.LargeChange = 2;
            this.trackBarBlure.Location = new System.Drawing.Point(15, 349);
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
            this.label3.Location = new System.Drawing.Point(6, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Толщина границ";
            // 
            // textBoxEdgesWight
            // 
            this.textBoxEdgesWight.Location = new System.Drawing.Point(269, 119);
            this.textBoxEdgesWight.Name = "textBoxEdgesWight";
            this.textBoxEdgesWight.Size = new System.Drawing.Size(72, 20);
            this.textBoxEdgesWight.TabIndex = 22;
            this.textBoxEdgesWight.Text = "10";
            // 
            // trackBarEdgesWight
            // 
            this.trackBarEdgesWight.BackColor = System.Drawing.SystemColors.HighlightText;
            this.trackBarEdgesWight.LargeChange = 2;
            this.trackBarEdgesWight.Location = new System.Drawing.Point(9, 119);
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
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.trackBarPalette);
            this.groupBox2.Controls.Add(this.textBoxPaletteSize);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(366, 329);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(348, 87);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Коэффициенты";
            // 
            // textBoxInfo
            // 
            this.textBoxInfo.Location = new System.Drawing.Point(534, 422);
            this.textBoxInfo.Name = "textBoxInfo";
            this.textBoxInfo.Size = new System.Drawing.Size(180, 20);
            this.textBoxInfo.TabIndex = 25;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(535, 449);
            this.progressBar.Maximum = 6;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(179, 23);
            this.progressBar.TabIndex = 26;
            // 
            // trackBarRegionSize
            // 
            this.trackBarRegionSize.BackColor = System.Drawing.SystemColors.HighlightText;
            this.trackBarRegionSize.Location = new System.Drawing.Point(9, 36);
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
            this.buttonRegions.Location = new System.Drawing.Point(269, 60);
            this.buttonRegions.Name = "buttonRegions";
            this.buttonRegions.Size = new System.Drawing.Size(72, 53);
            this.buttonRegions.TabIndex = 29;
            this.buttonRegions.Text = "Удалить маленькие области";
            this.buttonRegions.UseVisualStyleBackColor = true;
            this.buttonRegions.Click += new System.EventHandler(this.buttonRegions_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox3.Controls.Add(this.buttonEdges);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.textBoxRegionSize);
            this.groupBox3.Controls.Add(this.buttonRegions);
            this.groupBox3.Controls.Add(this.trackBarRegionSize);
            this.groupBox3.Controls.Add(this.textBoxEdgesWight);
            this.groupBox3.Controls.Add(this.trackBarEdgesWight);
            this.groupBox3.Location = new System.Drawing.Point(1074, 329);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(348, 183);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Границы и области";
            // 
            // buttonEdges
            // 
            this.buttonEdges.Location = new System.Drawing.Point(269, 145);
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
            this.label4.Location = new System.Drawing.Point(6, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Минимальный размер области";
            // 
            // textBoxRegionSize
            // 
            this.textBoxRegionSize.Location = new System.Drawing.Point(269, 36);
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 400);
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
            this.pictureBoxMouseColor.Location = new System.Drawing.Point(199, 400);
            this.pictureBoxMouseColor.Name = "pictureBoxMouseColor";
            this.pictureBoxMouseColor.Size = new System.Drawing.Size(161, 68);
            this.pictureBoxMouseColor.TabIndex = 33;
            this.pictureBoxMouseColor.TabStop = false;
            // 
            // checkBoxUseDatPalette
            // 
            this.checkBoxUseDatPalette.AutoSize = true;
            this.checkBoxUseDatPalette.Location = new System.Drawing.Point(199, 469);
            this.checkBoxUseDatPalette.Name = "checkBoxUseDatPalette";
            this.checkBoxUseDatPalette.Size = new System.Drawing.Size(161, 17);
            this.checkBoxUseDatPalette.TabIndex = 34;
            this.checkBoxUseDatPalette.Text = "Использовать эту палитру";
            this.checkBoxUseDatPalette.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel4.Controls.Add(this.pictureBoxMedian);
            this.panel4.Location = new System.Drawing.Point(720, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(348, 311);
            this.panel4.TabIndex = 9;
            // 
            // pictureBoxMedian
            // 
            this.pictureBoxMedian.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxMedian.Name = "pictureBoxMedian";
            this.pictureBoxMedian.Size = new System.Drawing.Size(250, 208);
            this.pictureBoxMedian.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxMedian.TabIndex = 6;
            this.pictureBoxMedian.TabStop = false;
            // 
            // pictureBoxtest
            // 
            this.pictureBoxtest.Location = new System.Drawing.Point(721, 329);
            this.pictureBoxtest.Name = "pictureBoxtest";
            this.pictureBoxtest.Size = new System.Drawing.Size(250, 208);
            this.pictureBoxtest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxtest.TabIndex = 7;
            this.pictureBoxtest.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1434, 605);
            this.Controls.Add(this.pictureBoxtest);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.checkBoxUseDatPalette);
            this.Controls.Add(this.pictureBoxMouseColor);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.textBoxInfo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.trackBarBlure);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonQuantize);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPalette)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPBCr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPBCg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPBCb)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQuantize)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEdges)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarEdgesWight)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRegionSize)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMouseColor)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMedian)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxtest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TrackBar trackBarPalette;
        private System.Windows.Forms.TextBox textBoxPaletteSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxOriginal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar trackBarPBCr;
        private System.Windows.Forms.TrackBar trackBarPBCg;
        private System.Windows.Forms.TrackBar trackBarPBCb;
        private System.Windows.Forms.TextBox textBoxPBCr;
        private System.Windows.Forms.TextBox textBoxPBCg;
        private System.Windows.Forms.TextBox textBoxPBCb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonQuantize;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBoxQuantize;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBoxEdges;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TrackBar trackBarBlure;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxEdgesWight;
        private System.Windows.Forms.TrackBar trackBarEdgesWight;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxInfo;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TrackBar trackBarRegionSize;
        private System.Windows.Forms.Button buttonRegions;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxRegionSize;
        private System.Windows.Forms.Button buttonEdges;
        private System.Windows.Forms.PictureBox pictureBoxMouseColor;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox checkBoxUseDatPalette;
        private System.Windows.Forms.DataGridViewTextBoxColumn palette;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBoxMedian;
        private System.Windows.Forms.PictureBox pictureBoxtest;
    }
}

