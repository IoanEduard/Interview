namespace _14.Trees.Concrete
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public class TreeNodeOfChar
    {
        public char val;
        public TreeNodeOfChar left;
        public TreeNodeOfChar right;
        public TreeNodeOfChar(char val = ' ', TreeNodeOfChar left = null, TreeNodeOfChar right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}