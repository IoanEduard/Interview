using _14.Trees.Interfaces;

namespace _14.Trees.Concrete.Documentation.freeCodeCampBinaryTrees
{
    public class FreeCodeCampBinaryTrees : IFreeCodeCampBinaryTrees
    {
        public TreeNode InitializeTree()
        {
            var a = new TreeNode(1);
            var b = new TreeNode(2);
            var c = new TreeNode(6);
            var d = new TreeNode(8);
            var e = new TreeNode(5);
            var f = new TreeNode(8);
            var g = new TreeNode(10);

            a.left = b;
            b.left = c;
            b.right = d;
            a.right = e;
            e.right = f;
            e.left = g;

            return a;
        }

        public TreeNode InitializeTree2()
        {
            var a = new TreeNode(1);
            var b = new TreeNode(2);
            var c = new TreeNode(3);

            a.right = b;
            b.left = c;

            return a;
        }

        public TreeNode InitializeTree3()
        {
            TreeNode tree = new TreeNode();
            tree = new TreeNode(1);
            tree.left = new TreeNode(2);
            tree.right = new TreeNode(3);
            tree.left.left = new TreeNode(4);
            tree.left.right = new TreeNode(5);

            return tree;
        }

        public TreeNodeOfChar InitializeTree4()
        {
            TreeNodeOfChar tree = new TreeNodeOfChar();

            var a = new TreeNodeOfChar('A');
            var b = new TreeNodeOfChar('B');
            var x = new TreeNodeOfChar('X');
            var s = new TreeNodeOfChar('S');
            var e = new TreeNodeOfChar('E');
            var m = new TreeNodeOfChar('M');
            var w = new TreeNodeOfChar('W');
            var t = new TreeNodeOfChar('T');
            var p = new TreeNodeOfChar('P');
            var n = new TreeNodeOfChar('N');
            var c = new TreeNodeOfChar('C');
            var h = new TreeNodeOfChar('H');

            tree = a;
            a.left = b;
            b.left = x;
            b.right = s;
            x.left = e;
            x.right = m;

            a.right = w;
            w.left = t;
            w.right = c;
            t.left = p;
            t.right = n;
            c.left = h;

            return tree;
        }

        public IList<TreeNode> DFS(TreeNode root)
        {
            var stack = new Stack<TreeNode>();
            var list = new List<TreeNode>();

            if (root == null) return list;

            stack.Push(root);

            while (stack.Count > 0)
            {
                var current = stack.Pop();
                list.Add(current);

                if (current.right != null) stack.Push(current.right);
                if (current.left != null) stack.Push(current.left);
            }

            return list;
        }

        public IList<int> DFSRecursive(TreeNode root, List<int> nodes)
        {
            if (root == null)
                return nodes;

            DFSRecursive(root.left, nodes);
            nodes.Add(root.val);
            DFSRecursive(root.right, nodes);

            return nodes;
        }

        public IList<int> BreadthFirstValuesIterative(TreeNode root)
        {
            var list = new List<int>();
            if (root == null) return list;

            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();
                list.Add(current.val);

                if (current.left != null)
                    queue.Enqueue(current.left);

                if (current.right != null)
                    queue.Enqueue(current.right);

            }

            return list;
        }

        public bool ValueExistsBFS(TreeNode root, int val)
        {
            if (root == null) return false;

            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();
                if (current.val == val) return true;

                if (current.left != null)
                    queue.Enqueue(current.left);

                if (current.right != null)
                    queue.Enqueue(current.right);
            }

            return false;
        }

        public bool ValueExistsRecursive(TreeNode root, int val)
        {
            if (root == null)
                return false;

            if (root.val == val)
                return true;

            return ValueExistsRecursive(root.left, val) || ValueExistsRecursive(root.right, val);
        }

        public int TreeSumRecursive(TreeNode root)
        {
            if (root == null)
                return 0;

            return root.val + TreeSumRecursive(root.left) + TreeSumRecursive(root.right);
        }

        public int TreeSumIterative(TreeNode root)
        {
            if (root == null)
                return 0;

            var sum = 0;
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();
                sum += current.val;

                if (current.left != null)
                    queue.Enqueue(current.left);

                if (current.right != null)
                    queue.Enqueue(current.right);
            }

            return sum;
        }

        public int MinValueIterativeBFS(TreeNode root)
        {
            if (root == null)
                return 0;

            var minimumValue = int.MaxValue;
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();
                minimumValue = Math.Min(current.val, minimumValue);

                if (current.left != null)
                    queue.Enqueue(current.left);

                if (current.right != null)
                    queue.Enqueue(current.right);
            }

            return minimumValue;
        }

        public int MinValueIterativeDFS(TreeNode root)
        {
            if (root == null)
                return 0;

            var minimumValue = int.MaxValue;
            var stack = new Stack<TreeNode>();
            stack.Push(root);

            while (stack.Count > 0)
            {
                var current = stack.Pop();
                minimumValue = Math.Min(current.val, minimumValue);

                if (current.left != null)
                    stack.Push(current.left);

                if (current.right != null)
                    stack.Push(current.right);
            }

            return minimumValue;
        }

        public int MinValueRecursive(TreeNode root)
        {
            if (root == null)
                return int.MaxValue;

            return Math.Min(root.val, Math.Min(MinValueRecursive(root.left), MinValueRecursive(root.right)));
        }

        public int MaxRootToLeafPathRecursive(TreeNode root)
        {
            if (root.left == null && root.right == null)
                return root.val;

            if (root == null) 
                return int.MinValue;

            var maxChild = Math.Max(MaxRootToLeafPathRecursive(root.left), MaxRootToLeafPathRecursive(root.right));

            return root.val + maxChild;
        }

        public int MaxRootToLeafPath(TreeNode root)
        {
            return 0;
        }
    }
}