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

        public int MaxDepth(TreeNode root)
        {
            if (root == null) return 0;

            var maxDepthLeft = MaxDepth(root.left);
            var maxDepthRight = MaxDepth(root.right);

            return Math.Max(maxDepthLeft + 1, maxDepthRight + 1);
        }
        public int MaxDepthIterative(TreeNode root)
        {
            if (root == null) return 0;
            var count = 0;

            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (true)
            {
                var countNodes = queue.Count;
                if (countNodes == 0)
                    return count;

                count++;

                while (countNodes > 0)
                {
                    var current = queue.Dequeue();

                    if (current.left != null)
                        queue.Enqueue(current.left);

                    if (current.right != null)
                        queue.Enqueue(current.right);

                    countNodes--;
                }
            }
        }

        public int MinDepth(TreeNode root)
        {
            if (root == null) return 0;
            var count = 0;

            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (true)
            {
                var countNodes = queue.Count;
                if (countNodes == 0)
                    return count;

                count++;

                while (countNodes > 0)
                {
                    var current = queue.Dequeue();

                    if (current.left == null && current.right == null)
                        return count;

                    if (current.left != null)
                        queue.Enqueue(current.left);

                    if (current.right != null)
                        queue.Enqueue(current.right);

                    countNodes--;
                }
            }
        }

        public int MinDepthRecursive(TreeNode root)
        {
            if (root == null) return 0;
            if (root.left != null) return MinDepthRecursive(root.right) + 1;
            if (root.right != null) return MinDepthRecursive(root.left) + 1;

            return Math.Min(MinDepthRecursive(root.left), MinDepthRecursive(root.right)) + 1;
        }

        public bool IsUnivalTree(TreeNode root)
        {
            if (root == null) return true;

            var value = root.val;
            var stack = new Stack<TreeNode>();

            while (root != null || stack.Count > 0)
            {
                while (root != null)
                {
                    if (value != root.val) return false;

                    stack.Push(root);
                    root = root.left;
                }

                root = stack.Pop();
                root = root.right;
            }

            return true;
        }

        public bool IsUnivalTreeRecursive(TreeNode root)
        {
            return IsUnivalTreeRecursiveSolution(root, root.val);
        }

        private bool IsUnivalTreeRecursiveSolution(TreeNode root, int val)
        {
            if (root == null) return true;
            if (root.val != val) return false;

            return IsUnivalTreeRecursiveSolution(root.left, val) && IsUnivalTreeRecursiveSolution(root.right, val);
        }

        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == null && q == null) return true;
            if (p == null || q == null) return false;

            return p.val == q.val && IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
        }

        public bool IsSameTreeIterative(TreeNode p, TreeNode q)
        {
            if (p == null && q == null) return true;
            if (p == null || q == null) return false;

            var stackP = new Stack<TreeNode>();
            var stackQ = new Stack<TreeNode>();

            stackP.Push(p);
            stackQ.Push(q);

            while (stackP.Count > 0 && stackQ.Count > 0)
            {
                var currentP = stackP.Pop();
                var currentQ = stackQ.Pop();

                if (currentP.val != currentQ.val) return false;

                if (currentP.left != null) stackP.Push(currentP.left);
                if (currentQ.left != null) stackQ.Push(currentQ.left);

                if (stackP.Count != stackQ.Count) return false;

                if (currentP.right != null) stackP.Push(currentP.right);
                if (currentQ.right != null) stackQ.Push(currentQ.right);

                if (stackP.Count != stackQ.Count) return false;
            }

            return true;
        }

        public bool IsSameTreeIterativeEfficient(TreeNode p, TreeNode q)
        {
            var stack = new Stack<TreeNode>();
            stack.Push(p);
            stack.Push(q);

            while (stack.Count > 0)
            {
                p = stack.Pop();
                q = stack.Pop();

                if (p == null || q == null) return false;
                if (p.val != q.val) return false;
                else
                {
                    stack.Push(p.left);
                    stack.Push(q.left);
                    stack.Push(p.right);
                    stack.Push(q.right);
                }
            }

            return true;
        }

        public TreeNode AddOneRow(TreeNode root, int val, int depth)
        {
            if (depth == 1)
                return new TreeNode(val, root, null);

            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            var currentDepth = 1;

            while (queue.Count > 0)
            {
                if (currentDepth == depth - 1) break;

                var queueCount = queue.Count;

                for (var i = 0; i < queueCount; i++)
                {
                    var temp = queue.Dequeue();
                    if (temp.left != null)
                        queue.Enqueue(temp.left);

                    if (temp.right != null)
                        queue.Enqueue(temp.right);
                }

                currentDepth++;
            }

            foreach (var node in queue)
            {
                var leftNode = node.left;
                node.left = new TreeNode(val, leftNode, null);

                var rightNode = node.right;
                node.right = new TreeNode(val, null, rightNode);
            }

            return root;
        }

        public TreeNode AddOneRowRecursive(TreeNode root, int val, int depth)
        {
            if (depth == 1) return new TreeNode(val, root, null);

            DFSInsert(root, val, depth, 1);
            return root;
        }

        private void DFSInsert(TreeNode root, int val, int depth, int currentDepth)
        {
            if (root == null) return;

            if (depth == currentDepth + 1)
            {
                root.left = new TreeNode(val, root.left, null);
                root.right = new TreeNode(val, null, root.right);
            }
            else
            {
                DFSInsert(root.left, val, depth, currentDepth + 1);
                DFSInsert(root.right, val, depth, currentDepth + 1);
            }
        }

        public bool IsValidBST(TreeNode root)
        {
            var list = new List<int>();
            InOrder(root, list);

            for (var i = 1; i < list.Count; i++)
            {
                if (list[i - 1] > list[i])
                {
                    return false;
                }
            }

            return true;
        }

        private void InOrder(TreeNode node, List<int> nodes)
        {
            if (node == null) return;

            InOrder(node.left, nodes);
            nodes.Add(node.val);
            InOrder(node.right, nodes);
        }

        public bool IsValidBST2(TreeNode root)
        {
            return IsValidBST2DFS(root, long.MinValue, long.MaxValue);
        }

        private bool IsValidBST2DFS(TreeNode root, long min, long max)
        {
            if (root == null) return true;
            if (min < root.val && root.val < max)
            {
                var left = IsValidBST2DFS(root.left, min, root.val);
                var right = IsValidBST2DFS(root.left, root.val, max);

                if (left && right)
                    return true;
            }

            return false;
        }

        public bool IsValidBST3(TreeNode root)
        {
            return IsValidBST3DFS(root, null, null);
        }

        private bool IsValidBST3DFS(TreeNode root, TreeNode min, TreeNode max)
        {
            if (root == null) return true;

            if ((max != null && root.val >= max.val) || (min != null && root.val <= min.val))
                return false;

            return IsValidBST3DFS(root.left, min, root) && IsValidBST3DFS(root.right, root, max);
        }

    }
}