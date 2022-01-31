using System;

namespace DIS_Assignmnet1_SPRING_2022
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1
            Console.WriteLine("Q1: Enter the string:");
            string s = Console.ReadLine();
            string final_string = RemoveVowels(s);
            Console.WriteLine("Final string after removing the Vowels: {0}", final_string);
            Console.WriteLine();

            //Question 2:
            string[] bulls_string1 = new string[] { "Marshall", "Student", "Center" };
            string[] bulls_string2 = new string[] { "MarshallStudent", "Center" };
            bool flag = ArrayStringsAreEqual(bulls_string1, bulls_string2);
            Console.WriteLine("Q2");
            if (flag)
            {
                Console.WriteLine("Yes, Both the array’s represent the same string");
            }
            else
            {
                Console.WriteLine("No, Both the array’s don’t represent the same string ");
            }
            Console.WriteLine();

            //Question 3:
            int[] bull_bucks = new int[] { 1, 2, 3, 2 };
            int unique_sum = SumOfUnique(bull_bucks);
            Console.WriteLine("Q3:");
            Console.WriteLine("Sum of Unique Elements in the array are :{0}", unique_sum);
            Console.WriteLine();


            //Question 4:
            int[,] bulls_grid = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Console.WriteLine("Q4:");
            int diagSum = DiagonalSum(bulls_grid);
            Console.WriteLine("The sum of diagonal elements in the bulls grid is {0}:", diagSum);
            Console.WriteLine();

            //Question 5:
            Console.WriteLine("Q5:");
            String bulls_string = "aiohn";
            int[] indices = { 3, 1, 4, 2, 0 };
            String rotated_string = RestoreString(bulls_string, indices);
            Console.WriteLine("The  Final string after rotation is {0} ", rotated_string);
            Console.WriteLine();

            //Quesiton 6:
            string bulls_string6 = "mumacollegeofbusiness";
            char ch = 'c';
            string reversed_string = ReversePrefix(bulls_string6, ch);
            Console.WriteLine("Q6:");
            Console.WriteLine("Resultant string are reversing the prefix:{0}", reversed_string);
            Console.WriteLine();

        }

        /* 
        <summary>
        Given a string s, remove the vowels 'a', 'e', 'i', 'o', and 'u' from it, and return the new string.
        Example 1:
        Input: s = "MumaCollegeofBusiness"
        Output: "MmCllgfBsnss"
        Example 2:
        Input: s = "aeiou"
        Output: ""
        Constraints:
        •	0 <= s.length <= 10000
        s consists of uppercase and lowercase letters
        </summary>
        */

        private static string RemoveVowels(string s)
        {
            // In the below problem foreachloop is used  to check vowels present in a string by comparing each vowel with each character present in a string varaiable
            //IF Vowels present after checking.I have used temporary string variable to store the characters which are not vowels and returns final string variable for function call
      
            try
            {
                string final_string = "";  //temporary  string varaible
                foreach (char c in s)
                {  // Each character in string variable is compared with vowel
                    if (c != 'a' && c != 'A' && c != 'e' && c != 'E' && c != 'i' && c != 'I' && c != 'o' && c != 'O' && c != 'u' && c != 'U')
                    {
                        final_string = final_string+c;
                    }
                }
                return final_string;
            }
            catch (Exception)
            {
                throw;
            }

        }

        /*<summary>
       Given two string arrays word1 and word2, return true if the two arrays represent the same string, and false otherwise.
       A string is represented by an array if the array elements concatenated in order forms the string.
       Example 1:
       Input: : bulls_string1 = ["Marshall", "Student",”Center”], : bulls_string2 = ["MarshallStudent ", "Center"]
        Output: true
       Explanation:
       word1 represents string "marshall" + "student" + “center” -> "MarshallStudentCenter "
       word2 represents string "MarshallStudent" + "Center" -> "MarshallStudentCenter"
       The strings are the same, so return true.
       Example 2:
       Input: word1 = ["Zimmerman", "School", ”of Advertising”, ”and Mass Communications”], word2 = ["Muma", “College”,"of”, “Business"]
        Output: false
       Example 3:
       Input: word1  = ["University", "of", "SouthFlorida"], word2 = ["UniversityofSouthFlorida"]
        Output: true
       </summary>
       */

        private static bool ArrayStringsAreEqual(string[] bulls_string1, string[] bulls_string2)
        {  //string concatenation is used here
           //Concat() method is used to join array of strings
            try
            {
                string bulls_string1_tot1 = string.Concat(bulls_string1); //joining bulls_string1 elements
                string bulls_string2_tot2 = string.Concat(bulls_string2); //joining bulls_string2 elements
                if (bulls_string1_tot1 == bulls_string2_tot2) //checking if joined strings are equal
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        /*
        <summary> 
       You are given an integer array bull_bucks. The unique elements of an array are the elements that appear exactly once in the array.
       Return the sum of all the unique elements of nums.
       Example 1:

       Input: bull_bucks = [1,2,3,2]
       Output: 4

       Explanation: The unique elements are [1,3], and the sum is 4.
       Example 2:
       Input: bull_bucks = [1,1,1,1,1]
       Output: 0
       Explanation: There are no unique elements, and the sum is 0.
       Example 3:
       Input: bull_bucks = [1,2,3,4,5]
       Output: 15
       Explanation: The unique elements are [1,2,3,4,5], and the sum is 15.

       </summary>
        */
        private static int SumOfUnique(int[] bull_bucks)
        {
            try
            {
                int[] integer_array = new int[100]; // forming a corresponding count array that stores count of each element from the input array
                int j = 0;
                int total = 0;
                foreach (int x in bull_bucks)
                {
                    integer_array[x-1] = integer_array[x-1] + 1;
                }

                foreach (int i in integer_array)
                {
                    j = j+1;
                    if (i == 1)
                    {
                        total = total + j; //calculating the sum of unique elements.
                    }
                   
                }
                return total;

            }
            catch (Exception)
            {
                throw;
            }
        }

        /*
       <summary>
      Given a square matrix bulls_grid, return the sum of the matrix diagonals.
      Only include the sum of all the elements on the primary diagonal and all the elements on the secondary diagonal that are not part of the primary diagonal.
      Example 1:
      Input: bulls_grid = [[1,2,3],[4,5,6], [7,8,9]]
      Output: 25

      Explanation: Diagonals sum: 1 + 5 + 9 + 3 + 7 = 25
      Notice that element mat[1][1] = 5 is counted only once.
      Example 2:
      Input: bulls_grid = [[1,1,1,1], [1,1,1,1],[1,1,1,1], [1,1,1,1]]
      Output: 8
      Example 3:

      Input: bulls_grid = [[5]]
      Output: 5

      </summary>
       */

        private static int DiagonalSum(int[,] bulls_grid)
        {
            //In the below given square matrix where x represents rows and y represent the columns
            // Calculate the diagonal elements.
            //By comparing x&y 1st diagonal elements value is caluclated
            //By comparing x+y with the value size-1 the cross diagonal is calculated.
            // Elements satisfying the conditions will be added to a temp variable and the specific result will be sent back to the function call
            try
            {
                int total = 0;
                int size = bulls_grid.GetLength(0);

                for (int x = 0; x < size; x++)
                {
                    for (int y = 0; y < size; y++)
                    {
                        if (x == y)   // Calculating the sum of first diagonal elements
                        {
                            total = total + bulls_grid[x, y];
                        }
                        if (x + y == size - 1 && x != y) // elements of cross diagonal elements is caluclated ,
                                                         //preventing repetitive addition of same array elements  Using i!=j   

                        {
                            total = total + bulls_grid[x, y];
                        }
                    }
                }
                return total;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        /* <summary>
         Given a string bulls_string  and an integer array indices of the same length.
         The string bulls_string  will be shuffled such that the character at the ith position moves to indices[i] in the shuffled string.
         Return the shuffled string.
         Example 3:
         Input: bulls_string  = "aiohn", indices = [3,1,4,2,0]
         Output: "nihao"
         */
        private static string RestoreString(string bulls_string, int[] indices)
        { //Array.IndexOf() is used
            try
            {
                string y = "";  // Temporary string variable
                for (int x = 0; x < indices.Length; x++)
                {  //Using Array.IndexOf postion to arrange them accordingly (ascending order) 
                    y += bulls_string[Array.IndexOf(indices, x)];
                }
                return y;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

        }
        /*
        <summary>
       Given a 0-indexed string bulls_string   and a character ch, reverse the segment of word that starts at index 0 and ends at the index of the first occurrence of ch (inclusive). If the character ch does not exist in word, do nothing.
       For example, if word = "abcdefd" and ch = "d", then you should reverse the segment that starts at 0 and ends at 3 (inclusive). The resulting string will be "dcbaefd".
       Return the resulting string.

       Example 1:
       Input: bulls_string   = "mumacollegeofbusiness", ch = "c"
       Output: "camumollegeofbusiness"
       Explanation: The first occurrence of "c" is at index 4. 
       Reverse the part of word from 0 to 4 (inclusive), the resulting string is "camumollegeofbusiness".

       Example 2:
       Input: bulls_string   = "xyxzxe", ch = "z"
       Output: "zxyxxe"
       Explanation: The first and only occurrence of "z" is at index 3.
       Reverse the part of word from 0 to 3 (inclusive), the resulting string is "zxyxxe".

       Example 3:
       Input: bulls_string   = "zimmermanschoolofadvertising", ch = "x"
       Output: "zimmermanschoolofadvertising"
       Explanation: "x" does not exist in word.
       You should not do any reverse operation, the resulting string is "zimmermanschoolofadvertising".
       */

        private static string ReversePrefix(string bulls_string6, char ch)
        {
            try
            {
                int i = 0;
                string prefix_string = ""; //temp output varaiable
                for (int x = 0; x < bulls_string6.Length; x++) //Checking whether the given character is present in the string
                {
                    if (ch == bulls_string6[x])
                    {
                        i = x;
                        break;
                    }

                }

                for (int y = i; y >= 0; y--) //reversing the string
                {
                    prefix_string = prefix_string + bulls_string6[y];

                }
                for (int y = i + 1; y < bulls_string6.Length; y++) //combining  reversed string to the remaining string 
                {
                    prefix_string = prefix_string + bulls_string6[y];
                }

                return prefix_string;


            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}






