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
            this.cbScale = new System.Windows.Forms.CheckBox();
            this.cbDistinctColors = new System.Windows.Forms.CheckBox();
            this.numScale = new System.Windows.Forms.NumericUpDown();
            this.numDistinctColors = new System.Windows.Forms.NumericUpDown();
            this.cbOptimization = new System.Windows.Forms.CheckBox();
            this.numOptimizeLevel = new System.Windows.Forms.NumericUpDown();
            this.cbGetCommand = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDistinctColors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOptimizeLevel)).BeginInit();
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
            this.btnConvert.Location = new System.Drawing.Point(266, 162);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 1;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numOptimizeLevel);
            this.groupBox1.Controls.Add(this.cbOptimization);
            this.groupBox1.Controls.Add(this.numDistinctColors);
            this.groupBox1.Controls.Add(this.numScale);
            this.groupBox1.Controls.Add(this.cbDistinctColors);
            this.groupBox1.Controls.Add(this.cbScale);
            this.groupBox1.Location = new System.Drawing.Point(95, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 143);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
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
            // numScale
            // 
            this.numScale.Location = new System.Drawing.Point(101, 19);
            this.numScale.Name = "numScale";
            this.numScale.Size = new System.Drawing.Size(120, 20);
            this.numScale.TabIndex = 4;
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
            // cbGetCommand
            // 
            this.cbGetCommand.Location = new System.Drawing.Point(172, 162);
            this.cbGetCommand.Name = "cbGetCommand";
            this.cbGetCommand.Size = new System.Drawing.Size(88, 23);
            this.cbGetCommand.TabIndex = 3;
            this.cbGetCommand.Text = "Get Command";
            this.cbGetCommand.UseVisualStyleBackColor = true;
            this.cbGetCommand.Click += new System.EventHandler(this.cbGetCommand_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 194);
            this.Controls.Add(this.cbGetCommand);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.btnChooseFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDistinctColors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOptimizeLevel)).EndInit();
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
    }
}

