using _0.Tests.Trees.BinaryTrees;
using _14.Trees.Concrete;
using  _14.Trees.Concrete.Documentation.freeCodeCampBinaryTrees;
using _14.Trees.Concrete.Documentation.TreeTraversal;
using _14.Trees.Concrete.LeetCode;
using _2.Printer.Concrete;

namespace _1.Main.StaticCalls.Trees
{
    public class BinaryTreesTestRunner
    {
        private Tests _tests;
        private TreeNode _head;
        private TreeNodeOfChar _headOfChars;

        public BinaryTreesTestRunner()
        {
            _tests = new Tests(new DisplayTypeInstantiator(),
                                new FreeCodeCampBinaryTrees(), 
                                new LeetCodeTrees(), 
                                new TreeTraversal());
            _head = _tests.TreeNode;
            _headOfChars = _tests.TreeNodeOfChars;
        }

        public void RunTests()
        {
            _tests.DFS(_head);
            _tests.DFSRecursive(_head);
            _tests.InorderTraversal(_head);
            _tests.InorderTraversalRecursive(_head);
            _tests.InorderTraversal(_head);
            _tests.PreOrderTraversalRecursive(_head);
            _tests.PreOrderTraversalIterative(_head);
            _tests.PreOrderTraversalIterativeOptimized(_head);
            _tests.PostOrderTraversalRecursive(_headOfChars);
            _tests.PostOrderTraversalIterative(_headOfChars);
            _tests.BreadthFirstValuesIterative(_head);
            _tests.ValueExistsBFS(_head);
            _tests.ValueExistsRecursive(_head);
            _tests.TreeSumRecursive(_head);
            _tests.TreeSumIterative(_head);
            _tests.MinValueIterativeBFS(_head);
            _tests.MinValueIterativeDFS(_head);
            _tests.MinValueRecursive(_head);
            _tests.MaxRootToLeafPath(_head);
            _tests.MaxRootToLeafPathRecursive(_head);
        }
    }
}