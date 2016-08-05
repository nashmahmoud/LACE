using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace LACE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string rootFolder;

        private void cbxSystems_SelectedIndexChanged(object sender, EventArgs e)
        {
            rootFolder = "input//" + cbxSystems.SelectedItem.ToString(); //Application.ExecutablePath.ToString().Replace(@"\LACE\LACE\bin\Debug\LACE.EXE", @"\LACE\LACE\bin\Debug\Input\" + cbxSystems.SelectedItem.ToString());
            populateFilesCbx();
            chart2.Series.Clear();

            backgroundWorker1.RunWorkerAsync();
            pictureBox1.Show();
            label1.Visible = true;
            
        }

        private void populateFilesCbx()
        {

            string[] filePaths = Directory.GetFiles(rootFolder, "*.txt", SearchOption.AllDirectories);

            cbxSystemReleases.Items.Clear();

            lblStat.Text = "Number of releases: " + filePaths.Length;
            

            ComboBoxItem item;

            foreach (string fileName in filePaths)
            {
                item = new ComboBoxItem();
                item.Text = new DirectoryInfo(fileName).Name;
                item.Value = fileName;

                cbxSystemReleases.Items.Add(item);
            }

        }

        private double[] birthRate;
        private void BirthDeathAnalysis()
        {
            //Read the frequency data of all system releases from the data folder
            

            
            string[] filePaths = Directory.GetFiles(rootFolder, "*.txt", SearchOption.AllDirectories);
            List<word> words;
            double birth;

            List<string> sortedPaths = new List<string>();
            sortedPaths.AddRange(filePaths);
            sortedPaths.Sort();
            birthRate = new double[filePaths.Length];
            birthRate[0] = 0; //First release always birth rate is 1

            for (int i = 1; i < sortedPaths.Count; i++)
            {
                // MessageBox.Show(sortedPaths[i]);

                words = new List<word>();
                //MessageBox.Show(Utili.loadFrequencyData(filePaths[i]).Count.ToString());
                words.AddRange(Utili.loadFrequencyData(sortedPaths[i]));
                birth = Utili.getBirthSum(words);

                //MessageBox.Show(filePaths[i] + " " + birth + " "  + words.Count);

                

                birthRate[i] = birth / words.Count;
                
            }

            
            DeathAnaysis();
        }

        private void plotDeathBirthData(double[] data, string serieseName)
        {
            
            chart2.Series.Add(serieseName);

            for (int i = 1; i < data.Length; i++)
            {
                chart2.Series[serieseName].Points.AddXY(i + 1, data[i]);
                
            }


            // txtInfo.Text += "------------------------------------------------------------------";

            chart2.Series[serieseName].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;

            chart2.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            chart2.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;

        }


        private double[] deathRate;
        private void DeathAnaysis()
        {

            //string rootFolder = Application.ExecutablePath.ToString().Replace(@"\LACE\LACE\bin\Debug\LACE.EXE", @"\LACE\LACE\bin\Debug\Input\" + cbxSystems.SelectedItem.ToString());
            string[] filePaths = Directory.GetFiles(rootFolder, "*.txt", SearchOption.AllDirectories);
            List<word> words;

            deathRate = new double[filePaths.Length];
            List<List<word>> releasesData = new List<List<word>>();
            double death = 0;

            //Skip the first release
            for (int i = 0; i < filePaths.Length; i++)
            {
                words = Utili.loadFrequencyData(filePaths[i]);
                releasesData.Add(words);
            }

            deathRate[0] = 0;

            for (int i = 0; i < releasesData.Count - 1; i++)
            {
                death = 0;

                for (int j = 0; j < releasesData[i].Count; j++)
                {
                    if (!releasesData[i + 1].Exists(x => (x.text == releasesData[i][j].text)))
                    {
                        death++;

                        //Force Analysis


                        // txtInfo.Text += releasesData[i][j].text + Environment.NewLine;
                        //MessageBox.Show((i+1) + " " + releasesData[i][j].text);
                    }
                }


                // txtInfo.Text += "------------------"+ Environment.NewLine;

              

                //MessageBox.Show(death.ToString());
                deathRate[i + 1] = death / releasesData[i].Count;
              
                //MessageBox.Show("Death: " + releasesData[i][j].text);

            }

            

        }

        private void btnTrackWord_Click(object sender, EventArgs e)
        {

            if (listView1.SelectedItems.Count == 0)
                analyzeWordEvolution(txtFilter.Text);
            else
                analyzeWordEvolution(listView1.SelectedItems[0].Text);
        }

        private void analyzeWordEvolution(string word)
        {

            //string rootFolder = Application.ExecutablePath.ToString().Replace(@"\LACE\LACE\bin\Debug\LACE.EXE", @"\LACE\LACE\bin\Debug\Input\" + cbxSystems.SelectedItem.ToString());
            string[] filePaths = Directory.GetFiles(rootFolder, "*.txt", SearchOption.AllDirectories);

            //Hold release vs frequency
            double[] x = new double[filePaths.Length];
            double[] y = new double[filePaths.Length];

            int i = 0;

            foreach (string fileName in filePaths)
            {
                List<word> words = Utili.loadFrequencyData(fileName);
                x[i] = i;
                y[i] = 0;



                for (int j = 0; j < words.Count; j++)
                    if (words[j].text == word)
                    {
                        y[i] = words[j].frequency / Utili.getFrequencySum(words);

                    }

                i++;



            }

            generateFrequency(word, x, y);

        }

        private void generateFrequency(string seriesNo, double[] x, double[] y)
        {
            //chart1.Series.Clear();

            chart1.Series.Add(seriesNo);


            for (int i = 0; i < x.Length; i++)
            {
                chart1.Series[seriesNo.ToString()].Points.AddXY(x[i] + 1, y[i]);
                
            }

            chart1.Series[seriesNo.ToString()].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;

        }

        List<word> lstViewItem = new List<word>(); 
        private void cbxSystemReleases_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            //chart3.Series.Clear();

            string fileName = (cbxSystemReleases.SelectedItem as ComboBoxItem).Value.ToString();


            List<word> words = Utili.loadFrequencyData(fileName);
            lstViewItem.AddRange(words);

            words.Sort();
            string newTxt;

            for (int i = 0; i < words.Count; i++)
            {
                if (words[i].isnew)
                    newTxt = "true";
                else
                    newTxt = "";

                if (cbxOnlyNew.Checked && newTxt == "true")
                    listView1.Items.Add(new ListViewItem(new string[] { words[i].text, words[i].frequency.ToString(), newTxt }));

                else if (!cbxOnlyNew.Checked)
                    listView1.Items.Add(new ListViewItem(new string[] { words[i].text, words[i].frequency.ToString(), newTxt }));

            }


            if (cbxSystemReleases.SelectedIndex > 0)
            {
                string previousRelease = (cbxSystemReleases.Items[cbxSystemReleases.SelectedIndex - 1] as ComboBoxItem).Value.ToString();
                getReleaseDeadWords(words, previousRelease);
            }
        }

        private void getReleaseDeadWords(List<word> wordsCurrent, string previousRelease)
        {
            List<word> wordsPrev = Utili.loadFrequencyData(previousRelease);

            for (int i = 0; i < wordsPrev.Count; i++)
                if (!wordsCurrent.Exists(x => (x.text == wordsPrev[i].text)))
                    listView1.Items.Add(new ListViewItem(new string[] { wordsPrev[i].text, "0", "Dead" }));

        }


        private void btnClearChart_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BirthDeathAnalysis();
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            plotDeathBirthData(birthRate, "Birth rate");
            plotDeathBirthData(deathRate, "Death rate");
            pictureBox1.Hide();
            label1.Visible = false;
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            listView1.Items.AddRange(lstViewItem.Where(i => string.IsNullOrEmpty(txtFilter.Text) || i.text.StartsWith(txtFilter.Text)).Select(c => new ListViewItem(c.text)).ToArray());
        }


    }
}
