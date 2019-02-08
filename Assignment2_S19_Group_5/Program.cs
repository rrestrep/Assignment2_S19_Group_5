using System;
using System.Collections.Generic;
// Authors: Carmelo Anthony, Rafael Restrepo, Mithra Sagar
// Course: ISM 6225 University of South Florida


namespace Assignment2_S19_Group_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //************************************************
            //************************************************
            //******** EXERCISE # 1: Left rotation ***********
            //************************************************
            //************************************************

            Console.WriteLine("Left Rotation");
            // A left rotation operation on an array shifts each of the array's elements 1 unit to the left
            // Request for a user input for the number of times he wants to rotate the array left
            Console.Write("\nPlease key the number of times you want to LEFT rotate an array defined as [1 2 3 4 5]: ");
            string input = Console.ReadLine();
            int d = int.Parse(input);

            // Set an Static Array to test
            int[] a = { 1, 2, 3, 4, 5 };

            // Left Shift Array Method called
            LeftShiftArray(a, d);
            Console.WriteLine(String.Join(",", a));
            Console.ReadKey(true);



            //************************************************
            //************************************************
            //********** EXERCISE 2: Maximum toys ************
            //************************************************
            //************************************************

            Console.WriteLine("\n\nMaximum toys");
            // Initialize k value
            int k = 50;
            // Write prices array
            int[] prices = { 1, 12, 5, 111, 200, 1000, 10 };
            // Call maximumToys method
            maximumToys(prices, k);
            Console.ReadKey(true);



            //************************************************
            //************************************************
            //********** EXERCISE 3: Balanced sums ***********
            //************************************************
            //************************************************

            Console.WriteLine("\n\nBalanced sums");
            List<int> arr = new List<int> { 1, 2, 3 };
            Console.WriteLine(balancedSums(arr));
            Console.ReadKey(true);



                        
            //************************************************
            //************************************************
            //******** EXERCISE 4: Missing numbers ***********
            //************************************************
            //************************************************
     
            Console.WriteLine("\n\nMissing numbers");
            int[] arr1 = { 203, 204, 205, 206, 207, 208, 203, 204, 205, 206 };
            int[] brr = { 203, 204, 204, 205, 206, 207, 205, 208, 203, 206, 205, 206, 204 };
            int[] r2 = missingNumbers(arr1, brr);

            displayArray(r2);
            Console.ReadKey(true);



            //************************************************
            //************************************************
            //******** EXERCISE 5: grading students **********
            //************************************************
            //************************************************
                    
            Console.Write("Student Grades:  ");
            int[] grades = { 73, 67, 38, 33 };
            Console.WriteLine("[{0}]", string.Join(", ", grades));
            int[] r3 = gradingStudents(grades);
            Console.Write("");
            Console.Write("Final Student Grades are:  ");
            Console.WriteLine("[{0}]", string.Join(", ", r3));
            Console.ReadKey(true);


            //************************************************
            //************************************************
            //********* EXERCISE 6: find the median **********
            //************************************************
            //************************************************
            
            Console.WriteLine("\n\nFind the median");
            // Create arr2 
            int[] arr2 = { 0, 1, 2, 4, 6, 5, 3 };
            // Call method findMedian
            findMedian(arr2);
            Console.ReadKey(true);


            //************************************************
            //************************************************
            //********* EXERCISE 7: closest numbers **********
            //************************************************
            //************************************************

            Console.Write("Closest numbers:  ");
            Console.WriteLine("");
            Console.WriteLine("");
            int[] arr3 = { 5, 2, 3, 4, 1 };
            Console.Write("Array:  ");
            Console.WriteLine("[{0}]", string.Join(", ", arr3));

            Console.Write("Closest numbers:  ");
            int[] r4 = closestNumbers(arr3);
            Console.WriteLine("[{0}]", string.Join(", ", r4));
            Console.ReadKey(true);



            //************************************************
            //************************************************
            //******* EXERCISE 8: Day of programmer **********
            //************************************************
            //************************************************

            Console.WriteLine("\n\nDay of Programmer");
            int year = 2017;
            Console.WriteLine(dayOfProgrammer(year));
            Console.ReadKey(true);
        }



        //*********************************************************************************************************************************
        //*********************************************************************************************************************************
        //************************************************     METHODS      ***************************************************************
        //*********************************************************************************************************************************
        //*********************************************************************************************************************************


        //************************************************
        //************************************************
        //******** EXERCISE # 1: Left rotation ***********
        //************************************************
        //************************************************

        static void displayArray(int[] arr)
        {
            Console.WriteLine();
            foreach (int n in arr)
            {
                Console.Write(n + " ");
            }
        }

        // Complete the rotLeft function below.

        public static void LeftShiftArray<T>(T[] arr, int shift)
        {
            shift = shift % arr.Length;
            T[] buffer = new T[shift];
            Array.Copy(arr, buffer, shift);
            Array.Copy(arr, shift, arr, 0, arr.Length - shift);
            Array.Copy(buffer, 0, arr, arr.Length - shift, shift);
           
        }



        //************************************************
        //************************************************
        //********** EXERCISE 2: Maximum toys ************
        //************************************************
        //************************************************
        
        // Complete the maximumToys function below.

        static int maximumToys(int[] prices, int k)
        {
            try
            {
                // Establish variables that will be used in calculating
                int min_position2, temp2;
                int numToys = 0, totPrice = 0;

                // Ask user for their desired budget
                Console.Write("What is your desired budget? ");
                // Take user's input and save to variable k
                string input = Console.ReadLine();
                k = int.Parse(input);

                Console.WriteLine("\nBelow are the sorted prices:");
                // Perform selection sort to go through array and place in ascending order
                for (int i = 0; i < prices.Length; i++)
                {
                    // Sets min_position to keep track of element with lowest value
                    min_position2 = i;
                    // Begins to cycle through array
                    for (int x = i + 1; x < prices.Length; x++)
                    {
                        // If the next element is smaller, then change min_position
                        if (prices[x] < prices[min_position2])
                        {
                            min_position2 = x;
                        }
                    } // End of inner for loop
                    // If min_position does not equal current element evaluated
                    // then perform the swap so that this is now the lowest element
                    if (min_position2 != 1)
                    {
                        temp2 = prices[i];
                        prices[i] = prices[min_position2];
                        prices[min_position2] = temp2;
                    }
                    Console.Write(" " + prices[i]);
                } // End of outer for loop
                Console.WriteLine("\n");
                // For each element in the array
                foreach (int p in prices)
                {
                    // Add each element until totPrice meets or is under budget
                    totPrice += p;
                    if (totPrice <= k)
                    {
                        // Note down the point in array where specifications are met
                        numToys++;
                        // Display the elements in the array that qualify
                        Console.Write(" " + p);
                    }
                    else
                    {
                        // Go back to the last qualifying totPrice
                        totPrice -= p;
                        // Break the loop
                        break;
                    }
                }

                // Display amount of toys individual can by and their accumulated total
                Console.WriteLine("\nYou can only buy " + numToys + " toys at most." +
                    " Their prices are listed directly above and total is: " + totPrice);
            }
            catch
            {
                // Catch block to handle exceptions
                Console.WriteLine("\nThe program failed to calculate. Please close and try again.");
                Console.ReadKey(true);
            }
            return 0;
        }



        //************************************************
        //************************************************
        //********** EXERCISE 3: Balanced sums ***********
        //************************************************
        //************************************************
        
        // Complete the balancedSums function below.

        static string balancedSums(List<int> arr)

        {
            try
            {
                //Instantiate variables to sum from both end of array
                int i = 0;
                int j = arr.Count - 1;
                //Instantiate variable to determine if both sides of array equal
                int sum = 0;
                //Instantiate output vairiable
                string isBalanced = "No";

                //While loop through array and adjust sum total minus total from right end of array and add from left end of array 
                while (i != j)
                {
                    if (sum >= 0)
                    {
                        sum -= arr[j];
                        j--;
                    }
                    else
                    {
                        sum += arr[i];
                        i++;
                    }
                }
                //If sum equals zero, array sums can be balanced. Change output to "Yes"
                if (sum == 0)
                    isBalanced = "Yes";

                //return output string
                return isBalanced;

            }//End try

            catch
            {
                // Catch block to handle exceptions
                Console.WriteLine("\nThe program balancedSums failed to calculate. Please close and try again.");
                Console.ReadKey(true);
            }//End catch

            return "";
        }


        //************************************************
        //************************************************
        //******** EXERCISE 4: Missing numbers ***********
        //************************************************
        //************************************************
        
        // Complete the missingNumbers function below.

        static int[] missingNumbers(int[] arr, int[] brr)

        {
            return new int[] { };
        }




        //************************************************
        //************************************************
        //******** EXERCISE 5: grading students **********
        //************************************************
        //************************************************

        // Complete the gradingStudents function below.

        static int[] gradingStudents(int[] grades)
            {
                /*
                 * Write your code here.
                 */
                List<int> list = new List<int>();
                foreach (int g in grades)
                {
                    if (g < 38)
                    {
                        list.Add(g);
                    }
                    else
                    {
                        int rd = 5 * (int)Math.Round(g / 5.0);
                        if (rd < g)
                        {
                            rd += 5;
                        }
                        if (rd - g < 3)
                        {
                            list.Add(rd);
                        }
                        else
                        {
                            list.Add(g);
                        }
                    }
                }
                return list.ToArray();
            }



        //************************************************
        //************************************************
        //********* EXERCISE 6: find the median **********
        //************************************************
        //************************************************
    
        // Complete the findMedian function below.

        static int findMedian(int[] arr2)
        {
            try
            {
                // Establish variables that will be used in calculating
                int min_position6;
                int temp;

                Console.Write("The median of the following sorted array [");
                // Perform selection sort to go through array and place in ascending order
                for (int i = 0; i < arr2.Length; i++)
                {
                    // Sets min_position to keep track of element with lowest value
                    min_position6 = i;
                    // Begins to cycle through array
                    for (int x = i + 1; x < arr2.Length; x++)
                    {
                        // If the next element is smaller, then change min_position
                        if (arr2[x] < arr2[min_position6])
                        {
                            min_position6 = x;
                        }
                    } // End of inner for loop
                    // If min_position does not equal current element evaluated
                    // then perform the swap so that this is now the lowest element
                    if (min_position6 != 1)
                    {
                        temp = arr2[i];
                        arr2[i] = arr2[min_position6];
                        arr2[min_position6] = temp;
                    }
                    Console.Write(" " + arr2[i]);
                } // End of outer for loop

                // Divide sorted length of array by 2 to gain median value
                int med = arr2.Length / 2;
                // Display median value in output
                Console.Write(" ] is: " + med);
            }
            catch
            {
                // Catch block to handle exceptions
                Console.WriteLine("\nThe program failed to calculate. Please close and try again.");
                Console.ReadKey(true);
            }
            return 0;
        }


        //************************************************
        //************************************************
        //********* EXERCISE 7: closest numbers **********
        //************************************************
        //************************************************

        // Complete the closestNumbers function below.

        static int[] closestNumbers(int[] arr)
        {
            // Complete this function
            int difference = int.MaxValue;
            List<int> nums = new List<int>();
            Array.Sort(arr);
            for (int i = 1; i < arr.Length; i++)
            {
                if (Math.Abs(arr[i] - arr[i - 1]) < difference)
                {
                    nums.Clear();
                    difference = Math.Abs(arr[i] - arr[i - 1]);
                }
                if (Math.Abs(arr[i] - arr[i - 1]) == difference)
                {
                    nums.Add(arr[i - 1]);
                    nums.Add(arr[i]);
                }
            }
            return nums.ToArray();
        }



        //************************************************
        //************************************************
        //******* EXERCISE 8: Day of programmer **********
        //************************************************
        //************************************************

        // Complete the dayOfProgrammer function below.

        static string dayOfProgrammer(int year)
        {
            try
            {
                // Create dayOfYear, resultMonth, and ResultDay variables
                // and initialize them with values 
                int dayOfYear = 256;
                int resultMonth = 0;
                int resultDay = 0;

                // Prompt the user to input the year they are traveling to
                Console.Write("Enter the year you are traveling to: ");
                string input8 = Console.ReadLine();
                // Take user's input and update the Year variable 
                year = int.Parse(input8);

                // Create new array that includes the min amount of days in each month, starting at Month 0)
                int[] daysPerMonth = new int[13] { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

                // Create conditional statements that will change # of days in Feb
                // If the year is 1918
                if (year == 1918)
                {
                    // Reduce February by 13 days 
                    // to reflect shift from Julian to Gregorian calendar
                    daysPerMonth[2] -= 13;
                }
                // Otherwise, if the year is before 1918 and divisible by 4
                else if ((year < 1918 && year % 4 == 0) ||
                    // OR if the year is after 1918 and is divisible by 4 but not divisible by 100
                    (year > 1918 && ((year % 4 == 0 & year % 100 != 0) ||
                    // OR if the year is divisible by 400 only
                    (year % 400 == 0))))
                {
                    // Make those years a leap year
                    // by adding 1 extra day to February
                    daysPerMonth[2]++;
                }

                // For loop that wil cycle through length of each month
                // in order to find 256th day of the year
                for (int d = 0; d < daysPerMonth.Length; d++)
                {
                    // If the day of the year (256) is less or equal to
                    // the current position of the counter
                    if (dayOfYear <= daysPerMonth[d])
                    {
                        // That month is the resultMonth
                        resultMonth = d;

                        // If we are in February
                        // and the year is 1918
                        if (d == 2 && year == 1918)
                        {
                            // Add 13 days to reflect
                            // the jump from Jan 31 to Feb 14
                            dayOfYear += 13;
                        }
                        // Take the final day calculated as 
                        // the result Day
                        resultDay = dayOfYear;
                        // Break out of the loop
                        break;
                    }
                    else
                    {
                        // The day of a regular year is calculated by 
                        // subtracting the remaining days in the month
                        // from the position of the counter
                        dayOfYear -= daysPerMonth[d];
                    }
                }

                // Display the answer to the user
                Console.WriteLine("In your year, the Day of the Programmer" +
                    " is on " + resultDay + "." + resultMonth + "." + year + "!");
            }
            catch
            {
                // Catch block to handle exceptions
                Console.WriteLine("\nThe program failed to calculate. Please close and try again.");
                Console.ReadKey(true);
            }
            return "";
        }

    } // End of class
} // End of namespace