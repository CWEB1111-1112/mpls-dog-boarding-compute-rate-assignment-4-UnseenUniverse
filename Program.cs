using System;
//Tony Condon
namespace assignment_four
{
    class Program
    {
        static void Main(string[] args)
        {
            //Global Declarations
            int dayCount;
            string code;
            int EXIT = -1;
            double totalCost;

            dayCount = houseKeeping();
            while(dayCount != EXIT){
                code = getCode();
                if (code == "A"){
                    totalCost = ComputeRateA(totalCost, dayCount);
                }
                if(code == "C"){
                    totalCost = ComputeRateC(totalCost, dayCount);
                }
                else{
                    totalCost = ComputeRate(totalCost, dayCount);
                }

                Conclude(dayCount, code, totalCost);
                dayCount = primer();
            }
        }

        static double ComputeRateA(double totalCost, int dayCount){
            totalCost = dayCount * 169;

            return totalCost;
        }

        static double ComputeRateC(double totalCost, int dayCount){
            totalCost = dayCount * 112;

            return totalCost;
        }

        static double ComputeRate(double totalCost, int dayCount){
            totalCost = dayCount * 75;

            return totalCost;
        }

        static int houseKeeping(){
            int dayCount;
            Console.WriteLine("Enter how many days the dog will be staying");
            dayCount = Convert.ToInt32(Console.ReadLine());
            return dayCount;
        }

        static string getCode(){
            string code;
            Console.WriteLine("Enter add-on code");
            code = Console.ReadLine();
            return code;
        }

        static int primer()
        {
            int dayCount;
            Console.WriteLine("to enter another dog, enter number of days or enter -1 to exit");
            dayCount = Convert.ToInt32(Console.ReadLine());
            return dayCount;

        }

        static void Conclude(int dayCount, string code, double totalCost){

            Console.WriteLine($"Number of days: {dayCount} \nCode: {code}\nTotal Cost: {totalCost}");
        }
    }
}
