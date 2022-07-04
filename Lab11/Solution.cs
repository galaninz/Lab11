using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    struct Solution
    {
        double k;
        double b;

        public Solution (double k, double b)
        {
            this.k = k;
            this.b = b;
        }
        public string Root()
        {
            if (k == 0)
                return "Ошибка";
            double r = -b / k;
            return $"Решение {r}";

        }
    }
}
