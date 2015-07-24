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

using SuperFileConverter.Entities.ConverterWrappers;

namespace SuperFileConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            GifsicleConverter = new Gifsicle();
            GifsicleConverter.OutputFile = new Uri(Environment.CurrentDirectory + "\\OUTPUT.gif");

            ImageMagickConverter = new ImageMagick();

            FFmpegConverter = new FFmpeg();
        }

        public Gifsicle GifsicleConverter;

        public ImageMagick ImageMagickConverter;

        public FFmpeg FFmpegConverter;

        public List<string> OutputFileTypes = new List<string> { "All|*.*" };

        public List<string> InputFileTypes = new List<string> { "All|*.*" };

        public AbstractConverterWrapper SelectedConverter = null;

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
            dlgChooseFile.Filter = string.Join("|", InputFileTypes);

            if (dlgChooseFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                SelectedConverter.InputFile = new Uri(dlgChooseFile.FileName);
            }
        }

        private void HandleSettings()
        {
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

            if (cbCrop.Checked)
            {
                int x1, y1, x2, y2;

                int.TryParse(tbCropX1.Text, out x1);
                int.TryParse(tbCropY1.Text, out y1);

                GifsicleConverter.CropX1 = x1;
                GifsicleConverter.CropY1 = y1;

                if (!string.IsNullOrEmpty(tbCropX2.Text))
                {
                    int.TryParse(tbCropX2.Text, out x2);

                    GifsicleConverter.CropX2 = x2;
                }

                if (!string.IsNullOrEmpty(tbCropY2.Text))
                {
                    int.TryParse(tbCropY2.Text, out y2);

                    GifsicleConverter.CropY2 = y2;
                }

                if (rbCropTo.Checked)
                {
                    GifsicleConverter.CropMode = 1;
                }

                if (rbCropBy.Checked)
                {
                    GifsicleConverter.CropMode = 2;
                }
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            HandleSettings();

            SelectedConverter.RunCommandFromSettings();
        }

        private void cbGetCommand_Click(object sender, EventArgs e)
        {
            HandleSettings();

            MessageBox.Show(SelectedConverter.GetCommandFromSettings());
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            dlgOutput.Filter = string.Join("|", OutputFileTypes);

            if (dlgOutput.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                SelectedConverter.OutputFile = new Uri(dlgOutput.FileName);
            }
        }

        private void ddlConverter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ddlConverter.SelectedItem.ToString()))
            {
                switch (ddlConverter.SelectedItem.ToString())
                {
                    case "Gifsicle":
                        SelectedConverter = GifsicleConverter;
                        break;

                    case "ImageMagick":
                        SelectedConverter = ImageMagickConverter;
                        break;

                    case "FFmpeg":
                        SelectedConverter = FFmpegConverter;
                        break;
                }

                InputFileTypes = SelectedConverter.AllowedInputTypes.Select(x => x.ToUpper() + "|*." + x).ToList();
                OutputFileTypes = SelectedConverter.AllowedOutputTypes.Select(x => x.ToUpper() + "|*." + x).ToList();

                if (SelectedConverter != null)
                {
                    cbScale.Enabled = numScale.Enabled = SelectedConverter.AvailableSettings.Contains("Scale");
                    cbDistinctColors.Enabled = numDistinctColors.Enabled = SelectedConverter.AvailableSettings.Contains("DistinctColors");
                    cbOptimization.Enabled = numOptimizeLevel.Enabled = SelectedConverter.AvailableSettings.Contains("Optimize");
                    cbCrop.Enabled = tbCropX1.Enabled = tbCropY1.Enabled = rbCropBy.Enabled = rbCropTo.Enabled = tbCropX2.Enabled = tbCropY2.Enabled = SelectedConverter.AvailableSettings.Contains("Crop");
                }
            }
        }
    }
}
