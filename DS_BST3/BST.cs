using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DS_BST3
{
    class BST
    {
        public Node root; // pointer to the root node
        public BST() { root = null; }

        // Method to insert a node into the BST
        public Node insert(Node p)
        {
            Node temp = root;
            //If the BST is empty or left and right are null, the new node being inserted will be the root
            if (temp == null)
            {
                root = p;
                return root;
            }
            while (true)
            {
                //going left
                if (p.num < temp.num) 
                {
                    if (temp.left == null)
                    {
                        temp.left = p;
                        break;
                    }
                    temp = temp.left;
                }
                //going right
                else 
                {
                    if (temp.right == null)
                    {
                        temp.right = p;
                        break;
                    }
                    temp = temp.right;
                }
            }
            return root;
        }

        //Method to print the nodes level by level
        public void levelOrder(Node root)
        {
            // If the root is null then there is nothing in the BST
            if (root == null) return;

            //Create an empty queue and insert the root into the queue
            Queue<Node> q = new Queue<Node>();
            q.Enqueue(root);
            while (true)
            {
                int node_count = q.Count;
                //If there aren't any nodes just break
                if (node_count == 0) break;

                //While there are nodes in the queue
                while (node_count > 0)
                {
                    //Node M will be the result of q.peek 
                    Node m = q.Peek();
                    Console.Write(m.num + " "); // display node m
                    q.Dequeue(); //dequeue the current q
                    if (m.left != null) 
                        q.Enqueue(m.left);
                    if (m.right != null)
                        q.Enqueue(m.right);
                    node_count--;
                }
                Console.WriteLine();
            }
        }

        public void displayPrime(Node p)
        {
            if (CheckPrime(p.num))
            {
                Console.Write(p.num + " ");
            }
            if (p.left != null)
            {
                displayPrime(p.left);
            }
            if (p.right != null)
            {
                displayPrime(p.right);
            }
            return;
        }

        public bool CheckPrime(int n)
        {
            Boolean prime = true;
            if (!(n <= 1))
            {
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if ((n % i) == 0)
                    {
                        prime = false;
                        break;
                    }
                }
                return prime;
            }
            return false;
        }
    }
}