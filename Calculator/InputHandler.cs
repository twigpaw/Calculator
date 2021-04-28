using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class InputHandler
    {
        public InputHandler()
        {
            init(0);
        }
    
        public void init(double number)
        {
            replace = true;
            negative = false;
            value = Math.Abs(number).ToString();
            negative = number < 0.0;
        }

        private bool negative;
        private bool replace;
        private string sign { get => (negative && value != "0") ? "-" : ""; }

        private string value;
        public override string ToString() {
            return sign + value;
        }
        public double? ToDouble() 
        {
            double result;
            bool success = Double.TryParse(this.ToString(), out result);
            if (success) return result;
            else return null; 
        }

        public void addSymbol(char c) {
            switch (c)
            {
                case '0': if (value != "0") value += c; break;
                case '.': if (!value.Contains('.')) value += c; break;
                default: value = replace ? c.ToString() : value + c; break;
            }
            replace = false;
        }

        public void InverseSign() { negative = !negative; }

        public void Backspace()
        {
            if (value.Length > 0) value = value == "0" ? "0" : value.Remove(value.Length - 1);
            if (value.Length == 0) value = "0";
        }
    }
}
