using _14.Trees.Interfaces;
using static System.Console;

namespace _14.Trees.Concrete.Documentation.TreeTraversal
{
    public class TreeTraversal : ITreeTraversal<int>
    {
        public void InorderTraversalRecursive(TreeNode node)
        {
            if (node == null)
                return;

            InorderTraversalRecursive(node.left);
            Write(node.val + " ");
            InorderTraversalRecursive(node.right);
        }

        public IList<int> InorderTraversalIterative(TreeNode root)
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

        public void PreOrderTraversalRecursive(TreeNode node)
        {
            if (node == null)
                return;

            Write(node.val + " ");
            PreOrderTraversalRecursive(node.left);
            PreOrderTraversalRecursive(node.right);
        }

        public IList<int> PreorderTraversalIterativeOptimized(TreeNode root)
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

        public IList<int> PreorderTraversalIterative(TreeNode root)
        {
            var list = new List<int>();
            if (root == null) return list;
            var stack = new Stack<TreeNode>();
            stack.Push(root);

            while (stack.Count > 0)
            {
                var node = stack.Peek();
                list.Add(node.val);
                stack.Pop();

                if (node.right != null)
                    stack.Push(node.right);

                if (node.left != null)
                    stack.Push(node.left);
            }

            return list;
        }

        public IList<int> MorrisPreorderTraversal(TreeNode node)
        {
            throw new NotImplementedException();
        }

        public void PostOrderTraversalRecursive(TreeNodeOfChar node)
        {
            if (node == null)
                return;

            PostOrderTraversalRecursive(node.left);
            PostOrderTraversalRecursive(node.right);
            Write(node.val + " ");
        }

        public IList<char> PostorderTraversalIterativeOfChars(TreeNodeOfChar root)
        {
            var list = new List<char>();
            if (root == null) return list;

            var stack = new Stack<TreeNodeOfChar>();

            TreeNodeOfChar lastVisited = null;
            var pointer = root;

            while (pointer != null && lastVisited != root)
            {
                while (pointer != null && pointer != lastVisited)
                {
                    stack.Push(pointer);
                    pointer = pointer.left;
                }

                pointer = stack.Peek();
                stack.Pop();

                if (pointer.right == null || pointer.right == lastVisited)
                {
                    lastVisited = pointer;
                    list.Add(pointer.val);
                }
                else
                {
                    stack.Push(pointer);
                    pointer = pointer.right;
                }
            }

            return list;
        }

        public IList<int> PostorderTraversalIterative(TreeNode root)
        {
            var stack1 = new Stack<TreeNode>();
            var stack2 = new Stack<TreeNode>();

            var list = new List<int>();
            if (root == null) return list;

            stack1.Push(root);

            while (stack1.Count > 0)
            {
                var pointer = stack1.Pop();
                stack2.Push(pointer);

                if (pointer.left != null)
                    stack1.Push(pointer.left);

                if (pointer.right != null)
                    stack1.Push(pointer.right);
            }

            while (stack2.Count > 0)
            {
                var pointer = stack2.Pop();
                list.Add(pointer.val);
            }

            return list;
        }

        //  public IList<int> LevelTraversal(TreeNode root)
        // {

        // }
    }
}