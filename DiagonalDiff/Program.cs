class Result
{
    public static int MatrixDiagonalDifference(List<List<int>> matrix)
    {
        int totalRows = matrix.Count;
        int totalCols = matrix[0].Count;
        int leftToRight = 0;
        int rightToLeft = 0;
        int x = totalCols - 1;
        for (int i = 0; i < totalRows; i++)
        {
            leftToRight += (matrix[i][i]);
            rightToLeft += (matrix[i][x]);
            x--;
        }
        return Math.Abs(leftToRight - rightToLeft);
    }
}

class Solution
{
    public static void Main(string[] args)
    {

        List<List<int>> arr = new List<List<int>>();
        List<int> list = new List<int>();
        list.Add(11);
        list.Add(2);
        list.Add(4);
        list.Add(6);

        arr.Add(list);
        list = new List<int>();
        list.Add(4);
        list.Add(5);
        list.Add(6);
        list.Add(7);
        arr.Add(list);

        list = new List<int>();
        list.Add(13);
        list.Add(25);
        list.Add(0);
        list.Add(5);
        arr.Add(list);

        list = new List<int>();
        list.Add(15);
        list.Add(20);
        list.Add(8);
        list.Add(22);
        arr.Add(list);
        int result = Result.MatrixDiagonalDifference(arr);
        Console.WriteLine(result);

    }
}
