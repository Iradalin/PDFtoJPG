using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using Ghostscript.NET;
using Ghostscript.NET.Rasterizer;
using System.Drawing.Imaging;
using System.Diagnostics;

namespace MxPdfToJPGMK
{
    public partial class Form1 : Form
    {
        private string zwrocFormatPliku { get; set; }
       
        public Form1()
        {
            InitializeComponent();
            panelUpuscPDF.BackgroundImageLayout = ImageLayout.Stretch;
            zwrocFormatPliku = ".JPG";
          
                numericUpDownOsX.Value = Properties.Settings.Default.OsX;
                numericUpDownOsY.Value = Properties.Settings.Default.OsY;

            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
            
        }

        public void panel1_DragDrop(object sender, DragEventArgs e)
        {try
            {
                if (e.Data.GetDataPresent(DataFormats.FileDrop))
                {


                    string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                    foreach (string filePath in files)
                    {
                        textBoxAdresPliku.Text = filePath;
                        var localGhostscriptDll = Path.Combine(Environment.CurrentDirectory, "gsdll32.dll");
                        var localDllInfo = new GhostscriptVersionInfo(localGhostscriptDll);

                        int desired_x_dpi = (int)numericUpDownOsX.Value;
                        int desired_y_dpi = (int)numericUpDownOsY.Value;

                        string inputPdfPath = filePath;

                        string outputPath = Environment.CurrentDirectory;

                        GhostscriptRasterizer _rasterizer = new GhostscriptRasterizer();

                        _rasterizer.Open(inputPdfPath, localDllInfo, false);

                        string nazwa = Cos(filePath).nazwa;
                        string folder = Cos(filePath).folder + nazwa + "\\";


                        textBoxFolderOut.Text = folder;
                        ImageFormat formatObrazka = imageFormat();
                        for (int pageNumber = 1; pageNumber <= _rasterizer.PageCount; pageNumber++)
                        {
                            string pageFilePath = Path.Combine(folder.Remove(folder.Length - 4), nazwa + pageNumber.ToString() + zwrocFormatPliku);
                            Image img = _rasterizer.GetPage(desired_x_dpi, desired_y_dpi, pageNumber);

                            if (Directory.Exists(folder))
                            {
                                img.Save(pageFilePath, formatObrazka);
                            }
                            else {
                                Directory.CreateDirectory(folder.Remove(folder.Length-4));
                                img.Save(pageFilePath, formatObrazka);
                                  }
                        }

                        _rasterizer.Close();
                    }

                }
            }catch (Exception ex)
            { MessageBox.Show(ex.Message +ex.Source+ex.InnerException+ex.StackTrace); }
        }
        public ImageFormat imageFormat()
        { if (Properties.Settings.Default.formatPliku.Equals(".JPG"))
            {
                return ImageFormat.Jpeg;
                }
            else if (Properties.Settings.Default.formatPliku.Equals(".PNG"))
            {
                return ImageFormat.Png; }

            return ImageFormat.Gif;
                }
        
      public struct sciezkaPlikuPDF
        {
           public string folder;
           public string nazwa;
        }
           public sciezkaPlikuPDF Cos(string str)
        {
            sciezkaPlikuPDF pdfUrl = new sciezkaPlikuPDF();
            
            for (int i =str.Length; i>=0;i-- )
            {
                if(str[i-1].Equals('\\'))
                    {
                    pdfUrl.nazwa = str.Substring(i);
                    pdfUrl.folder = str.Remove(i, str.Length - i);
                    return pdfUrl;
                }
                    
            }
            return pdfUrl;
        }
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton btn = (RadioButton)sender;
            switch (btn.Text)
            {
                case "JPG":
                    zwrocFormatPliku = ".JPG";
                    Properties.Settings.Default.formatPliku = ".JPG";
                    break;
                case "PNG":
                    zwrocFormatPliku = ".PNG";
                    Properties.Settings.Default.formatPliku = ".PNG";
                    break;
                case "GIF":
                    zwrocFormatPliku = ".GIF";
                    Properties.Settings.Default.formatPliku = ".GIF";
                    break;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.OsX = (int)numericUpDownOsX.Value;
            Properties.Settings.Default.OsY = (int)numericUpDownOsY.Value;
            Properties.Settings.Default.Save();
        }

        private void Form1_FormClosed(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.OsX = (int)numericUpDownOsX.Value;
            Properties.Settings.Default.OsY = (int)numericUpDownOsY.Value;

        }

        private void buttonAdresPlikuWyjsciowego_Click(object sender, EventArgs e)
        {
            if (!textBoxFolderOut.Text.Equals(""))
                {
                Process.Start(textBoxFolderOut.Text); }
        }
    }
}
