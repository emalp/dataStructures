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

namespace DataStructuresGui
{
    public partial class chartForm : Form
    {

        Random r = new Random();
        Stopwatch stopwatch = new Stopwatch();
        linklist ll = new linklist();
        bTree binaryTree = new bTree();
        hashMap hm;

        public chartForm()
        {
            InitializeComponent();
            
        }

        public chartForm(int selected, Boolean get, int size) {

            InitializeComponent();
            chartLoad(selected, get, size);
            chart.ChartAreas[0].AxisY.ScaleView.Zoom(0, size);  // put axis y as number of inputs          
            chart.ChartAreas[0].AxisY.Title = "Element Index";
            chart.ChartAreas[0].AxisX.Title = "Time taken to retrieve (in miliseconds)";
            // ll = new linklist();
        }


        private void chartForm_Load(object sender, EventArgs e)
        {
            chart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart.ChartAreas[0].CursorX.IsUserEnabled = true;
            chart.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            chart.ChartAreas[0].AxisX.ScaleView.Zoomable = true;


        }

        public void chartLoad(int selected, Boolean get, int size) {

            if (selected == 0) // LINKED LIST
            {
                if (get == true)
                {
                    stopwatch.Reset();
                    stopwatch.Start();
                    for (int x = 0; x <= size; x++)
                    {
                        int z = r.Next(1, size);
                        ll.add(z);
                    } // random values added
                    stopwatch.Stop();
                    TimeSpan xtime = stopwatch.Elapsed;
                    stopwatch.Reset();

                    double timex = xtime.Seconds * 1000 + (xtime.TotalMilliseconds);
                    MessageBox.Show("" + timex + " Miliseconds taken to add random values to the Linkedlist."); // eti miliseconds layo

                    chart.ChartAreas[0].AxisX.ScaleView.Zoom(0, (int)timex);

                    for (int o = 1; o <= size; o += 5)
                    {

                        chart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                        chart.Series[0].Points.AddXY(llfunction(o), o);

                    }

                }
                else
                {
                    // DO SORTING GRAPH AS WELL.
                    for (int x = 0; x <= size; x++)
                    {
                        int z = r.Next(1, size);
                        ll.add(z);
                    } // random values added
                    stopwatch.Reset();
                    stopwatch.Start();
                    ll.sort();
                    stopwatch.Stop();
                    TimeSpan xtime = stopwatch.Elapsed;
                    stopwatch.Reset();

                    double timex = xtime.Seconds * 1000 + (xtime.TotalMilliseconds);
                    MessageBox.Show("" + timex + " Miliseconds taken to sort random values to the Linkedlist."); // eti miliseconds layo

                    chart.ChartAreas[0].AxisX.ScaleView.Zoom(0, (int)timex);

                    for (int o = 1; o <= size; o += 5)
                    {

                        chart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                        chart.Series[0].Points.AddXY(llfunction(o), o);

                    }
                }

            }

            else if (selected == 1) //BINARY TREE
            { // now case for binary tree

                // chart.ChartAreas[0].AxisY.ScaleView.Zoom(0, -size); // testing for the graph to be ulto.

                int temp = 0;

                stopwatch.Start();
                for (int x = 0; x <= size; x++)
                {
                    int z = r.Next(1, size);
                    binaryTree.add(z);
                    temp = z;

                } // random values added
                stopwatch.Stop();
                TimeSpan xtime = stopwatch.Elapsed;
                stopwatch.Reset();


                double timex = xtime.Seconds * 1000 + (xtime.TotalMilliseconds);
                MessageBox.Show("" + timex + " Miliseconds taken to add random values to the Binary Tree."); // eti miliseconds layo

                chart.ChartAreas[0].AxisX.ScaleView.Zoom(0, (int)timex);
                // now getting all node shits.

                binaryTree.Get(temp); // getting the last element
                int f = binaryTree.totalNodesgui; // total nodesgui has the amount of nodes collidided at the path.

                int s = size;
                int p = 0;

                List<int> allvals;
                allvals = binaryTree.allvalsgui;
                var allNodeValues = allvals.ToArray();


                while (f != 1)
                {

                    int x = 0;
                    chart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                    chart.Series[0].Points.AddXY(btreefunction(allNodeValues[x]), p);// time taken to get to that node, size);
                    f--;
                    x++;
                    s /= 2;
                    p = size - s;
                }


            } // binarytree method end.

            else {  // HASH MAP
                // now time chart for hash map
                hm = new hashMap(size);

                int[] temp = new int[size/5];
                int ini1 = 0;
                int ini2 = 0;
                int ltemp1 = 0;
                int ltemp2 = ltemp1;

                stopwatch.Start();
                for (int x = 0; x <= size; x++)
                {
                    int jpt = 0;
                    ltemp1 = x;
                    int z = r.Next(1, size);
                    ini1 = z;
                    int w = r.Next(1, size);
                    ini2 = w;
                    hm.add(Convert.ToString(ini1), Convert.ToString(ini2)); // key value pairs
                    if (ltemp1 == (ltemp2 + 5)) {
                        temp[jpt] = ini1; // temp[] array has all the keys..
                        ltemp2 = ltemp1;
                        jpt++;
                    }
                     

                } // random values added
                stopwatch.Stop();
                TimeSpan xtime = stopwatch.Elapsed;
                stopwatch.Reset();


                double timex = xtime.Seconds * 1000 + (xtime.TotalMilliseconds);
                MessageBox.Show("" + timex + " Miliseconds taken to add random values to the Hash Map."); // eti miliseconds layo

                chart.ChartAreas[0].AxisX.ScaleView.Zoom(0, (int)timex);


                for (int x = 0; x <= temp.Length - 1; x++) {
                    
                    chart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                    chart.Series[0].Points.AddXY(hmfunction(temp[x]),x); // plotting time vs n elements graph.
                   
                }


            }


        } // chart method end

        public int llfunction(int input) {

            stopwatch.Reset();
            stopwatch.Start();
            int v = Convert.ToInt32(ll.getIndex(input));
            stopwatch.Stop();
            
            TimeSpan t = stopwatch.Elapsed;
            stopwatch.Reset();

            double timex = (t.Seconds * 1000) + t.Milliseconds;

            return (int) timex;

        }

        public int btreefunction(int value) {


            stopwatch.Start();
            binaryTree.Get(value);
            stopwatch.Stop();
            stopwatch.Reset();

            TimeSpan t = stopwatch.Elapsed;
            stopwatch.Reset();

            double timex = (t.Seconds * 1000) + t.Milliseconds;
            //int final = (int)Math.Log(timex, 2);


            return (int)timex;
        }

        public int hmfunction(int key) {

            stopwatch.Start();
            hm.get(Convert.ToString(key));
            stopwatch.Stop();

            TimeSpan t = stopwatch.Elapsed;
            stopwatch.Reset();

            double timex = (t.Seconds * 1000) + t.Milliseconds;

            return (int)timex;
        }

        private void chart_Click(object sender, EventArgs e)
        {

        }
    }
}
