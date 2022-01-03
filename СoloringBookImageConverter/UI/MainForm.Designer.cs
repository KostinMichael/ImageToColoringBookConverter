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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pbQuantize = new System.Windows.Forms.PictureBox();
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.openImageTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.quantizedImageTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.resultImageTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.paletteImageTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.trbPaletteSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuantize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbBlur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbLineThickness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbMinSquare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMouseColor)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // trbPaletteSize
            // 
            this.trbPaletteSize.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.trbPaletteSize.LargeChange = 2;
            this.trbPaletteSize.Location = new System.Drawing.Point(12, 57);
            this.trbPaletteSize.Maximum = 100;
            this.trbPaletteSize.Name = "trbPaletteSize";
            this.trbPaletteSize.Size = new System.Drawing.Size(200, 45);
            this.trbPaletteSize.TabIndex = 3;
            this.trbPaletteSize.Value = 2;
            this.trbPaletteSize.ValueChanged += new System.EventHandler(this.trbPaletteSize_ValueChanged);
            this.trbPaletteSize.KeyUp += new System.Windows.Forms.KeyEventHandler(this.trbPaletteSize_KeyUp);
            this.trbPaletteSize.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trbPaletteSize_MouseUp);
            // 
            // labelPaletteSize
            // 
            this.labelPaletteSize.AutoSize = true;
            this.labelPaletteSize.Location = new System.Drawing.Point(12, 41);
            this.labelPaletteSize.Name = "labelPaletteSize";
            this.labelPaletteSize.Size = new System.Drawing.Size(150, 13);
            this.labelPaletteSize.TabIndex = 5;
            this.labelPaletteSize.Text = "Кол-во цветов в палитре: 16";
            // 
            // pbOriginal
            // 
            this.pbOriginal.Location = new System.Drawing.Point(3, 3);
            this.pbOriginal.Name = "pbOriginal";
            this.pbOriginal.Size = new System.Drawing.Size(400, 400);
            this.pbOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbOriginal.TabIndex = 6;
            this.pbOriginal.TabStop = false;
            this.pbOriginal.Click += new System.EventHandler(this.pictureBoxOriginal_Click);
            this.pbOriginal.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxOriginal_MouseMove);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "Коэффициенты ф-ции поиска ближайшего цвета в палитре";
            // 
            // pbQuantize
            // 
            this.pbQuantize.Location = new System.Drawing.Point(3, 3);
            this.pbQuantize.Name = "pbQuantize";
            this.pbQuantize.Size = new System.Drawing.Size(400, 400);
            this.pbQuantize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbQuantize.TabIndex = 6;
            this.pbQuantize.TabStop = false;
            // 
            // pbResult
            // 
            this.pbResult.Location = new System.Drawing.Point(3, 3);
            this.pbResult.Name = "pbResult";
            this.pbResult.Size = new System.Drawing.Size(400, 400);
            this.pbResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbResult.TabIndex = 6;
            this.pbResult.TabStop = false;
            // 
            // labelBlur
            // 
            this.labelBlur.AutoSize = true;
            this.labelBlur.Location = new System.Drawing.Point(213, 41);
            this.labelBlur.Name = "labelBlur";
            this.labelBlur.Size = new System.Drawing.Size(164, 13);
            this.labelBlur.TabIndex = 20;
            this.labelBlur.Text = "Предварительное размытие: 0";
            this.labelBlur.Visible = false;
            // 
            // trbBlur
            // 
            this.trbBlur.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.trbBlur.LargeChange = 2;
            this.trbBlur.Location = new System.Drawing.Point(216, 57);
            this.trbBlur.Maximum = 50;
            this.trbBlur.Name = "trbBlur";
            this.trbBlur.Size = new System.Drawing.Size(200, 45);
            this.trbBlur.TabIndex = 18;
            this.trbBlur.TickFrequency = 10;
            this.trbBlur.Visible = false;
            this.trbBlur.ValueChanged += new System.EventHandler(this.trbBlur_ValueChanged);
            // 
            // labelLineThickness
            // 
            this.labelLineThickness.AutoSize = true;
            this.labelLineThickness.Location = new System.Drawing.Point(213, 110);
            this.labelLineThickness.Name = "labelLineThickness";
            this.labelLineThickness.Size = new System.Drawing.Size(104, 13);
            this.labelLineThickness.TabIndex = 23;
            this.labelLineThickness.Text = "Толщина линий: 10";
            this.labelLineThickness.Visible = false;
            // 
            // trbLineThickness
            // 
            this.trbLineThickness.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.trbLineThickness.LargeChange = 2;
            this.trbLineThickness.Location = new System.Drawing.Point(216, 126);
            this.trbLineThickness.Maximum = 50;
            this.trbLineThickness.Minimum = 1;
            this.trbLineThickness.Name = "trbLineThickness";
            this.trbLineThickness.Size = new System.Drawing.Size(200, 45);
            this.trbLineThickness.TabIndex = 21;
            this.trbLineThickness.TickFrequency = 10;
            this.trbLineThickness.Value = 10;
            this.trbLineThickness.Visible = false;
            this.trbLineThickness.ValueChanged += new System.EventHandler(this.trbLineThickness_ValueChanged);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(433, 465);
            this.progressBar.Maximum = 6;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(400, 10);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 26;
            // 
            // trbMinSquare
            // 
            this.trbMinSquare.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.trbMinSquare.Location = new System.Drawing.Point(12, 126);
            this.trbMinSquare.Maximum = 1000;
            this.trbMinSquare.Minimum = 1;
            this.trbMinSquare.Name = "trbMinSquare";
            this.trbMinSquare.Size = new System.Drawing.Size(200, 45);
            this.trbMinSquare.TabIndex = 28;
            this.trbMinSquare.TickFrequency = 100;
            this.trbMinSquare.Value = 5;
            this.trbMinSquare.Visible = false;
            this.trbMinSquare.ValueChanged += new System.EventHandler(this.trbMinSquare_ValueChanged);
            // 
            // labelMinSquare
            // 
            this.labelMinSquare.AutoSize = true;
            this.labelMinSquare.Location = new System.Drawing.Point(12, 110);
            this.labelMinSquare.Name = "labelMinSquare";
            this.labelMinSquare.Size = new System.Drawing.Size(180, 13);
            this.labelMinSquare.TabIndex = 6;
            this.labelMinSquare.Text = "Минимальный размер области: 5 ";
            this.labelMinSquare.Visible = false;
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
            this.dataGridView1.Location = new System.Drawing.Point(11, 177);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 50;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(199, 249);
            this.dataGridView1.TabIndex = 32;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.Visible = false;
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
            this.pictureBoxMouseColor.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pictureBoxMouseColor.Location = new System.Drawing.Point(216, 177);
            this.pictureBoxMouseColor.Name = "pictureBoxMouseColor";
            this.pictureBoxMouseColor.Size = new System.Drawing.Size(198, 45);
            this.pictureBoxMouseColor.TabIndex = 33;
            this.pictureBoxMouseColor.TabStop = false;
            this.pictureBoxMouseColor.Visible = false;
            // 
            // checkBoxUseDatPalette
            // 
            this.checkBoxUseDatPalette.AutoSize = true;
            this.checkBoxUseDatPalette.Location = new System.Drawing.Point(216, 228);
            this.checkBoxUseDatPalette.Name = "checkBoxUseDatPalette";
            this.checkBoxUseDatPalette.Size = new System.Drawing.Size(161, 17);
            this.checkBoxUseDatPalette.TabIndex = 34;
            this.checkBoxUseDatPalette.Text = "Использовать эту палитру";
            this.checkBoxUseDatPalette.UseVisualStyleBackColor = true;
            this.checkBoxUseDatPalette.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileTSMI,
            this.aboutTSMI});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(847, 24);
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
            // aboutTSMI
            // 
            this.aboutTSMI.Name = "aboutTSMI";
            this.aboutTSMI.Size = new System.Drawing.Size(65, 20);
            this.aboutTSMI.Text = "Справка";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Location = new System.Drawing.Point(426, 30);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(415, 433);
            this.tabControl2.TabIndex = 40;
            this.tabControl2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tabControl2_MouseMove);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pbOriginal);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(407, 407);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Оригинал";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.pbQuantize);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(407, 407);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Упрощённое";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.pbResult);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(407, 407);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "Результат";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(847, 479);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.pictureBoxMouseColor);
            this.Controls.Add(this.checkBoxUseDatPalette);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.labelMinSquare);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.labelPaletteSize);
            this.Controls.Add(this.trbLineThickness);
            this.Controls.Add(this.trbBlur);
            this.Controls.Add(this.trbMinSquare);
            this.Controls.Add(this.labelLineThickness);
            this.Controls.Add(this.trbPaletteSize);
            this.Controls.Add(this.labelBlur);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "СoloringBookImageConverter";
            ((System.ComponentModel.ISupportInitialize)(this.trbPaletteSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuantize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbBlur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbLineThickness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbMinSquare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMouseColor)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TrackBar trbPaletteSize;
        private System.Windows.Forms.Label labelPaletteSize;
        private System.Windows.Forms.PictureBox pbOriginal;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pbQuantize;
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileTSMI;
        private System.Windows.Forms.ToolStripMenuItem openImageTSMI;
        private System.Windows.Forms.ToolStripMenuItem aboutTSMI;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripMenuItem saveTSMI;
        private System.Windows.Forms.ToolStripMenuItem quantizedImageTSMI;
        private System.Windows.Forms.ToolStripMenuItem resultImageTSMI;
        private System.Windows.Forms.ToolStripMenuItem paletteImageTSMI;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

