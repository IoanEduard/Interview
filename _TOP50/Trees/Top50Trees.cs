using _14.Trees.Concrete;
using _TOP50.Trees.Interfaces;

namespace _TOP50.Trees
{
    public class Top50Trees : Top50UtilityMethods, ITop50TreesProblems
    {
        public int MaximumDepthOrHeightOfATree(TreeNode tree)
        {
            if (tree == null)
                return 0;

            var leftMax = MaximumDepthOrHeightOfATree(tree.left);
            var rightMax = MaximumDepthOrHeightOfATree(tree.right);

            return Math.Max(leftMax, rightMax) + 1;
        }

        public int MaximumDepthOrHeightOfATreeIterative(TreeNode treeNode)
        {
            if (treeNode == null) return 0;

            var queue = new Queue<TreeNode>();
            queue.Enqueue(treeNode);

            var level = 0;

            while (queue.Count > 0)
            {
                var queueSize = queue.Count;
                if (queueSize == 0) return level;

                while (queueSize-- > 0)
                {
                    var deq = queue.Dequeue();

                    if (deq.left != null) queue.Enqueue(deq.left);
                    if (deq.right != null) queue.Enqueue(deq.right);
                }

                level++;
            }

            return level;
        }

        public int MaximumDepthOrHeightOfATreeIterative2(TreeNode treeNode)
        {
            var depth = 0;
            var queue = new Queue<TreeNode>();

            queue.Enqueue(treeNode);

            while (queue.Count != 0)
            {
                var levelSize = queue.Count;
                while (levelSize-- != 0)
                {
                    var node = queue.Dequeue();
                    if (node != null)
                    {
                        if (node.left != null) queue.Enqueue(node.left);
                        if (node.right != null) queue.Enqueue(node.right);
                    }
                }

                depth++;
            }

            return depth;
        }

        public int MaximumDepthOrHeightOfATreeIterative3(TreeNode treeNode)
        {
            var height = 0;
            var queue = new Queue<TreeNode>();

            queue.Enqueue(treeNode);

            while (queue.Count != 0)
            {
                var queueSize = queue.Count;

                for (var i = 0; i < queueSize; i++)
                {
                    var node = queue.Dequeue();

                    if (node.left != null) queue.Enqueue(node.left);
                    if (node.right != null) queue.Enqueue(node.right);
                }

                height++;
            }

            return height;
        }

        public bool IdenticalTrees(TreeNode a, TreeNode b)
        {
            if (a == null && b == null)
                return true;

            if (a == null || b == null)
                return false;

            return a.val == b.val && IdenticalTrees(a.left, b.left) && IdenticalTrees(a.right, b.right);
        }

        public bool IdenticalTrees2(TreeNode a, TreeNode b)
        {
            if (a == null && b == null)
                return true;

            if (a != null && b != null)
                return IdenticalTrees(a.left, b.left) && IdenticalTrees(a.right, b.right);

            return false;
        }

        public bool IdenticalTreesComparingTraversals(TreeNode a, TreeNode b)
        {
            var listA = new List<int>();
            var listB = new List<int>();

            Inorder(a, listA);
            Inorder(b, listB);
            if (!listA.SequenceEqual(listB))
                return false;

            ClearLists(listA, listB);

            PreOrder(a, listA);
            PreOrder(b, listB);
            if (!listA.SequenceEqual(listB))
                return false;

            ClearLists(listA, listB);

            PostOrder(a, listA);
            PostOrder(b, listB);
            if (!listA.SequenceEqual(listB))
                return false;

            ClearLists(listA, listB);

            return true;
        }

        public bool IndenticalTreesUsingPreorder(TreeNode a, TreeNode b)
        {
            var listA = new List<int>();
            var listB = new List<int>();

            PreorderForIdenticalTrees(a, listA);
            PreorderForIdenticalTrees(b, listB);

            return listA.SequenceEqual(listB);
        }

        public bool IndenticalTreesLevelOrderTraversal(TreeNode a, TreeNode b)
        {
            if (a == null && b == null) return true;
            if (a == null || b == null) return false;

            var queueA = new Queue<TreeNode>();
            var queueB = new Queue<TreeNode>();

            while (queueA.Count != 0 && queueB.Count != 0)
            {
                var nodeA = queueA.Dequeue();
                var nodeB = queueB.Dequeue();

                if (nodeA.val != nodeB.val) return false;
                if (nodeA.left != null && nodeB.left == null) return false;
                if (nodeA.left == null && nodeB.left != null) return false;

                if (nodeA.right != null && nodeB.right == null) return false;
                if (nodeA.right == null && nodeB.right != null) return false;

                if (nodeA.left != null && nodeB.left != null)
                {
                    queueA.Enqueue(nodeA.left);
                    queueB.Enqueue(nodeB.left);
                }

                if (nodeA.right != null && nodeB.right != null)
                {
                    queueA.Enqueue(nodeA.right);
                    queueB.Enqueue(nodeB.right);
                }
            }

            return true;
        }

        public TreeNode MirrorTree(TreeNode tree)
        {
            if (tree == null)
                return tree!;

            var leftTree = MirrorTree(tree.left);
            var rightTree = MirrorTree(tree.right);

            tree.left = rightTree;
            tree.right = leftTree;

            return tree;
        }

        public TreeNode MirrorTreeIterative(TreeNode tree)
        {
            if (tree == null)
                return tree!;

            var queue = new Queue<TreeNode>();
            queue.Enqueue(tree);

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();

                var temp = current.left;
                current.left = current.right;
                current.right = temp;

                if (current.left != null)
                    queue.Enqueue(current.left);

                if (current.right != null)
                    queue.Enqueue(current.right);
            }

            return tree;
        }

        public bool SymetricTreeRecursive(TreeNode head)
        {
            return head == null || IsMirror(head.left, head.right);
        }
        public bool SymetricTreeIterative(TreeNode head)
        {
            var queue = new Queue<TreeNode>();

            queue.Enqueue(head.left);
            queue.Enqueue(head.right);

            while (queue.Count > 0)
            {
                var leftSubTree = queue.Dequeue();
                var rightSubTree = queue.Dequeue();

                if (leftSubTree == null && rightSubTree == null) continue;
                if (leftSubTree == null || rightSubTree == null) return false;
                if (leftSubTree.val != rightSubTree.val) return false;

                queue.Enqueue(leftSubTree.left);
                queue.Enqueue(rightSubTree.right);

                queue.Enqueue(leftSubTree.right);
                queue.Enqueue(rightSubTree.left);
            }

            return true;
        }

        public int DiameterOfBinaryTree(TreeNode node)
        {
            if (node == null) return 0;
            var max = 0;
            DiameterOfATreeSolve(node, ref max);
            return max;
        }


        public int DiameterOfBinaryTreeIterative(TreeNode node)
        {
            if (node == null) return 0;
            var max = 0;

            var stack = new Stack<TreeNode>();
            var dictionary = new Dictionary<TreeNode, int>();

            stack.Push(node);

            while (stack.Count > 0)
            {
                var stackTemp = stack.Peek();

                if (stackTemp.left != null && !dictionary.ContainsKey(stackTemp.left))
                    stack.Push(stackTemp.left);
                else if (stackTemp.right != null && !dictionary.ContainsKey(stackTemp.right))
                    stack.Push(stackTemp.right);
                else
                {
                    var popNode = stack.Pop();

                    var left = popNode.left != null ? dictionary[popNode.left] : 0;
                    var right = popNode.right != null ? dictionary[popNode.right] : 0;

                    dictionary.Add(popNode, Math.Max(left, right) + 1);
                    max = Math.Max(max, left + right);
                }
            }

            return max;
        }

        public bool IsBalancedDFS(TreeNode root)
        {
            if (root == null) return false;

            if (Depth(root) == -1) return false;

            return true;
        }

        public bool IsBalancedDFS2(TreeNode root)
        {
            if (root == null) return false;

            bool isBalanced = true;

            GetDepth(root, ref isBalanced);

            return isBalanced;

        }

        private int GetDepth(TreeNode root, ref bool isBalanced)
        {
            if (root == null) return 0;

            int left = GetDepth(root.left, ref isBalanced);
            int right = GetDepth(root.right, ref isBalanced);

            if (Math.Abs(left - right) > 1)
                isBalanced = false;

            return Math.Max(left, right) + 1;
        }

        // https://www.techiedelight.com/check-children-sum-property-binary-tree/
        public int isSumProperty(TreeNode root)
        {
            if (root == null)
                return 0;

            if (root.left == null && root.right == null)
                return root.val;

            int leftNode = 0;
            if (root.left != null)
                leftNode = isSumProperty(root.left);

            int rightNode = 0;
            if (root.right != null)
                leftNode = isSumProperty(root.right);

            if (root.val == leftNode + rightNode && rightNode != -1 && leftNode != -1)
                return root.val;

            return -1;
        }
    }
}