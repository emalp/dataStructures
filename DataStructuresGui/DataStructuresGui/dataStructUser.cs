using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataStructuresGui
{
    public partial class dataStructUser : Form
    {

        int selected;

        public dataStructUser()
        {

            InitializeComponent();
      
        }

        private void dataStructUser_Load(object sender, EventArgs e)
        {

            // first creating the charttype as line.
           // chart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;



            getRadio.Enabled = false;
            sortRadio.Enabled = false;
            startCalculation.Enabled = false;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectCombo.SelectedIndex == 0)
            {
                getRadio.Enabled = true;
                sortRadio.Enabled = true;
                startCalculation.Enabled = true;
                getRadio.Checked = true;
                selected = 0;
            }
            else if (selectCombo.SelectedIndex == 1)
            {
                getRadio.Enabled = true;
                sortRadio.Enabled = false;
                startCalculation.Enabled = true;
                getRadio.Checked = true;
                selected = 1;
            }
            else if (selectCombo.SelectedIndex == 2) {
                getRadio.Enabled = true;
                sortRadio.Enabled = false;
                startCalculation.Enabled = true;
                getRadio.Checked = true;
                selected = 2;
            }

        }

        private void startCalculation_Click(object sender, EventArgs e)
        {
            Boolean get = false;
            int selected = this.selected;
            int size= -1;

            if (System.Text.RegularExpressions.Regex.IsMatch(inputSize.Text, @"^\d+$"))
            {
                if (int.Parse(inputSize.Text) < 1000)
                {
                    MessageBox.Show("Please enter a integer greater than 1000");
                }
                else
                {
                    size = int.Parse(inputSize.Text);
                }
            }
            else {
                MessageBox.Show("Please enter an int in input size.");
            }

            if (getRadio.Checked == true)
            {
                get = true;
            }
            else if (sortRadio.Checked == true)
            {
                get = false;
            }
            else {
                get = false;
            }


            // send in the form of selected,get,size.
            if (size != -1)
            {
                chartForm cf = new chartForm(selected, get, size);
                cf.Show();
            }

            
        }
    }
}
