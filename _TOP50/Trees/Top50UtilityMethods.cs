using _14.Trees.Concrete;

namespace _TOP50.Trees
{
    public class Top50UtilityMethods
    {
        protected void PostOrder(TreeNode node, List<int> list)
        {
            if (node == null) return;

            PostOrder(node.left, list);
            PostOrder(node.right, list);
            list.Add(node.val);
        }

        protected void PreOrder(TreeNode node, List<int> list)
        {
            if (node == null) return;

            list.Add(node.val);
            PreOrder(node.left, list);
            PreOrder(node.right, list);
        }

        protected void Inorder(TreeNode node, List<int> list)
        {
            if (node == null) return;

            Inorder(node.left, list);
            list.Add(node.val);
            Inorder(node.right, list);
        }

        protected void ClearLists(List<int> a, List<int> b)
        {
            a.Clear();
            b.Clear();
        }

        protected void PreorderForIdenticalTrees(TreeNode node, List<int> treenodesList)
        {
            if (node == null) return;

            if (node.left != null) PreorderForIdenticalTrees(node.left, treenodesList);
            else treenodesList.Add(0);

            if (node.right != null) PreorderForIdenticalTrees(node.right, treenodesList);
            else treenodesList.Add(0);
        }

        public void InOrder(TreeNode node)
        {
            if (node == null)
            {
                return;
            }

            InOrder(node.left);
            Console.Write(node.val + " ");
            InOrder(node.right);
        }

        protected bool IsMirror(TreeNode headLeft, TreeNode headRight)
        {
            if (headLeft == null && headRight == null) return true;
            if (headLeft == null || headRight == null) return false;
            if (headLeft.val != headRight.val) return false;

            return IsMirror(headLeft.left, headRight.right) && IsMirror(headRight.right, headLeft.left);
        }

        protected int Depth(TreeNode root)
        {
            if (root == null) return 0;

            var depthLeft = Depth(root.left);
            if (depthLeft == -1) return -1;

            var depthRight = Depth(root.right);
            if (depthRight == -1) return -1;

            if (Math.Abs(depthLeft - depthRight) > 1)
                return -1;

            return Math.Max(depthLeft, depthRight) + 1;
        }

        protected int DiameterOfATreeSolve(TreeNode node, ref int max)
        {
            if (node == null) return 0;

            var leftHeight = DiameterOfATreeSolve(node.left, ref max);
            var rightHeight = DiameterOfATreeSolve(node.right, ref max);

            max = Math.Max(max, leftHeight + rightHeight);

            return Math.Max(leftHeight, rightHeight) + 1;
        }

    }
}