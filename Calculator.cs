using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericArithmeticCalculator
{
    public class Calculator<T> where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
    {
        public delegate T Operation(T x, T y);

        public Operation Add;
        public Operation Subtract;
        public Operation Multiply;
        public Operation Divide;

        public Calculator()
        {
            Add = (x, y) => (dynamic)x + (dynamic)y;
            Subtract = (x, y) => (dynamic)x - (dynamic)y;
            Multiply = (x, y) => (dynamic)x * (dynamic)y;
            Divide = (x, y) => (dynamic)x / (dynamic)y;
        }

        public T AddNumber(T x, T y)
        {
            return Add(x, y);
        }

        public T SubstrctNumber(T x, T y)
        {
            return Subtract(x, y);
        }

        public T MultiplicatNumber(T x, T y)
        {
            return Multiply(x, y);
        }

        public T DivisionNumber(T x, T y)
        {
            return Divide(x, y);
        }
    }
}
