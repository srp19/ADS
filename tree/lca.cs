using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADS.tree
{
    public class LCAInBST
    {
        public class TreeNode
        {
            public TreeNode left { get; set; }
            public TreeNode right { get; set;  }
            public int value { get; set;  }

            public TreeNode(int value)
            {
                this.value = value;
            }
        }

        TreeNode root;

        /*
                                5
                          2           6
                       0     3            9
                         1             7
                                         8

        */
        private TreeNode createBST()
        {
            TreeNode n0 = new TreeNode(0);
            TreeNode n1 = new TreeNode(1);
            TreeNode n2 = new TreeNode(2);
            TreeNode n3 = new TreeNode(3);
            TreeNode n5 = new TreeNode(5);
            TreeNode n6 = new TreeNode(6);
            TreeNode n7 = new TreeNode(7);
            TreeNode n8 = new TreeNode(8);
            TreeNode n9 = new TreeNode(9);

            this.root = n5;

            root.left = n2;
            root.right = n6;

            n2.left = n0;
            n2.right = n3;

            n6.right = n9;

            n0.right = n1;
            n9.left = n7;

            n7.right = n8;

            return root;
        }

        // finds and returns node with given value in BST
        private TreeNode findNode(TreeNode root, int value)
        {
            if (root == null)
            {
                return null;
            }

            if (value == root.value)
            {
                return root;
            }

            if (value < root.value)
            {
                return findNode(root.left, value);
            }
            else
            {
                return findNode(root.right, value);
            }
        }


        // the sub-routine that actually finds LCA node for nodes n1 and n2
        private TreeNode findLCA(TreeNode currentNode, TreeNode n1, TreeNode n2)
        {
            if (currentNode == null)
            {
                return null;
            }

            // before calling this sub-routine, we have made sure that n1.value <= n2.value
            // check if currentNode is the LCA for n1 and n2
            if ((n1.value < currentNode.value) && (currentNode.value < n2.value))
            {
                return currentNode;
            }
            else if ((n1.value == currentNode.value) || (currentNode.value == n2.value))
            {
                return currentNode;
            }

            // if currentNode is not the LCA for n1 and n2
            TreeNode lcaNode;

            if (n2.value < currentNode.value) // both n1 and n2 are in the left sub-tree of currentNode
            {
                lcaNode = findLCA(currentNode.left, n1, n2);
            }
            else // both n1 and n2 are in the right sub-tree of currentNode
            {
                lcaNode = findLCA(currentNode.right, n1, n2);
            }

            return lcaNode;
        }


        // this sub-routine that is entry point for clients and this in turn calls- 
        // findLCA(TreeNode currentNode, TreeNode n1, TreeNode n2) 
        public int findLCA(int value1, int value2)
        {
            // make sure that value1 is always less than or equal to value2 
            if (value2 < value1)
            {
                int temp = value1;
                value1 = value2;
                value2 = temp;
            }

            // find node corresponding to value1
            TreeNode n1 = findNode(root, value1);

            if (n1 != null)
            {
                // find node corresponding to value2
                TreeNode n2 = findNode(root, value2);

                // find LCA for these nodes
                if (n2 != null)
                {
                    TreeNode lcaNode = findLCA(root, n1, n2);
                    return lcaNode.value;
                }
            }

            // if either n1 or n2 is not found
            return -1;
        }


        public static void Main()
        {
            LCAInBST solution = new LCAInBST();

            /*
                                    5
                              2           6
                           0     3            9
                             1             7
                                             8

            */
            solution.createBST();

            Console.WriteLine(solution.findLCA(7, 8));
        }
    }
}
