using BitAdders;

namespace TestBitAdder
{
    public class Tests
    {
        private BitAdder _HalfAdder;
        private BitAdder _FullAdder;
        private BitAdder _FourBitAdder;
        [SetUp]
        public void Setup()
        {
            _HalfAdder = new BitAdder("Halfadder");
            _FullAdder = new BitAdder("Fulladder");
            _FourBitAdder = new BitAdder("4Bitadder");
        }
        [Test]
        [TestCase(false, false, false, false)]
        [TestCase(false, true, true, false)]
        [TestCase(true, false, true, false)]
        [TestCase(true, true, false, true)]
        public void HalfAdder_InputTwoBooleans_ReturnsTupleWithTwoBooleans(bool x, bool y, bool resultS, bool resultC)
        {
            Assert.That((resultS, resultC), Is.EqualTo(_HalfAdder.HalfAdd(x, y)));
        }
        [Test]
        [TestCase(false, false, false, false, false)]
        [TestCase(false, false, true, false, true)]
        [TestCase(false, true, true, true, false)]
        [TestCase(true, false, false, false, true)]
        [TestCase(true, false, true, true, false)]
        [TestCase(true, true, false, true, false)]
        [TestCase(true, true, true, true, true)]
        public void FullAdder_InputThreeBooleans_ReturnsTupleWithTwoBooleans(bool x, bool y, bool c, bool resultC, bool resultS)
        {
            Assert.That((resultS, resultC), Is.EqualTo(_FullAdder.FullAdd(x, y, c)));
        }
        [Test]
        [TestCase(false, false, false, false, false, false, false, true, false, false, false, true, false)]
        [TestCase(true, false, false, false, false, true, false, false, true, true, false, false, false)]
        [TestCase(false, true, false, true, true, false, true, false, true, true, true, true, false)]
        [TestCase(false, false, true, false, false, false, true, true, false, true, false, true, false)]
        [TestCase(false, true, false, false, false, true, false, false, true, false , false, false, false)]
        [TestCase(true, true, true, true, false, false, false, false, true, true , true, true, false)]
        public void FourBitAdder_InputEightBooleans_ReturnsTupleWithFourBooleans(bool a0, bool a1, bool a2, bool a3, bool b0, bool b1, bool b2, bool b3, bool s0, bool s1, bool s2, bool s3, bool c0)
        {
            Assert.That((s0, s1, s2, s3, c0), Is.EqualTo(_FourBitAdder.FourBitAdd(a0, a1, a2, a3, b0, b1, b2, b3)));
        }
        [Test]
        [TestCase(0, false, false, false, false)]
        [TestCase(1, false, false, false, true)]
        [TestCase(2, false, false, true, false)]
        [TestCase(3, false, false, true, true)]
        [TestCase(4, false, true, false, false)]
        [TestCase(5, false, true, false, true)]
        [TestCase(6, false, true, true, false)]
        [TestCase(7, false, true, true, true)]
        [TestCase(8, true, false, false, false)]
        [TestCase(9, true, false, false, true)]
        [TestCase(10, true, false, true, false)]
        [TestCase(11, true, false, true, true)]
        [TestCase(12, true, true, false, false)]
        [TestCase(13, true, true, false, true)]
        [TestCase(14, true, true, true, false)]
        [TestCase(15, true, true, true, true)]
        public void ConvertOneDecimalToBit_InputOneDecimal_ReturnsTupleWithFourBooleans(int decimal1, bool a0, bool a1, bool a2, bool a3)
        {
            Assert.That((a0, a1, a2, a3), Is.EqualTo(_FourBitAdder.ConvertOneDecimalToBit(decimal1)));
        }
        [Test]
        [TestCase(15, 0, true, true, true, true, false, false, false, false)]
        [TestCase(7, 3, false, true, true, true, false, false, true, true)]
        [TestCase(2, 3, false, false, true, false, false, false, true, true)]
        public void ConvertTwoDecimalsToBit_InputTwoDecimal_ReturnsTupleWithEightBooleans(int decimal1, int decimal2, bool a0, bool a1, bool a2, bool a3, bool b0, bool b1, bool b2, bool b3)
        {
            Assert.That((a0, a1, a2, a3, b0, b1, b2, b3), Is.EqualTo(_FourBitAdder.ConvertTwoDecimalsToBit(decimal1, decimal2)));
        }
        [Test]
        [TestCase(15, true, true, true, true)]
        [TestCase(0, false, false, false, false)]
        [TestCase(5, false, true, false, true)]
        public void Convert4BitToDecimal_AddOneObjcetBitAdder_Input4BitAsBooleans_ReturnsOneInteger(int number, bool a0, bool a1, bool a2, bool a3)
        {
            Assert.That(number, Is.EqualTo(_FourBitAdder.Convert4BitToDecimal(a0, a1, a2, a3)));
        }
        [Test]
        [TestCase(7, 8, 15)]
        [TestCase(7, 7, 14)]
        [TestCase(6, 7, 13)]
        [TestCase(4, 8, 12)]
        [TestCase(3, 8, 11)]
        [TestCase(2, 8, 10)]
        [TestCase(4, 4, 8)]
        [TestCase(1, 1, 2)]
        [TestCase(2, 3, 5)]
        public void Add4BitInt_InputTwoDecimals_ReturnsOneInteger(int number1, int number2, int result)
        {
            Assert.That(result, Is.EqualTo(_FourBitAdder.Add4BitInt(number1, number2)));
        }
    }
}