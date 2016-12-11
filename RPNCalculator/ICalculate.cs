using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPNCalculator
{
    
    public interface ICalculate
    {
        int Calculate(int firstVal, int secondVal);
    }

    public class Add : ICalculate
    {
        public int Calculate(int firstVal, int secondVal)
        {
            return firstVal + secondVal;
        }
    }

    public class Substract : ICalculate
    {
        public int Calculate(int firstVal, int secondVal)
        {
            return firstVal - secondVal;
        }
    }

    public class Multiply : ICalculate
    {
        public int Calculate(int firstVal, int secondVal)
        {
            return firstVal * secondVal;
        }
    }

    public class Divide : ICalculate
    {
        public int Calculate(int firstVal, int secondVal)
        {
            return firstVal / secondVal;
        }
    }

    public class Calculationfactory
    {
        ICalculate CalculationApproach;
        Dictionary<string, ICalculate> CalculationApproachList = new Dictionary<string, ICalculate>(){
            { "+", new Add() },
            { "-", new Substract () },
            { "*", new Multiply () },
            { "/", new Divide()}

        };

            
        public  ICalculate GetCaculationApproach( string opertator)
        {
            ICalculate CalculationMethod;

            if (CalculationApproachList.TryGetValue(opertator, out CalculationMethod))
            {
               return  CalculationMethod;
            }
            return null;
        }
    }



}
