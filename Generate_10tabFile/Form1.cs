using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Generate_10tabFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string inputDir;
        string fileName;
        string fileNameExtension;

        OpenFileDialog browseButton = new OpenFileDialog();
        private void ImportFileButton_Click(object sender, EventArgs e)
        {
            browseButton.Filter = "Text files |*.tit";
            if (browseButton.ShowDialog() == DialogResult.OK)
            {
                inputDir = Path.GetDirectoryName(browseButton.FileName);
                fileName = Path.GetFileNameWithoutExtension(browseButton.SafeFileName);
                fileNameExtension = Path.GetExtension(browseButton.SafeFileName);

                fileDirInput.Text = browseButton.FileName;
                fileDirOutput.Text = inputDir + "\\" + fileName+"(2)" + fileNameExtension;
            }
         }


        List<string> newFileText = new List<string>();
        string tmpString;

        private void ExportFileButton_Click(object sender, EventArgs e)
        {

            
            if (fileDirOutput.Text != "")
            {
                
            foreach (string line in File.ReadLines(browseButton.FileName))
            {
                    //MessageBox.Show(line);
                    
                    tmpString = line.Insert(24, " ");
                    tmpString = tmpString.Insert(2, " ");
                    newFileText.Add(tmpString);
            }
            
                //READ FILE AND DO SOMETHING
                File.WriteAllLines(fileDirOutput.Text, newFileText.ToArray());
                Application.Exit();
            }
            
        }
    }
}
