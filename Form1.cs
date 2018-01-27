using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Collections.Specialized;
using System.Diagnostics;
using AdvancedCognition.Imaging;
using Newtonsoft.Json;

namespace NumberPlatReaderTester
{
    public partial class Form1 : Form
    {
        private bool ROIEnabled= false;
        public Form1()
        {
            InitializeComponent();
        }

        


        private void button2_Click(object sender, EventArgs e)
        {
            ROIEnabled = false;

            System.Uri u = new Uri("http://app.cogedg.com:4555/api/");
            label1.Text = "";

            string file="";

           DialogResult d = openFileDialog1.ShowDialog();
            if (d== System.Windows.Forms.DialogResult.OK)
            {
                System.IO.FileInfo fInfo = new System.IO.FileInfo(openFileDialog1.FileName);

                
                string strFilePath = fInfo.DirectoryName + @"\" +  fInfo.Name;

                //MessageBox.Show(strFileName + ", " + strFilePath);

                pictureBox1.ImageLocation = strFilePath;
                using (var client = new WebClient())
                {
                    byte[] reslut;
                    try
                    {
                        reslut = client.UploadFile(u, strFilePath);
                    }
                    catch (Exception ex)
                    {
                        label1.Text=ex.Message.ToString();
                        return;
                    }
                    var str = System.Text.Encoding.UTF8.GetString(reslut);
                    label1.Text = str;
                }
            }

        }

        private void btnTest2_Click(object sender, EventArgs e)
        {
            ROIEnabled = false;

            label1.Text = "";

            string Result = "";
            Rectangle _selection;

            DialogResult d = openFileDialog1.ShowDialog();
            if (d == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.FileInfo fInfo = new System.IO.FileInfo(openFileDialog1.FileName);


                string strFilePath = fInfo.DirectoryName + @"\" + fInfo.Name;
                Image _originalImage; Image imgCrop;
                string[] Allfiles = Directory.GetFiles(fInfo.DirectoryName + @"\", "*.jpg",SearchOption.AllDirectories);
                lblTotalFile.Text = "Total Pic.: " + Allfiles.Count().ToString();
                Application.DoEvents();
                int FileCounter=0;
                int NumPlateFoundCount = 0;
                int NumPlateNotFoundCount = 0;

                foreach (string _file in Allfiles)
                {
                    FileCounter= FileCounter+1;
                    lblProcessFiles.Text= "Total Proc.: " + FileCounter.ToString();
                    Application.DoEvents();
                    Debug.WriteLine(_file);
                    Writelog(fInfo.DirectoryName,Environment.NewLine + _file);
                    _originalImage = Image.FromFile(_file);
                    pictureBox1.Image = _originalImage;
                    lblFileName.Text = _file;
                    Application.DoEvents();
                 //_originalImage = pictureBox1.Image.Clone() as Image;
                Debug.WriteLine("Width (px): " + _originalImage.Size.Width.ToString());
                Writelog(fInfo.DirectoryName, Environment.NewLine + "Width (px): " + _originalImage.Size.Width.ToString());
                Debug.WriteLine("height (px): " + _originalImage.Size.Height.ToString());
                Writelog(fInfo.DirectoryName, Environment.NewLine + "height (px): " + _originalImage.Size.Height.ToString());
                Debug.WriteLine("H Reso: " + _originalImage.HorizontalResolution.ToString());
                Writelog(fInfo.DirectoryName, Environment.NewLine + "H Reso: " + _originalImage.HorizontalResolution.ToString());
                Debug.WriteLine("V Reso: " + _originalImage.VerticalResolution.ToString());
                Writelog(fInfo.DirectoryName, Environment.NewLine + "V Reso: " + _originalImage.VerticalResolution.ToString());

                if (_originalImage.Size.Width>450)
                {
                    double spl = (double)(_originalImage.Size.Width / 450);
                    for (int i = 0; i < spl; i++)
                    {
                        Image imgC = Image.FromFile(_file);
                        if (txtFromToppx.Text.Length==0)
                        {
                            
                            _selection = new Rectangle(450 * i, 0, 450 * (i + 1), _originalImage.Size.Height);
                        }
                        else
                        {
                            _selection = new Rectangle(450 * i, 0, 450 * (i + 1), Int32.Parse( txtFromToppx.Text));
                        }
                        
                        imgC = imgC.CropImage(_selection);
                        pictureBox1.Image = imgC;
                        Application.DoEvents();
                        imgC.Save( @"d:\crop.jpg");
                       Result= CheckNumberPlate(@"d:\crop.jpg");
                       Writelog(fInfo.DirectoryName, Environment.NewLine + "Result: " + Result);
                       if (!Result.Contains("failed") )
                       {
                           NumPlateFoundCount = NumPlateFoundCount + 1;
                           lblNumPlatFound.Text = "Total Found: " + NumPlateFoundCount.ToString();
                           lblNumberPlate.Text = Result;
                           Application.DoEvents();
                           SuccessLog(fInfo.DirectoryName, Environment.NewLine + _file + "     number: " + Result);
                       }
                       else
                       {
                           NumPlateNotFoundCount = NumPlateNotFoundCount + 1;
                           lblNumPlateNotFound.Text = "Total Not Found: " + NumPlateNotFoundCount.ToString();
                           lblNumberPlate.Text = "Not Found";
                           Application.DoEvents();
                       }
                    }
                    
                }
                else
                {
                    _originalImage.Save(@"d:\crop.jpg");
                   Result= CheckNumberPlate(@"d:\crop.jpg");
                   Writelog(fInfo.DirectoryName, Environment.NewLine + "Result: " + Result);
                   if (!Result.Contains("failed"))
                   {
                       NumPlateFoundCount = NumPlateFoundCount + 1;
                       lblNumPlatFound.Text = "Total Found: " + NumPlateFoundCount.ToString();
                       Application.DoEvents();
                       SuccessLog(fInfo.DirectoryName, Environment.NewLine + _file + "     number: " + Result);
                   }
                   else
                   {
                       NumPlateNotFoundCount = NumPlateNotFoundCount + 1;
                       lblNumPlateNotFound.Text = "Total Not Found: " + NumPlateNotFoundCount.ToString();
                       Application.DoEvents();
                   }
                }

                
                }
                

               
            }
        }

        private string CheckNumberPlate(string FilePath)
        {
            System.Uri u = new Uri("http://app.cogedg.com:4555/api/");
            using (var client = new WebClient())
            {
                byte[] reslut;
                try
                {
                    reslut = client.UploadFile(u, FilePath);
                }
                catch (Exception ex)
                {
                    //label1.Text = ex.Message.ToString();
                    return ex.Message.ToString(); ;
                }
                var str = System.Text.Encoding.UTF8.GetString(reslut);
                return str;
                //label1.Text = str;
                //Writelog(Environment.NewLine + "Result: " + str);
            }
        }

        private NumberPlateInfo  CheckNumberPlateWithAccuracy(string FilePath)
        {
            
            System.Uri u = new Uri("http://app.cogedg.com:4555/api_2/");
            using (var client = new WebClient())
            {
                byte[] reslut;
                try
                {
                    reslut = client.UploadFile(u, FilePath);
                }
                catch (Exception ex)
                {

                    throw ex; 
                }
                var str = System.Text.Encoding.UTF8.GetString(reslut);


                return JsonConvert.DeserializeObject<NumberPlateInfo>(str);
                
                // JSON Format 
                 //               {
                 //"Accuracy": "85.19", 
                 //"NumberPlate": "Dhaka Metro Gha \n11 -0334"
                 //                 }

            }
        }

        private void Writelog(string Logpath,string logtext)
        {
            string path = Logpath + @"\log.txt";
            // This text is added only once to the file.
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(DateTime.Now + " " + logtext);

                }
            }

            // This text is always added, making the file longer over time
            // if it is not deleted.
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(DateTime.Now + " " + logtext);
            }

           
        }

        private void SuccessLog(string Logpath, string logtext)
        {
            string path = Logpath + @"\Successlog.txt";
            // This text is added only once to the file.
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine( logtext);

                }
            }

            // This text is always added, making the file longer over time
            // if it is not deleted.
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine( logtext);
            }


        }

        
       

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (ROIEnabled == true)
            {
                Rectangle ee = new Rectangle(Int32.Parse(txtTopX.Text), Int32.Parse(txtTopY.Text), Int32.Parse(txtWith.Text), Int32.Parse(txtHeight.Text));
                using (Pen pen = new Pen(Color.LightGreen, 2))
                {
                    e.Graphics.DrawRectangle(pen, ee);
                    
                }   
            }

            ROIEnabled = false;
        }

        private void btnTestROI_Click(object sender, EventArgs e)
        {

            if (Int32.Parse(txtWith.Text)>450)
            {
                txtWith.Text = "450";
            }

            ROIEnabled = true;

            label1.Text = "";

            string Result = "";
            Rectangle _selection;

            DialogResult d = openFileDialog1.ShowDialog();
            if (d == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.FileInfo fInfo = new System.IO.FileInfo(openFileDialog1.FileName);
                

                string strFilePath = fInfo.DirectoryName + @"\" + fInfo.Name;
                Image _originalImage; Image imgCrop;
                string[] Allfiles = Directory.GetFiles(fInfo.DirectoryName + @"\", "*.jpg", SearchOption.AllDirectories);
                lblTotalFile.Text = "Total Pic.: " + Allfiles.Count().ToString();
                Application.DoEvents();
                int FileCounter = 0;
                int NumPlateFoundCount = 0;
                int NumPlateNotFoundCount = 0;

                foreach (string _file in Allfiles)
                {
                    NumberPlateInfo npf = new NumberPlateInfo();
                    FileCounter = FileCounter + 1;
                    lblProcessFiles.Text = "Total Proc.: " + FileCounter.ToString();
                    Application.DoEvents();
                    Debug.WriteLine(_file);
                    Writelog(fInfo.DirectoryName, Environment.NewLine + _file);
                    _originalImage = Image.FromFile(_file);
                    ROIEnabled = true;
                    pictureBox1.Image = _originalImage;
                    lblFileName.Text = _file;
                    Application.DoEvents();
                    //_originalImage = pictureBox1.Image.Clone() as Image;
                    Debug.WriteLine("Width (px): " + _originalImage.Size.Width.ToString());
                    Writelog(fInfo.DirectoryName, Environment.NewLine + "Width (px): " + _originalImage.Size.Width.ToString());
                    Debug.WriteLine("height (px): " + _originalImage.Size.Height.ToString());
                    Writelog(fInfo.DirectoryName, Environment.NewLine + "height (px): " + _originalImage.Size.Height.ToString());
                    Debug.WriteLine("H Reso: " + _originalImage.HorizontalResolution.ToString());
                    Writelog(fInfo.DirectoryName, Environment.NewLine + "H Reso: " + _originalImage.HorizontalResolution.ToString());
                    Debug.WriteLine("V Reso: " + _originalImage.VerticalResolution.ToString());
                    Writelog(fInfo.DirectoryName, Environment.NewLine + "V Reso: " + _originalImage.VerticalResolution.ToString());

                    _selection = new Rectangle(Int32.Parse(txtTopX.Text),Int32.Parse(txtTopY.Text),Int32.Parse(txtWith.Text),Int32.Parse(txtHeight.Text));
                    Image imgC = Image.FromFile(_file);
                    imgC = imgC.CropImage(_selection);

                    Application.DoEvents();
                    imgC.Save(@"d:\crop.jpg");
                    try
                    {
                        npf = CheckNumberPlateWithAccuracy(@"d:\crop.jpg");
                    }
                    catch (Exception ex)
                    {
                        Writelog(fInfo.DirectoryName, Environment.NewLine + "Error: " + ex.Message.ToString());
                        continue;
                    }
                        
                        Writelog(fInfo.DirectoryName, Environment.NewLine + "Result: " + npf.NumberPlate);
                        if (npf.Accuracy!="0")
                        {
                            NumPlateFoundCount = NumPlateFoundCount + 1;
                            lblNumPlatFound.Text = "Found: " + NumPlateFoundCount.ToString();
                            lblNumberPlate.Text = npf.NumberPlate;
                            lblAccuracy.Text = npf.Accuracy;

                            Application.DoEvents();
                            SuccessLog(fInfo.DirectoryName, Environment.NewLine + _file + "     number: " + npf.NumberPlate + " Accuracy: " + npf.Accuracy);
                        }
                        else
                        {
                            NumPlateNotFoundCount = NumPlateNotFoundCount + 1;
                            lblNumPlateNotFound.Text = "Not Found: " + NumPlateNotFoundCount.ToString();
                            lblNumberPlate.Text = npf.NumberPlate;
                            lblAccuracy.Text = npf.Accuracy;
                            Application.DoEvents();
                        }



                }



            }
        }

        private void txtTopY_TextChanged(object sender, EventArgs e)
        {
            ROIEnabled = true;
            pictureBox1.Refresh();
        }

        private void btnLoadPicToCal_Click(object sender, EventArgs e)
        {
             DialogResult d = openFileDialog1.ShowDialog();
             if (d == System.Windows.Forms.DialogResult.OK)
             {
                 System.IO.FileInfo fInfo = new System.IO.FileInfo(openFileDialog1.FileName);

                 string strFilePath = fInfo.DirectoryName + @"\" + fInfo.Name;
                 pictureBox1.ImageLocation = strFilePath;
             }
        }

        private void txtTopX_TextChanged(object sender, EventArgs e)
        {
            ROIEnabled = true;
            pictureBox1.Refresh();
        }

        private void txtWith_TextChanged(object sender, EventArgs e)
        {
            ROIEnabled = true;
            pictureBox1.Refresh();
        }

        private void txtHeight_TextChanged(object sender, EventArgs e)
        {
            ROIEnabled = true;
            pictureBox1.Refresh();
        }
    }
}
