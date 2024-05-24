using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            string username = "tranhuuduy";
            string password = "29102005";
            string time= "12345";

            string content;
            using (StringWriter sw = new StringWriter())
            {
                sw.WriteLine("username "+ username);
                sw.WriteLine("password "+ password);
                sw.WriteLine("time "+ time);
                 content = sw.ToString();
            }
            using (StringReader StringReader = new StringReader(content))
            {
                string line;
                while ((line = StringReader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }



        }
       
    }
}
