using System;


namespace Console_calc
{
    public class Calc
    {
        private decimal _result = 0;
        Values val = new();
        private bool _firstState = true;

        public void SetVal()
        {
                do
                {
                    if (_firstState)
                    {
                        if (val.SetNumbMethod())
                        {
                            Console.WriteLine("Your number: \t" + val.Numb);
                            _result = Calculat("+");
                            Console.WriteLine("Result: \t" + _result);
                        }

                    }
                    else
                    {
                        if (val.SetNumbMethod())
                        {
                            Console.WriteLine("Your number: \t" + val.Numb);
                            Console.WriteLine("Choose operator: +, -, *, /, c, exit");
                            _result = Calculat(Console.ReadLine());

                            Console.WriteLine("Result: \t" + _result);

                        }
                    }

                    

                } while (true);

            


        }

        private decimal Calculat(string operation)
        {

            switch (operation)
            {
                case "+":
                    _firstState = false;
                    _result = _result + val.Numb;
                    break;
                case "-":
                    _result = _result - val.Numb;
                    break;

                case "*":
                    _result = _result * val.Numb;
                    break;

                case "/":
                    if (val.Numb !=0)
                    {
                        _result = _result / val.Numb;
                    }
                    else
                    {
                        Console.WriteLine("Wrong operation!");
                    }
                    break;

                case "c":
                    _result = 0;
                    break;

                case "exit":
                    Exit();
                    break;

                default:
                    Console.WriteLine("Wrong operation!");
                    break;
            }

            return _result;
        }

        private static void Exit()
        {
            Environment.Exit(0);
        }

    }
}
