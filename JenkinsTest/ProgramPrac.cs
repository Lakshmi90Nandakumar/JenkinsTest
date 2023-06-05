using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JenkinsTest
{
    [TestClass]
    public class ProgramPrac
    {
        [TestMethod]
        public void NamePyramid()
        {
            string s = "Lakshmi";
            int len=s.Length;
            for(int i=0;i<s.Length;i++)
            {
                for(int j=s.Length-1;j>=(len=i);j--)
                {
                    Console.Write(" ");
                }
                for(int j=0;j<=i;j++)
                {
                    Console.Write(s[i] + " ");
                }
                Console.WriteLine();
            }
        }
        [TestMethod]
        public void ComboNotRepeat()
        {
            int[] n = { 7, 3, 3, 8, 2, 6, 4, 5, 4, 4,6,2,8,};
            Dictionary<int,int> dic= new Dictionary<int,int>();
            for(int i=0;i<n.Length;i++)
            {
              for(int j=i+1;j<n.Length;j++)
                {
                    if (n[i] + n[j]==10)
                    {
                        if (!dic.ContainsKey(n[i]))
                        {
                            if (!dic.ContainsValue(n[j]))
                            {
                                dic.Add(n[i], n[j]);
                            }
                        }
                    }
                }
            }
            foreach(KeyValuePair<int,int> kvp in dic)
            {
                Console.WriteLine(kvp.Key+" + "+kvp.Value);
            }
                
        }
    }
}
