using System.Text;
using CodingQuestion2.Interfaces;

namespace CodingQuestion2.Domain
{
    public class MatrixTraversal : ITraversal
    {
        int minimumColumn, maximumColumn, minimumRow, maximumRow;
        int[,] matrix;

        public MatrixTraversal(int[,] matrix)
        {
            this.matrix = matrix;
            minimumColumn = 0;
            maximumColumn = 0;
            maximumRow = matrix.GetLength(0) - 1;
            maximumColumn = matrix.GetLength(1) - 1;
        }

        public string TraverseMultidimensionalMatrx()
        {
            StringBuilder sb = new StringBuilder();

            int i = 0;
            while(minimumRow < maximumRow || minimumColumn < maximumColumn)
            {
                if(maximumRow <= 0 || maximumColumn <= 0)
                {
                    return sb.ToString();
                }

                //handle the case when there is no spin, just a lateral traversal of either vertical or horizontal.
                if(minimumRow == maximumRow)
                {
                    for(i = minimumColumn; i <= maximumColumn; i++)
                    {
                        sb.Append(string.Format("{0} ", matrix[maximumRow, i]));
                    }
                    return sb.ToString();
                }

                if(minimumColumn == maximumColumn)
                {
                    for(i = minimumRow; i <= maximumRow; i++)
                    {
                        sb.Append(string.Format("{0} ", matrix[i, maximumColumn]));
                    }
                    return sb.ToString();
                }

                //move right while keeping i steady
                for(i = minimumColumn; i <= maximumColumn; i++)
                {
                    sb.Append(string.Format("{0} ", matrix[minimumRow, i]));
                }
                minimumRow++;

                //move down while keeping j steady
                for(i = minimumRow; i <= maximumRow; i++)
                {
                    sb.Append(string.Format("{0} ", matrix[i, maximumColumn]));
                }
                maximumColumn--;

                //move left while keeping i steady
                for(i = maximumColumn; i >= minimumColumn; i--)
                {
                    sb.Append(string.Format("{0} ", matrix[maximumRow, i]));
                }
                maximumRow--;

                //move up while keeping j steady
                for(i = maximumRow; i >= minimumRow; i--)
                {   
                    sb.Append(string.Format("{0} ", matrix[i, minimumColumn]));
                }
                minimumColumn++;
            }

            return sb.ToString();
        }
    }
}
