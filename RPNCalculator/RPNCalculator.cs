using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPNCalculator
{
    public class RPNCalculator
    {
        public int FirstValue { get; set; }
        public int SecondValue { get; set; }
        public string Operator { get; set; }

        Calculationfactory calculationFactory = new Calculationfactory();
        public int? Apply(int firstValue, int secondValue, string Operator) { 
            ICalculate CalculationMethod = calculationFactory.GetCaculationApproach(Operator);
            return CalculationMethod.Calculate(firstValue, secondValue);

        }

        public int? CalculateExpression(string Expression)
        {

            return null;
        }

    }
}
