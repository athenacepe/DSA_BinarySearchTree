using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace DS_BST3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Insert the contents of the three files into the string arrays
                string[] lines1 = System.IO.File.ReadAllLines(@"C:\Users\athen\Desktop\assignment 3\file4.txt");
                string[] lines2 = System.IO.File.ReadAllLines(@"C:\Users\athen\Desktop\assignment 3\file2.txt");
                string[] lines3 = System.IO.File.ReadAllLines(@"C:\Users\athen\Desktop\assignment 3\file3.txt");


                //Convert the string arrays into int arrays
                int[] ints1 = Array.ConvertAll(lines1, int.Parse);
                int[] ints2 = Array.ConvertAll(lines2, int.Parse);
                int[] ints3 = Array.ConvertAll(lines3, int.Parse);


                //Create 3 binary search trees
                BST treeA = new BST();
                BST treeB = new BST();
                BST treeC = new BST();


                //Create for loops that will insert the contents of the int array into a corresponding BST
                for (int i = 0; i < ints1.Length; i++)
                {
                    Node p = new Node(ints1[i]);
                    treeA.insert(p);
                }

                for (int i = 0; i < ints2.Length; i++)
                {
                    Node p = new Node(ints2[i]);
                    treeB.insert(p);
                }

                for (int i = 0; i < ints3.Length; i++)
                {
                    Node p = new Node(ints3[i]);
                    treeC.insert(p);
                }


                //Output for tree A
                Console.WriteLine("---------- Details for Binary Search Tree A ----------");
                Console.Write("Numbers in tree A level by level: \n"); treeA.levelOrder(treeA.root);
                Console.Write("\nPrime Numbers in tree A: "); treeA.displayPrime(treeA.root);


                //Output for tree B
                Console.WriteLine("\n\n---------- Details for Binary Search Tree B ----------");
                Console.Write("Numbers in tree B level by level: \n"); treeB.levelOrder(treeB.root);
                Console.Write("\nPrime Numbers in tree B: "); treeB.displayPrime(treeB.root);


                //Output for tree C
                Console.WriteLine("\n\n---------- Details for Binary Search Tree C ----------");
                Console.Write("Numbers in tree C level by level: \n"); treeC.levelOrder(treeC.root);
                Console.Write("\nPrime Numbers in tree C: "); treeC.displayPrime(treeC.root);
                

                Console.WriteLine("\n\nPress any key to continue...");
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("Error.");
                Console.ReadKey();
            }
        }
    }
}