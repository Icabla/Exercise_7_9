using System;

class digits
{
    static void Main()
    {
        //counters 
        int oneDigit = 0, twoDigits = 0, threeDigits = 0, fourOrMoreDigits = 0;
        
        Console.Write("Insert a number: ");
        string insertedNumber = Console.ReadLine();

        while (insertedNumber != "end")
        {
            int number = Convert.ToInt32(insertedNumber);
            if (number != 0)
            {

                if (number / 10 == 0)
                    oneDigit++;  
                else if (number / 100 == 0)
                    twoDigits++;  
                else if (number / 1000 == 0)
                    threeDigits++;  
                else
                    fourOrMoreDigits++;  
            }
            insertedNumber = Console.ReadLine();
        }
        Console.WriteLine("One digit: {0} Two digits: {1} Three digits: {2} Four digits or more: {3}", oneDigit, twoDigits, threeDigits, fourOrMoreDigits);
    }
}


