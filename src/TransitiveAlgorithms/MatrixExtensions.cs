using System.Text;

namespace TransitiveAlgorithms
{
    public static class MatrixExtensions
    {
        public static string MatrixToString(this int[,] matrix)
        {
            var stringBuilder = new StringBuilder();
            string output = "";

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                stringBuilder.Clear();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    stringBuilder.AppendFormat("{0,2}", matrix[row, col]);
                }

                output += stringBuilder + "\n";
            }

            return output;
        }
    }
}
