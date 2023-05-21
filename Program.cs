using System;

namespace Calculator_Project
{
    internal class Program
    {

        class clsCalculator
        {

            private float _Result = 0;
            private float _LastNumber = 0;
            private string _LastOperation = "Clear";

            private bool _IsZero(float Number)
            {
                  return (Number == 0);
            }

            public void Add(short Number)
            {
                _LastNumber = Number;
                _LastOperation = "Adding";
                _Result += Number;
            }

            public void Subtract(short Number)
            {
                _LastNumber = Number;
                _LastOperation = "Subtracting";
                _Result -= Number;
            }
            public void Multiply(short Number)
            {
                _LastNumber = Number;
                _LastOperation = "Multiplying";
                _Result *= Number;
            }

            public bool Divide(short Number)
            {
                bool Succeeded = true;

                _LastOperation = "Dividing";

                if (_IsZero(Number))
                {
                _LastNumber = Number;
                _Result /= 1;
                Succeeded = false;
                } else
                {
                    _LastNumber = Number;
                    _Result /= Number;

                }

                return Succeeded;

            }

            public float GetFinalResult()
            {
                return _Result;
            }

            public void Clear()
            {
                _LastNumber = 0;
                _LastOperation = "Clear";
                _Result = 0;
            }

            public void PrintResults()
            {
                Console.WriteLine("Result After {0} {1} is : {2}", _LastOperation, _LastNumber, _Result);
            }

        }

        static void Main(string[] args)
        {
            clsCalculator Calculator1 = new clsCalculator();

            Calculator1.Clear();
            Calculator1.Add(10);
            Calculator1.PrintResults();

            Calculator1.Add(100);
            Calculator1.PrintResults();


            Calculator1.Subtract(20);
            Calculator1.PrintResults();

            Calculator1.Divide(0);
            Calculator1.PrintResults();


            Calculator1.Divide(2);
            Calculator1.PrintResults();


            Calculator1.Multiply(3);
            Calculator1.PrintResults();

            Calculator1.Clear();
            Calculator1.PrintResults();

            Console.ReadLine();

        }
    }
}
