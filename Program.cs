namespace App1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( Solution.MergeAlternately("abc", "pqrzz"));
            Console.WriteLine(Solution.GcdOfStrings("TAUXXTAUXXTAUXXTAUXXTAUXX", "TAUXXTAUXXTAUXXTAUXXTAUXXTAUXXTAUXXTAUXXTAUXX"));
            
        }
    }
    public static class Solution
    {
        public static string MergeAlternately(string word1, string word2)
        {
            int l1 = word1.Length;
            int l2 = word2.Length;
            int len=l1<l2?l2:l1;
            bool isLower1 = word1.All(c => char.IsLower(c));
            bool isLower2 = word2.All(c => char.IsLower(c));
           string finalstr = "";

            if (l1 >= 1 && l2 <= 100 && isLower1 && isLower2)
            {
                int p1 = 0;
                int p2 = 0;
                for(int i = 0; i < len; i++)
                {
                    if(p1<l1)
                    {
                        finalstr += (word1[p1++]);
                    }
                   if(p2<l2)
                    {
                        finalstr += (word2[p2++]);
                    }

                }

            }
            return finalstr;
        }

        public static string GcdOfStrings(string str1, string str2)
        {
            if (str1 + str2 != str2 + str1)
            {
                return "";
            }
            int a =str1.Length;
            int b = str2.Length;
            while (b>0)
            {
                int temp = b;
                b = a % b;
                a= temp;
            }

            string str = str1.Substring(0, a);

            return str;
        }
    }

}
