using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _14.Trees.Concrete.LeetCode
{
    public class LeetCodeTrees
    {
        // FAIL
        public int MaxDepth(TreeNode root, int countLeft = 0, int countRight = 0)
        {
            if (root == null) return 0;
            MaxDepth(root.left, countLeft++);
            MaxDepth(root.right, countRight++);

            return 0;
        }
    }
}