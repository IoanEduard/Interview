using _14.Trees.Concrete;

namespace _14.Trees.Interfaces
{
    public interface ILeetCodeTrees
    {
        int MaxDepth(TreeNode root, int countLeft = 0, int countRight = 0);
        int RangeSumBST(TreeNode root, int low, int high);
        int DeepestLeavesSum(TreeNode root);
        IList<int> InorderTraversal(TreeNode root);
    }
}