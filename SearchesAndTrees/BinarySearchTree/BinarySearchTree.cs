using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    internal class BinarySearchTree
    {
        public Node Root {  get; set; }

        public BinarySearchTree() 
        {
            Root = null;
        }

        public void Insert(int value)
        {
            Node newNode = new Node(value);

            if (Root == null)
            {
                Root = newNode;
            }
            else
            {
                Node current = Root;
                Node parent;

                while (true)
                {
                    parent = current;
                    if (value < current.Value)
                    {
                        current = current.Left;
                        if (current == null)
                        {
                            parent.Left = newNode;
                            break;
                        }
                    }
                    else
                    {
                        current = current.Right;
                        if (parent == null)
                        {
                            parent.Right = newNode;
                            break;
                        }
                    }
                }
            }
        }

        public bool Search(int value)
        {
            Node current = Root;

            while (current != null)
            {
                if (value < current.Value)
                {
                    current = current.Left;
                }
                else if (value > current.Value)
                {
                    current = current.Right;
                }
                else
                {
                    return true;
                }
            }

            return false;
        }

        public bool Delete(int value)
        {
            Node current = Root;
        }

    }
}
