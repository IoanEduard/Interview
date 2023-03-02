using System.Collections;

namespace _14.Trees.Concrete.Documentation.IEnumerable_DFS
{
    public class TreeNodePreOrder<T> : IEnumerable<T>
    {
        public T val;
        public TreeNodePreOrder<T> left;
        public TreeNodePreOrder<T> right;
        public TreeNodePreOrder(T val, TreeNodePreOrder<T> left = null, TreeNodePreOrder<T> right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }

        public IEnumerator<T> GetEnumerator()
        {
            yield return val;

            if (left != null)
            {
                foreach (var child in left)
                    yield return child;
            }

            if (right != null)
            {
                foreach (var child in right)
                    yield return child;
            }

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}