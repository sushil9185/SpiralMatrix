namespace SpiralMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public IList<int> SpiralOrder(int[][] matrix)
        {

            List<int> result = new List<int>();

            if (matrix == null || matrix.Length == 0 || matrix[0].Length == 0)
            {
                return result;
            }

            int m = matrix.Length;
            int n = matrix[0].Length;
            int top = 0, bottom = m - 1, right = n - 1, left = 0;

            while (top <= bottom && left <= right)
            {
                // left to right
                for (int i = left; i <= right; i++)
                {
                    result.Add(matrix[top][i]);
                }
                top++; //move the top boundry down

                //top to bottom
                for (int i = top; i <= bottom; i++)
                {
                    result.Add(matrix[i][right]);
                }
                right--;

                if (top <= bottom)
                {
                    //right to left
                    for (int i = right; i >= left; i--)
                    {
                        result.Add(matrix[bottom][i]);
                    }
                    bottom--;
                }

                if (left <= right)
                {
                    //bottom to top
                    for (int i = bottom; i >= top; i--)
                    {
                        result.Add(matrix[i][left]);
                    }
                    left++;
                }
            }
            return result;
        }
    }
}
