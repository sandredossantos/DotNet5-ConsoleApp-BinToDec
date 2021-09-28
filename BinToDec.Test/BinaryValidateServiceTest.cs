using BinToDec.Domain.Interfaces;
using BinToDec.Service;
using Xunit;

namespace BinToDec.Test
{
    public class BinaryValidateServiceTest
    {
        [Fact]
        public void Should_Return_A_Success_True_When_A_Binary_Is_Valid()
        {
            //arrange
            IBinaryValidateService service = new BinaryValidateService();
            var binary = "1001";

            //act
            bool result = service.Validate(binary);

            //assert
            Assert.True(result);
        }

        [Fact]
        public void Should_Return_A_Success_False_When_A_Binary_Exceed_The_Character_Limit()
        {
            //arrange
            IBinaryValidateService service = new BinaryValidateService();
            var binary = "100101101";

            //act
            bool result = service.Validate(binary);

            //assert
            Assert.False(result);
        }

        [Fact]
        public void Should_Return_A_Success_False_When_A_Binary_Has_Characters_Other_Than_0_Or_1()
        {
            //arrange
            IBinaryValidateService service = new BinaryValidateService();
            var binary = "10012";

            //act
            bool result = service.Validate(binary);

            //assert
            Assert.False(result);
        }
    }
}