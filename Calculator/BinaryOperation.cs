using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class BinaryOperation
    {
        public delegate double operation(double left, double right);

        public BinaryOperation(string s)
        {
            _string = s;
            switch (s[0])
            {
                case '+': Evaluate = (x, y) => x + y; break;
                case '-': Evaluate = (x, y) => x - y; break;
                case '*': Evaluate = (x, y) => x * y; break;
                case '/': Evaluate = (x, y) => x / y; break;
                default:  Evaluate = (x, y) => x;     break;
            }
        }

        private readonly string _string = "";

        public override string ToString() { return _string[0].ToString(); }

        public readonly operation Evaluate;
    }
}
