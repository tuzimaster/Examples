namespace CodingQuestion2.Interfaces
{
    public interface IGenerator
    {
        int[,] GenerateMatrix(int rows, int columns);
        string PrintMatrix(int[,] matrix);
    }
}
