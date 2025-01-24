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
        public void HalfAdder_AddOneObjectBitAdder_InputTwoBooleans_ReturnsTupleWithTwoBooleans(bool x, bool y, bool resultS, bool resultC)
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
        public void FullAdder_AddOneObjectBitAdder_InputThreeBooleans_ReturnsTupleWithTwoBooleans(bool x, bool y, bool c, bool resultC, bool resultS)
        {
            Assert.That((resultS, resultC), Is.EqualTo(_HalfAdder.FullAdd(x, y, c)));
        }
        [Test]
        [TestCase(false, false, false, false, false, false, false, true, false, false, false, true, false)]
        [TestCase(true, false, false, false, false, true, false, false, true, true, false, false, false)]
        [TestCase(false, true, false, true, true, false, true, false, true, true, true, true, false)]
        public void FourBitAdder_AddOneObjectBitAdder_InputEightBooleans_ReturnsTupleWithFourBooleans(bool a0, bool a1, bool a2, bool a3, bool b0, bool b1, bool b2, bool b3, bool s0, bool s1, bool s2, bool s3, bool c0)
        {
            Assert.That((s0, s1, s2, s3, c0), Is.EqualTo(_FourBitAdder.FourBitAdd(a0, a1, a2, a3, b0, b1, b2, b3)));
        }
    }
}