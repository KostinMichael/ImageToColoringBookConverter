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
        Painter painter;

        public MainForm() {
            InitializeComponent();
            btnProcessImage.Click += (sender, args) => Invoke(ProcessImage);
            painter = new Painter(200, 25, 16);
            pbOriginal.Image = new Bitmap("med.png");
        }
        public void Showy() {
            Application.Run(this);
        }

        public event EventHandler ProcessImage;
        public event EventHandler<ImagePathEventArgs> ImagePathChanged;

        /*private void Invoke(Action action) {
            if (action != null) action();
        }*/

        public void SetOriginalImage(Bitmap bitmap) {
            pbOriginal.Image = bitmap;
        }

        public void SetSimplifiedImage(Bitmap bitmap) {
            pbQuantize.Image = bitmap;
        }

        public void SetResultImage(Bitmap bitmap) {
            pbResult.Image = bitmap;
        }

        //квантизация
        private void QuantizeImage(object sender, EventArgs e) {

        }













        //клик по квантизированной картинке сохраняет её
        private void pictureBoxQuantize_Click(object sender, EventArgs e) {
            pbQuantize.Image.Save("1dfg.jpg");
            pbResult.Image.Save("dfghdfh.jpg");
        }

        //изменение размера палитры
        private void trackBarPalette_ValueChanged(object sender, EventArgs e) {
            trackBarPalette.MouseCaptureChanged += delegate {
                painter.SetPaletteSize(trackBarPalette.Value);
            };
            textBoxPaletteSize.Text = trackBarPalette.Value.ToString();
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


        private void DoWork(object sender, DoWorkEventArgs e) {
            var worker = sender as BackgroundWorker;
            e.Result = e.Argument;

            painter.makeEdgesImage(new Bitmap("med.png"), 0);
        }

        public void setText(String s) {
            if (InvokeRequired) {
                BeginInvoke(new Action(() => textBoxInfo.Text = s));
                // BeginInvoke(new Action(() => progressBar1.Value += 1));
            } else {
                textBoxInfo.Text = s;
                //  progressBar1.Value += 1;
            }
        }

        public void setOutpuImage(Bitmap bmp) {
            if (InvokeRequired) {
                BeginInvoke(new Action(() => pbQuantize.Image = bmp));
            } else {
                pbQuantize.Image = bmp;
            }
        }

        public void setOutputEdges(Bitmap bmp) {
            if (InvokeRequired) {
                BeginInvoke(new Action(() => pbResult.Image = bmp));
            } else {
                pbResult.Image = bmp;
            }
        }

        private void buttonRegions_Click(object sender, EventArgs e) {
            int ggg = trackBarRegionSize.Value;
            //Thread threadGravity = new Thread(() => imageQuantizer.refreshEdges(ggg));
            //threadGravity.Start();
        }

        private void buttonEdges_Click(object sender, EventArgs e) {
            //fdfkhnl вшашту
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
            MouseEventArgs me = (MouseEventArgs)e;
            Point coordinates = me.Location;
            pictureBoxMouseColor.BackColor = ((Bitmap)pbOriginal.Image).GetPixel(coordinates.X, coordinates.Y);
        }
        //кликнул по клетке для удаления
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            dataGridView1.Columns[0].HeaderText = "Палитра " + (dataGridView1.RowCount).ToString();
            dataGridView1.ClearSelection();
        }

        private void openImageTSMI_Click(object sender, EventArgs e) {
            openFileDialog.Filter = Resources.picture_format_filter;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                ImagePathChanged(this, new ImagePathEventArgs(openFileDialog.FileName));
            }
        }

        private void btnQuantizeImage_Click(object sender, EventArgs e)
        {
            
        }
    }
}
