
using System.Text;
using _14.Trees.Concrete;
using _2.Printer.Interfaces;
using static System.Console;

namespace _2.Printer.Concrete
{
    public class Display<T> : IDisplay<T>
    {
        public StringBuilder _sr;

        public Display()
        {
            _sr = new StringBuilder();
        }

        public void DisplayNewLine()
        {
            WriteLine();
        }

        public void DisplayResult(T[] array)
        {
            var i = 0;
            foreach (var item in array)
            {
                _sr.Append($"{item}");

                if (i < array.Length - 1)
                    _sr.Append(" ");

                i++;
            }

            WriteLine(_sr.ToString());
            _sr.Clear();
        }

        public void DisplayResult(T[][] matrix)
        {
            for (int n = 0; n < matrix.Length; n++)
            {
                Write("Row({0}): ", n);
                for (int k = 0; k < matrix[n].Length; k++)
                {
                    Write("{0} ", matrix[n][k]);
                }
                WriteLine();
            }
        }

        public void DisplayResult(TreeNode treeNode)
        {
            Write($"{treeNode.val} ");
        }


        public void DisplayResult(IList<T> treeNodes)
        {
            var i = 0;
            foreach (var item in treeNodes)
            {
                _sr.Append($"{item}");

                if (i < treeNodes.Count - 1)
                    _sr.Append(" ");

                i++;
            }

            WriteLine(_sr.ToString());
            _sr.Clear();
        }

        public void DisplayResult(T value)
        {
            WriteLine(value);
        }


    }
}