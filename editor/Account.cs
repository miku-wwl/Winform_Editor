using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace editor
{
    class Account
    {
        // Use ReadAllLines() to read login information
        public String[] userName = new string[100];
        public String[] passWord = new string[100];
        public String[] userType = new string[100];
        public String[] firstName = new string[100];
        public String[] lastName = new string[100];
        public String[] birthDay = new string[100];
        public int count = -1;

        public void Read()
        {
            count = -1;
            string[] lines = System.IO.File.ReadAllLines("login.txt");
            foreach (string set in lines)
            {
                // Split each line
                count++;
                string[] splits = set.Split(',');
                userName[count] = splits[0];
                passWord[count] = splits[1];
                userType[count] = splits[2];
                firstName[count] =splits[3];
                lastName[count] = splits[4];
                birthDay[count] = splits[5];

            }
            
        }
        public void Print()
        {
            using (StreamWriter sw = new StreamWriter("test.txt",true))
            {
                sw.WriteLine("{0}",this.count);

                for (int i = 0; i <= count; i++)
                {

                   sw.WriteLine("{0}{1}{2}{3}{4}{5}\n", userName[i], passWord[i], userType[i], firstName[i], lastName[i], birthDay[i]);

                }
                sw.Close();
            
            }
           


            
        }
        
        
}
}
