using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresGui
{
    public class hashMap
    {

        int BUCKET_ARRAY_SIZE = 256;
        private Node[] bucketArray;
        Node array = new Node();



        public hashMap() { }

        public hashMap(int initialSize)
        {
            try
            {
                bucketArray = new Node[initialSize];
                this.BUCKET_ARRAY_SIZE = initialSize;
            }
            catch (Exception ex) {
                // no ntg..
            }
        }

        // ---------------------- add method start ------------------------------------------

            /// <summary>
            /// 
            /// </summary>
            /// <param name="key"></param>
            /// <param name="value"></param>
        public void add(String key, String value)
        {

            char[] b = key.ToCharArray();
            int hash = 1;
            foreach (char a in b)
            {
                hash = (hash * Convert.ToInt32(a)) % BUCKET_ARRAY_SIZE;

            }



            Node entry = new Node(key, value);


            //if else to  check for (key%size) collision
            if (bucketArray[hash] == null)
            {

                bucketArray[hash] = entry;
                Console.WriteLine("Initial key value pair added!");
            }
            else
            {

                Node current = bucketArray[hash];
                while (current.next != null)
                {
                    // Check if the key already exists 
                    if (current.getKey() == entry.getKey())
                    {

                        current.setValue(entry.getValue());
                        return;
                    }
                    current = current.next;
                }
                // When the code gets here current.next == null 
                // Insert the node 
                current.next = entry;
                Console.WriteLine("Initial key value pair added!");
            }
        }
        // ----------------------------- add method end ----------------------------------


        // ----------------------------------- get method start --------------------------------------s

        public String get(String key)
        {
            //get hash key
            char[] b = key.ToCharArray();
            int hash = 1;
            foreach (char a in b)
            {
                hash = (hash * Convert.ToInt32(a)) % BUCKET_ARRAY_SIZE;

            }

            Node n = bucketArray[hash];

            while (n != null)
            {
                if (n.getKey() == key)
                {
                    return n.getValue();
                }
                n = n.getNext();
            }
            // Not found? then return null 
            return null;
        }
        // -------------------------------get method end ---------------------------

        // ------------------- node for linked list start ---------------------------------s
        class Node
        {
            private String key;
            private String value;
            public Node next;

            public Node() { }

            public Node(String key, String value)
            {
                this.key = key;
                this.value = value;
            }

            public String getKey()
            {
                return key;
            }

            public void setKey(String key)
            {
                this.key = key;
            }

            public String getValue()
            {
                return value;
            }

            public void setValue(String value)
            {
                this.value = value;
            }

            public Node getNext()
            {
                return next;
            }

            public void setNext(Node next)
            {
                this.next = next;
            }
        }
    }

    // ----------------------- node for linked list end ----------------------------------


}
