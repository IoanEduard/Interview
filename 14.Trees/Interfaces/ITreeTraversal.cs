using _14.Trees.Concrete;

namespace _14.Trees.Interfaces
{
    public interface ITreeTraversal<T>
    {
        /// <summary>
        /// Steps
        /// <para>1. Traverse the left subtree, i.e., call Inorder(left-subtree)</para> 
        /// <para>2. Visit the root</para> 
        /// <para>3. Traverse the left subtree, i.e., call Inorder(left-subtree)</para> 
        /// <para>4. Visit the root</para> 
        /// <para>5. Traverse the right subtree, i.e., call Inorder(right-subtree)</para> 
        /// Description
        /// <para>In the case of binary search trees (BST), Inorder traversal gives nodes in non-decreasing order. </para> 
        /// <para>To get nodes of BST in non-increasing order, a variation of Inorder traversal where Inorder traversal is reversed can be used</para> 
        /// </summary>
        /// <returns></returns>

        void InorderTraversalRecursive(TreeNode node);

        /// <summary>
        /// <para>In an inorder traversal of a binary tree, we traverse one subtree of a node, then "visit" the node, and then traverse its other subtree. </para>
        /// <para>Usually, we traverse the node's left subtree first and then traverse the node's right subtree.</para>
        /// <para>Reference: https://faculty.cs.niu.edu/~mcmahon/CS241/Notes/Data_Structures/binary_tree_traversals.html</para>
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        IList<T> InorderTraversalIterative(TreeNode root);

        /// <summary>
        /// Steps
        /// <para>1. Visit the root</para>
        /// <para>2. Traverse the left subtree, i.e., call Preorder(left-subtree)</para>
        /// <para>3. Traverse the right subtree, i.e., call Preorder(right-subtree)</para>
        /// Description
        /// <para> Preorder traversal is used to create a copy of the tree. Preorder traversal is also used to get prefix expressions of an expression tree.</para>
        /// </summary>
        /// <param name="node"></param>
        void PreOrderTraversalRecursive(TreeNode node);

        /// <summary>
        /// Steps
        /// <para>1. Create an empty stack nodeStack and push root node to stack. </para>
        /// <para>2. Do the following while nodeStack is not empty.  </para>
        /// <para>3. Pop an item from the stack and print it. </para>
        /// <para>4. Push right child of a popped item to stack </para>
        /// <para>5. Push left child of a popped item to stack</para>
        /// <para>6. The right child is pushed before the left child to make sure that the left subtree is processed first.</para>
        /// Description
        /// <para>Following is a simple stack based iterative process to print Preorder traversal. </para>
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>

        IList<T> PreorderTraversalIterative(TreeNode root);

        /// <summary>
        /// Description
        /// <para> Optimized solution for the iterative version</para>
        /// <para> Time Complexity: O(N) </para>
        /// <para> Auxiliary Space: O(H), where H is the height of the tree.</para>
        /// <para>
        ///  In the previous solution we can see that the left child is popped as soon as it is pushed to the stack, 
        ///     therefore it is not required to push it into the stack. 
        /// </para>
        /// <para>
        ///  The idea is to start traversing the tree from the root node, and keep printing the left child while exists and simultaneously, 
        ///     push the right child of every node in an auxiliary stack. 
        /// </para>
        /// <para>
        ///  Once we reach a null node, pop a right child from the auxiliary stack and repeat the process while the auxiliary stack is not-empty. 
        /// </para>
        /// </summary>
        /// <returns></returns>
        IList<T> PreorderTraversalIterativeOptimized(TreeNode root);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        IList<T> MorrisPreorderTraversal(TreeNode node);

        /// <summary>
        /// Steps
        /// <para>1. Traverse the left subtree, i.e., call Postorder(left-subtree)</para>
        /// <para>2. Traverse the right subtree, i.e., call Postorder(right-subtree)</para>
        /// <para>3. Visit the root</para>
        /// Description
        /// <para>Postorder traversal is used to delete the tree. </para>
        /// <para>Postorder traversal is also useful to get the postfix expression of an expression tree</para>
        /// </summary>
        /// <param name="node"></param>
        void PostOrderTraversalRecursive(TreeNodeOfChar node);

        /// <summary>
        /// Steps
        /// 
        /// Description
        /// <para> This is a trickier algorithm to write than the iterative preorder or inorder traversals, since we will need to backtrack from a node to its parent twice.</para>
        /// <para> Some sources solve this problem (poorly, in my opinion) by using two different stacks</para>
        /// <para> Donald Knuth's The Art of Computer Programming has a more efficient version of the algorithm that maintains an extra pointer to the node that was last visited 
        ///             and uses it to distinguish between backtracking to a node after traversing its left subtree versus backtracking to a node after traversing its right subtree.</para>
        /// Source
        /// https://faculty.cs.niu.edu/~mcmahon/CS241/Notes/Data_Structures/binary_tree_traversals.html
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        IList<char> PostorderTraversalIterativeOfChars(TreeNodeOfChar root);

        /// <summary>
        /// Steps:
        /// <para> 1. Push root to first stack.</para>
        /// <para> 2. Loop while first stack is not empty</para>
        ///     <para> 2.1 Pop a node from first stack and push it to second stack</para>
        ///     <para> 2.2 Push left and right children of the popped node to first stack</para>
        /// <para> 3. Print contents of second stack</para>
        /// 
        /// Description:
        /// <para>Using two stacks approach, more details in the links</para>
        /// 
        /// Source
        /// <para>https://www.geeksforgeeks.org/iterative-postorder-traversal/?ref=lbp<para>
        /// <para>https://leetcode.com/problems/binary-tree-postorder-traversal/solutions/45648/three-ways-of-iterative-postorder-traversing-easy-explanation/</para>
        /// <para>Good Explanation: https://www.codingninjas.com/codestudio/library/iterative-postorder-traversal-of-a-binary-tree-part-2</para>
        /// <para>Good Explanation: https://www.enjoyalgorithms.com/blog/iterative-binary-tree-traversals-using-stack</para>
        /// <para>Good Explanation: https://www.techiedelight.com/postorder-tree-traversal-iterative-recursive/</para>
        /// <para>Good Explanation: https://www.geeksforgeeks.org/iterative-postorder-traversal-using-stack/</para>
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        IList<T> PostorderTraversalIterative(TreeNode root);

    }
}