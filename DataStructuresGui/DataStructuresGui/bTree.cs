using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresGui
{
    class bTree
    {
        
        binaryNode root = new binaryNode();
        binaryNode tempNode = new binaryNode();
        binaryNode tempm1 = new binaryNode();

        public int totalNodesgui = 1;  // recorded when used get command
        public List<int> allvalsgui = new List<int>(); //recorded when used get command


        // --------------------add method start ------------------------------------------------------------
        public Boolean add(Object data)
        {
            Boolean val = false;
            if (data == null)
            {
                Console.WriteLine("Can't enter null as data!");
                val = false;              
                return val;               
            }
            else
            {

                try
                {

                    if (root.val == null)
                    {

                        root.val = data;
                        root.left = null;
                        root.right = null;
                        root.parent = null;
                        Console.WriteLine("Element added at root." + root.val);
                        val = true;
                    }
                    else
                    {

                        binaryNode beingAddedNode = new binaryNode();
                        beingAddedNode.val = data;

                        //binaryNode tempNode = new binaryNode();
                        tempNode = root;
                        int mainValue = Convert.ToInt32(tempNode.val);

                        binaryNode tempm1 = new binaryNode();
                        tempm1 = tempNode;

                        int tempValue = Convert.ToInt32(root.val);
                        int beingAddedValue = Convert.ToInt32(beingAddedNode.val);

                        // check for where to add the value, i.e left, right or already present
                        while (true)
                        {

                            if (beingAddedValue < mainValue)
                            {
                                tempm1 = tempNode;
                                tempNode = tempNode.left;

                                if (tempNode == null)
                                {
                                    tempm1.left = beingAddedNode;
                                    beingAddedNode.parent = tempm1;
                                    Console.WriteLine(beingAddedNode.val + " added to tree at Left from parent.");
                                    Console.WriteLine("Parent : " + beingAddedNode.parent.val);
                                    val = true;
                                    break;
                                }

                                mainValue = Convert.ToInt32(tempNode.val);

                            }
                            else if (beingAddedValue == mainValue)
                            {
                                Console.WriteLine("The value you've tried to add is already present in the tree.");
                                val = false;
                                break;
                            }
                            else
                            {
                                tempm1 = tempNode;
                                tempNode = tempNode.right;

                                if (tempNode == null)
                                {
                                    tempm1.right = beingAddedNode;
                                    beingAddedNode.parent = tempm1;
                                    Console.WriteLine(beingAddedNode.val + " added to tree at Right from parent.");
                                    Console.WriteLine("Parent : " + beingAddedNode.parent.val);
                                    val = true;
                                    break;
                                   
                                }

                                mainValue = Convert.ToInt32(tempNode.val);

                            }


                        } // While true ends here.
                        return val;
                    }


                } // main try ends here.

                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                return val;
            } // Main if(data == null) ends here.


        } // Add Method ends here.
        // ------------------add method end. ----------------------------------------------------------


        // ----------------- get method start -----------------------------------------------------------

        public void Get(Object val)
        { // get method starts.
            allvalsgui.Add(Convert.ToInt32(root.val));

            try
            {
                // check for null value
                if (val == null)
                {
                    Console.WriteLine("Cant get a null value!");

                }
                else
                {

                    int searchingVal = Convert.ToInt32(val);


                    tempNode = root;
                    tempm1 = tempNode;
                    int mainValue = Convert.ToInt32(tempNode.val);

                    // infinite loop to check which to get i.e jumps along branches until the required value is found
                    while (true)
                    {

                        if (searchingVal < mainValue)
                        {
                            tempm1 = tempNode;
                            tempNode = tempNode.left;

                            if (tempNode == null)
                            {
                                Console.WriteLine("VALUE NOT FOUND.");
                                break;
                            }

                            totalNodesgui++; // only for task3 gui
                            allvalsgui.Add(Convert.ToInt32(tempNode.val)); // this is only for gui

                            mainValue = Convert.ToInt32(tempNode.val);

                        }
                        else if (searchingVal == mainValue)
                        {
                            totalNodesgui++;
                            allvalsgui.Add(Convert.ToInt32(tempNode.val));

                            String leftVal;
                            String rightVal;
                            String parentVal;

                            if (tempNode.left == null)
                            {
                                leftVal = "NULL";
                            }
                            else
                            {
                                leftVal = Convert.ToString(tempNode.left.val);
                            }

                            if (tempNode.right == null)
                            {
                                rightVal = "NULL";

                            }
                            else
                            {
                                rightVal = Convert.ToString(tempNode.right.val);
                            }

                            if (tempNode.parent == null)
                            {
                                parentVal = "NULL";
                            }
                            else
                            {
                                parentVal = Convert.ToString(tempNode.parent.val);
                            }


                            Console.WriteLine("VALUE FOUND!!");
                            Console.WriteLine(mainValue);
                            Console.WriteLine("Node value: " + tempNode.val);
                            Console.WriteLine("Left of Node: " + leftVal);
                            Console.WriteLine("Right of Node : " + rightVal);
                            Console.WriteLine("Node's parent: " + parentVal);
                            break;


                        }
                        else
                        {
                            tempm1 = tempNode;
                            tempNode = tempNode.right;

                            if (tempNode == null)
                            {
                                Console.WriteLine("VALUE NOT FOUND.");
                                break;
                            }
                            totalNodesgui++;
                            allvalsgui.Add(Convert.ToInt32(tempNode.val));
                            mainValue = Convert.ToInt32(tempNode.val);
                        }


                    } // while true ends here.
                }


            } // Main try ends here.
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }


        } // GET method ends here.
          // ----------------------------------- get method end ------------------------------


        // ---------------------------------Remove method start ----------------------------------------------
        public void remove(Object val)
        {
            try
            {
                // remove method utilizes the get method for searching..

                if (val == null)
                {
                    Console.WriteLine("Can't remove a null value.");
                }
                else
                {
                    this.Get(val);

                    //Removing a leaf node.
                    if (tempNode.left == null && tempNode.right == null)
                    {

                        tempNode.parent = null;
                        if (Convert.ToInt32(val) < Convert.ToInt32(tempm1.val))
                        {
                            tempm1.left = null;



                        }
                        else
                        {
                            tempm1.right = null;
                        }

                        Console.WriteLine("Leaf Node deleted.");

                    } // Leaf node removed.

                    else if ((tempNode.left == null && tempNode.right != null) || (tempNode.left != null & tempNode.right == null))
                    {

                        // Removing node with only one child.

                        binaryNode fighterNode = new binaryNode();

                        if (tempNode.left != null)
                        {
                            fighterNode = tempNode.left;
                        }
                        else
                        {
                            fighterNode = tempNode.right;
                        }

                        if (Convert.ToInt32(tempNode.val) < Convert.ToInt32(tempm1.val))
                        {
                            tempm1.left = fighterNode;
                        }
                        else
                        {
                            tempm1.right = fighterNode;
                        }

                        fighterNode.parent = tempm1;

                        Console.WriteLine("Node with one child deleted.");

                    } // Node with only one child deleted!.

                    else
                    {

                        // both right and left children are present.

                        // deleting a full fledged node.

                        binaryNode checkNode = new binaryNode();
                        binaryNode tNode = new binaryNode();
                        tNode = tempNode;
                        checkNode = tempNode;

                        if (Convert.ToInt32(val) < Convert.ToInt32(root.val))
                        {
                            checkNode = tempNode.left; // there is surely some value at checkNode. and as it's left, go left first and only then right.
                            while (true)
                            {

                                if (checkNode.right == null)
                                {

                                    Console.WriteLine("Node " + tempNode.val + " removing..");
                                    remove(checkNode.val);
                                    tNode.val = checkNode.val;
                                    Console.WriteLine("Complete Node deleted!");
                                    break;
                                }
                                else
                                {
                                    checkNode = checkNode.right;
                                }

                            }
                        }
                        else
                        {
                            checkNode = tempNode.right;
                            while (true)
                            {

                                if (checkNode.left == null)
                                {

                                    Console.WriteLine("Node " + tempNode.val + " removing..");
                                    remove(checkNode.val);
                                    tNode.val = checkNode.val;
                                    Console.WriteLine("Complete Node deleted!");
                                    break;
                                }
                                else
                                {
                                    checkNode = checkNode.left;
                                }

                            }

                        }

                    }

                }


            } // Main try end.
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }


        } // Remove method end..

        // ----------------------------------- Remove method end -------------------------------------------------




    } // main binary tree class end.



    class binaryNode
    {

        public binaryNode left;
        public binaryNode right;
        public Object val;
        public binaryNode parent;

    }
}
