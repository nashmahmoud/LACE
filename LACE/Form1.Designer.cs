namespace LACE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.cbxSystems = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblStat = new System.Windows.Forms.Label();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbxOnlyNew = new System.Windows.Forms.CheckBox();
            this.Filter = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.btnTrackWord = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.clmnWord = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnFreq = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnNew = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbxSystemReleases = new System.Windows.Forms.ComboBox();
            this.btnClearChart = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxSystems
            // 
            this.cbxSystems.FormattingEnabled = true;
            this.cbxSystems.Items.AddRange(new object[] {
            "Netty",
            "Plumble",
            "SimpleTask",
            "AdAway",
            "Flym"});
            this.cbxSystems.Location = new System.Drawing.Point(17, 35);
            this.cbxSystems.Name = "cbxSystems";
            this.cbxSystems.Size = new System.Drawing.Size(291, 21);
            this.cbxSystems.TabIndex = 14;
            this.cbxSystems.SelectedIndexChanged += new System.EventHandler(this.cbxSystems_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.lblStat);
            this.groupBox2.Controls.Add(this.chart2);
            this.groupBox2.Controls.Add(this.cbxSystems);
            this.groupBox2.Location = new System.Drawing.Point(33, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1171, 242);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "System Analysis";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Please wait ...";
            this.label1.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(139, 147);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 42);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // lblStat
            // 
            this.lblStat.AutoSize = true;
            this.lblStat.Location = new System.Drawing.Point(17, 73);
            this.lblStat.Name = "lblStat";
            this.lblStat.Size = new System.Drawing.Size(0, 13);
            this.lblStat.TabIndex = 16;
            // 
            // chart2
            // 
            chartArea1.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart2.Legends.Add(legend1);
            this.chart2.Location = new System.Drawing.Point(374, 19);
            this.chart2.Name = "chart2";
            this.chart2.Size = new System.Drawing.Size(775, 211);
            this.chart2.TabIndex = 15;
            this.chart2.Text = "chart2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chart1);
            this.groupBox1.Controls.Add(this.cbxOnlyNew);
            this.groupBox1.Controls.Add(this.Filter);
            this.groupBox1.Controls.Add(this.txtFilter);
            this.groupBox1.Controls.Add(this.btnTrackWord);
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Controls.Add(this.cbxSystemReleases);
            this.groupBox1.Controls.Add(this.btnClearChart);
            this.groupBox1.Location = new System.Drawing.Point(33, 280);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1171, 435);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Release Analysis";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(374, 73);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(775, 300);
            this.chart1.TabIndex = 33;
            this.chart1.Text = "chart1";
            // 
            // cbxOnlyNew
            // 
            this.cbxOnlyNew.AutoSize = true;
            this.cbxOnlyNew.Location = new System.Drawing.Point(19, 54);
            this.cbxOnlyNew.Name = "cbxOnlyNew";
            this.cbxOnlyNew.Size = new System.Drawing.Size(136, 17);
            this.cbxOnlyNew.TabIndex = 32;
            this.cbxOnlyNew.Text = "Display only new words";
            this.cbxOnlyNew.UseVisualStyleBackColor = true;
            // 
            // Filter
            // 
            this.Filter.AutoSize = true;
            this.Filter.Location = new System.Drawing.Point(23, 393);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(29, 13);
            this.Filter.TabIndex = 24;
            this.Filter.Text = "Filter";
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(58, 390);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(170, 20);
            this.txtFilter.TabIndex = 23;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // btnTrackWord
            // 
            this.btnTrackWord.Location = new System.Drawing.Point(234, 388);
            this.btnTrackWord.Name = "btnTrackWord";
            this.btnTrackWord.Size = new System.Drawing.Size(119, 23);
            this.btnTrackWord.TabIndex = 14;
            this.btnTrackWord.Text = "Track Selected Word";
            this.btnTrackWord.UseVisualStyleBackColor = true;
            this.btnTrackWord.Click += new System.EventHandler(this.btnTrackWord_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmnWord,
            this.clmnFreq,
            this.clmnNew});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(17, 73);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(327, 300);
            this.listView1.TabIndex = 13;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // clmnWord
            // 
            this.clmnWord.Text = "word";
            this.clmnWord.Width = 123;
            // 
            // clmnFreq
            // 
            this.clmnFreq.Text = "Frequency";
            this.clmnFreq.Width = 107;
            // 
            // clmnNew
            // 
            this.clmnNew.Text = "New";
            this.clmnNew.Width = 162;
            // 
            // cbxSystemReleases
            // 
            this.cbxSystemReleases.FormattingEnabled = true;
            this.cbxSystemReleases.Location = new System.Drawing.Point(17, 30);
            this.cbxSystemReleases.Name = "cbxSystemReleases";
            this.cbxSystemReleases.Size = new System.Drawing.Size(202, 21);
            this.cbxSystemReleases.TabIndex = 11;
            this.cbxSystemReleases.SelectedIndexChanged += new System.EventHandler(this.cbxSystemReleases_SelectedIndexChanged);
            // 
            // btnClearChart
            // 
            this.btnClearChart.Location = new System.Drawing.Point(1076, 393);
            this.btnClearChart.Name = "btnClearChart";
            this.btnClearChart.Size = new System.Drawing.Size(73, 23);
            this.btnClearChart.TabIndex = 15;
            this.btnClearChart.Text = "Clear";
            this.btnClearChart.UseVisualStyleBackColor = true;
            this.btnClearChart.Click += new System.EventHandler(this.btnClearChart_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 726);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "LACE - Lingutsic Analysis of Code Evolution";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxSystems;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbxOnlyNew;
        private System.Windows.Forms.Label Filter;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Button btnTrackWord;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader clmnWord;
        private System.Windows.Forms.ColumnHeader clmnFreq;
        private System.Windows.Forms.ColumnHeader clmnNew;
        private System.Windows.Forms.ComboBox cbxSystemReleases;
        private System.Windows.Forms.Button btnClearChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label lblStat;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

