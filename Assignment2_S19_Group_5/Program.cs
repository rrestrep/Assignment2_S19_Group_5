using System;

using System.Collections.Generic;



namespace Assignment2_S19_Group_5

{

    class Program

    {

        static void Main(string[] args)

        {

        // EXERCISE # 1: Left rotation

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

        // EXERCISE 2: Maximum toys

            Console.WriteLine("\n\nMaximum toys");
            // Initialize k value
            int k = 50;
            // Write prices array
            int[] prices = { 1, 12, 5, 111, 200, 1000, 10 };
            // Call maximumToys method
            maximumToys(prices, k);
            Console.ReadKey(true);


        // EXERCISE 3: Balanced sums

            Console.WriteLine("\n\nBalanced sums");
            List<int> arr = new List<int> { 1, 2, 3 };
            Console.WriteLine(balancedSums(arr));
            Console.ReadKey(true);


        // EXERCISE 4: Missing numbers

            Console.WriteLine("\n\nMissing numbers");
            int[] arr1 = { 203, 204, 205, 206, 207, 208, 203, 204, 205, 206 };
            int[] brr = { 203, 204, 204, 205, 206, 207, 205, 208, 203, 206, 205, 206, 204 };
            int[] r2 = missingNumbers(arr1, brr);

            displayArray(r2);
            Console.ReadKey(true);


        // EXERCISE 5: grading students

            Console.WriteLine("\n\nGrading students");
            int[] grades = { 73, 67, 38, 33 };
            int[] r3 = gradingStudents(grades);
            displayArray(r3);
            Console.ReadKey(true);


        // EXERCISE 6: find the median

            Console.WriteLine("\n\nFind the median");
            // Create arr2 
            int[] arr2 = { 0, 1, 2, 4, 6, 5, 3 };
            // Call method findMedian
            findMedian(arr2);
            Console.ReadKey(true);

        // EXERCISE 7: closest numbers

            Console.WriteLine("\n\nClosest numbers");
            int[] arr3 = { 5, 4, 3, 2 };
            int[] r4 = closestNumbers(arr3);
            displayArray(r4);
            Console.ReadKey(true);


        // EXERCISE 8: Day of programmer
            Console.WriteLine("\n\nDay of Programmer");
            int year = 2017;
            Console.WriteLine(dayOfProgrammer(year));
            Console.ReadKey(true);
        }



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

        // Complete the balancedSums function below.

        static string balancedSums(List<int> arr)

        {
            return "";
        }

        // Complete the missingNumbers function below.

        static int[] missingNumbers(int[] arr, int[] brr)

        {
            return new int[] { };
        }

        // Complete the gradingStudents function below.

        static int[] gradingStudents(int[] grades)

        {
            return new int[] { };
        }
    
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

        // Complete the closestNumbers function below.

        static int[] closestNumbers(int[] arr)

        {       
            return new int[] { };
        }

        // Complete the dayOfProgrammer function below.

        static string dayOfProgrammer(int year)

        {
            return "";
        }

    } // End of class
} // End of namespace