namespace BitAdders
{
    public class BitAdder
    {
        private string _Name;
        public string Name { get { return _Name; } }
        public BitAdder(string name) {  _Name = name; }
        public (bool sum, bool carry_out) HalfAdd(bool x, bool y) { return (((!x && y) || (x && !y)), (x && y)); }
        public (bool sum, bool carry_out) FullAdd(bool x, bool y, bool c) 
        { 
            (bool sum0, bool carry0) = HalfAdd(x, y);
            (bool sum1, bool carry1) = HalfAdd(sum0, c);
            return (sum1, (carry0 || carry1));
        }
        public (bool sum0, bool sum1, bool sum2, bool sum3, bool carry_out) FourBitAdd(bool a0, bool a1, bool a2, bool a3, bool b0, bool b1, bool b2, bool b3)
        {
            (bool sum0, bool carry0) = HalfAdd(a0, b0);
            (bool sum1, bool carry1) = FullAdd(a1, b1, carry0);
            (bool sum2, bool carry2) = FullAdd(a2, b2, carry1);
            (bool sum3, bool carry_out) = FullAdd(a3, b3, carry2);
            return (sum0, sum1, sum2, sum3, carry_out);
        }
    }
}
