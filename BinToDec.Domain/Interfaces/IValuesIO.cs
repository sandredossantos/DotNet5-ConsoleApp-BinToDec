namespace BinToDec.Domain.Interfaces
{
    public interface IValuesIO
    {
        bool IsValid();
        int[] CreateArrayToBinary();
    }
}