using _14.Trees.Concrete;

namespace _14.Trees.Interfaces
{
    /// <summary>
    /// Source: https://www.youtube.com/watch?v=fAAZixBzIAI
    /// </summary>
    public interface IFreeCodeCampBinaryTrees
    {

        /// <summary>
        ///                a
        ///               / \
        ///              b   e
        ///             /    / \ 
        ///            c    g   f

        /// </summary>
        /// <returns></returns>
        TreeNode InitializeTree();
        TreeNode InitializeTree2();

        /// <summary>
        ///                   1
        ///                  / \
        ///                 2   3
        ///                / \
        ///               4   5
        /// </summary>
        /// <returns></returns>
        TreeNode InitializeTree3();

        /// <summary>
        ///  <para>                 A                </para> 
        ///  <para>               /   \              </para> 
        ///  <para>              /     \             </para> 
        ///  <para>             B       W            </para> 
        ///  <para>            / \     / \           </para> 
        ///  <para>           X   S   T   C          </para> 
        ///  <para>          / \     /   /           </para> 
        ///  <para>         E   M   P   H            </para> 
        /// </summary>
        /// <returns></returns>
        TreeNodeOfChar InitializeTree4();

        /// <summary>
        /// Inorder version of a tree traversal with a return IList<int>
        /// Info:
        /// <para>https://softwareengineering.stackexchange.com/questions/227779/is-pre-order-traversal-same-as-depth-first-search</para>
        /// </summary>
        /// <param name="root"></param>
        /// <param name="nodes"></param>
        /// <returns></returns>

        IList<TreeNode> DFS(TreeNode root);

        /// <summary>
        /// <para> We add/remove nodes at the top</para>
        /// <para> What I pop I consider is visited</para>
        /// <para> We add a to the stack, then we add e and b, we consider b as current, and we pick c as our current node at the top of the stack.</para>
        /// Info:
        /// <para>https://softwareengineering.stackexchange.com/questions/227779/is-pre-order-traversal-same-as-depth-first-search</para>
        /// </summary>
        /// <param name="root"></param>
        /// <param name="nodes"></param>
        /// <returns></returns>
        IList<int> DFSRecursive(TreeNode root, List<int> nodes);

        /// <summary>
        /// <para>Also known as Level Traversal which speaks for itself. We traverse the levels of the tree</para>
        /// <para>We implement with a Queue</para>
        /// <para>O(n) where n is nr of nodes. We add and remove from Queue. </para>
        /// <para>Space Complexity O(n), it happens in constant time if algorithm is efficient </para>
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        IList<int> BreadthFirstValuesIterative(TreeNode root);

        /// <summary>
        /// Find a given value in the tree using Breadth first traversal
        /// </summary>
        /// <param name="root">Root of a tree</param>
        /// <param name="val">Target value</param>
        /// <returns></returns>
        bool ValueExistsBFS(TreeNode root, int val);
        bool ValueExistsRecursive(TreeNode root, int val);

        /// <summary>
        /// Using DFS
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        int TreeSumRecursive(TreeNode node);
        int TreeSumIterative(TreeNode root);
        int MinValueIterativeBFS(TreeNode root);
        int MinValueIterativeDFS(TreeNode root);
        int MinValueRecursive(TreeNode root);
        int MaxRootToLeafPathRecursive(TreeNode root);
        int MaxRootToLeafPath(TreeNode root);
    }
}