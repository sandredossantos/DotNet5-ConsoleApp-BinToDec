using BinToDec.Domain.Interfaces;
using System;

namespace BinToDec.Service
{
    public class BinaryValidateService : IBinaryValidateService
    {
        public bool Validate(string binary)
        {
            if (ValidateLength(binary) && ValidateCharacters(binary))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool ValidateLength(string binary)
        {
            if (binary.Length > 8)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool ValidateCharacters(string binary)
        {
            for (int i = 0; i < binary.Length; i++)
            {
                short number = (short)Char.GetNumericValue(binary[i]);

                if (number > 1)
                {
                    return false;
                }
            }

            return true;
        }
    }
}