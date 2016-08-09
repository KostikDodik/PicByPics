using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PicByPics
{
    public partial class Form1 : Form
    {
        public void GetFiles(DirectoryInfo dir)
        {
            try
            {
                foreach (FileInfo f in dir.GetFiles())
                {
                    bool isimage = false;
                    switch (f.Name.Substring(f.Name.Length - 4))
                    {
                        case ".jpg": isimage = true; break;
                        case ".JPG": isimage = true; break;
                        case ".png": isimage = true; break;
                        case ".bmp": isimage = true; break;
                        case "jpeg": isimage = true; break;
                    }
                    if (isimage)
                        PicPart.parts.Add(new PicPart(new Bitmap(f.FullName)));
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
            return;
        }
        Bitmap originalPicture;
        string writeTo;
        public Form1()
        {
            using (var choosePic = new OpenFileDialog())
                if (choosePic.ShowDialog() == DialogResult.OK)
                {
                    originalPicture = new Bitmap(choosePic.FileName);
                    writeTo = choosePic.FileName.Substring(0, choosePic.FileName.LastIndexOf('\\')+1) + "Fragmented " + choosePic.FileName.Substring(choosePic.FileName.LastIndexOf('\\')+1);
                }
            using (var chooseDir = new FolderBrowserDialog())
                if (chooseDir.ShowDialog() == DialogResult.OK)
                    GetFiles(new DirectoryInfo(chooseDir.SelectedPath));
            Bitmap azaza = Worker.mozaikPic(new Bitmap(originalPicture,originalPicture.Width/5,originalPicture.Height/5),30);
            azaza.Save(writeTo);
            InitializeComponent();
        }
    }
}
