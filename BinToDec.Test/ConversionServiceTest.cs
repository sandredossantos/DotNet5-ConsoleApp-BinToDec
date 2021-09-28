using BinToDec.Domain.Interfaces;
using BinToDec.Service;
using Xunit;

namespace BinToDec.Test
{
    public class ConversionServiceTest
    {
        [Fact]
        public void Should_Return_A_Decimal_Value_When_Given_A_Valid_Binary_Value()
        {
            //arrange
            IConversionService service = new ConversionService();
            var binary = "100101";

            //act
            var value = service.ConvertBinaryToDecimal(binary);

            //assert
            Assert.True(value.Equals(37));
        }
    }
}