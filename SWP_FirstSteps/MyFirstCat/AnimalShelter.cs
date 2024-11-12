using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstCat
{
    internal class AnimalShelter
    {
        public List<Cat> _Animals;
        public List<Cat> Animals
        {
            get { return _Animals; }
            set
            {
                if (_Animals == value) return;
                _Animals = value;
            }
        }
        public AnimalShelter()
        {
            Animals = new List<Cat>();
        }
    }
}
