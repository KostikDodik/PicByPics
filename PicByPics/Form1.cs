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
        Bitmap originalPicture;

        public Form1()
        {
            InitializeComponent();
            StatusLabel.Text = "Ready";
        }


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
                    {
                        PicPart.parts.Add(new PicPart(new Bitmap(f.FullName)));
                        StatusLabel.Text = "Loading sticks. Loaded "+ PicPart.parts.Count +" pictures.";
                    }
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                StatusLabel.Text = "Some problems with loading. Totaly loaded " + PicPart.parts.Count + " sticks";
            }
            StatusLabel.Text = "Ready";
            return;
        }

        private void ChooseFolderBut_Click(object sender, EventArgs e)
        {
            using (var chooseDir = new FolderBrowserDialog())
                if (chooseDir.ShowDialog() == DialogResult.OK)
                    GetFiles(new DirectoryInfo(chooseDir.SelectedPath));
        }

        private void TakeImageBut_Click(object sender, EventArgs e)
        {
            using (var choosePic = new OpenFileDialog())
                if (choosePic.ShowDialog() == DialogResult.OK)
                {
                    originalPicture = new Bitmap(choosePic.FileName);
                    ChoosenImageLabel.Text = choosePic.FileName.Substring(choosePic.FileName.LastIndexOf('\\') + 1);
                    SaveTB.Text = choosePic.FileName.Substring(0, choosePic.FileName.LastIndexOf('\\') + 1) + "Fragmented " + choosePic.FileName.Substring(choosePic.FileName.LastIndexOf('\\') + 1);
                }
            if (PicPart.parts.Count > 1 && !originalPicture.Equals(null))
                StatusLabel.Text = "Ready to start transforming";

        }

        private void SaveBut_Click(object sender, EventArgs e)
        {
            if (PicPart.parts.Count > 1 && !originalPicture.Equals(null))
            {
                int mat=5, size=30;
                Int32.TryParse(MatrixTB.Text, out mat);
                Int32.TryParse(SizeTB.Text, out size);
                Worker.mozaikPic(new Bitmap(originalPicture, originalPicture.Width / mat, originalPicture.Height / mat), size).Save(SaveTB.Text);
                StatusLabel.Text = "Initiating with matrix size "+ mat + 'X' + mat +"pxl and sticks' size " + size + 'X' +size + "pxl.";
            }
            else StatusLabel.Text = "You missed some important part";
        }

        private void ChoosePathBut_Click(object sender, EventArgs e)
        {
            using (var dia = new OpenFileDialog())
                if (dia.ShowDialog() == DialogResult.OK)
                {
                    SaveTB.Text = dia.FileName;
                }
        }
    }
}
