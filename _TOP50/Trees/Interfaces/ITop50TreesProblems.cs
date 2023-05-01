using _14.Trees.Concrete;

namespace _TOP50.Trees.Interfaces
{

    /// <summary>
    /// Sources: 
    /// <para> https://www.geeksforgeeks.org/write-c-code-to-determine-if-two-trees-are-identical/ </para>
    /// <para> https://www.geeksforgeeks.org/find-the-maximum-depth-or-height-of-a-tree/ </para>
    /// </summary>
    public interface ITop50TreesProblems
    {
        /// <summary>
        /// <para>Given a binary tree, the task is to find the height of the tree. Height of the tree is the number of edges in the tree from the root to the deepest node,</para>
        /// <para>Height of the empty tree is 0.</para>
        /// 
        /// <para>Recursively calculate height of left and right subtrees of a node and assign height to the node as max of the heights of two children plus 1.</para>
        /// 
        /// <para>Recursively do a Depth-first search.</para>
        ///     <para>If the tree is empty then return -1</para>
        ///     <para>Otherwise, do the following</para>
        ///     <para>Get the max depth of the left subtree recursively  i.e. call maxDepth( tree->left-subtree)</para>
        ///     <para>Get the max depth of the right subtree recursively  i.e. call maxDepth( tree->right-subtree)</para>
        ///     <para>Get the max of max depths of left and right subtrees and add 1 to it for the current node.</para>
        /// </summary>
        /// <param name="Tree"></param>
        /// <returns></returns>

        int MaximumDepthOrHeightOfATree(TreeNode Tree);

        /// <summary>
        /// <para>Using BFS method - Queue nodes </para>
        /// <para>Sources: </para>
        /// <para>https://www.techiedelight.com/calculate-height-binary-tree-iterative-recursive/ </para>
        /// <para>https://www.enjoyalgorithms.com/blog/find-height-of-a-binary-tree </para>
        /// </summary>
        /// <param name="treeNode"></param>
        /// <returns></returns>
        int MaximumDepthOrHeightOfATreeIterative(TreeNode treeNode);

        /// <summary>
        /// <para> Below Text is useless</para>
        /// <para>Find the Maximum Depth or Height of a Tree using Level Order Traversal:</para>
        /// <para>Traverse the tree in level order traversal starting from root.</para>
        ///     <para>Initialize an empty queue Q, a variable depth and push root, then push null into the Q.</para>
        ///     <para>Run a while loop till Q is not empty.</para>
        ///         <para>Store the front element of Q and Pop out the front element.</para>
        ///         <para> If the front of Q is NULL then increment depth by one and if queue is not empty then push NULL into the Q.</para>
        ///          <para>Else if the element is not NULL then check for its left and right children and if they are not NULL push them into Q.</para>
        ///     <para>Return depth.</para>
        /// 
        /// </summary>
        /// <param name="treeNode"></param>
        /// <returns></returns>
        int MaximumDepthOrHeightOfATreeIterative2(TreeNode treeNode);

        /// <summary>
        /// Another method to find height using Level Order Traversal:
        /// </summary>
        /// <param name="treeNode"></param>
        /// <returns></returns>
        int MaximumDepthOrHeightOfATreeIterative3(TreeNode treeNode);

        bool IdenticalTrees(TreeNode a, TreeNode b);
        bool IdenticalTrees2(TreeNode a, TreeNode b);

        /// <summary>
        /// Two trees are identical or not by comparing their traversals:
        /// SequenceEqual has been used
        /// </summary>
        /// <returns></returns>
        bool IdenticalTreesComparingTraversals(TreeNode a, TreeNode b);
        bool IndenticalTreesUsingPreorder(TreeNode a, TreeNode b);
        bool IndenticalTreesLevelOrderTraversal(TreeNode a, TreeNode b);

        /// <summary>
        /// Follow the steps below to solve the problem:
        ///     Call Mirror for left-subtree i.e., Mirror(left-subtree)
        ///     Call Mirror for right-subtree i.e., Mirror(right-subtree)
        ///     Swap left and right subtrees.
        ///     temp = left-subtree
        ///     left-subtree = right-subtree
        ///     right-subtree = temp
        /// </summary>
        /// <param name="tree"></param>
        /// <returns></returns>
        TreeNode MirrorTree(TreeNode tree);

        /// <summary>
        /// Follow the steps below to solve the problem:
        ///     Perform the level order traversal
        ///     While traversing over the tree swap the left and right child of current node
        /// </summary>
        /// <param name="tree"></param>
        /// <returns></returns>
        TreeNode MirrorTreeIterative(TreeNode tree);

        /// <summary>
        /// DFS approach
        /// Base cases: tree is null, left and right are null, left or right are null, values do not match
        /// Recurse the method on both opposite sides.
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        bool SymetricTreeRecursive(TreeNode head);

        /// <summary>
        /// Is exactly like height of a Tree
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        int DiameterOfBinaryTree(TreeNode node);

        /// <summary>
        /// https://tech-guidance.com/the-diameter-of-a-binary-tree/
        /// https://leetcode.com/problems/diameter-of-binary-tree/solutions/1878074/c-iterative-solution/
        /// https://www.youtube.com/watch?v=bkxqA8Rfv04
        /// We have to keep track of the Height and Diameter, both are not same same, gfg is a dumb website with bad solutions.
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
         int DiameterOfBinaryTreeIterative(TreeNode node);

         bool IsBalancedDFS(TreeNode root);
    }

}