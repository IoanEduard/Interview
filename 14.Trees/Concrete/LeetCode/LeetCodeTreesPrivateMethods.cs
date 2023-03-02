namespace _14.Trees.Concrete.LeetCode
{
    public class LeetCodeTreesPrivateMethods
    {
        protected IList<int> PreOrderTraversalRecursive(TreeNode root, IList<int> result)
        {
            if (root == null) return result;

            result.Add(root.val);
            result = PreOrderTraversalRecursive(root.left, result);
            result = PreOrderTraversalRecursive(root.right, result);

            return result;
        }

        protected IList<int> PreorderTraversalIterativeOptimized(TreeNode root)
        {
            var list = new List<int>();
            if (root == null) return list;
            var stack = new Stack<TreeNode>();

            while (stack.Count > 0 || root != null)
            {
                while (root != null)
                {
                    list.Add(root.val);

                    if (root.right != null)
                        stack.Push(root.right);

                    root = root.left;
                }

                if (stack.Count > 0)
                    root = stack.Pop();
            }

            return list;
        }

        protected IList<int> PostOrderTraversalRecursive(TreeNode node, IList<int> result)
        {
            if (node == null)
                return result;

            result = PostOrderTraversalRecursive(node.left, result);
            result = PostOrderTraversalRecursive(node.right, result);
            result.Add(node.val);

            return result;
        }
    }
}