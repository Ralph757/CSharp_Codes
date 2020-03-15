using System;

namespace BMI_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //In this section I am asking to user to provide their input of their weight
            Console.WriteLine("Enter your weight in lbs: ");
            //Since user input is a string, I need to convert to a double because the BMI categories has double numbers
            double wgt = Convert.ToDouble(Console.ReadLine());
            //Now I am asking the user to input their height
            Console.WriteLine("What is your height in inches: ");
            //Since user input is a string, I need to convert to a double because the BMI categories has double numbers
            double hgt = Convert.ToDouble(Console.ReadLine());

            //I am getting the new bmiWgt because i have to mulitply 703 * the user wgt
            double bmiWgt = 703 * wgt;
            //I am getting the new bmiHgt because I would need to multiply the hgt * hgt
            double bmiHgt = hgt * hgt;
            //for me to get the calculations, I could use the information from a above to calculate the BMI by dividing the bmiWgt by the bmiHgt
            double bMI = bmiWgt / bmiHgt;

            //I am using this to show the user what their actual BMI is
            Console.WriteLine("Your BMI score is " + bMI + ".");

            //I will use the if statment to determine if the bMI <= 18.5.  
            if (bMI < 16)
            {
                // If statement is true, the below will be printed
                Console.WriteLine("Your BMI classification is: Severe thinness.");
            }
            //I will use the else if statement to determine if the bMI is <= 16.99
            else if (bMI <= 16.99)
            {
                //If statement is true, the below will be printed
                Console.WriteLine("Your BMI classification is: Moderate thinness.");
            }
            //I will use the else if statement to determine if the bMI is <= 18.49
            else if (bMI <= 18.49)
            {
                //If statement is true, the below will be printed
                Console.WriteLine("Your BMI classification is: Mild thinness.");
            }
            //I will use the else if statement to determine if the bMI is <= 24.9
            else if (bMI <= 24.9)
            {
                //If statement is true, the below will be printed
                Console.WriteLine("Your BMI classification is: Normal weight.");
            }
            //I will use the else if statement to determine if the bMI is <= 29.9
            else if (bMI <= 29.9)
            {
                //If statement is true, the below will be printed
                Console.WriteLine("Your BMI classification is: Overweight.");
            }
            //I will use the else if statement to determine if the bMI is <= 34.9
            else if (bMI <= 34.9)
            {
                //If statement is true, the below will be printed
                Console.WriteLine("Your BMI classification is: Obese class I.");
            }
            //I will use the else if statement to determine if the bMI is <= 39.9
            else if (bMI <= 39.9)
            {
                //If statement is true, the below will be printed
                Console.WriteLine("Your BMI classification is: Obese class II.");
            }
            //If none of the above matches, the else statement closes the statement
            else
            {
                //When all ifs and else if statements above are false, the below will be printed
                Console.WriteLine("Your BMI classification is: Obese class III.");
            }
        }
    }
}
