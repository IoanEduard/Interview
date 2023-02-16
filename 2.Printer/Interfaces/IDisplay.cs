namespace _2.Printer.Interfaces
{
    public interface IDisplay<T>
    {
        void DisplayResult(T value);
        void DisplayResult(T[] array);
        void DisplayResult(T[][] matrix);
    }
}