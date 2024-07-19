namespace Store.Tests
{
    public class KakiTest
    {
        [Fact]
        public void IsKakinum_WithNull_ReturnFalse()
        {
            bool actual = Kaki.IsKakinum(null);

            Assert.False(actual);
        }

        [Fact]
        public void IsKakinum_WithBlankString_ReturnFalse()
        {
            bool actual = Kaki.IsKakinum("   ");

            Assert.False(actual);
        }

        [Fact]
        public void IsKakinum_WithInvalidKakinum_ReturnFalse()
        {
            bool actual = Kaki.IsKakinum("KakiNumber 123");

            Assert.False(actual);
        }

        [Fact]
        public void IsKakinum_WithKakinum5_ReturnFalse()
        {
            bool actual = Kaki.IsKakinum("KakiNumber 123-4 5");

            Assert.True(actual);
        }

        [Fact]
        public void IsKakinum_WithTrashStart_ReturnFalse()
        {
            bool actual = Kaki.IsKakinum("KakiNumber 123-4 5 rrr");

            Assert.False(actual);
        }
    }
}