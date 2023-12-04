// See https://aka.ms/new-console-template for more information
public class BasicSyntax
{
    public static void Main(string[] args)
    {
        //If Usage
        /*
        bool myBoolVariable = true;
        string positiveMessage = "Variable is true";

        string negativeMessage = "Variable is false";
        if (myBoolVariable)
        {
            Console.WriteLine(positiveMessage);
        }
        else
        {
            Console.WriteLine(negativeMessage);
        }
        */


        //Switch Usage

        /*
        Console.WriteLine("Enter your GPA");

        String input;

        input = Console.ReadLine();

        double gpa = double.Parse(input);

        switch(gpa)
        {
            case <=1:
                Console.WriteLine("Youre failed from course");
                break;
            case <=2:
                Console.WriteLine("You barely passed");
                break;
            case <=3:
                Console.WriteLine("You passed well");
                break;
            case <=4:
                Console.WriteLine("You're the best");
                break;
        }
        */

        //Function and Method Usage

        /*
        static void woa()
        {
            Console.WriteLine("WOOOOOOOOOOOOOWWOWOWOWOWOWOWOWOWOWOWWOW");
        }

        string longLive(String Message)
        {
            Message = Message + "\nLong live Radovin";
            return Message;
        }

        string taxMessage = "The tax of hay going to be increased into %20 level";
        Console.WriteLine(longLive(taxMessage));

        woa();

        */

        //ref usage
        /*

        int originNum = 30;
        ref int refNum = ref originNum;

        refNum = 60;
        originNum = 23;
        Console.WriteLine("Original num :" + originNum + "\nrefNum :" + refNum);

        */
    
        
        //out usage

        /*    
        int rnd(out int number)
        {
            Random random = new Random();
            number = random.Next(1,100);
            return number;
        }

        int myNum;
        
        Console.WriteLine(rnd(out myNum));
        */
        
        
        //params usage

        /*
        int avarage(params int[]myArray)
        {
            int total = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
                total = total + myArray[i];
            }
            return total/myArray.Length;
        }

        Console.WriteLine(avarage(2, 3, 4, 7, 9));
        Console.WriteLine(avarage(2, 3, 4, 7, 9,1234,42,12,454,56));
        */
        
        

    }
}

