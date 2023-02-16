namespace _LeetCode_Easy.Concrete.DesignOOP
{
    public class OrderedStream
    {
        private string[] _stream;
        private int _pointer = 0;

        public OrderedStream(int n)
        {
            _stream = new string[n];
        }

        public IList<string> Insert(int idKey, string value)
        {
            IList<string> result = new List<string>();

            _stream[idKey - 1] = value;

            while (_pointer < _stream.Length && _stream[_pointer] != null)
            {
                result.Add(_stream[_pointer]);
                _pointer++;
            }

            return result;
        }
    }
}