namespace SuperFileConverter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dlgChooseFile = new System.Windows.Forms.OpenFileDialog();
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbCropBy = new System.Windows.Forms.RadioButton();
            this.rbCropTo = new System.Windows.Forms.RadioButton();
            this.tbCropY2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCropX2 = new System.Windows.Forms.TextBox();
            this.tbCropY1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCropX1 = new System.Windows.Forms.TextBox();
            this.cbCrop = new System.Windows.Forms.CheckBox();
            this.numOptimizeLevel = new System.Windows.Forms.NumericUpDown();
            this.cbOptimization = new System.Windows.Forms.CheckBox();
            this.numDistinctColors = new System.Windows.Forms.NumericUpDown();
            this.numScale = new System.Windows.Forms.NumericUpDown();
            this.cbDistinctColors = new System.Windows.Forms.CheckBox();
            this.cbScale = new System.Windows.Forms.CheckBox();
            this.cbGetCommand = new System.Windows.Forms.Button();
            this.dlgOutput = new System.Windows.Forms.SaveFileDialog();
            this.btnOutput = new System.Windows.Forms.Button();
            this.ddlConverter = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOptimizeLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDistinctColors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScale)).BeginInit();
            this.SuspendLayout();
            // 
            // dlgChooseFile
            // 
            this.dlgChooseFile.FileName = "openFileDialog1";
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Location = new System.Drawing.Point(13, 13);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(75, 23);
            this.btnChooseFile.TabIndex = 0;
            this.btnChooseFile.Text = "Choose File";
            this.btnChooseFile.UseVisualStyleBackColor = true;
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(266, 190);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 1;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbCropBy);
            this.groupBox1.Controls.Add(this.rbCropTo);
            this.groupBox1.Controls.Add(this.tbCropY2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbCropX2);
            this.groupBox1.Controls.Add(this.tbCropY1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbCropX1);
            this.groupBox1.Controls.Add(this.cbCrop);
            this.groupBox1.Controls.Add(this.numOptimizeLevel);
            this.groupBox1.Controls.Add(this.cbOptimization);
            this.groupBox1.Controls.Add(this.numDistinctColors);
            this.groupBox1.Controls.Add(this.numScale);
            this.groupBox1.Controls.Add(this.cbDistinctColors);
            this.groupBox1.Controls.Add(this.cbScale);
            this.groupBox1.Location = new System.Drawing.Point(95, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 171);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // rbCropBy
            // 
            this.rbCropBy.AutoSize = true;
            this.rbCropBy.Location = new System.Drawing.Point(167, 117);
            this.rbCropBy.Name = "rbCropBy";
            this.rbCropBy.Size = new System.Drawing.Size(36, 17);
            this.rbCropBy.TabIndex = 16;
            this.rbCropBy.Text = "By";
            this.rbCropBy.UseVisualStyleBackColor = true;
            // 
            // rbCropTo
            // 
            this.rbCropTo.AutoSize = true;
            this.rbCropTo.Checked = true;
            this.rbCropTo.Location = new System.Drawing.Point(101, 117);
            this.rbCropTo.Name = "rbCropTo";
            this.rbCropTo.Size = new System.Drawing.Size(37, 17);
            this.rbCropTo.TabIndex = 15;
            this.rbCropTo.TabStop = true;
            this.rbCropTo.Text = "To";
            this.rbCropTo.UseVisualStyleBackColor = true;
            // 
            // tbCropY2
            // 
            this.tbCropY2.Location = new System.Drawing.Point(167, 140);
            this.tbCropY2.Name = "tbCropY2";
            this.tbCropY2.Size = new System.Drawing.Size(54, 20);
            this.tbCropY2.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "x";
            // 
            // tbCropX2
            // 
            this.tbCropX2.Location = new System.Drawing.Point(101, 140);
            this.tbCropX2.Name = "tbCropX2";
            this.tbCropX2.Size = new System.Drawing.Size(42, 20);
            this.tbCropX2.TabIndex = 12;
            // 
            // tbCropY1
            // 
            this.tbCropY1.Location = new System.Drawing.Point(167, 91);
            this.tbCropY1.Name = "tbCropY1";
            this.tbCropY1.Size = new System.Drawing.Size(54, 20);
            this.tbCropY1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "x";
            // 
            // tbCropX1
            // 
            this.tbCropX1.Location = new System.Drawing.Point(101, 91);
            this.tbCropX1.Name = "tbCropX1";
            this.tbCropX1.Size = new System.Drawing.Size(42, 20);
            this.tbCropX1.TabIndex = 9;
            // 
            // cbCrop
            // 
            this.cbCrop.AutoSize = true;
            this.cbCrop.Location = new System.Drawing.Point(6, 91);
            this.cbCrop.Name = "cbCrop";
            this.cbCrop.Size = new System.Drawing.Size(47, 17);
            this.cbCrop.TabIndex = 8;
            this.cbCrop.Text = "Crop";
            this.cbCrop.UseVisualStyleBackColor = true;
            // 
            // numOptimizeLevel
            // 
            this.numOptimizeLevel.Location = new System.Drawing.Point(101, 67);
            this.numOptimizeLevel.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numOptimizeLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numOptimizeLevel.Name = "numOptimizeLevel";
            this.numOptimizeLevel.Size = new System.Drawing.Size(120, 20);
            this.numOptimizeLevel.TabIndex = 7;
            this.numOptimizeLevel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbOptimization
            // 
            this.cbOptimization.AutoSize = true;
            this.cbOptimization.Location = new System.Drawing.Point(6, 67);
            this.cbOptimization.Name = "cbOptimization";
            this.cbOptimization.Size = new System.Drawing.Size(82, 17);
            this.cbOptimization.TabIndex = 6;
            this.cbOptimization.Text = "Optimization";
            this.cbOptimization.UseVisualStyleBackColor = true;
            // 
            // numDistinctColors
            // 
            this.numDistinctColors.Location = new System.Drawing.Point(101, 42);
            this.numDistinctColors.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.numDistinctColors.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numDistinctColors.Name = "numDistinctColors";
            this.numDistinctColors.Size = new System.Drawing.Size(120, 20);
            this.numDistinctColors.TabIndex = 5;
            this.numDistinctColors.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // numScale
            // 
            this.numScale.DecimalPlaces = 1;
            this.numScale.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numScale.Location = new System.Drawing.Point(101, 19);
            this.numScale.Name = "numScale";
            this.numScale.Size = new System.Drawing.Size(120, 20);
            this.numScale.TabIndex = 4;
            this.numScale.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbDistinctColors
            // 
            this.cbDistinctColors.AutoSize = true;
            this.cbDistinctColors.Location = new System.Drawing.Point(6, 43);
            this.cbDistinctColors.Name = "cbDistinctColors";
            this.cbDistinctColors.Size = new System.Drawing.Size(92, 17);
            this.cbDistinctColors.TabIndex = 3;
            this.cbDistinctColors.Text = "Distinct Colors";
            this.cbDistinctColors.UseVisualStyleBackColor = false;
            // 
            // cbScale
            // 
            this.cbScale.AutoSize = true;
            this.cbScale.Location = new System.Drawing.Point(6, 19);
            this.cbScale.Name = "cbScale";
            this.cbScale.Size = new System.Drawing.Size(52, 17);
            this.cbScale.TabIndex = 2;
            this.cbScale.Text = "Scale";
            this.cbScale.UseVisualStyleBackColor = true;
            // 
            // cbGetCommand
            // 
            this.cbGetCommand.Location = new System.Drawing.Point(172, 190);
            this.cbGetCommand.Name = "cbGetCommand";
            this.cbGetCommand.Size = new System.Drawing.Size(88, 23);
            this.cbGetCommand.TabIndex = 3;
            this.cbGetCommand.Text = "Get Command";
            this.cbGetCommand.UseVisualStyleBackColor = true;
            this.cbGetCommand.Click += new System.EventHandler(this.cbGetCommand_Click);
            // 
            // btnOutput
            // 
            this.btnOutput.Location = new System.Drawing.Point(12, 69);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(75, 23);
            this.btnOutput.TabIndex = 4;
            this.btnOutput.Text = "Output";
            this.btnOutput.UseVisualStyleBackColor = true;
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // ddlConverter
            // 
            this.ddlConverter.FormattingEnabled = true;
            this.ddlConverter.Items.AddRange(new object[] {
            "Gifsicle",
            "ImageMagick",
            "FFmpeg"});
            this.ddlConverter.Location = new System.Drawing.Point(12, 42);
            this.ddlConverter.Name = "ddlConverter";
            this.ddlConverter.Size = new System.Drawing.Size(75, 21);
            this.ddlConverter.TabIndex = 5;
            this.ddlConverter.SelectedIndexChanged += new System.EventHandler(this.ddlConverter_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 220);
            this.Controls.Add(this.ddlConverter);
            this.Controls.Add(this.btnOutput);
            this.Controls.Add(this.cbGetCommand);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.btnChooseFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOptimizeLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDistinctColors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScale)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog dlgChooseFile;
        private System.Windows.Forms.Button btnChooseFile;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbScale;
        private System.Windows.Forms.CheckBox cbDistinctColors;
        private System.Windows.Forms.NumericUpDown numScale;
        private System.Windows.Forms.NumericUpDown numDistinctColors;
        private System.Windows.Forms.CheckBox cbOptimization;
        private System.Windows.Forms.NumericUpDown numOptimizeLevel;
        private System.Windows.Forms.Button cbGetCommand;
        private System.Windows.Forms.CheckBox cbCrop;
        private System.Windows.Forms.TextBox tbCropY2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCropX2;
        private System.Windows.Forms.TextBox tbCropY1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCropX1;
        private System.Windows.Forms.RadioButton rbCropBy;
        private System.Windows.Forms.RadioButton rbCropTo;
        private System.Windows.Forms.SaveFileDialog dlgOutput;
        private System.Windows.Forms.Button btnOutput;
        private System.Windows.Forms.ComboBox ddlConverter;
    }
}

