using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_22_Binary_Search_Trees
{
    class Node
    {
        public Node left, right;
        public int data;

        public Node(int data)
        {
            this.data = data;
            left = right = null;
        }
    }
    class Program
    {
        static int getHeight(Node root)
        { 
            if (root == null)
            {
                return -1;
            } else
            {
                int left = getHeight(root.left);
                int right = getHeight(root.right);
                
                if (left > right)
                {
                    return 1+left;
                } else
                {
                    return 1+right;
                }

            }
        }

        static Node insert(Node root, int data)
        {
            if (root == null)
            {
                return new Node(data);
            }
            else
            {
                Node cur;
                if (data <= root.data)
                {
                    cur = insert(root.left, data);
                    root.left = cur;
                }
                else
                {
                    cur = insert(root.right, data);
                    root.right = cur;
                }
                return root;
            }
        }

        static void Main(String[] args)
        {
            Node root = null;
            int T = int.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = int.Parse(Console.ReadLine());
                root = insert(root, data);
            }
            int height = getHeight(root);
            Console.WriteLine(height);
            Console.Read();
        }
    }
}
