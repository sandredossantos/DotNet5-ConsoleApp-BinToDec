using BinToDec.Domain.Interfaces;

namespace BinToDec.Domain.Entities
{
    public class ValuesIO : IValuesIO
    {
        public string Binary { get; set; }
        public int Decimal { get; set; }
        public ValuesIO() { }
        public ValuesIO(string Binary)
        {
            this.Binary = Binary;
        }
        public int[] CreateArrayToBinary()
        {
            throw new System.NotImplementedException();
        }

        public bool IsValid()
        {
            throw new System.NotImplementedException();
        }
    }
}