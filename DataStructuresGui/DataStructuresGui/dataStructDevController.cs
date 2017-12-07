using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DataStructuresGui
{
    class dataStructDevController
    {
        dataStructDev d = new dataStructDev();
        Random r = new Random();

        // --------------------- Linked List testing first!!!!!!! ----------------
        public TimeSpan[] linklistTest(int value) {

            linklist ll = new linklist();

            // Populate linked list with random val first.
           
            //int y = r.Next(1000, 100000);
            Stopwatch watcher = new Stopwatch();

            watcher.Start();
            for (int x = 0; x <= value; x++) {
                int rndval = r.Next(1, value);
                ll.add(rndval);
            }
            watcher.Stop();
            // linklist populated.
            TimeSpan addTs = watcher.Elapsed;

            watcher.Reset(); // resetting the stopwatch for retrieval


            // Now calculating the getAll() time elapsed.
           
            TimeSpan gets = new TimeSpan();
            TimeSpan[] get = new TimeSpan[100];
            for (int x = 0; x <= 100-1; x++)
            {
                gets = new TimeSpan();
                watcher.Start();
                int q = Convert.ToInt32(ll.getIndex(value));
                watcher.Stop();
                gets = watcher.Elapsed;

                get[x] = gets;
                watcher.Reset();

            }

            TimeSpan getTs = new TimeSpan();
            foreach (TimeSpan t in get) {
                getTs += t;
            }
            //TimeSpan getTs = new TimeSpan();
            //getTs = TimeSpan.FromMilliseconds((totalTime.TotalSeconds)*100 +  totalTime.TotalMilliseconds );       
            
            TimeSpan[] llSpan = {addTs, getTs };
            return llSpan;

        } // linklist test end.
        // ------------------------- linkledlist test end -------------------


// ----------------------------- binarytree test start ----------------------------------

        public TimeSpan[] binaryTreetest(int value) {
            bTree binarytree = new bTree();

            Random r = new Random();
            Stopwatch watcher = new Stopwatch();
            int getval = 0;

            // adding "value" random data into binary tree
            watcher.Start();
            for (int x = 0; x <= value; x++)
            {
                //Again:
                int rndval = r.Next(1, value);
                binarytree.add(rndval);
               // if (!binarytree.add(rndval)) {
               //     goto Again;
               // }
                getval = rndval;
            }
            
            watcher.Stop();
            // data addition complete

            TimeSpan addbtTs = watcher.Elapsed; // binaryTree addition timespan.

            watcher.Reset();


            // Now calculating the get(Object val) time elapsed.

            TimeSpan gets = new TimeSpan();
            TimeSpan[] get = new TimeSpan[100];
            for (int x = 0; x <= 100 - 1; x++)
            {
                gets = new TimeSpan();
                watcher.Start();
                binarytree.Get(getval);
               
                watcher.Stop();
                gets = watcher.Elapsed;

                get[x] = gets;
                watcher.Reset();

            }

            TimeSpan getbtTs = new TimeSpan();
            foreach (TimeSpan t in get)
            {
                getbtTs += t;
            }

            TimeSpan[] bt = {addbtTs, getbtTs };
            return bt;



        }// binarytree test complete.

        // ----------------------BinaryTree test complete -----------------------------


        // -------------------- Hashmap start ------------------------------------------
        public TimeSpan[] hashMapTest(int value)
        {

            hashMap hm = new hashMap(value); // created hashmap of 100,000.


            Random r = new Random();
            Stopwatch watcher = new Stopwatch();
            int lastKey = 0;

            watcher.Start();
            for (int x = 0; x <= value; x++)
            {
                //Again:
                int randkey = r.Next(1, value);
                int inirdkey = randkey;
                randkey = r.Next(1, value);
                int inirdVal = randkey;
                // if (!binarytree.add(rndval)) {
                //     goto Again;
                // }
                hm.add(Convert.ToString(inirdkey),Convert.ToString( inirdVal));
                lastKey = inirdkey;
            }

            watcher.Stop();

            // all values added to hash map.

            TimeSpan addhmTs = watcher.Elapsed; // hashmap addition timespan.

            watcher.Reset();

            TimeSpan gets = new TimeSpan();
            TimeSpan[] get = new TimeSpan[100];
            for (int x = 0; x <= 100 - 1; x++)
            {
                gets = new TimeSpan();
                watcher.Start();
                hm.get(Convert.ToString(lastKey));

                watcher.Stop();
                gets = watcher.Elapsed;

                get[x] = gets;
                watcher.Reset();

            }

            TimeSpan gethmTs = new TimeSpan();
            foreach (TimeSpan t in get)
            {
                gethmTs += t;
            }


            TimeSpan[] hmm = { addhmTs, gethmTs };
            return hmm;
        }

        // ----------------Hashmap time test complete ----------------------------
    }
}
