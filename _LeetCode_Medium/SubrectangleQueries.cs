namespace _LeetCode_Medium;
public class SubrectangleQueries
{
    private int[][] _rectangle;

    public SubrectangleQueries(int[][] rectangle)
    {
        _rectangle = rectangle;
    }

    public void UpdateSubrectangle(int row1, int col1, int row2, int col2, int newValue)
    {
        for (var i = row1; i <= row2; i++)
        {
            for (var j = col1; j <= col2; j++)
            {
                _rectangle[i][j] = newValue;
            }
        }
    }

    public int GetValue(int row, int col)
    {
        return _rectangle[row][col];
    }
}
