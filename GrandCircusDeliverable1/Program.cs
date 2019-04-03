
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusDeliverable1
{
    /*
    Create a Console App that takes in 3 different $ amounts then totals it up
        - prints average
        - prints smallest amount
        - prints largest amount
    
    
    NEXT, Format and print the total to look like this 
    EXAMPLEEEEE:
    So 1923.53 would turn into: 
        - US: $1,923.53
        - Swedish: 1 923,53 kr
        - Japanese: ‎¥‎ 1,924 (rounds up)
        - Thai: ‎฿ 1,923.53      
    */
    class MainClass
    {
        public static void Main(string[] args)
        {
            double firstAmount;
            double secondAmount;
            double thirdAmount;
            double averageAmount;
            double smallestAmount;
            double largestAmount;
            double totalAmount;

            Console.WriteLine("Enter 3 different dollar amounts");

            Console.WriteLine("Enter the first amount:");
            firstAmount = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second amount:");
            secondAmount = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the third amount:");
            thirdAmount = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(" ");

            averageAmount = (firstAmount + secondAmount + thirdAmount) / 3.00;

            Console.WriteLine("The average amount is: " + "$" + averageAmount);

            // Smallest Amount
            if (firstAmount < secondAmount && firstAmount < thirdAmount)
            {
                smallestAmount = firstAmount;
            }
            else if (secondAmount < firstAmount && secondAmount < thirdAmount)
            {
                smallestAmount = secondAmount;
            }
            else
            {
                smallestAmount = thirdAmount;
            }

            Console.WriteLine("The smallest amount is: " + "$" + smallestAmount);

            // Largest Amount
            if (firstAmount > secondAmount && firstAmount > thirdAmount)
            {
                largestAmount = firstAmount;
            }
            else if (secondAmount > firstAmount && secondAmount > thirdAmount)
            {
                largestAmount = secondAmount;
            }
            else
            {
                largestAmount = thirdAmount;
            }
            Console.WriteLine("The largest amount is: " + "$" + largestAmount);

            totalAmount = firstAmount + secondAmount + thirdAmount;


            Console.WriteLine(" ");

            Console.WriteLine("   • US: " + totalAmount.ToString("C", CultureInfo.CurrentCulture));
            Console.WriteLine("   • Swedish: " + totalAmount.ToString("c", CultureInfo.GetCultureInfo("sv-SE")));
            Console.WriteLine("   • Japanese: " + totalAmount.ToString("c", CultureInfo.GetCultureInfo("ja-JP")));
            Console.WriteLine("   • Thai: ‎" + totalAmount.ToString("c", CultureInfo.GetCultureInfo("th-TH")));

            Console.ReadKey();

        }
    }
}