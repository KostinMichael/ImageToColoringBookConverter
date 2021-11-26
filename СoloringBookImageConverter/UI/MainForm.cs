using System;
using System.Drawing;
using System.Windows.Forms;
using СoloringBookImageConverter.Properties;

namespace СoloringBookImageConverter.UI {
    //для листа А4 рекомендуется ариал-8   гдето- 25х25 пикселей
    public partial class MainForm : Form, IMainView {
        public event EventHandler ProcessImage;
        public event EventHandler<ImagePathEventArgs> ImagePathChanged;
        public event EventHandler<TrackBarEventArgs> BlurDegreeChanged;
        public event EventHandler<TrackBarEventArgs> PaletteSizeChanged;
        public event EventHandler<TrackBarEventArgs> MinSquareChanged;
        public event EventHandler<TrackBarEventArgs> LineThicknessChanged;
        public event EventHandler<TrackBarEventArgs> RedPCBDegree;
        public event EventHandler<TrackBarEventArgs> GreenPCBDegree;
        public event EventHandler<TrackBarEventArgs> BluePCBDegree;

        public MainForm() {
            InitializeComponent();
        }

        //-------------------legacy------------------
        private void pictureBoxOriginal_Click(object sender, EventArgs e) {
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
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            dataGridView1.Columns[0].HeaderText = "Палитра " + (dataGridView1.RowCount).ToString();
            dataGridView1.ClearSelection();
        }
        //-------------------legacy------------------

        /// <summary>
        /// отображает цвет пикселя под курсором в pictureBoxMouseColor 
        /// при наведении на оригинальное изображение 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxOriginal_MouseMove(object sender, MouseEventArgs e) {
            if (pbOriginal.Image != null) {
                Point coordinates = e.Location;
                pictureBoxMouseColor.BackColor = ((Bitmap)pbOriginal.Image).GetPixel(coordinates.X, coordinates.Y);
            }
        }

        public void Showy() {
            Application.Run(this);
        }

        public void ShowErrorMessage(string errorMessage) {
            MessageBox.Show(errorMessage);
        }

        public void SetOriginalImage(Bitmap bitmap) {
            pbOriginal.Image = bitmap;
        }

        public void SetSimplifiedImage(Bitmap bitmap) {
            pbQuantize.Image = bitmap;
        }

        public void SetResultImage(Bitmap bitmap) {
            pbResult.Image = bitmap;
        }
        private void btnProcessImage_Click(object sender, EventArgs e) {
            ProcessImage?.Invoke(this, new EventArgs());
        }

        private void openImageTSMI_Click(object sender, EventArgs e) {
            openFileDialog.Filter = Resources.picture_format_filter;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                ImagePathChanged?.Invoke(this, new ImagePathEventArgs(openFileDialog.FileName));
            }
        }

        private void trbBlur_ValueChanged(object sender, EventArgs e) {
            BlurDegreeChanged?.Invoke(this, new TrackBarEventArgs(trbBlur.Value));
            labelBlur.Text = Resources.label_blur + trbBlur.Value;
        }
        private void trbPaletteSize_ValueChanged(object sender, EventArgs e) {
            labelPaletteSize.Text = Resources.label_palette_size + trbPaletteSize.Value;
            PaletteSizeChanged?.Invoke(this, new TrackBarEventArgs(trbPaletteSize.Value));
        }
        private void trbPCBr_ValueChanged(object sender, EventArgs e) {
            labelPBCr.Text = Resources.label_pbcr + trbPBCr.Value;
            RedPCBDegree?.Invoke(this, new TrackBarEventArgs(trbPBCr.Value));
        }
        private void trbPCBg_ValueChanged(object sender, EventArgs e) {
            labelPBCg.Text = Resources.label_pbcg + trbPBCg.Value;
            GreenPCBDegree?.Invoke(this, new TrackBarEventArgs(trbPBCg.Value));
        }
        private void trbPCBb_ValueChanged(object sender, EventArgs e) {
            labelPBCb.Text = Resources.label_pbcb + trbPBCb.Value;
            BluePCBDegree?.Invoke(this, new TrackBarEventArgs(trbPBCb.Value));
        }
        private void trbMinSquare_ValueChanged(object sender, EventArgs e) {
            labelMinSquare.Text = Resources.label_min_square + trbMinSquare.Value;
            MinSquareChanged?.Invoke(this, new TrackBarEventArgs(trbMinSquare.Value));
        }
        private void trbLineThickness_ValueChanged(object sender, EventArgs e) {
            labelLineThickness.Text = Resources.label_line_thickness + trbLineThickness.Value;
            LineThicknessChanged?.Invoke(this, new TrackBarEventArgs(trbLineThickness.Value));
        }
    }
}
