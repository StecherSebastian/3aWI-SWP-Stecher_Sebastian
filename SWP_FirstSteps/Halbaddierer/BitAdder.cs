namespace BitAdders
{
    public class BitAdder
    {
        private string _Name;
        public string Name { get { return _Name; } }
        public BitAdder(string name) { _Name = name; }
        public (bool sum, bool carry) HalfAdd(bool x, bool y) { return (x ^ y, x && y); }
        public (bool sum, bool carry) FullAdd(bool x, bool y, bool c)
        {
            (bool sum0, bool carry0) = HalfAdd(x, y);
            (bool sum1, bool carry1) = HalfAdd(sum0, c);
            return (sum1, (carry0 || carry1));
        }
        public (bool sum0, bool sum1, bool sum2, bool sum3, bool carry) FourBitAdd(bool a3, bool a2, bool a1, bool a0, bool b3, bool b2, bool b1, bool b0)
        {
            (bool sum0, bool carry0) = HalfAdd(a0, b0);
            (bool sum1, bool carry1) = FullAdd(a1, b1, carry0);
            (bool sum2, bool carry2) = FullAdd(a2, b2, carry1);
            (bool sum3, bool carry_out) = FullAdd(a3, b3, carry2);
            return (sum3, sum2, sum1, sum0, carry_out);
        }
        public (bool a0, bool a1, bool a2, bool a3, bool b0, bool b1, bool b2, bool b3) ConvertTwoDecimalsToBit (int number1, int number2)
        {
            (bool a0, bool a1, bool a2, bool a3) = ConvertOneDecimalToBit(number1);
            (bool b0, bool b1, bool b2, bool b3) = ConvertOneDecimalToBit(number2);
            return (a0, a1, a2, a3, b0, b1, b2, b3);
        }
        public (bool a0, bool a1, bool a2, bool a3) ConvertOneDecimalToBit(int number)
        {
            bool a0 = (number & 8) != 0;
            bool a1 = (number & 4) != 0;
            bool a2 = (number & 2) != 0;
            bool a3 = (number & 1) != 0;
            return (a0, a1, a2, a3);
        }
        public int Convert4BitToDecimal(bool a0, bool a1, bool a2, bool a3)
        {
            int decimal1 = 0;
            if (a0) { decimal1 += 8; }
            if (a1) { decimal1 += 4; }
            if (a2) { decimal1 += 2; }
            if (a3) { decimal1 += 1; }
            return decimal1;
        }
        public int Add4BitInt(int x, int y)
        {
            (bool a0, bool a1, bool a2, bool a3, bool b0, bool b1, bool b2, bool b3) = ConvertTwoDecimalsToBit(x, y);
            (bool sum0, bool sum1, bool sum2, bool sum3, bool carry_out) = FourBitAdd(a0, a1, a2, a3, b0, b1, b2, b3);
            return Convert4BitToDecimal(sum0, sum1, sum2, sum3);
        }    
    }
}