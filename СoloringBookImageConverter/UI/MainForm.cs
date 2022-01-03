using System;
using System.Drawing;
using System.Windows.Forms;
using СoloringBookImageConverter.Common;
using СoloringBookImageConverter.Properties;

namespace СoloringBookImageConverter.UI
{
    //для листа А4 рекомендуется ариал-8   гдето- 25х25 пикселей
    public partial class MainForm : Form, IMainView
    {
        public event EventHandler ProcessImage;
        public event EventHandler<ImagePathEventArgs> ImagePathChanged;
        public event EventHandler<TrackBarEventArgs> BlurDegreeChanged;
        public event EventHandler<TrackBarEventArgs> PaletteSizeChanged;
        public event EventHandler<TrackBarEventArgs> MinSquareChanged;
        public event EventHandler<TrackBarEventArgs> LineThicknessChanged;
        private int _activeTab = -1;
        public MainForm()
        {
            InitializeComponent();
        }

        #region Legacy
        private void pictureBoxOriginal_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            Point coordinates = me.Location;
            //textBoxInfo.Text = coordinates.X.ToString() + "---" + coordinates.Y.ToString();
            dataGridView1.Rows.Add();
            dataGridView1.ClearSelection();
            // Color.FromArgb(
            dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[0].Style.BackColor = ((Bitmap)pbOriginal.Image).GetPixel(coordinates.X, coordinates.Y);
            dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;
            dataGridView1.Columns[0].HeaderText = "Палитра " + (dataGridView1.RowCount).ToString();
        }

        //кликнул по клетке для удаления
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow ?? throw new InvalidOperationException());
            dataGridView1.Columns[0].HeaderText = "Палитра " + (dataGridView1.RowCount).ToString();
            dataGridView1.ClearSelection();
        }
        #endregion

        /// <summary>
        /// отображает цвет пикселя под курсором в pictureBoxMouseColor 
        /// при наведении на оригинальное изображение 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxOriginal_MouseMove(object sender, MouseEventArgs e)
        {
            if (pbOriginal.Image != null)
            {
                Point coordinates = e.Location;
                //pictureBoxMouseColor.BackColor = ((Bitmap)pbOriginal.Image).GetPixel(coordinates.X, coordinates.Y);
            }
        }

        public void Showy()
        {
            Application.Run(this);
        }

        public void ShowMessage(string text)
        {
            MessageBox.Show(text);
        }

        public void SetOriginalImage(Bitmap bitmap)
        {
            pbOriginal.Image = bitmap;
        }

        public void SetSimplifiedImage(Bitmap bitmap)
        {
            pbQuantize.Image = bitmap;
        }

        public void SetResultImage(Bitmap bitmap)
        {
            pbResult.Image = bitmap;
        }

        public void SetPaletteMaxSize(int maxValue)
        {
            trbPaletteSize.Maximum = maxValue;
            trbPaletteSize.Value = 1;
        }

        public void SetPaletteSizeInfo(int value)
        {
            labelPaletteSize.Text = Resources.label_palette_size + value;
        }

        public void BlockElements()
        {
            Invoke(new Action(() =>
            {
                trbBlur.Enabled = false;
                trbLineThickness.Enabled = false;
                trbMinSquare.Enabled = false;
                trbPaletteSize.Enabled = false;
            }));

        }
        public void UnBlockElements()
        {
            trbBlur.Invoke(new Action(() => trbBlur.Enabled = true));
            trbLineThickness.Invoke(new Action(() => trbLineThickness.Enabled = true));
            trbMinSquare.Invoke(new Action(() => trbMinSquare.Enabled = true));
            trbPaletteSize.Invoke(new Action(() => trbPaletteSize.Enabled = true));
        }

        private void openImageTSMI_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = Resources.picture_format_filter;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ImagePathChanged?.Invoke(this, new ImagePathEventArgs(openFileDialog.FileName));
            }
        }
        private void trbBlur_ValueChanged(object sender, EventArgs e)
        {
            BlurDegreeChanged?.Invoke(this, new TrackBarEventArgs((byte)trbBlur.Value));
            labelBlur.Text = Resources.label_blur + trbBlur.Value;
        }

        private void trbPaletteSize_MouseUp(object sender, MouseEventArgs e)
        {
            ProcessImage?.Invoke(this, new TrackBarEventArgs(trbPaletteSize.Value));
        }
        private void trbPaletteSize_ValueChanged(object sender, EventArgs e)
        {
            PaletteSizeChanged?.Invoke(this, new TrackBarEventArgs(trbPaletteSize.Value));
        }
        private void trbPaletteSize_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ProcessImage?.Invoke(this, new TrackBarEventArgs(trbPaletteSize.Value));
            }
        }

        private void trbMinSquare_ValueChanged(object sender, EventArgs e)
        {
            labelMinSquare.Text = Resources.label_min_square + trbMinSquare.Value;
            MinSquareChanged?.Invoke(this, new TrackBarEventArgs(trbMinSquare.Value));
        }
        private void trbLineThickness_ValueChanged(object sender, EventArgs e)
        {
            labelLineThickness.Text = Resources.label_line_thickness + trbLineThickness.Value;
            LineThicknessChanged?.Invoke(this, new TrackBarEventArgs(trbLineThickness.Value));
        }
        public void SetupProgress(int maxValue, int step)
        {
            progressBar.Invoke(new Action(() => progressBar.Value = 0));
            progressBar.Invoke(new Action(() => progressBar.Maximum = maxValue));
            progressBar.Invoke(new Action(() => progressBar.Step = step));
        }
        public void ProgressStep()
        {
            progressBar.Invoke(new Action(() => progressBar.Increment(progressBar.Step)));
        }

        private void tabControl2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X <= 62 && _activeTab != 0)
            {
                tabControl2.SelectedIndex = _activeTab = 0;
            }
            if (e.X > 62 && e.X <= 130 && _activeTab != 1)
            {
                tabControl2.SelectedIndex = _activeTab = 1;
            }
            if (e.X > 139 && _activeTab != 2)
            {
                tabControl2.SelectedIndex = _activeTab = 2;
            }
        }
    }
}
