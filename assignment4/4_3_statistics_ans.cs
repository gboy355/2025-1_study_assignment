using System;
using System.Linq;

namespace statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] data = {
                {"StdNum", "Name", "Math", "Science", "English"},
                {"1001", "Alice", "85", "90", "78"},
                {"1002", "Bob", "92", "88", "84"},
                {"1003", "Charlie", "79", "85", "88"},
                {"1004", "David", "94", "76", "92"},
                {"1005", "Eve", "72", "95", "89"}
            };
            // You can convert string to double by
            // double.Parse(str)

            int stdCount = data.GetLength(0) - 1;
            // ---------- TODO ----------
            // Average Scores
            int[] Mathscore = new int[stdCount];
            int[] Sciencescore = new int[stdCount];
            int[] Englishscore = new int[stdCount];
            for (int i = 1; i <= stdCount; i++) {Mathscore[i - 1] = double.Parse(date[i, 2]); Sciencescore[i - 1] = double.Parse(data[i, 3]); Englishscore[i - 1]= double.Parse(data[i, 4]);}
            Console.WriteLine("Average Scores:");
            Console.WriteLine($"Math: {Mathscore.sum() / stdCount}");
            Console.WriteLine($"Science: {Sciencescore.sum() / stdCount}");
            Console.WriteLine($"English: {Englishscore.sum() / stdCount}");
            // --------------------
        }
    }
}

/* example output

Average Scores: 
Math: 84.40
Science: 86.80
English: 86.20

Max and min Scores: 
Math: (94, 72)
Science: (95, 76)
English: (92, 78)

Students rank by total scores:
Alice: 2nd
Bob: 5th
Charlie: 1st
David: 4th
Eve: 3rd

*/
