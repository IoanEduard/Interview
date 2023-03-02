using _14.Trees.Interfaces;

namespace _14.Trees.Concrete.LeetCode
{
    public class LeetCodeTrees : LeetCodeTreesPrivateMethods, ILeetCodeTrees
    {
        // FAIL
        public int MaxDepth(TreeNode root, int countLeft = 0, int countRight = 0)
        {
            if (root == null) return 0;
            MaxDepth(root.left, countLeft++);
            MaxDepth(root.right, countRight++);

            return 0;
        }

        public int RangeSumBST(TreeNode root, int low, int high)
        {
            var stack = new Stack<TreeNode>();

            var sum = 0;
            stack.Push(root);

            while (stack.Count > 0)
            {
                var current = stack.Pop();
                sum += current.val >= low && current.val <= high ? current.val : 0;

                if (current.right != null) stack.Push(current.right);
                if (current.left != null) stack.Push(current.left);
            }

            return sum;
        }

        public int DeepestLeavesSum(TreeNode root)
        {
            var maxDeepestLeave = 0;

            var stack = new Stack<TreeNode>();
            var dict = new Dictionary<int, List<int>>();

            stack.Push(root);
            maxDeepestLeave++;

            while (stack.Count > 0)
            {
                var current = stack.Pop();

                if (dict.ContainsKey(current.val))
                {
                    if (current.right != null)
                    {
                        stack.Push(current.right);
                        dict[maxDeepestLeave].Add(current.val);
                    }

                    if (current.left != null)
                    {
                        stack.Push(current.left);
                        dict[maxDeepestLeave].Add(current.val);
                    }

                    maxDeepestLeave++;
                }
                else
                {
                    dict.Add(maxDeepestLeave, new List<int>() { current.val });
                }
            }

            return dict[maxDeepestLeave].Sum();
        }

        public IList<int> InorderTraversal(TreeNode root)
        {
            var list = new List<int>();
            if (root == null) return list;

            var stack = new Stack<TreeNode>();

            while (stack.Count > 0 || root != null)
            {
                while (root != null)
                {
                    stack.Push(root);
                    root = root.left;
                }

                root = stack.Pop();
                list.Add(root.val);
                root = root.right;
            }

            return list;
        }

        public IList<int> PreorderTraversal(TreeNode root)
        {
            // return PreOrderTraversalRecursive(root, new List<int>());
            return PreorderTraversalIterativeOptimized(root);
        }

        public IList<int> PostorderTraversal(TreeNode root)
        {
            return PostOrderTraversalRecursive(root, new List<int>());
        }


        public int[] SearchBST(TreeNode root, int val)
        {
            if (root == null)
                return new int[0];

            var result = new int[3];
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();
                if (current.val == val)
                {
                    result[0] = current.val;
                    result[1] = current.left.val;
                    result[2] = current.right.val;
                }

                if (current.left != null)
                    queue.Enqueue(current.left);

                if (current.right != null)
                    queue.Enqueue(current.right);
            }

            return result;
        }

    }
}