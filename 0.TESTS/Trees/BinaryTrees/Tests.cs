using _2.Printer.Interfaces;
using _14.Trees.Interfaces;
using _14.Trees.Concrete;
using _0.Tests.Trees.BinaryTrees.Interfaces;
using _14.Trees.Concrete.Documentation.TreeTraversal;

namespace _0.Tests.Trees.BinaryTrees
{
    public class Tests : IFreeCodeCampBinaryTreesTests
    {
        private readonly IDisplay<TreeNode> _display;
        private readonly IDisplay<string> _displayText;
        private readonly IDisplay<int> _displayList;
        private readonly IDisplay<char> _displayChar;
        private readonly IDisplay<bool> _displayBool;
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

        public Tests(IDisplay<TreeNode> display,
            IDisplay<int> displayList,
            IDisplay<string> displayText,
            IDisplay<char> displayChar,
            IDisplay<bool> displayBool,
            IFreeCodeCampBinaryTrees freeCodeCampBinaryTrees,
            ILeetCodeTrees leetCode,
            TreeTraversal treeTraversal)
        {
            _display = display;
            _displayText = displayText;
            _displayChar = displayChar;
            _displayList = displayList;
            _displayBool = displayBool;
            _freeCodeCampBinaryTrees = freeCodeCampBinaryTrees;
            _leetCode = leetCode;
            _treeTraversal = treeTraversal;
            TreeNode = _freeCodeCampBinaryTrees.InitializeTree3();
            TreeNodeOfChars = _freeCodeCampBinaryTrees.InitializeTree4();

        }

        public void InitializeTree()
        {
            _display.DisplayResult(_freeCodeCampBinaryTrees.InitializeTree());
        }

        public void DFS(TreeNode root)
        {
            _display.DisplayResult(_freeCodeCampBinaryTrees.DFS(root));
        }

        public void DFSRecursive(TreeNode root)
        {
            _displayList.DisplayResult(_freeCodeCampBinaryTrees.DFSRecursive(root, new List<int>()));
        }

        public void BreadthFirstValuesIterative(TreeNode root)
        {
            _displayList.DisplayResult(_freeCodeCampBinaryTrees.BreadthFirstValuesIterative(root));
        }

        public void ValueExistsBFS(TreeNode root)
        {
            _displayBool.DisplayResult(_freeCodeCampBinaryTrees.ValueExistsBFS(root, 3));
        }

        public void ValueExistsRecursive(TreeNode root)
        {
            _displayBool.DisplayResult(_freeCodeCampBinaryTrees.ValueExistsRecursive(root, 3));
        }

        public void TreeSumRecursive(TreeNode root)
        {
            _displayList.DisplayResult(_freeCodeCampBinaryTrees.TreeSumRecursive(root));
        }

        public void TreeSumIterative(TreeNode root)
        {
            _displayList.DisplayResult(_freeCodeCampBinaryTrees.TreeSumIterative(root));
        }

        public void MinValueIterativeBFS(TreeNode root)
        {
            _displayList.DisplayResult(_freeCodeCampBinaryTrees.MinValueIterativeBFS(root));
        }

        public void MinValueIterativeDFS(TreeNode root)
        {
            _displayList.DisplayResult(_freeCodeCampBinaryTrees.MinValueIterativeDFS(root));
        }

        public void MinValueRecursive(TreeNode root)
        {
            _displayList.DisplayResult(_freeCodeCampBinaryTrees.MinValueRecursive(root));
        }

        public void MaxRootToLeafPath(TreeNode root)
        {
            _displayList.DisplayResult(_freeCodeCampBinaryTrees.MaxRootToLeafPath(root));
        }

        public void MaxRootToLeafPathRecursive(TreeNode root)
        {
            _displayList.DisplayResult(_freeCodeCampBinaryTrees.MaxRootToLeafPathRecursive(root));
        }

        public void InorderTraversal(TreeNode root)
        {
            _displayList.DisplayResult(_treeTraversal.InorderTraversalIterative(root));
            _display.DisplayNewLine();
        }

        public void InorderTraversalRecursive(TreeNode root)
        {
            _treeTraversal.InorderTraversalRecursive(root);
            _display.DisplayNewLine();
        }

        public void PreOrderTraversalRecursive(TreeNode root)
        {
            _treeTraversal.PreOrderTraversalRecursive(root);
            _display.DisplayNewLine();
        }

        public void PreOrderTraversalIterative(TreeNode root)
        {
            _displayList.DisplayResult(_treeTraversal.PreorderTraversalIterative(root));
        }

        public void PreOrderTraversalIterativeOptimized(TreeNode root)
        {
            _displayList.DisplayResult(_treeTraversal.PreorderTraversalIterativeOptimized(root));
        }

        public void PostOrderTraversalRecursive(TreeNodeOfChar root)
        {
            _displayText.DisplayResult("Postorder Traversal - Recursive");
            _treeTraversal.PostOrderTraversalRecursive(root);
            _display.DisplayNewLine();
        }

        public void PostOrderTraversalIterative(TreeNodeOfChar root)
        {
            _displayText.DisplayResult("Postorder Traversal - Iterative");
            _displayChar.DisplayResult(_treeTraversal.PostorderTraversalIterativeOfChars(root));
        }
    }
}