namespace GameOfLife
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.bStop = new System.Windows.Forms.Button();
            this.bStart = new System.Windows.Forms.Button();
            this.nudDensity = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudResolution = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDensity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudResolution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.splitContainer1.Panel1.Controls.Add(this.bStop);
            this.splitContainer1.Panel1.Controls.Add(this.bStart);
            this.splitContainer1.Panel1.Controls.Add(this.nudDensity);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.nudResolution);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1016, 549);
            this.splitContainer1.SplitterDistance = 193;
            this.splitContainer1.TabIndex = 0;
            // 
            // bStop
            // 
            this.bStop.FlatAppearance.BorderColor = System.Drawing.Color.Fuchsia;
            this.bStop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bStop.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bStop.Location = new System.Drawing.Point(11, 188);
            this.bStop.Name = "bStop";
            this.bStop.Size = new System.Drawing.Size(134, 40);
            this.bStop.TabIndex = 5;
            this.bStop.Text = "Stop";
            this.bStop.UseVisualStyleBackColor = true;
            this.bStop.Click += new System.EventHandler(this.bStop_Click);
            // 
            // bStart
            // 
            this.bStart.FlatAppearance.BorderColor = System.Drawing.Color.Fuchsia;
            this.bStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bStart.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bStart.Location = new System.Drawing.Point(11, 140);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(134, 42);
            this.bStart.TabIndex = 4;
            this.bStart.Text = "Start";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // nudDensity
            // 
            this.nudDensity.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudDensity.Location = new System.Drawing.Point(11, 102);
            this.nudDensity.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudDensity.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudDensity.Name = "nudDensity";
            this.nudDensity.Size = new System.Drawing.Size(134, 22);
            this.nudDensity.TabIndex = 3;
            this.nudDensity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudDensity.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Density";
            // 
            // nudResolution
            // 
            this.nudResolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudResolution.Location = new System.Drawing.Point(11, 36);
            this.nudResolution.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudResolution.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudResolution.Name = "nudResolution";
            this.nudResolution.Size = new System.Drawing.Size(134, 22);
            this.nudResolution.TabIndex = 1;
            this.nudResolution.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudResolution.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Resolution";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(815, 545);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // timer1
            // 
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 549);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "GameOfLife";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudDensity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudResolution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown nudResolution;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudDensity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bStop;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.Timer timer1;
    }
}

