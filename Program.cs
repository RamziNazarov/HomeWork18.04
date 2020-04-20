using System;

namespace HomeWork18._04
{
    class programm
    {
        static T Pluss<T>(T firstEl,T secondEl)
        {
            T result = (dynamic)firstEl + (dynamic)secondEl;
            return result;
        }
        static T Minuss<T>(T firstEl,T secondEl)
        {
            T result = (dynamic)firstEl - (dynamic)secondEl;
            return result;
        }
        static T Multiple<T>(T firstEl, T secondEl)
        {
            T result = (dynamic)firstEl * (dynamic)secondEl;
            return result;
        }
        static T Delete<T>(T firstEl, T secondEl)
        {
            T result;
            if(secondEl == (dynamic)0)
            {
                result = (dynamic)0;
                return result;
            }
            else
            {
                result = (dynamic)firstEl / (dynamic)secondEl;
                return result;
            }
        }
        delegate T Mess<T>(T one,T two);
        static void Main()
        {
            string choice = "1";
            while(choice != "5"){
                Mess<int> mess;
                Mess<double> mes;
                System.Console.Write("Первый операнд: ");
                string aStr = Console.ReadLine();
                System.Console.Write("Второй операнд: ");
                string bStr = Console.ReadLine();
                System.Console.Write("Операции:\n1. -\n2. +\n3. /\n4. *\n5. Выход\nВаш выбор: ");
                choice = Console.ReadLine();
                int a;
                switch(choice)
                {
                    case "-":
                    case "1":
                        if(int.TryParse(aStr,out a) && int.TryParse(bStr,out a))
                        {   
                            mess = Minuss;
                            int aa = int.Parse(aStr); 
                            int ab = int.Parse(bStr);
                            Console.WriteLine($"{aStr} - {bStr} = {mess.Invoke(aa,ab)}");
                        }
                        else
                        {
                            mes = Minuss;
                            double aa = double.Parse(aStr);
                            double ab = double.Parse(bStr);
                            Console.WriteLine($"{aStr} - {bStr} = {mes.Invoke(aa,ab)}");
                        }
                    break;
                    case "+":
                    case "2":
                        if(int.TryParse(aStr,out a) && int.TryParse(bStr,out a))
                        {   
                            mess = Pluss;
                            int aa = int.Parse(aStr); 
                            int ab = int.Parse(bStr);
                            Console.WriteLine($"{aStr} + {bStr} = {mess.Invoke(aa,ab)}");
                        }
                        else
                        {
                            mes = Pluss;
                            double aa = double.Parse(aStr);
                            double ab = double.Parse(bStr);
                            Console.WriteLine($"{aStr} + {bStr} = {mes.Invoke(aa,ab)}");
                        }
                    break;
                    case "/":
                    case "3":
                        if(int.TryParse(aStr,out a) && int.TryParse(bStr,out a))
                        {   
                            mess = Delete;
                            int aa = int.Parse(aStr); 
                            int ab = int.Parse(bStr);
                            Console.WriteLine($"{aStr} / {bStr} = {mess.Invoke(aa,ab)}");
                        }
                        else
                        {
                            mes = Delete;
                            double aa = double.Parse(aStr);
                            double ab = double.Parse(bStr);
                            Console.WriteLine($"{aStr} / {bStr} = {Math.Round(mes.Invoke(aa,ab),2)}");
                        }
                    break;
                    case "*":
                    case "4":
                        if(int.TryParse(aStr,out a) && int.TryParse(bStr,out a))
                        {   
                            mess = Multiple;
                            int aa = int.Parse(aStr); 
                            int ab = int.Parse(bStr);
                            Console.WriteLine($"{aStr} * {bStr} = {mess.Invoke(aa,ab)}");
                        }
                        else
                        {
                            mes = Multiple;
                            double aa = double.Parse(aStr);
                            double ab = double.Parse(bStr);
                            Console.WriteLine($"{aStr} * {bStr} = {mes.Invoke(aa,ab)}");
                        }
                    break;
                }
                System.Console.Write("Press any key...");
            Console.ReadKey();
            Console.Clear();
            }
        }
    }
}