    class LINQQueryExpressions
    {
        static void Main()
        {         
            // Specify the data source.
            int[] testScores = new int[] { 97, 92, 81, 60 };

            // Define the query expression.
            IEnumerable<int> testScoreQuery =
                from score in testScores
                where score > 80
                select score;

            // Execute the query.
            foreach (int i in testScoreQuery)
            {
                Console.Write(i + " ");
            }  
            // Output: 97 92 81

            // Final projects are coming up, and we need a place
            // to put those grades
            int[] finalProjectScores = new int[4];

            // Each student hands in their project
            finalProjectScores[0] = 89;
            finalProjectScores[1] = 90;
            finalProjectScores[2] = 76;
            finalProjectScores[3] = 100;

            // Student 4 aced their final project! They'll get a
            // boost to their last test grade
            testScores[3] += 15;

            // Let's look at everyone's scores
            foreach (var s in testScores)     
            {
                Console.Write(s + " ");
            }
            // Output: 97 92 81 75    
        }
    }
    