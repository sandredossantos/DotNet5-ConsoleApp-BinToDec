using BinToDec.Domain.Interfaces;
using System;

namespace BinToDec.Service
{
    public class ConversionService : IConversionService
    {
        public int ConvertBinaryToDecimal(int[] binary)
        {
            int value = 0;

            for (int i = binary.Length; i-- > 0;)
            {
                value += binary[i] * (int)Math.Pow(2, i);
            };

            return value;
        }
    }
}