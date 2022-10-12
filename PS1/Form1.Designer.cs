namespace PS1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.shapesControl = new System.Windows.Forms.TabControl();
            this.lines = new System.Windows.Forms.TabPage();
            this.drawLineButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linesYEnd = new System.Windows.Forms.NumericUpDown();
            this.linesXEnd = new System.Windows.Forms.NumericUpDown();
            this.linesYStart = new System.Windows.Forms.NumericUpDown();
            this.linesXStart = new System.Windows.Forms.NumericUpDown();
            this.lines_EndPoint = new System.Windows.Forms.Label();
            this.line_startPoint = new System.Windows.Forms.Label();
            this.rectangles = new System.Windows.Forms.TabPage();
            this.rectangleDraw = new System.Windows.Forms.Button();
            this.rectanglesHeight = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.rectanglesWidth = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.rectanglesY = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.rectanglesX = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ellipses = new System.Windows.Forms.TabPage();
            this.ellipsesDrawButton = new System.Windows.Forms.Button();
            this.ellipsesRadius = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.ellipsesY = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.ellipsesX = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.changeButton = new System.Windows.Forms.Button();
            this.myPictureBox = new System.Windows.Forms.PictureBox();
            this.shapesControl.SuspendLayout();
            this.lines.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.linesYEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linesXEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linesYStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linesXStart)).BeginInit();
            this.rectangles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rectanglesHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rectanglesWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rectanglesY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rectanglesX)).BeginInit();
            this.ellipses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ellipsesRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ellipsesY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ellipsesX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // shapesControl
            // 
            this.shapesControl.Controls.Add(this.lines);
            this.shapesControl.Controls.Add(this.rectangles);
            this.shapesControl.Controls.Add(this.ellipses);
            this.shapesControl.Location = new System.Drawing.Point(12, 12);
            this.shapesControl.Name = "shapesControl";
            this.shapesControl.SelectedIndex = 0;
            this.shapesControl.Size = new System.Drawing.Size(690, 101);
            this.shapesControl.TabIndex = 1;
            // 
            // lines
            // 
            this.lines.Controls.Add(this.drawLineButton);
            this.lines.Controls.Add(this.label4);
            this.lines.Controls.Add(this.label3);
            this.lines.Controls.Add(this.label2);
            this.lines.Controls.Add(this.label1);
            this.lines.Controls.Add(this.linesYEnd);
            this.lines.Controls.Add(this.linesXEnd);
            this.lines.Controls.Add(this.linesYStart);
            this.lines.Controls.Add(this.linesXStart);
            this.lines.Controls.Add(this.lines_EndPoint);
            this.lines.Controls.Add(this.line_startPoint);
            this.lines.Location = new System.Drawing.Point(4, 24);
            this.lines.Name = "lines";
            this.lines.Padding = new System.Windows.Forms.Padding(3);
            this.lines.Size = new System.Drawing.Size(682, 73);
            this.lines.TabIndex = 0;
            this.lines.Text = "Lines";
            this.lines.UseVisualStyleBackColor = true;
            // 
            // drawLineButton
            // 
            this.drawLineButton.Location = new System.Drawing.Point(604, 36);
            this.drawLineButton.Name = "drawLineButton";
            this.drawLineButton.Size = new System.Drawing.Size(75, 23);
            this.drawLineButton.TabIndex = 8;
            this.drawLineButton.Text = "Draw";
            this.drawLineButton.UseVisualStyleBackColor = true;
            this.drawLineButton.Click += new System.EventHandler(this.drawLineButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(13, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(450, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(135, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(328, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "X";
            // 
            // linesYEnd
            // 
            this.linesYEnd.Location = new System.Drawing.Point(470, 36);
            this.linesYEnd.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.linesYEnd.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.linesYEnd.Name = "linesYEnd";
            this.linesYEnd.Size = new System.Drawing.Size(93, 23);
            this.linesYEnd.TabIndex = 3;
            // 
            // linesXEnd
            // 
            this.linesXEnd.Location = new System.Drawing.Point(348, 36);
            this.linesXEnd.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.linesXEnd.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.linesXEnd.Name = "linesXEnd";
            this.linesXEnd.Size = new System.Drawing.Size(93, 23);
            this.linesXEnd.TabIndex = 4;
            // 
            // linesYStart
            // 
            this.linesYStart.Location = new System.Drawing.Point(155, 35);
            this.linesYStart.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.linesYStart.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.linesYStart.Name = "linesYStart";
            this.linesYStart.Size = new System.Drawing.Size(93, 23);
            this.linesYStart.TabIndex = 3;
            // 
            // linesXStart
            // 
            this.linesXStart.Location = new System.Drawing.Point(33, 35);
            this.linesXStart.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.linesXStart.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.linesXStart.Name = "linesXStart";
            this.linesXStart.Size = new System.Drawing.Size(93, 23);
            this.linesXStart.TabIndex = 2;
            // 
            // lines_EndPoint
            // 
            this.lines_EndPoint.AutoSize = true;
            this.lines_EndPoint.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lines_EndPoint.Location = new System.Drawing.Point(328, 13);
            this.lines_EndPoint.Name = "lines_EndPoint";
            this.lines_EndPoint.Size = new System.Drawing.Size(75, 21);
            this.lines_EndPoint.TabIndex = 1;
            this.lines_EndPoint.Text = "End Point";
            // 
            // line_startPoint
            // 
            this.line_startPoint.AutoSize = true;
            this.line_startPoint.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.line_startPoint.Location = new System.Drawing.Point(13, 12);
            this.line_startPoint.Name = "line_startPoint";
            this.line_startPoint.Size = new System.Drawing.Size(81, 21);
            this.line_startPoint.TabIndex = 0;
            this.line_startPoint.Text = "Start Point";
            // 
            // rectangles
            // 
            this.rectangles.Controls.Add(this.rectangleDraw);
            this.rectangles.Controls.Add(this.rectanglesHeight);
            this.rectangles.Controls.Add(this.label10);
            this.rectangles.Controls.Add(this.rectanglesWidth);
            this.rectangles.Controls.Add(this.label9);
            this.rectangles.Controls.Add(this.rectanglesY);
            this.rectangles.Controls.Add(this.label8);
            this.rectangles.Controls.Add(this.rectanglesX);
            this.rectangles.Controls.Add(this.label7);
            this.rectangles.Controls.Add(this.label6);
            this.rectangles.Controls.Add(this.label5);
            this.rectangles.Location = new System.Drawing.Point(4, 24);
            this.rectangles.Name = "rectangles";
            this.rectangles.Padding = new System.Windows.Forms.Padding(3);
            this.rectangles.Size = new System.Drawing.Size(682, 73);
            this.rectangles.TabIndex = 1;
            this.rectangles.Text = "Rectangles";
            this.rectangles.UseVisualStyleBackColor = true;
            // 
            // rectangleDraw
            // 
            this.rectangleDraw.Location = new System.Drawing.Point(604, 29);
            this.rectangleDraw.Name = "rectangleDraw";
            this.rectangleDraw.Size = new System.Drawing.Size(75, 23);
            this.rectangleDraw.TabIndex = 9;
            this.rectangleDraw.Text = "Draw";
            this.rectangleDraw.UseVisualStyleBackColor = true;
            this.rectangleDraw.Click += new System.EventHandler(this.rectangleDraw_Click);
            // 
            // rectanglesHeight
            // 
            this.rectanglesHeight.Location = new System.Drawing.Point(498, 29);
            this.rectanglesHeight.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.rectanglesHeight.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.rectanglesHeight.Name = "rectanglesHeight";
            this.rectanglesHeight.Size = new System.Drawing.Size(93, 23);
            this.rectanglesHeight.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(445, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 19);
            this.label10.TabIndex = 9;
            this.label10.Text = "Height";
            // 
            // rectanglesWidth
            // 
            this.rectanglesWidth.Location = new System.Drawing.Point(343, 29);
            this.rectanglesWidth.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.rectanglesWidth.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.rectanglesWidth.Name = "rectanglesWidth";
            this.rectanglesWidth.Size = new System.Drawing.Size(93, 23);
            this.rectanglesWidth.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(294, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 19);
            this.label9.TabIndex = 2;
            this.label9.Text = "Width";
            // 
            // rectanglesY
            // 
            this.rectanglesY.Location = new System.Drawing.Point(151, 29);
            this.rectanglesY.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.rectanglesY.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.rectanglesY.Name = "rectanglesY";
            this.rectanglesY.Size = new System.Drawing.Size(93, 23);
            this.rectanglesY.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(131, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 19);
            this.label8.TabIndex = 6;
            this.label8.Text = "Y";
            // 
            // rectanglesX
            // 
            this.rectanglesX.Location = new System.Drawing.Point(29, 29);
            this.rectanglesX.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.rectanglesX.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.rectanglesX.Name = "rectanglesX";
            this.rectanglesX.Size = new System.Drawing.Size(93, 23);
            this.rectanglesX.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(9, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 19);
            this.label7.TabIndex = 8;
            this.label7.Text = "X";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(294, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 21);
            this.label6.TabIndex = 3;
            this.label6.Text = "Parameters";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(9, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "Start Point";
            // 
            // ellipses
            // 
            this.ellipses.Controls.Add(this.ellipsesDrawButton);
            this.ellipses.Controls.Add(this.ellipsesRadius);
            this.ellipses.Controls.Add(this.label15);
            this.ellipses.Controls.Add(this.ellipsesY);
            this.ellipses.Controls.Add(this.label14);
            this.ellipses.Controls.Add(this.ellipsesX);
            this.ellipses.Controls.Add(this.label13);
            this.ellipses.Controls.Add(this.label12);
            this.ellipses.Controls.Add(this.label11);
            this.ellipses.Location = new System.Drawing.Point(4, 24);
            this.ellipses.Name = "ellipses";
            this.ellipses.Padding = new System.Windows.Forms.Padding(3);
            this.ellipses.Size = new System.Drawing.Size(682, 73);
            this.ellipses.TabIndex = 2;
            this.ellipses.Text = "Ellipses";
            this.ellipses.UseVisualStyleBackColor = true;
            // 
            // ellipsesDrawButton
            // 
            this.ellipsesDrawButton.Location = new System.Drawing.Point(604, 29);
            this.ellipsesDrawButton.Name = "ellipsesDrawButton";
            this.ellipsesDrawButton.Size = new System.Drawing.Size(75, 23);
            this.ellipsesDrawButton.TabIndex = 10;
            this.ellipsesDrawButton.Text = "Draw";
            this.ellipsesDrawButton.UseVisualStyleBackColor = true;
            this.ellipsesDrawButton.Click += new System.EventHandler(this.ellipsesDrawButton_Click);
            // 
            // ellipsesRadius
            // 
            this.ellipsesRadius.Location = new System.Drawing.Point(373, 29);
            this.ellipsesRadius.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ellipsesRadius.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.ellipsesRadius.Name = "ellipsesRadius";
            this.ellipsesRadius.Size = new System.Drawing.Size(93, 23);
            this.ellipsesRadius.TabIndex = 12;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(321, 32);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 19);
            this.label15.TabIndex = 11;
            this.label15.Text = "Radius";
            // 
            // ellipsesY
            // 
            this.ellipsesY.Location = new System.Drawing.Point(151, 29);
            this.ellipsesY.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ellipsesY.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.ellipsesY.Name = "ellipsesY";
            this.ellipsesY.Size = new System.Drawing.Size(93, 23);
            this.ellipsesY.TabIndex = 10;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(131, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(17, 19);
            this.label14.TabIndex = 9;
            this.label14.Text = "Y";
            // 
            // ellipsesX
            // 
            this.ellipsesX.Location = new System.Drawing.Point(29, 29);
            this.ellipsesX.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ellipsesX.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.ellipsesX.Name = "ellipsesX";
            this.ellipsesX.Size = new System.Drawing.Size(93, 23);
            this.ellipsesX.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(9, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(17, 19);
            this.label13.TabIndex = 8;
            this.label13.Text = "X";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(321, 6);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 21);
            this.label12.TabIndex = 3;
            this.label12.Text = "Parameters";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(9, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 21);
            this.label11.TabIndex = 2;
            this.label11.Text = "Center Point";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(620, 119);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(539, 119);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(75, 23);
            this.changeButton.TabIndex = 3;
            this.changeButton.Text = "Change";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // myPictureBox
            // 
            this.myPictureBox.BackColor = System.Drawing.Color.White;
            this.myPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.myPictureBox.Location = new System.Drawing.Point(12, 148);
            this.myPictureBox.Name = "myPictureBox";
            this.myPictureBox.Size = new System.Drawing.Size(690, 469);
            this.myPictureBox.TabIndex = 2;
            this.myPictureBox.TabStop = false;
            this.myPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.MyPictureBox_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 627);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.myPictureBox);
            this.Controls.Add(this.shapesControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.shapesControl.ResumeLayout(false);
            this.lines.ResumeLayout(false);
            this.lines.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.linesYEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linesXEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linesYStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linesXStart)).EndInit();
            this.rectangles.ResumeLayout(false);
            this.rectangles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rectanglesHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rectanglesWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rectanglesY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rectanglesX)).EndInit();
            this.ellipses.ResumeLayout(false);
            this.ellipses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ellipsesRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ellipsesY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ellipsesX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl shapesControl;
        private TabPage lines;
        private Button clearButton;
        private Button changeButton;
        private Button drawLineButton;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private NumericUpDown linesYEnd;
        private NumericUpDown linesXEnd;
        private NumericUpDown linesYStart;
        private NumericUpDown linesXStart;
        private Label lines_EndPoint;
        private Label line_startPoint;
        private TabPage rectangles;
        private Button rectangleDraw;
        private NumericUpDown rectanglesHeight;
        private Label label10;
        private NumericUpDown rectanglesWidth;
        private Label label9;
        private NumericUpDown rectanglesY;
        private Label label8;
        private NumericUpDown rectanglesX;
        private Label label7;
        private Label label6;
        private Label label5;
        private TabPage ellipses;
        private Button ellipsesDrawButton;
        private NumericUpDown ellipsesRadius;
        private Label label15;
        private NumericUpDown ellipsesY;
        private Label label14;
        private NumericUpDown ellipsesX;
        private Label label13;
        private Label label12;
        private Label label11;
        private PictureBox myPictureBox;
    }
}