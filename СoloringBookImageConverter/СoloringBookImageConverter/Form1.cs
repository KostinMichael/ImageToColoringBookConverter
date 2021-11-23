using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ImageQuantizer
{
    public partial class Form1 : Form
    {
        Painter painter;

        public Form1()
        {
            InitializeComponent();
            //для листа А4 рекомендуется ариал-8 где-то 25х25 пикселей
            int a = 3 / 2;
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            painter = new Painter(200, 25, 16);
            pictureBoxOriginal.Image = new Bitmap("med1x1.png");
        }
        //клик по квантизированной картинке сохраняет её
        private void pictureBoxQuantize_Click(object sender, EventArgs e)
        {
            pictureBoxQuantize.Image.Save("q1.jpg");
            pictureBoxMedian.Image.Save("m1.jpg");
            pictureBoxEdges.Image.Save("e1.jpg");
        }
        //изменение размера палитры
        private void trackBarPalette_ValueChanged(object sender, EventArgs e)
        {
            trackBarPalette.MouseCaptureChanged += delegate 
            {
                painter.SetPaletteSize(trackBarPalette.Value);
            };
            textBoxPaletteSize.Text = trackBarPalette.Value.ToString();
        }
        //изменение минимального размера регионов
        private void trackBarRegionSize_ValueChanged(object sender, EventArgs e)
        {
            textBoxRegionSize.Text = trackBarRegionSize.Value.ToString();
        }
        //изменение толщины границ
        private void trackBarEdgesWight_ValueChanged(object sender, EventArgs e)
        {
            /*trackBarEdgesWight.MouseCaptureChanged += delegate
            {
                imageQuantizer.setPaletteSize(trackBarEdgesWight.Value);
            };*/
            textBoxEdgesWight.Text = trackBarEdgesWight.Value.ToString();
        }
        //изменение параметров ф-ции ПБЦ
        private void PBCtrackbarChange(object sender, EventArgs e)
        {
            trackBarPBCr.MouseCaptureChanged += delegate
            {
               // imageQuantizer.setPBCRatio(Convert.ToByte(textBoxPBCr.Text), Convert.ToByte(textBoxPBCg.Text), Convert.ToByte(textBoxPBCb.Text));
            };
            trackBarPBCg.MouseCaptureChanged += delegate
            {
               // imageQuantizer.setPBCRatio(Convert.ToByte(textBoxPBCr.Text), Convert.ToByte(textBoxPBCg.Text), Convert.ToByte(textBoxPBCb.Text));
            };
            trackBarPBCb.MouseCaptureChanged += delegate
            {
               // imageQuantizer.setPBCRatio(Convert.ToByte(textBoxPBCr.Text), Convert.ToByte(textBoxPBCg.Text), Convert.ToByte(textBoxPBCb.Text));
            };
            textBoxPBCr.Text = trackBarPBCr.Value.ToString();
            textBoxPBCg.Text = trackBarPBCg.Value.ToString();
            textBoxPBCb.Text = trackBarPBCb.Value.ToString();
        }
        //квантизация
        private void buttonQuantize_Click(object sender, EventArgs e)
        {
            progressBar.Value = 0;
            bool useCustomPalette = checkBoxUseDatPalette.Checked;
            BackgroundWorker backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += DoWork;
            backgroundWorker.RunWorkerAsync();
            backgroundWorker.RunWorkerCompleted += delegate
            {
                pictureBoxQuantize.Image = painter.getQuantizeBitmap();
                pictureBoxMedian.Image = painter.GetMedianImage(10);
                
                pictureBoxEdges.Image = painter.getEdgesBitmap();
            };

            // Thread threadGravity = new Thread(() => painter.makeEdgesImage(new Bitmap("med.png"), 0));
            //  threadGravity.Start();
        }

        private void DoWork(object sender, DoWorkEventArgs e)
        {
            var worker = sender as BackgroundWorker;
            e.Result = e.Argument;
            painter.makeEdgesImage(new Bitmap("m1.jpg"), 0);

        }

        public void setText(String s)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action(() => textBoxInfo.Text = s));
               // BeginInvoke(new Action(() => progressBar1.Value += 1));
            }
            else
            {
                textBoxInfo.Text = s;
              //  progressBar1.Value += 1;
            }
        }
        
        public void setOutpuImage(Bitmap bmp)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action(() => pictureBoxQuantize.Image = bmp));
            }
            else
            {
                pictureBoxQuantize.Image = bmp;
            }
        }

        public void setOutputEdges(Bitmap bmp)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action(() => pictureBoxEdges.Image = bmp));
            }
            else
            {
                pictureBoxEdges.Image = bmp;
            }
        }

        private void buttonRegions_Click(object sender, EventArgs e)
        {
            int ggg = trackBarRegionSize.Value;
          //Thread threadGravity = new Thread(() => imageQuantizer.refreshEdges(ggg));
          //threadGravity.Start();
        }

        private void buttonEdges_Click(object sender, EventArgs e)
        {
            //fdfkhnl вшашту
        }

        private void pictureBoxOriginal_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            Point coordinates = me.Location;
            textBoxInfo.Text = coordinates.X.ToString() + "---" + coordinates.Y.ToString();
            dataGridView1.Rows.Add();
            dataGridView1.ClearSelection();
            // Color.FromArgb(
            dataGridView1.Rows[dataGridView1.RowCount-1].Cells[0].Style.BackColor = ((Bitmap)pictureBoxOriginal.Image).GetPixel(coordinates.X, coordinates.Y);
            dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;
            dataGridView1.Columns[0].HeaderText = "Палитра " + (dataGridView1.RowCount).ToString();
        }

        private void pictureBoxOriginal_MouseMove(object sender, MouseEventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            Point coordinates = me.Location;
            pictureBoxMouseColor.BackColor = ((Bitmap)pictureBoxOriginal.Image).GetPixel(coordinates.X, coordinates.Y);
        }
        //кликнул по клетке для удаления
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            dataGridView1.Columns[0].HeaderText = "Палитра " + (dataGridView1.RowCount).ToString();
            dataGridView1.ClearSelection();
        }

        
    }
}
