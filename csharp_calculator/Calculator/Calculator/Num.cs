using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    struct Num
    {
        public readonly long Integer;
        public readonly double? Fraction;
        public readonly char opr;
        public Num(string numStr, char opr, int radix)
        {
            //获取数据符号，并使数据非负
            int sign=1;
            if (numStr.StartsWith("-"))
            {
                numStr = numStr.Substring(1);
                sign = -1;
            }
            //分离整数部分与小数部分
            int pos = numStr.IndexOf('.');
            if (pos < 0)
            {
                //无小数点时才可能有非十进制
                this.Integer = Convert.ToInt64(numStr, radix);
                this.Fraction = null;
            }
            else
            {
                //有小数点必是十进制
                if (pos == 0)
                    this.Integer = 0;
                else
                    this.Integer = long.Parse(numStr.Substring(0, pos));
                if (pos + 1 == numStr.Length)
                    this.Fraction = 0.0;
                else
                    this.Fraction = double.Parse(numStr.Substring(pos))*sign;
            }
            this.Integer *= sign;
            this.opr = opr;
        }
        public Num(string numStr, int radix):this(numStr,'@',radix)
        {
            //不带运算符的数据
        }
        public string ToString(int radix)
        {
            if (radix == 10)
            {
                double v=Integer;
                if (Fraction.HasValue)
                    v += Fraction.Value;
                return v.ToString();
            }
            else
            {
                return Convert.ToString(Integer, 10);
            }
        }
    }
}
