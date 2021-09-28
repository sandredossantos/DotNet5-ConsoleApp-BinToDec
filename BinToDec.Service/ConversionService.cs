using BinToDec.Domain.Interfaces;
using System;

namespace BinToDec.Service
{
    public class ConversionService : IConversionService
    {
        public int ConvertBinaryToDecimal(string binary)
        {
            int value = 0;
            int exp = 0;

            for (int i = binary.Length; i-- > 0;)
            {
                value += (short)Char.GetNumericValue(binary[i]) * (int)Math.Pow(2, exp);
                exp++;
            };

            return value;
        }
    }
}