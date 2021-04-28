using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class Calculator
    {
        private double left = 0.0;
        private double right = 0.0;
        private Func<double, double, double> operation = null;

        public void setNumber(double number)
        {
            if (operation == null) left = number;
            else right = number;
        }

        public void setOperation(Func<double, double, double> operation)
        {
            this.operation = operation;
        }

        public double evaluate()
        {
            double result = operation(left, right);
            operation = null;
            return result;
        }
    }
}
