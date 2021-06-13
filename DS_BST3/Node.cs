using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_BST3
{
    class Node
    {
        public Node right;
        public Node left;
        public int num;

        public Node(int num)
        {
            this.num = num;
            left = null;
            right = null;
        }
    }
}