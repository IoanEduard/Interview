using _14.Trees.Interfaces;
using _14.Trees.Concrete;
using _0.Tests.Trees.BinaryTrees.Interfaces;
using _14.Trees.Concrete.Documentation.TreeTraversal;
using _2.Printer.Concrete;

namespace _0.Tests.Trees.BinaryTrees
{
    public class Tests : IFreeCodeCampBinaryTreesTests
    {
        private readonly DisplayTypeInstantiator _display;
        private readonly IFreeCodeCampBinaryTrees _freeCodeCampBinaryTrees;
        private readonly ILeetCodeTrees _leetCode;
        private readonly ITreeTraversal<int> _treeTraversal;
        private TreeNode _treeNode;
        public TreeNode TreeNode
        {
            get { return _treeNode; }
            set { _treeNode = value; }
        }

        private TreeNodeOfChar _treeNodeOfChars;
        public TreeNodeOfChar TreeNodeOfChars
        {
            get { return _treeNodeOfChars; }
            set { _treeNodeOfChars = value; }
        }

        public Tests(DisplayTypeInstantiator display,
            IFreeCodeCampBinaryTrees freeCodeCampBinaryTrees,
            ILeetCodeTrees leetCode,
            TreeTraversal treeTraversal)
        {
            _display = display;
            _freeCodeCampBinaryTrees = freeCodeCampBinaryTrees;
            _leetCode = leetCode;
            _treeTraversal = treeTraversal;
            TreeNode = _freeCodeCampBinaryTrees.InitializeTree3();
            TreeNodeOfChars = _freeCodeCampBinaryTrees.InitializeTree4();
        }

        public void DisplayInitializedTree()
        {
            _display.DisplayTreeNode.DisplayResult(_freeCodeCampBinaryTrees.InitializeTree());
        }

        public void DFS(TreeNode root)
        {
            _display.DisplayTreeNode.DisplayResult(_freeCodeCampBinaryTrees.DFS(root));
        }

        public void DFSRecursive(TreeNode root)
        {
            _display.DisplayInteger.DisplayResult(_freeCodeCampBinaryTrees.DFSRecursive(root, new List<int>()));
        }

        public void BreadthFirstValuesIterative(TreeNode root)
        {
            _display.DisplayInteger.DisplayResult(_freeCodeCampBinaryTrees.BreadthFirstValuesIterative(root));
        }

        public void ValueExistsBFS(TreeNode root)
        {
            _display.DisplayBoolean.DisplayResult(_freeCodeCampBinaryTrees.ValueExistsBFS(root, 3));
        }

        public void ValueExistsRecursive(TreeNode root)
        {
            _display.DisplayBoolean.DisplayResult(_freeCodeCampBinaryTrees.ValueExistsRecursive(root, 3));
        }

        public void TreeSumRecursive(TreeNode root)
        {
            _display.DisplayInteger.DisplayResult(_freeCodeCampBinaryTrees.TreeSumRecursive(root));
        }

        public void TreeSumIterative(TreeNode root)
        {
            _display.DisplayInteger.DisplayResult(_freeCodeCampBinaryTrees.TreeSumIterative(root));
        }

        public void MinValueIterativeBFS(TreeNode root)
        {
            _display.DisplayInteger.DisplayResult(_freeCodeCampBinaryTrees.MinValueIterativeBFS(root));
        }

        public void MinValueIterativeDFS(TreeNode root)
        {
            _display.DisplayInteger.DisplayResult(_freeCodeCampBinaryTrees.MinValueIterativeDFS(root));
        }

        public void MinValueRecursive(TreeNode root)
        {
            _display.DisplayInteger.DisplayResult(_freeCodeCampBinaryTrees.MinValueRecursive(root));
        }

        public void MaxRootToLeafPath(TreeNode root)
        {
            _display.DisplayInteger.DisplayResult(_freeCodeCampBinaryTrees.MaxRootToLeafPath(root));
        }

        public void MaxRootToLeafPathRecursive(TreeNode root)
        {
            _display.DisplayInteger.DisplayResult(_freeCodeCampBinaryTrees.MaxRootToLeafPathRecursive(root));
        }

        public void InorderTraversal(TreeNode root)
        {
            _display.DisplayInteger.DisplayResult(_treeTraversal.InorderTraversalIterative(root));
            _display.DisplayString.DisplayNewLine();
        }

        public void InorderTraversalRecursive(TreeNode root)
        {
            _treeTraversal.InorderTraversalRecursive(root);
            _display.DisplayString.DisplayNewLine();
        }

        public void PreOrderTraversalRecursive(TreeNode root)
        {
            _treeTraversal.PreOrderTraversalRecursive(root);
            _display.DisplayString.DisplayNewLine();
        }

        public void PreOrderTraversalIterative(TreeNode root)
        {
            _display.DisplayInteger.DisplayResult(_treeTraversal.PreorderTraversalIterative(root));
        }

        public void PreOrderTraversalIterativeOptimized(TreeNode root)
        {
            _display.DisplayInteger.DisplayResult(_treeTraversal.PreorderTraversalIterativeOptimized(root));
        }

        public void PostOrderTraversalRecursive(TreeNodeOfChar root)
        {
            _display.DisplayString.DisplayResult("Postorder Traversal - Recursive");
            _treeTraversal.PostOrderTraversalRecursive(root);
            _display.DisplayString.DisplayNewLine();
        }

        public void PostOrderTraversalIterative(TreeNodeOfChar root)
        {
            _display.DisplayString.DisplayResult("Postorder Traversal - Iterative");
            _display.DisplayChar.DisplayResult(_treeTraversal.PostorderTraversalIterativeOfChars(root));
        }
    }
}

