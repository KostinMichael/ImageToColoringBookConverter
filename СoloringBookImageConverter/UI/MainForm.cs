using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using СoloringBookImageConverter.Controllers;
using СoloringBookImageConverter.Properties;

namespace СoloringBookImageConverter.UI {
    //для листа А4 рекомендуется ариал-8   гдето- 25х25 пикселей
    public partial class MainForm : Form, IMainView {
        public event EventHandler ProcessImage;
        public event EventHandler<ImagePathEventArgs> ImagePathChanged;
        public event EventHandler<TrackBarEventArgs> BlurDegreeChanged;
        public event EventHandler<TrackBarEventArgs> PaletteSizeChanged;

        public MainForm() {
            InitializeComponent();
        }

        //-------------------legacy------------------
        //клик по квантизированной картинке сохраняет её
        private void pictureBoxQuantize_Click(object sender, EventArgs e) {
            pbQuantize.Image.Save("1dfg.jpg");
            pbResult.Image.Save("dfghdfh.jpg");
        }
        //изменение минимального размера регионов
        private void trackBarRegionSize_ValueChanged(object sender, EventArgs e) {
            textBoxRegionSize.Text = trackBarRegionSize.Value.ToString();
        }
        //изменение толщины границ
        private void trackBarEdgesWight_ValueChanged(object sender, EventArgs e) {
            /*trackBarEdgesWight.MouseCaptureChanged += delegate
            {
                imageQuantizer.setPaletteSize(trackBarEdgesWight.Value);
            };*/
            textBoxEdgesWight.Text = trackBarEdgesWight.Value.ToString();
        }
        //изменение параметров ф-ции ПБЦ
        private void PBCtrackbarChange(object sender, EventArgs e) {
            trackBarPBCr.MouseCaptureChanged += delegate {
                // imageQuantizer.setPBCRatio(Convert.ToByte(textBoxPBCr.Text), Convert.ToByte(textBoxPBCg.Text), Convert.ToByte(textBoxPBCb.Text));
            };
            trackBarPBCg.MouseCaptureChanged += delegate {
                // imageQuantizer.setPBCRatio(Convert.ToByte(textBoxPBCr.Text), Convert.ToByte(textBoxPBCg.Text), Convert.ToByte(textBoxPBCb.Text));
            };
            trackBarPBCb.MouseCaptureChanged += delegate {
                // imageQuantizer.setPBCRatio(Convert.ToByte(textBoxPBCr.Text), Convert.ToByte(textBoxPBCg.Text), Convert.ToByte(textBoxPBCb.Text));
            };
            textBoxPBCr.Text = trackBarPBCr.Value.ToString();
            textBoxPBCg.Text = trackBarPBCg.Value.ToString();
            textBoxPBCb.Text = trackBarPBCb.Value.ToString();
        }

        private void buttonRegions_Click(object sender, EventArgs e) {
            int ggg = trackBarRegionSize.Value;
            //Thread threadGravity = new Thread(() => imageQuantizer.refreshEdges(ggg));
            //threadGravity.Start();
        }

        private void pictureBoxOriginal_Click(object sender, EventArgs e) {
            MouseEventArgs me = (MouseEventArgs)e;
            Point coordinates = me.Location;
            textBoxInfo.Text = coordinates.X.ToString() + "---" + coordinates.Y.ToString();
            dataGridView1.Rows.Add();
            dataGridView1.ClearSelection();
            // Color.FromArgb(
            dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[0].Style.BackColor = ((Bitmap)pbOriginal.Image).GetPixel(coordinates.X, coordinates.Y);
            dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;
            dataGridView1.Columns[0].HeaderText = "Палитра " + (dataGridView1.RowCount).ToString();
        }

        private void pictureBoxOriginal_MouseMove(object sender, MouseEventArgs e) {
            if (pbOriginal.Image != null) {
                MouseEventArgs me = (MouseEventArgs)e;
                Point coordinates = me.Location;
                pictureBoxMouseColor.BackColor = ((Bitmap)pbOriginal.Image).GetPixel(coordinates.X, coordinates.Y);
            }
        }

        //кликнул по клетке для удаления
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            dataGridView1.Columns[0].HeaderText = "Палитра " + (dataGridView1.RowCount).ToString();
            dataGridView1.ClearSelection();
        }
        //-------------------legacy------------------






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
            labelBlur.Text = Resources.trb_blur + trbBlur.Value;
        }
        private void trbPaletteSize_ValueChanged(object sender, EventArgs e) {
            labelPaletteSize.Text = Resources.trb_palette_size + trbPaletteSize.Value;
            PaletteSizeChanged?.Invoke(this, new TrackBarEventArgs(trbPaletteSize.Value));
        }
    }
}
