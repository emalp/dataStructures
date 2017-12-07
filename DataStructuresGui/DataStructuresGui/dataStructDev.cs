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
    public partial class dataStructDev : Form
    {

        public int x;
        public dataStructDev()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            statusLabel.Text = "";
           

            dataStructDevController dsv = new dataStructDevController();
            Random r = new Random();
            int[] rdvalues = new int[5];
            for (int x = 0; x <= 4; x++) {
                rdvalues[x] = r.Next(1000, 100000);
            }
            // Testing linked List first.


            Label[] lladd = { lladd1, lladd2 , lladd3, lladd4, lladd5};
            Label[] llretrieve = { llretrieve1, llretrieve2, llretrieve3, llretrieve4, llretrieve5};

            for (int x = 0; x <= 4; x++) {
                
                TimeSpan[] time = dsv.linklistTest(rdvalues[x]);

                double addmili = time[0].TotalMilliseconds;
                int addSec = time[0].Seconds;

                double getmili = (time[1].TotalMilliseconds) / 100;
                int getsec = time[1].Seconds;

                

                lladd[x].Text = "At " + rdvalues[x] + " values = " + addSec + " : " + addmili;
                llretrieve[x].Text = "At " + rdvalues[x] + " values = " + getsec + " : " + getmili;
            }

            statusLabel.Text = "LinkedList calculation completed. Checking Binary Tree now.";


            // Now testing  BinaryTree
            Label[] btadd = { btadd1, btadd2, btadd3, btadd4, btadd5 };
            Label[] btget = { btget1, btget2, btget3, btget4, btget5 };

            for (int x = 0; x <= 4; x++)
            {
                TimeSpan[] btTime = dsv.binaryTreetest(rdvalues[x]);

                double addbtmili = btTime[0].TotalMilliseconds;
                int addbtSec = btTime[0].Seconds;

                double getbtmili = btTime[1].TotalMilliseconds / 100;
                int getbtSec = btTime[1].Seconds;

                btadd[x].Text = "At " + rdvalues[x] + " values = " + addbtSec + " : " + addbtmili;
                btget[x].Text = "At " + rdvalues[x] + " values = " + getbtSec + " : " + getbtmili;

                statusLabel.Text = "Binary Tree calculation completed. Checking HashMap now.";
            }

            // Testing hashmap now.
            Label[] hmadd = { hmadd1, hmadd2, hmadd3, hmadd4, hmadd5 };
            Label[] hmget = { hmget1, hmget2, hmget3, hmget4, hmget5 };

            for (int x = 0; x <= 4; x++)
            {
                TimeSpan[] hmTime = dsv.hashMapTest(rdvalues[x]);

                double addhmmili = hmTime[0].TotalMilliseconds;
                int addhmSec = hmTime[0].Seconds;

                double gethmmili = hmTime[1].TotalMilliseconds / 100;
                int gethmSec = hmTime[1].Seconds;

                hmadd[x].Text = "At " + rdvalues[x] + " values = " + addhmSec + " : " + addhmmili;
                hmget[x].Text = "At " + rdvalues[x] + " values = " + gethmSec + " : " + gethmmili;

                statusLabel.Text = "All Data Structures calculation complete.";
            }
        }

        private void dataStructDev_Load(object sender, EventArgs e)
        {

        }
    }
}
