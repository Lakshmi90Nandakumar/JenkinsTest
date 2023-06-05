using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JenkinsTest
{
    [TestClass]
    public class example
    {
        [TestMethod]
        public void ReverseWithoutSplit() 
        {
            String s = "My Name is Lakshmi";
            string[] str = new string[5];
            int j = 0, k = 0, v = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ' || i == s.Length - 1)
                {
                    str[j] = s.Substring(k, v);
                    v = 1;
                    Console.WriteLine(str[j]);
                    j++;
                    k = i + 1;
                }
                else
                {
                    v++;
                }

            }
            for (int i = str.Length - 1; i >= 0; i--)
            {
                Console.Write(str[i] + " ");
            }
        }
        [TestMethod]
        public void PrintPossible()
        {
            string s = "sum";
            for(int i=0;i<s.Length;i++)
            {
                for(int j=1;j<=s.Length-i;j++)
                {
                    Console.WriteLine(s.Substring(i,j));
                }
               
            }
           
        }
    }
}
