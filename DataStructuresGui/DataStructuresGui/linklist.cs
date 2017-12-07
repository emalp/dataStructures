using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresGui
{
    class linklist
    {

        public Node starting;
        public int index = 0;
        public Node currentNodeGui;

        public linklist() {
            currentNodeGui = starting;
        }


        // This method will print all the nodes from the starting to the end
        public void getAll()
        {
            Node currentNode = starting;
            while (currentNode != null)
            {

                //Console.Write(currentNode.Value);
                if (currentNode.next == null)
                {

                }
                else
                {
                    //Console.Write(" -> ");
                }
                currentNode = currentNode.next;

            }
        }

        public Object getIndex(int index)
        {
            int initial = 1;
            Node currentNode = starting;
            currentNode = starting;

            while (initial != index)
            {
                initial++;
                if (currentNode.next == null)
                {
                    break;
                }
                else
                {
                    //Console.Write(" -> ");
                    currentNode = currentNode.next;
                }
               
            }
            return currentNode.Value;
            //Console.WriteLine(currentNode.Value);

        }


        public void add(Object valueToAdd)
        {

            if (starting == null)
            {
                starting = new Node();
                starting.Value = valueToAdd;
                index++;
                starting.next = null;

            }
            else
            {
                Node lastNode = new Node();
                lastNode.Value = valueToAdd;

                Node initial = starting;
                while (initial.next != null)
                {
                    initial = initial.next;

                }
                initial.next = lastNode;
                initial.next.next = null;

            }

        }



        public void removeNode(int position)
        {

            if (starting == null)
                return;


            Node temp = starting;

            // If head needs to be removed
            if (position == 0)
            {
                starting = temp.next;   // Change head
                return;
            }

            // Find previous node of the node to be deleted
            for (int i = 0; temp != null && i < position - 1; i++)
                temp = temp.next;

            // If position is more than number of ndoes
            if (temp == null || temp.next == null)
                return;

            // node temp->next is the node to be deleted
            Node last = temp.next.next;

            temp.next = last;  // dechain the deleted node from list
        }

        public void sort()
        {
            Node iterator = new Node();
            Node mainIterator = new Node();
            mainIterator = starting;
            iterator = starting;




            while (mainIterator.next != null)
            {
                iterator = starting;
                while (iterator.next != null)
                {
                    if (Convert.ToInt32(iterator.Value) > Convert.ToInt32(iterator.next.Value))
                    {
                        int temp = Convert.ToInt32(iterator.Value);
                        iterator.Value = iterator.next.Value;
                        iterator.next.Value = temp;

                        iterator = iterator.next;

                    }
                    else
                    {
                        iterator = iterator.next;
                    }
                }
                mainIterator = mainIterator.next;
            }


        }
        // This is the place for returning graph values.

        public Object getIndexGui(int inival,  int index)
        {
            int initial = inival;
            //currentNodeGui = starting;

            while (initial != index)
            {
                initial++;
                if (starting.next == null)
                {
                    break;
                }
                else
                {
                    //Console.Write(" -> ");
                    starting = starting.next;
                }

            }
            return starting.Value;
            //Console.WriteLine(currentNode.Value);

        }


    }


    class Node
    {
        public Node next;
        public Object Value;

    }
}
