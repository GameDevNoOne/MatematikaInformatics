using Xunit;
using DecimalConverter;

namespace DecimalConverterTest
{

    public class DecimalConverterTest
    {
        [Fact]
        public void TestConverter()
        {
            Ulomek ulomek = DecimalToUlomek.DecimalnoStevilo(1.1111111111, 1);
            Assert.Equal(10, ulomek.Stevec);
            Assert.Equal(9, ulomek.Imenovalec);
            ulomek = DecimalToUlomek.DecimalnoStevilo(1.1212121212, 2);
            Assert.Equal(37, ulomek.Stevec);
            Assert.Equal(33, ulomek.Imenovalec);
        }

    }
}