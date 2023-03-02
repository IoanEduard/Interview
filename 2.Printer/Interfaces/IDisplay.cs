using _14.Trees.Concrete;

namespace _2.Printer.Interfaces
{
    public interface IDisplay<T>
    {
        void DisplayResult(T[] array);
        void DisplayResult(T[][] matrix);
        void DisplayResult(TreeNode treeNode);
        void DisplayResult(IList<T> treeNodes);
        void DisplayResult(T value);
        void DisplayNewLine();
    }
}