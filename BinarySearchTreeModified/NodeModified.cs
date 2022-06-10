using System;

namespace BinarySearchTreeModified
{
    class NodeModified<T> : IComparable<T>, IComparable
        where T : IComparable, IComparable<T>
    {
        public T Key { get; private set; }
        public int Count { get; private set; }
        public NodeModified<T> Left { get; private set; }
        public NodeModified<T> Right { get; private set; }

        #region Constructors
        public NodeModified(T data)
        {
            Key = data;
            Count = 1;
        }

        public NodeModified(T data, NodeModified<T> left, NodeModified<T> right)
        {
            Key = data;
            Left = left;
            Right = right;
            Count = 1;
        }
        
        #endregion

        #region IComparable

        public int CompareTo(object obj)
        {
            if (obj is NodeModified<T> item)
                return Key.CompareTo(item);
            else
                throw new ArgumentException("Type mismatch");
        }
        public int CompareTo(T other)
        {
            return Key.CompareTo(other);
        }
       
        #endregion
       
        /// <summary>
        /// Delete an element
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public bool Delete(T data)
        {
            var node = new NodeModified<T>(data);

            if (node.Key.CompareTo(Key) == -1)
            {
                if (Left == null)
                {
                    Left = node;
                }
                else
                {
                    Left.Delete(data);
                }
            }
            else if (node.Key.CompareTo(Key) == 1)
            {
                if (Right == null)
                {
                    Right = node;
                }
                else
                {
                    Right.Delete(data);
                }
            }
            else
            {
                if (Count == 0)
                    return false;
                --Count;
                return true;
            }
            return false;
        }
        /// <summary>
        /// Add an element
        /// </summary>
        /// <param name="data"></param>
        public void Add(T data)
        {
            var node = new NodeModified<T>(data);

            if (node.Key.CompareTo(Key) == -1)
            {
                if (Left == null)
                {
                    Left = node;
                }
                else
                {
                    Left.Add(data);
                }
            }
            else if (node.Key.CompareTo(Key) == 1)
            {
                if (Right == null)
                {
                    Right = node;
                }
                else
                {
                    Right.Add(data);
                }
            }
            else
            {
                ++Count;
            }
        }

        public override string ToString()
        {
            return Key.ToString() + "\t" + Count + "\n";
        }
    }
}
