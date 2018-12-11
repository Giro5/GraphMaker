namespace GraphMaker
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.GraphicChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.YEqLbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BuildBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AxisXLbl = new System.Windows.Forms.Label();
            this.XMin = new System.Windows.Forms.TextBox();
            this.Semicolon1 = new System.Windows.Forms.Label();
            this.XMax = new System.Windows.Forms.TextBox();
            this.RightBracket1 = new System.Windows.Forms.Label();
            this.RightBracket2 = new System.Windows.Forms.Label();
            this.YMax = new System.Windows.Forms.TextBox();
            this.Semicolon2 = new System.Windows.Forms.Label();
            this.YMin = new System.Windows.Forms.TextBox();
            this.AxisYLbl = new System.Windows.Forms.Label();
            this.AutoY = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.GraphicChart)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GraphicChart
            // 
            this.GraphicChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GraphicChart.BackColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea1.AxisX.LineWidth = 2;
            chartArea1.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea1.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisY.LineWidth = 2;
            chartArea1.Name = "ChartArea1";
            this.GraphicChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.GraphicChart.Legends.Add(legend1);
            this.GraphicChart.Location = new System.Drawing.Point(0, 86);
            this.GraphicChart.Margin = new System.Windows.Forms.Padding(5);
            this.GraphicChart.Name = "GraphicChart";
            this.GraphicChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Line";
            this.GraphicChart.Series.Add(series1);
            this.GraphicChart.Size = new System.Drawing.Size(1017, 632);
            this.GraphicChart.TabIndex = 0;
            this.GraphicChart.Text = "chart1";
            // 
            // YEqLbl
            // 
            this.YEqLbl.AutoSize = true;
            this.YEqLbl.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YEqLbl.Location = new System.Drawing.Point(12, 45);
            this.YEqLbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.YEqLbl.Name = "YEqLbl";
            this.YEqLbl.Size = new System.Drawing.Size(40, 22);
            this.YEqLbl.TabIndex = 1;
            this.YEqLbl.Text = "Y =";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(62, 42);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(799, 30);
            this.textBox1.TabIndex = 2;
            // 
            // BuildBtn
            // 
            this.BuildBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BuildBtn.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BuildBtn.Location = new System.Drawing.Point(871, 37);
            this.BuildBtn.Margin = new System.Windows.Forms.Padding(5);
            this.BuildBtn.Name = "BuildBtn";
            this.BuildBtn.Size = new System.Drawing.Size(125, 39);
            this.BuildBtn.TabIndex = 3;
            this.BuildBtn.Text = "Build";
            this.BuildBtn.UseVisualStyleBackColor = true;
            this.BuildBtn.Click += new System.EventHandler(this.BuildBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1017, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // AxisXLbl
            // 
            this.AxisXLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AxisXLbl.AutoSize = true;
            this.AxisXLbl.Location = new System.Drawing.Point(12, 726);
            this.AxisXLbl.Name = "AxisXLbl";
            this.AxisXLbl.Size = new System.Drawing.Size(100, 22);
            this.AxisXLbl.TabIndex = 5;
            this.AxisXLbl.Text = "Axis X: [";
            // 
            // XMin
            // 
            this.XMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.XMin.Location = new System.Drawing.Point(109, 723);
            this.XMin.Name = "XMin";
            this.XMin.Size = new System.Drawing.Size(45, 30);
            this.XMin.TabIndex = 6;
            this.XMin.Text = "-10";
            // 
            // Semicolon1
            // 
            this.Semicolon1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Semicolon1.AutoSize = true;
            this.Semicolon1.Location = new System.Drawing.Point(154, 726);
            this.Semicolon1.Name = "Semicolon1";
            this.Semicolon1.Size = new System.Drawing.Size(20, 22);
            this.Semicolon1.TabIndex = 7;
            this.Semicolon1.Text = ";";
            // 
            // XMax
            // 
            this.XMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.XMax.Location = new System.Drawing.Point(170, 723);
            this.XMax.Name = "XMax";
            this.XMax.Size = new System.Drawing.Size(45, 30);
            this.XMax.TabIndex = 8;
            this.XMax.Text = "10";
            // 
            // RightBracket1
            // 
            this.RightBracket1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RightBracket1.AutoSize = true;
            this.RightBracket1.Location = new System.Drawing.Point(215, 726);
            this.RightBracket1.Name = "RightBracket1";
            this.RightBracket1.Size = new System.Drawing.Size(20, 22);
            this.RightBracket1.TabIndex = 9;
            this.RightBracket1.Text = "]";
            // 
            // RightBracket2
            // 
            this.RightBracket2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RightBracket2.AutoSize = true;
            this.RightBracket2.Location = new System.Drawing.Point(497, 726);
            this.RightBracket2.Name = "RightBracket2";
            this.RightBracket2.Size = new System.Drawing.Size(20, 22);
            this.RightBracket2.TabIndex = 14;
            this.RightBracket2.Text = "]";
            // 
            // YMax
            // 
            this.YMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.YMax.Enabled = false;
            this.YMax.Location = new System.Drawing.Point(452, 723);
            this.YMax.Name = "YMax";
            this.YMax.Size = new System.Drawing.Size(45, 30);
            this.YMax.TabIndex = 13;
            // 
            // Semicolon2
            // 
            this.Semicolon2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Semicolon2.AutoSize = true;
            this.Semicolon2.Location = new System.Drawing.Point(436, 726);
            this.Semicolon2.Name = "Semicolon2";
            this.Semicolon2.Size = new System.Drawing.Size(20, 22);
            this.Semicolon2.TabIndex = 12;
            this.Semicolon2.Text = ";";
            // 
            // YMin
            // 
            this.YMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.YMin.Enabled = false;
            this.YMin.Location = new System.Drawing.Point(391, 723);
            this.YMin.Name = "YMin";
            this.YMin.Size = new System.Drawing.Size(45, 30);
            this.YMin.TabIndex = 11;
            // 
            // AxisYLbl
            // 
            this.AxisYLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AxisYLbl.AutoSize = true;
            this.AxisYLbl.Location = new System.Drawing.Point(294, 726);
            this.AxisYLbl.Name = "AxisYLbl";
            this.AxisYLbl.Size = new System.Drawing.Size(100, 22);
            this.AxisYLbl.TabIndex = 10;
            this.AxisYLbl.Text = "Axis Y: [";
            // 
            // AutoY
            // 
            this.AutoY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AutoY.AutoSize = true;
            this.AutoY.Checked = true;
            this.AutoY.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AutoY.Location = new System.Drawing.Point(518, 725);
            this.AutoY.Name = "AutoY";
            this.AutoY.Size = new System.Drawing.Size(69, 26);
            this.AutoY.TabIndex = 15;
            this.AutoY.Text = "Auto";
            this.AutoY.UseVisualStyleBackColor = true;
            this.AutoY.CheckedChanged += new System.EventHandler(this.AutoY_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 756);
            this.Controls.Add(this.AutoY);
            this.Controls.Add(this.RightBracket2);
            this.Controls.Add(this.YMax);
            this.Controls.Add(this.Semicolon2);
            this.Controls.Add(this.YMin);
            this.Controls.Add(this.AxisYLbl);
            this.Controls.Add(this.RightBracket1);
            this.Controls.Add(this.XMax);
            this.Controls.Add(this.Semicolon1);
            this.Controls.Add(this.XMin);
            this.Controls.Add(this.AxisXLbl);
            this.Controls.Add(this.BuildBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.YEqLbl);
            this.Controls.Add(this.GraphicChart);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "GraphMaker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GraphicChart)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart GraphicChart;
        private System.Windows.Forms.Label YEqLbl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BuildBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Label AxisXLbl;
        private System.Windows.Forms.TextBox XMin;
        private System.Windows.Forms.Label Semicolon1;
        private System.Windows.Forms.TextBox XMax;
        private System.Windows.Forms.Label RightBracket1;
        private System.Windows.Forms.Label RightBracket2;
        private System.Windows.Forms.TextBox YMax;
        private System.Windows.Forms.Label Semicolon2;
        private System.Windows.Forms.TextBox YMin;
        private System.Windows.Forms.Label AxisYLbl;
        private System.Windows.Forms.CheckBox AutoY;
    }
}

