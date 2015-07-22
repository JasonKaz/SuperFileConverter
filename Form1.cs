using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

using SuperFileConverter.ConverterWrappers;

namespace SuperFileConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            GifsicleConverter = new Gifsicle();
            GifsicleConverter.OutputFile = new Uri(Environment.CurrentDirectory + "\\OUTPUT.gif");
        }

        public Gifsicle GifsicleConverter;

        string GetRelativePath(string filespec, string folder)
        {
            Uri pathUri = new Uri(filespec);
            // Folders must end in a slash
            if (!folder.EndsWith(Path.DirectorySeparatorChar.ToString()))
            {
                folder += Path.DirectorySeparatorChar;
            }
            Uri folderUri = new Uri(folder);
            return Uri.UnescapeDataString(folderUri.MakeRelativeUri(pathUri).ToString().Replace('/', Path.DirectorySeparatorChar));
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            dlgChooseFile.Filter = "GIF|*.gif";

            if (dlgChooseFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                GifsicleConverter.InputFile = new Uri(dlgChooseFile.FileName);
            }
        }

        private void HandleSettings(){
            if (cbScale.Checked)
            {
                double val = 0.0;

                double.TryParse(numScale.Value.ToString(), out val);

                GifsicleConverter.Scale = val;
            }

            if (cbDistinctColors.Checked)
            {
                int val = 0;

                int.TryParse(numDistinctColors.Value.ToString(), out val);

                GifsicleConverter.DistinctColors = val;
            }

            if (cbOptimization.Checked)
            {
                int val = 0;

                int.TryParse(numOptimizeLevel.Value.ToString(), out val);

                GifsicleConverter.OptimizeLevel = val;
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            HandleSettings();

            GifsicleConverter.RunCommandFromSettings();
        }

        private void cbGetCommand_Click(object sender, EventArgs e)
        {
            HandleSettings();

            MessageBox.Show(GifsicleConverter.GetCommandFromSettings());
        }
    }
}
