namespace NumberPlatReaderTester
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
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnTest2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFromToppx = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnTestROI = new System.Windows.Forms.Button();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtWith = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTopY = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTopX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFileName = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblNumPlateNotFound = new System.Windows.Forms.Label();
            this.lblNumPlatFound = new System.Windows.Forms.Label();
            this.lblProcessFiles = new System.Windows.Forms.Label();
            this.lblTotalFile = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLoadPicToCal = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblNumberPlate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(0, 490);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JPEG FILE|*.JPG|BITMAP|*.BMP";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.Controls.Add(this.lblFileName);
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Size = new System.Drawing.Size(939, 490);
            this.splitContainer1.SplitterDistance = 641;
            this.splitContainer1.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.btnTest2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtFromToppx);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 142);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(294, 104);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Location = new System.Drawing.Point(3, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(288, 29);
            this.label9.TabIndex = 11;
            this.label9.Text = "Image splitting sample. Split the image into mutiple images of 450 px wide.";
            // 
            // btnTest2
            // 
            this.btnTest2.Location = new System.Drawing.Point(167, 48);
            this.btnTest2.Name = "btnTest2";
            this.btnTest2.Size = new System.Drawing.Size(102, 23);
            this.btnTest2.TabIndex = 8;
            this.btnTest2.Text = "Read Num. Plate";
            this.btnTest2.UseVisualStyleBackColor = true;
            this.btnTest2.Click += new System.EventHandler(this.btnTest2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Pix from top";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Take";
            // 
            // txtFromToppx
            // 
            this.txtFromToppx.Location = new System.Drawing.Point(44, 50);
            this.txtFromToppx.Name = "txtFromToppx";
            this.txtFromToppx.Size = new System.Drawing.Size(49, 20);
            this.txtFromToppx.TabIndex = 11;
            this.txtFromToppx.Text = "1600";
            this.txtFromToppx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLoadPicToCal);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnTestROI);
            this.groupBox1.Controls.Add(this.txtHeight);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtWith);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtTopY);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtTopX);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 246);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 101);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Image Region of Interest Sample.";
            // 
            // btnTestROI
            // 
            this.btnTestROI.Location = new System.Drawing.Point(167, 44);
            this.btnTestROI.Name = "btnTestROI";
            this.btnTestROI.Size = new System.Drawing.Size(115, 23);
            this.btnTestROI.TabIndex = 9;
            this.btnTestROI.Text = "Read Num. Plate";
            this.btnTestROI.UseVisualStyleBackColor = true;
            this.btnTestROI.Click += new System.EventHandler(this.btnTestROI_Click);
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(260, 73);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(33, 20);
            this.txtHeight.TabIndex = 7;
            this.txtHeight.Text = "250";
            this.txtHeight.TextChanged += new System.EventHandler(this.txtHeight_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(220, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Height";
            // 
            // txtWith
            // 
            this.txtWith.Location = new System.Drawing.Point(184, 73);
            this.txtWith.Name = "txtWith";
            this.txtWith.Size = new System.Drawing.Size(33, 20);
            this.txtWith.TabIndex = 5;
            this.txtWith.Text = "450";
            this.txtWith.TextChanged += new System.EventHandler(this.txtWith_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(149, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Width";
            // 
            // txtTopY
            // 
            this.txtTopY.Location = new System.Drawing.Point(113, 73);
            this.txtTopY.Name = "txtTopY";
            this.txtTopY.Size = new System.Drawing.Size(33, 20);
            this.txtTopY.TabIndex = 3;
            this.txtTopY.Text = "450";
            this.txtTopY.TextChanged += new System.EventHandler(this.txtTopY_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Top y";
            // 
            // txtTopX
            // 
            this.txtTopX.Location = new System.Drawing.Point(41, 73);
            this.txtTopX.Name = "txtTopX";
            this.txtTopX.Size = new System.Drawing.Size(33, 20);
            this.txtTopX.TabIndex = 1;
            this.txtTopX.Text = "1160";
            this.txtTopX.TextChanged += new System.EventHandler(this.txtTopX_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Top x";
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblFileName.Location = new System.Drawing.Point(0, 347);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(35, 13);
            this.lblFileName.TabIndex = 10;
            this.lblFileName.Text = "label2";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblNumPlateNotFound, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblNumPlatFound, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblProcessFiles, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTotalFile, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 360);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(294, 130);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // lblNumPlateNotFound
            // 
            this.lblNumPlateNotFound.AutoSize = true;
            this.lblNumPlateNotFound.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNumPlateNotFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumPlateNotFound.ForeColor = System.Drawing.Color.Red;
            this.lblNumPlateNotFound.Location = new System.Drawing.Point(150, 65);
            this.lblNumPlateNotFound.Name = "lblNumPlateNotFound";
            this.lblNumPlateNotFound.Size = new System.Drawing.Size(141, 65);
            this.lblNumPlateNotFound.TabIndex = 3;
            this.lblNumPlateNotFound.Text = "Not Found";
            // 
            // lblNumPlatFound
            // 
            this.lblNumPlatFound.AutoSize = true;
            this.lblNumPlatFound.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNumPlatFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumPlatFound.ForeColor = System.Drawing.Color.Red;
            this.lblNumPlatFound.Location = new System.Drawing.Point(3, 65);
            this.lblNumPlatFound.Name = "lblNumPlatFound";
            this.lblNumPlatFound.Size = new System.Drawing.Size(141, 65);
            this.lblNumPlatFound.TabIndex = 2;
            this.lblNumPlatFound.Text = "Found";
            // 
            // lblProcessFiles
            // 
            this.lblProcessFiles.AutoSize = true;
            this.lblProcessFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProcessFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcessFiles.ForeColor = System.Drawing.Color.Red;
            this.lblProcessFiles.Location = new System.Drawing.Point(150, 0);
            this.lblProcessFiles.Name = "lblProcessFiles";
            this.lblProcessFiles.Size = new System.Drawing.Size(141, 65);
            this.lblProcessFiles.TabIndex = 1;
            this.lblProcessFiles.Text = "Proceesed Pic";
            // 
            // lblTotalFile
            // 
            this.lblTotalFile.AutoSize = true;
            this.lblTotalFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFile.ForeColor = System.Drawing.Color.Red;
            this.lblTotalFile.Location = new System.Drawing.Point(3, 0);
            this.lblTotalFile.Name = "lblTotalFile";
            this.lblTotalFile.Size = new System.Drawing.Size(141, 65);
            this.lblTotalFile.TabIndex = 0;
            this.lblTotalFile.Text = "Total Pic";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(2, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Test 1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnLoadPicToCal
            // 
            this.btnLoadPicToCal.Location = new System.Drawing.Point(9, 44);
            this.btnLoadPicToCal.Name = "btnLoadPicToCal";
            this.btnLoadPicToCal.Size = new System.Drawing.Size(135, 23);
            this.btnLoadPicToCal.TabIndex = 11;
            this.btnLoadPicToCal.Text = "Load pic to calibration";
            this.btnLoadPicToCal.UseVisualStyleBackColor = true;
            this.btnLoadPicToCal.Click += new System.EventHandler(this.btnLoadPicToCal_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NumberPlatReaderTester.Properties.Resources.scene00169;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(2304, 1314);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblNumberPlate);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 68);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(294, 74);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Vehicle Reg. Number";
            // 
            // lblNumberPlate
            // 
            this.lblNumberPlate.AutoSize = true;
            this.lblNumberPlate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberPlate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblNumberPlate.Location = new System.Drawing.Point(6, 26);
            this.lblNumberPlate.Name = "lblNumberPlate";
            this.lblNumberPlate.Size = new System.Drawing.Size(233, 25);
            this.lblNumberPlate.TabIndex = 0;
            this.lblNumberPlate.Text = "XXX XXX X XX-XXXXX";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 503);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnTest2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblNumPlateNotFound;
        private System.Windows.Forms.Label lblNumPlatFound;
        private System.Windows.Forms.Label lblProcessFiles;
        private System.Windows.Forms.Label lblTotalFile;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFromToppx;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTopY;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTopX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtWith;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnTestROI;
        private System.Windows.Forms.Button btnLoadPicToCal;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblNumberPlate;
    }
}

