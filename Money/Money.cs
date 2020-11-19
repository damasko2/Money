using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money_H
{
    class Money:Exception
    {
        private double sum;
        
        public Money(double num)
        {
            try
            {
                if (num>=0)
                {
                    sum = Math.Round(num, 2);
                }
                else
                {
                    throw new Exception("Значение не может быть меньше 0");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Исключение: {ex.Message}");
            }
        }

        public static Money operator +(Money n1, Money n2)
        {
            return new Money(n1.sum + n2.sum);
        }
        public static Money operator *(Money n1, Money n2)
        {
            return new Money(n1.sum * n2.sum);
        }
        public static Money operator -(Money n1, Money n2)
        {
            return new Money(n1.sum - n2.sum);
        }
        public static Money operator /(Money n1, Money n2)
        {
            return new Money(n1.sum / n2.sum);
        }
        public static Money operator ++(Money n1)
        {
            return new Money(n1.sum += 0.01);
        }
        public static Money operator --(Money n1)
        {
            return new Money(n1.sum -= 0.01);
        }
        public static bool operator <(Money n1, Money n2)
        {
            return n1.sum < n2.sum;
        }
        public static bool operator >(Money n1, Money n2)
        {
            return n1.sum > n2.sum;
        }
        public static bool operator ==(Money n1, Money n2)
        {
            return n1.sum == n2.sum;
        }
        public static bool operator !=(Money n1, Money n2)
        {
            return !(n1.sum == n2.sum);
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        public override bool Equals(object obj)
        {
            return this.ToString()==obj.ToString();
        }

        public override string ToString()
        {
            return $"Сумма {sum} грн";
        }
    }
}
