using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearEquasion
{
    struct Linear
    {
        double k;
        double b;

        public Linear (double k, double b)
        {
            this.k = k;
            this.b = b;

        }

        public string Root()
        {
            if (k != 0 && b != 0)
            {
                double solution = -b / k;
                return $"Решение: {solution}";
            }
            else if (k == 0 && b != 0)
                return "Решения нет.";
            else
                return "Бесконечное количество корней.";

        }
    }
}
