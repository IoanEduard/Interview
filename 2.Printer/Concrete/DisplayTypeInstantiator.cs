using _14.Trees.Concrete;
using _2.Printer.Interfaces;
using _7.LinkedLists.Concrete;

namespace _2.Printer.Concrete
{
    public class DisplayTypeInstantiator
    {
        public IDisplay<bool> DisplayBoolean { get; set; }
        public IDisplay<string> DisplayString { get; set; }
        public IDisplay<char> DisplayChar { get; set; }
        public IDisplay<int> DisplayInteger { get; set; }
        // public IDisplay<int[]> DisplayIntegerArray { get; set; }
        // public IDisplay<int[][]> DisplayIntegerMatrix { get; set; }
        public IDisplay<TreeNode> DisplayTreeNode { get; set; }
        public IDisplay<ListNode> DisplayListNode { get; set; }

        public DisplayTypeInstantiator()
        {
            DisplayBoolean = new Display<bool>();
            DisplayString = new Display<string>();
            DisplayChar = new Display<char>();
            DisplayInteger = new Display<int>();
            // DisplayIntegerArray = new Display<int[]>();
            // DisplayIntegerMatrix = new Display<int[][]>();
            DisplayTreeNode = new Display<TreeNode>();
            DisplayListNode = new Display<ListNode>();
        }
    }
}