using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace EarthboundBackground
{
    public partial class frmMain : Form
    {
        public int tick;
        public Bitmap layer1 = null;
        public Bitmap layer2 = null;

        public byte[] rawLayer1 = null;
        public byte[] rawLayer2 = null;

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnOpenImage_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                layer1 = new Bitmap(ofd.FileName);
                rawLayer1 = ConvertBitmap(layer1);
                pictureBox1.Image = layer1;
                btnStart.Enabled = true;
            }
        }

        private void btnOpenImage2_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                layer2 = new Bitmap(ofd.FileName);
                rawLayer2 = ConvertBitmap(layer2);
                pictureBox1.Image = layer2;
                btnStart.Enabled = true;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (layer1 == null && layer2 != null)
            {
                layer1 = new Bitmap(layer2.Width, layer2.Height, PixelFormat.Format8bppIndexed);
                rawLayer1 = ConvertBitmap(layer1);
            }

            if (layer2 == null && layer1 != null)
            {
                layer2 = new Bitmap(layer1.Width, layer1.Height, PixelFormat.Format8bppIndexed);
                rawLayer2 = ConvertBitmap(layer2);
            }

            tmrDelta.Start();
            btnStop.Enabled = true;
            btnPause.Enabled = true;
            btnClearImages.Enabled = false;
            btnStart.Enabled = false;
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            tmrDelta.Stop();
            btnStart.Enabled = true;
            btnClearImages.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            tmrDelta.Stop();
            tick = 0;
            lblDelta.Text = "";
            btnStop.Enabled = false;
            btnPause.Enabled = false;
            btnStart.Enabled = true;
            btnClearImages.Enabled = true;
        }

        private void tmrDelta_Tick(object sender, EventArgs e)
        {
            tick++;
            lblDelta.Text = "Delta: " + tick.ToString();
            double amp = trkAmplitude.Value;
            double freq = (double)trkFrequency.Value / 100;
            double scale = (double)trkScale.Value / 100;
            double compression = trkCompression.Value;

            lblFormula.Text = "Current Formula: " + amp.ToString() + " * sin(" + freq.ToString() + " * y + " + scale.ToString() + " * delta)";

            for (int y = 0; y < layer1.Height; y++)
            {
                int offset = Convert.ToInt32(amp * Math.Sin(freq * y + scale * tick));

                int new_x = 0;
                int new_y = 0;

                switch (Convert.ToInt32(cmbType.Text))
                {
                    case 0:
                        new_x = offset;
                        break;

                    case 1:
                        new_x = (y % 2 == 1) ? offset : -offset;
                        break;

                    case 2:
                        new_y = Convert.ToInt32(y * compression + offset);
                        break;
                }

                new_y = (new_y + layer1.Height) % layer1.Height;

                for (int x = 0; x < layer1.Width; x++)
                {
                    new_x = (new_x + layer1.Width) % layer1.Width;

                    rawLayer2[y * layer1.Width + x] = rawLayer1[new_y * layer1.Width + new_x];

                    new_x++;
                }

                Bitmap newImage = ConvertByteArray(rawLayer2, layer2.Width, layer2.Height);

                pictureBox1.Image = newImage;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            sfd.Filter = "Bitmap Image File (*.bmp)|*.bmp|JPG File|*.jpg|PNG File (*.png)|*.png|All File Types (*.*)|*.*";
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string extension = Path.GetExtension(sfd.FileName);

                switch (extension)
                {
                    case ".bmp":
                        pictureBox1.Image.Save(sfd.FileName, ImageFormat.Bmp);
                        break;

                    case ".jpg":
                        pictureBox1.Image.Save(sfd.FileName, ImageFormat.Jpeg);
                        break;

                    case ".png":
                        pictureBox1.Image.Save(sfd.FileName, ImageFormat.Png);
                        break;

                    default:
                        pictureBox1.Image.Save(sfd.FileName);
                        break;
                }
            }
        }

        private byte[] ConvertBitmap(Bitmap bitmap)
        {
            BitmapData raw = null;
            byte[] rawImage = null;

            try
            {
                raw = bitmap.LockBits(
                    new Rectangle(0, 0, bitmap.Width, bitmap.Height),
                    ImageLockMode.ReadOnly,
                    PixelFormat.Format8bppIndexed
                );

                int size = raw.Height * raw.Stride;
                rawImage = new byte[size];

                Marshal.Copy(raw.Scan0, rawImage, 0, size);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (raw != null)
                {
                    bitmap.UnlockBits(raw);
                }
            }
            return rawImage;
        }

        private Bitmap ConvertByteArray(byte[] bitmapData, int width, int height)
        {
            Bitmap bitmap = null;
            BitmapData raw = null;

            try
            {
                bitmap = new Bitmap(width, height, PixelFormat.Format8bppIndexed);

                raw = bitmap.LockBits(
                    new Rectangle(0, 0, width, height),
                    ImageLockMode.WriteOnly,
                    bitmap.PixelFormat
                );

                int dataSize = width * height;

                Marshal.Copy(bitmapData, 0, raw.Scan0, dataSize);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (raw != null)
                {
                    bitmap.UnlockBits(raw);
                }
            }

            return bitmap;
        }

        private void btnClearImages_Click(object sender, EventArgs e)
        {
            if (layer1 != null)
                layer1.Dispose();
            layer1 = null;

            if (layer2 != null)
                layer2.Dispose();
            layer2 = null;

            if (pictureBox1.Image != null)
                pictureBox1.Image.Dispose();
            pictureBox1.Image = null;

            rawLayer1 = null;
            rawLayer2 = null;

            btnStart.Enabled = false;
        }
    }
}