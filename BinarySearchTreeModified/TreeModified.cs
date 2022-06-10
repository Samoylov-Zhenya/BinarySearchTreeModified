using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeModified
{
    class TreeModified<T>
        where T : IComparable, IComparable<T>
    {
        public NodeModified<T> Root { get; private set; }
        public int Count { get; private set; }

        /// <summary>
        /// Delete an element.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public bool Del(T data)
        {
            if (Root == null)
            {
                Root = new NodeModified<T>(data);
                Count = 1;
                return false;
            }
            if (Root.Delete(data))
                --Count;

            return true;
        }
        /// <summary>
        /// Add an element
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public bool Add(T data)
        {
            if (Root == null)
            {
                Root = new NodeModified<T>(data);
                Count = 1;
                return false;
            }

            Root.Add(data);
            Count++;

            return true;
        }

        /// <summary>
        /// Sorted list without repetition
        /// </summary>
        /// <returns></returns>
        public List<T> InorderT()
        {
            if (Root == null)
            {
                return new List<T>();
            }

            return InorderT(Root);
        }

        private List<T> InorderT(NodeModified<T> node)
        {
            var list = new List<T>();
            if (node != null)
            {
                if (node.Left != null)
                {
                    list.AddRange(InorderT(node.Left));
                }
                list.Add(node.Key);
                if (node.Right != null)
                {
                    list.AddRange(InorderT(node.Right));
                }
            }

            return list;
        }

        /// <summary>
        /// Sorted list key and count
        /// </summary>
        /// <returns></returns>
        public List<NodeModified<T>> InorderNode()
        {
            if (Root == null)
            {
                return new List<NodeModified<T>>();
            }
            return InorderNode(Root);
        }

        private List<NodeModified<T>> InorderNode(NodeModified<T> node)
        {
            var list = new List<NodeModified<T>>();
            if (node != null)
            {
                if (node.Left != null)
                {
                    list.AddRange(InorderNode(node.Left));
                }
                list.Add(node);
                if (node.Right != null)
                {
                    list.AddRange(InorderNode(node.Right));
                }
            }
            return list;
        }

        /// <summary>
        /// Sorted array with repeating elements
        /// </summary>
        /// <returns></returns>
        public List<T> InorderTArray()
        {

            if (Root == null)
            {
                return new List<T>();
            }
            return InorderTArray(Root);
        }

        private List<T> InorderTArray(NodeModified<T> node)
        {
            var list = new List<T>();
            if (node != null)
            {
                if (node.Left != null)
                {
                    list.AddRange(InorderTArray(node.Left));
                }
                for (int i = 0; i < node.Count; i++)
                {
                    list.Add(node.Key);
                }
                if (node.Right != null)
                {
                    list.AddRange(InorderTArray(node.Right));
                }
            }
            return list;
        }
    }
}