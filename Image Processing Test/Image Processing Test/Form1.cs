using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Concurrent;
using System.Drawing.Imaging;

namespace Image_Processing_Test
{
    public partial class Form1 : Form
    {
        const int FINAL_GRID_SIZE = 255;
        const int IMAGE_WIDTH = FINAL_GRID_SIZE * 3;
        const int IMAGE_HEIGHT = FINAL_GRID_SIZE * 3;
        double BRIGHTNESS_THRESHOLD = 0.5;
        double GREEN_THRESHOLD = 0.95;
        Bitmap originalPicture;
        Bitmap modifiedPicture = new Bitmap(IMAGE_WIDTH, IMAGE_HEIGHT);
        Bitmap GridPicture = new Bitmap(FINAL_GRID_SIZE, FINAL_GRID_SIZE);
        List<Int32[]> StartList = new List<Int32[]>();
        int[] Start = new int[2];
        List<Int32[]> EndList = new List<Int32[]>();
        int[] End = new int[2];
        int convolute_thresh = 6;
        double Color_Lower_Thresh = 0.1;
        public Form1()
        {
            InitializeComponent();
            numGreenThres.Value = (decimal)GREEN_THRESHOLD;
            numBrightThres.Value = (decimal)BRIGHTNESS_THRESHOLD;
            numColorLower.Value = (decimal)(Color_Lower_Thresh);
            numConvolute.Value = (decimal)(convolute_thresh);
        }

        private void btnFileSelect_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            originalPicture = new Bitmap(Image.FromFile(openFileDialog1.FileName));
            txtFileName.Text = openFileDialog1.FileName;
            originalPicture = resizeImage(originalPicture, IMAGE_WIDTH, IMAGE_HEIGHT);
            pictureBoxOriginal.Image = originalPicture;
            System.Console.Out.WriteLine(originalPicture.Size.Width + "x"+ originalPicture.Size.Height);
            btnProcess.Enabled = true;
        }

        public static Bitmap resizeImage(Bitmap image, int width, int height)
        {
            // Create a new bitmap with the specified size
            Bitmap resizedImage = new Bitmap(width, height);

            // Draw the original image onto the new bitmap with the new size
            using (Graphics graphics = Graphics.FromImage(resizedImage))
            {
                // Set high-quality resizing properties
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

                // Draw the image
                graphics.DrawImage(image, 0, 0, width, height);
            }

            return resizedImage;
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            System.Console.Out.WriteLine("A");
            progressBar1.Maximum = FINAL_GRID_SIZE * FINAL_GRID_SIZE;
            progressBar1.Value = 0;
            modifiedPicture = processImageMT(originalPicture);
            System.Console.Out.WriteLine("B");
            findStart();
            findEnd();
            Graphics graphics = Graphics.FromImage(modifiedPicture);
            SolidBrush brush = new SolidBrush(Color.Purple);
            graphics.FillEllipse(brush, (Start[0] - 2), (Start[1] - 2), 4, 4);
            brush = new SolidBrush(Color.Gold);
            graphics.FillEllipse(brush, (End[0] - 2), (End[1] - 2), 4, 4);
            pictureBoxProcessed.Image = modifiedPicture;
            System.Console.Out.WriteLine("C");
            graphics = Graphics.FromImage(GridPicture);
            graphics.DrawImage(getGridMT(modifiedPicture), 0, 0, IMAGE_WIDTH/3, IMAGE_HEIGHT/3);
            brush = new SolidBrush(Color.Purple);
            graphics.FillEllipse(brush, (Start[0]/3 - 2), (Start[1]/3 - 2), 4, 4);
            brush = new SolidBrush(Color.Gold);
            graphics.FillEllipse(brush, (End[0]/3 - 2), (End[1]/3 - 2), 4, 4);
            pictureBoxConvolute.Image = GridPicture;
            System.Console.Out.WriteLine("D");
        }

        private Bitmap getGrid(Bitmap Image)
        {
            int width = originalPicture.Width;
            int height = originalPicture.Height;
            Bitmap finalImage = new Bitmap(width/3, height/3);
            for (int y = 0; y * 3 < height; y++)
            {
                for (int x = 0; x * 3 < width; x++)
                {
                    int t = 0;
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            if (Image.GetPixel(3*x + i, 3*y + j).GetBrightness() > 0) t++;
                        }
                    }
                    //System.Console.Out.WriteLine(t);
                    if (t < 6) finalImage.SetPixel(x, y, Color.Black);
                    progressBar1.Increment(1);
                }
            }
            return finalImage;
        }

        private Bitmap getGridMT(Bitmap image)
        {
            int width = image.Width;
            int height = image.Height;
            int gridWidth = width / 3;
            int gridHeight = height / 3;
            Bitmap finalImage = new Bitmap(gridWidth, gridHeight, PixelFormat.Format24bppRgb);

            // Lock the source bitmap once and copy data into an array for multi-threaded access
            BitmapData originalData = image.LockBits(
                new Rectangle(0, 0, width, height),
                ImageLockMode.ReadOnly,
                PixelFormat.Format24bppRgb);

            int originalStride = originalData.Stride;
            byte[] originalPixels = new byte[originalStride * height];
            System.Runtime.InteropServices.Marshal.Copy(originalData.Scan0, originalPixels, 0, originalPixels.Length);
            image.UnlockBits(originalData); // Unlock after copying data

            // Prepare the final image for multi-threaded write access
            BitmapData finalData = finalImage.LockBits(
                new Rectangle(0, 0, gridWidth, gridHeight),
                ImageLockMode.WriteOnly,
                PixelFormat.Format24bppRgb);

            int finalStride = finalData.Stride;
            byte[] finalPixels = new byte[finalStride * gridHeight];

            // Set up a progress counter
            int totalCells = gridHeight;
            int progressStep = totalCells / 100; // Update every 1%
            int processedCells = 0;

            // Parallelize the grid creation
            Parallel.For(0, gridHeight, y =>
            {
                for (int x = 0; x < gridWidth; x++)
                {
                    int pixelCount = 0;

                    // Check a 3x3 region in the original image
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            int originalX = x * 3 + i;
                            int originalY = y * 3 + j;
                            int originalIndex = originalY * originalStride + originalX * 3;

                            Color color = Color.FromArgb(
                                originalPixels[originalIndex + 2],
                                originalPixels[originalIndex + 1],
                                originalPixels[originalIndex]);

                            if (color.GetBrightness() > 0)
                            {
                                pixelCount++;
                            }
                        }
                    }

                    // Set the pixel color in the final image
                    int finalIndex = y * finalStride + x * 3;
                    if (pixelCount < convolute_thresh)
                    {
                        finalPixels[finalIndex] = 0; // Black color
                        finalPixels[finalIndex + 1] = 0;
                        finalPixels[finalIndex + 2] = 0;
                    }
                    else
                    {
                        finalPixels[finalIndex] = 255; // White color
                        finalPixels[finalIndex + 1] = 255;
                        finalPixels[finalIndex + 2] = 255;
                    }
                }

                // Update progress safely
                Interlocked.Increment(ref processedCells);

            });

            // Copy the pixel data back to the final bitmap
            System.Runtime.InteropServices.Marshal.Copy(finalPixels, 0, finalData.Scan0, finalPixels.Length);
            finalImage.UnlockBits(finalData);

            // Ensure final progress bar is filled
            Invoke((Action)(() => progressBar1.Value = progressBar1.Maximum));

            return finalImage;
        }





        private void findStart()
        {
            int xTotal = 0;
            int yTotal = 0;
            int numPixel = 0;
            foreach (int[] pixel in StartList)
            {
                numPixel++;
                xTotal += pixel[0];
                yTotal += pixel[1];
            }
            int yAverage = yTotal / numPixel;
            int xAverage = xTotal / numPixel;
            Start[0] = xAverage; Start[1] = yAverage;
        }

        private void findEnd()
        {
            int xTotal = 0;
            int yTotal = 0;
            int numPixel = 0;
            foreach (int[] pixel in EndList)
            {
                numPixel++;
                xTotal += pixel[0];
                yTotal += pixel[1];
            }
            int yAverage = yTotal / numPixel;
            int xAverage = xTotal / numPixel;
            End[0] = xAverage; End[1] = yAverage;
        }

        private Bitmap processImage(Bitmap originalPicture)
        {
            StartList.Clear();
            EndList.Clear();
            int width = originalPicture.Width;
            int height = originalPicture.Height;
            Bitmap contrastImage = new Bitmap(width, height);
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color color = originalPicture.GetPixel(x, y);
                    
                    if (isStart(color))
                    {
                        contrastImage.SetPixel(x, y, Color.Green);
                        StartList.Add(new int[]{x, y});
                    }
                    else if (isEnd(color))
                    {
                        contrastImage.SetPixel(x, y, Color.Red);
                        EndList.Add(new int[] { x, y });
                    }
                    else if (isWall(color))
                    {
                        color = Color.Black;
                        contrastImage.SetPixel(x, y, color);

                    }
                    else
                    {
                        contrastImage.SetPixel(x, y, Color.White);
                    }
                        
                    
                    progressBar1.Increment(1);
                }
            }
            return contrastImage;
        }




        private Bitmap processImageMT(Bitmap originalPicture)
        {
            StartList.Clear();
            EndList.Clear();
            int width = originalPicture.Width;
            int height = originalPicture.Height;

            Bitmap contrastImage = new Bitmap(width, height, PixelFormat.Format24bppRgb);

            // Using concurrent collections for thread-safe operations
            var startListConcurrent = new ConcurrentBag<int[]>();
            var endListConcurrent = new ConcurrentBag<int[]>();

            // Lock the bits of both the original and contrast images
            BitmapData originalData = originalPicture.LockBits(
                new Rectangle(0, 0, width, height),
                ImageLockMode.ReadOnly,
                PixelFormat.Format24bppRgb);

            BitmapData contrastData = contrastImage.LockBits(
                new Rectangle(0, 0, width, height),
                ImageLockMode.WriteOnly,
                PixelFormat.Format24bppRgb);

            int stride = originalData.Stride;
            IntPtr scan0Original = originalData.Scan0;
            IntPtr scan0Contrast = contrastData.Scan0;

            int totalPixels = width * height;
            int progressStep = totalPixels / 100; // Update every 1% for smoother UI

            // Use a variable to keep track of progress safely
            int processedPixels = 0;

            // Parallelize processing across rows
            Parallel.For(0, height, y =>
            {
                byte[] rowOriginal = new byte[stride];
                byte[] rowContrast = new byte[stride];

                System.Runtime.InteropServices.Marshal.Copy(scan0Original + y * stride, rowOriginal, 0, stride);

                for (int x = 0; x < width; x++)
                {
                    int pixelIndex = x * 3;
                    Color color = Color.FromArgb(rowOriginal[pixelIndex + 2], rowOriginal[pixelIndex + 1], rowOriginal[pixelIndex]);

                    if (isStart(color))
                    {
                        rowContrast[pixelIndex] = 0;    // Set green color
                        rowContrast[pixelIndex + 1] = 255;
                        rowContrast[pixelIndex + 2] = 0;

                        startListConcurrent.Add(new int[] { x, y });
                    }
                    else if (isEnd(color))
                    {
                        rowContrast[pixelIndex] = 0;    // Set red color
                        rowContrast[pixelIndex + 1] = 0;
                        rowContrast[pixelIndex + 2] = 255;

                        endListConcurrent.Add(new int[] { x, y });
                    }
                    else if (isWall(color))
                    {
                        rowContrast[pixelIndex] = 0;
                        rowContrast[pixelIndex + 1] = 0;
                        rowContrast[pixelIndex + 2] = 0;
                    }
                    else
                    {
                        rowContrast[pixelIndex] = 255;
                        rowContrast[pixelIndex + 1] = 255;
                        rowContrast[pixelIndex + 2] = 255;
                    }
                }

                System.Runtime.InteropServices.Marshal.Copy(rowContrast, 0, scan0Contrast + y * stride, stride);

                // Update progress safely and incrementally
                Interlocked.Add(ref processedPixels, width); // Track number of pixels processed

                    //Invoke((Action)(() => progressBar1.Value = Math.Min(progressBar1.Maximum, processedPixels)));

            });

            // Unlock the bits after processing
            originalPicture.UnlockBits(originalData);
            contrastImage.UnlockBits(contrastData);

            // Copy concurrent collections back to main lists
            StartList.AddRange(startListConcurrent);
            EndList.AddRange(endListConcurrent);

            // Ensure final progress bar is filled

            return contrastImage;
        }




        private bool isWall(Color color)
        {
            return (color.GetBrightness() < BRIGHTNESS_THRESHOLD);
        }

        private bool isStart(Color color)
        {
            
            return (color.GetHue() > 79 && color.GetHue() < 156 && color.GetBrightness() < GREEN_THRESHOLD && color.GetBrightness() > Color_Lower_Thresh && color.GetSaturation() > 0.20);
        }

        private bool isEnd(Color color)
        {

            return ((color.GetHue() > 345 || color.GetHue() < 15) && color.GetBrightness() < GREEN_THRESHOLD && color.GetBrightness() > Color_Lower_Thresh && color.GetSaturation() > 0.40);
        }

        private void numBrightThres_ValueChanged(object sender, EventArgs e)
        {
            BRIGHTNESS_THRESHOLD = (double)numBrightThres.Value;
        }

        private void numGreenThres_ValueChanged(object sender, EventArgs e)
        {
            GREEN_THRESHOLD = (double)numGreenThres.Value;
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            convolute_thresh = (int)numConvolute.Value;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            Color_Lower_Thresh = (double)numColorLower.Value;
        }
    }
}
