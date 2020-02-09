using System;

namespace Assignment1_Spring2020
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5; 
            PrintPattern(n);

            Console.WriteLine("\n");
            int n2 = 6;
            PrintSeries(n2);

            Console.WriteLine("\n");
            string s = "09:15:35PM";
            string t = UsfTime(s);
            Console.WriteLine(t);

            Console.WriteLine("\n");
            int n3 = 110;
            int k = 11;
            UsfNumbers(n3, k);

            Console.WriteLine("\n");
            string[] words = new string[] { "abcd", "dcba", "lls", "s", "sssll" };
            PalindromePairs(words);

            Console.WriteLine("\n");
            int n4 = 15;
            Stones(n4);

        }


        private static void PrintPattern(int n)
        {
            try
            {
                if (n < 0)
                {
                    Console.Write("Please enter a valid input");
                }
                else
                {
                    if (n == 0) //checking for n value and if it's zero it will return nothing
                    {
                        return;
                    }
                    for (int i = n; i >= 1; i--)//Using for loop to print pattern
                    {
                        Console.Write(i + " "); //Printing pattern while giving space between numbers
                    }
                    Console.WriteLine(" ");//going to the next line
                    PrintPattern(n - 1);//Recursive function will repeat the same next steps to print pattern 
                }
            }
            catch
            {
                Console.WriteLine("Exception Occured while computing printPattern");
            }
        }


        private static void PrintSeries(int n2)
        {
            try
            {
                if (n2 < 0)
                {
                    Console.Write("Please enter a valid input");
                }
                else
                {
                    int sum = 0; //initialsing the sum to zero
                    for (int i = 1; i <= n2; i++)
                    {
                        sum = sum + i; //adding the sum to the looping value
                        if(i!=n2)
                        
                       Console.Write(sum + ","); //Print total sum with a comma and the for loop executes again
                    else
                            Console.WriteLine(sum);
                    }
                }

            }
            catch
            {
                Console.WriteLine("Exception Occured while computing printSeries");
            }
        }


        public static string UsfTime(string s)
        {
            try
            {
                if (s.Length != 0)
                {
                    DateTime d1 = Convert.ToDateTime(s);//Converting it to datetime using library
                                                        //Console.WriteLine(d1);
                    int hour = d1.Hour;
                    int min = d1.Minute; 
                    int sec = d1.Second;
                    int time = (hour * 60 * 60 + min * 60 + sec); //Calculating the total number of seconds
                    int usfmin = time / 45; //no.of min in usf planet
                    int F = time % 45; //no.of sec left in usf planet
                    int usfhour = usfmin / 60; //no.of hours in usf planet
                    int S = usfmin % 60; //no.of min left in usf planet
                    int U = usfhour % 36; //no.of hours left in usf planet
                    Console.WriteLine("{0}:{1}:{2}", U, S, F);
                }
                else
                    Console.WriteLine("Invalid format");
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception Occured while computing UsfTime with message"+e.Message);
            }
            return null;
        }


        public static void UsfNumbers(int n3, int k)
        {
            try
            {
                if (n3 < 0)
                {
                    Console.Write("Please enter a valid input");
                }
                else
                {
                    for (int i = 1; i <= n3; i++)//starting the loop to check for i values
                    {
                        if (i % k == 1)//dividing it by k and printing k numbers per line
                        {
                            Console.Write("\n");//printing it in the next line
                        }
                        if (i % 3 == 0) //checking for multiples of 3
                        {
                            if (i % 5 == 0) //checking for multiples of 5
                            {
                                Console.Write("US" + " ");//print if multiples of 3 and 5
                            }

                            else if (i % 7 == 0)
                            {
                                Console.Write("UF" + " ");//print if multiples of 3 and 7
                            }
                            else
                            {
                                Console.Write("U" + " ");//only multiple of 3
                            }
                        }
                        else if (i % 5 == 0)
                        {
                            if (i % 7 == 0)
                            {
                                Console.Write("SF" + " ");//print if multiples of 5 and 7
                            }
                            else
                            {
                                Console.Write("S" + " ");//print only multiple of 5
                            }
                        }
                        else if (i % 7 == 0)
                        {
                            Console.Write("F" + " ");//print only multiple of 7
                        }
                        else
                            Console.Write(i + " ");//otherwise print the number
                    }
                }
                }
            catch
            {
                Console.WriteLine("Exception occured while computing UsfNumbers()");
            }
        }
    


        public static void PalindromePairs(string[] words)
        {
            try
            {
                if (words.Length < 2)//checking if there are 2 words
                {
                    Console.WriteLine("Enter gretar than one word");//print that we need more than one word
                }
                else
                {
                    for (int i = 0; i < words.Length; i++)//Using for loop,checking the index position
                    {
                        for (int j = 0; j < words.Length; j++)//Using for loop and checking the index position
                        {
                            if (i != j)//checking that the indexes are not the same
                            {
                                String pal = words[i] + words[j];//adding the indexes
                                char[] ch = pal.ToCharArray();//converting it into a character
                                Array.Reverse(ch);//reversing the character array
                                String rev = new string(ch);//putting it in a new string
                                bool b = pal.Equals(rev, StringComparison.OrdinalIgnoreCase);//comparing both the strings
                                if (b)
                                {
                                    Console.Write("(" + i + "," + j + ")");//Printing the indexes
                                }
                            }
                        }
                    }
                }
            }
            catch
            {

                Console.WriteLine("Exception occured while computing PalindromePairs()");
            }
        }

        
        public static void Stones(int n4)
        {
            try
            {
                // Write your code here
                if (n4 < 1)//checking if the n values is less than 1
                {
                    Console.WriteLine("Can't play the game");//print no game
                }
                else
                {
                    if (n4 % 4 == 0)//checking if n is a multiple of 4
                    {
                        Console.WriteLine("false");//if n is a 4 multiple he loses so print false
                        return;
                    }
                    if (n4 < 4)//checking for n less than 4
                    {
                        Console.WriteLine("[" + n4 + "]");//print the number whichever is less than 4
                        return;
                    }
                    Console.Write("[" + n4 % 4);
                    n4 = n4 - n4 % 4;//subtracting the number from the 4 multiple
                    int flag = 0;//initialsing the flag value to zero
                    while (n4 > 0)//using while loop
                    {

                        if (flag == 0)//if the flag value is zero
                        {
                            Console.Write("," + 3);//print the first pick to be 3
                            n4 = n4 - 3;//subtracting the picked value
                            flag = 1;//to enter the flag 1 chance
                        }
                        else
                        {
                            Console.Write("," + 1);//print that 1 to be picked
                            n4 = n4 - 1;//subtracting 1 each time
                            flag = 0;//it will again to the flag zero loop
                        }
                    }
                    Console.Write("]");
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing Stones()");
            }
        }


    }
}
