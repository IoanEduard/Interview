namespace _LeetCode_Hard.NumberOfWaysToFormATargetStringGivenADictionary
{
    public class Editorial
    {
        public int NumWays(string[] words, string target)
        {
            // problem constraint "return it modulo 10^9 + 7."
            const int mod = 1000000007;

            //  the length of strings in words
            var k = words[0].Length;

            //  be the length of target
            var m = target.Length;

            /*
                We can imagine words as a matrix containing n rows (each being a word) and k columns.
                The process of building target is as follows. We iterate over columns of the matrix from left to right, and at each of them, we have two options: 
                    1. to pick a character at the current column 
                    OR
                    2. to skip.
            */

            // Let frequencyCount[c][j] denote the number of occurrences of the character c in the j-th column of the matrix – one can precompute this before calculating the DP.
            var frequencyCount = new int[26][];

            // we initialize frequency count array
            for (var i = 0; i < frequencyCount.Length; i++)
                frequencyCount[i] = new int[k];

            /*
                0 1 2 3
                a c c a
                b b b b 
                c a c a

                Count character c in the j-th column index
                a  1 1 0 2 
                b  1 1 1 1 
                c  1 1 2 0
                d  0 0 0 0 
                e  0 0 0 0
                
                ..
                0 0 0 0

                I am having an array of all characters which have an array for their frequency in the words
            */
            for (var i = 0; i < k; i++)
                foreach (var word in words)
                    frequencyCount[word[i] - 'a'][i]++;

            // We initialize dp matrix with m + 1 rows
            // Why m + 1 rows?
            double[][] dp = new double[m + 1][];

            for (var i = 0; i < dp.Length; i++)
                dp[i] = new double[k + 1]; // why k + 1 columns

            dp[0][0] = 1;

            // dp[i][j] be the number of ways to build the prefix of target of length i using only the j leftmost columns.
            // Why i <= m
            for (var i = 0; i <= m; i++)
            {
                for (var j = 0; j < k; j++)
                {
                    // if i < m, we need to add the character target[i] to the currently built prefix; otherwise, we have completely built the string target.
                    if (i < m)
                    {
                        // When we choose a character target[i] from the j-th column and add it to the current prefix (which has length i before adding), its length becomes i + 1. 
                        // After this, we cannot use the j-th column, and have to move to the (j + 1)-th one. It describes a transition from the state dp[i][j] to dp[i + 1][j + 1]
                        dp[i + 1][j + 1] += frequencyCount[target[i] - 'a'][j] * dp[i][j];

                        //  In how many ways can one perform such a transition? The number of ways to choose a character target[i] in the j-th column equals cnt[target[i]][j] – the number of its occurrences. 
                        //  Therefore, we can do dp[i + 1][j + 1] += cnt[target[i]][j] * dp[i][j].
                        dp[i + 1][j + 1] %= mod;
                    }
                    // When we skip the j-th column and move on to the (j + 1)-th one, we do not add anything to the current prefix, and its length remains equal to i
                    dp[i][j + 1] += dp[i][j];

                    // Here we have a transition from the state dp[i][j] to dp[i][j + 1]. There is one way not to choose any character, therefore we can do dp[i][j + 1] += dp[i][j].
                    dp[i][j + 1] %= mod;
                }
            }

            // The answer to the problem is dp[m][k] – we need to build the string of length m using k columns.
            /*
                1 1 1 1 1
                0 1 2 2 4
                0 0 1 3 5
                0 0 0 0 6
            */
            return (int)dp[m][k];
        }
    }
}

