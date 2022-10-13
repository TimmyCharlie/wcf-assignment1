using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Assignment1Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string Prime(int n)
        {
            int i, m = 0, flag = 0;
            m = n / 2;
            for (i = 2; i <= m; i++)
            {
                if (n % i == 0)
                {
                    return("Number is not Prime.");
                }
            }
            if (flag == 0)
                return ("Number is Prime.");
            else
                return ("Error");
        }

        public string PrintHtml(string tag, string data)
        {
            string startTag, endTag;
            startTag = "<" + tag + ">";
            endTag = "<" + "/" + tag + ">";
            return(startTag + data + endTag);
        }

        public string ReverseString(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public int[] Sort5(int[] ints, int order)
        {
            int num1;
            Boolean swapped = true;



            if (order == 1)
            {
                while (swapped)
                {
                    swapped = false;
                    for (int counter = 0; counter < 4; counter++)
                    {
                        if (ints[counter] > ints[counter + 1])
                        {
                            num1 = ints[counter];
                            ints[counter] = ints[counter + 1];
                            ints[counter + 1] = num1;
                            swapped = true;

                        }
                    }
                }
            }
            else
            {
                {
                    while (swapped)
                    {
                        swapped = false;
                        for (int counter = 0; counter < 4; counter++)
                        {
                            if (ints[counter] < ints[counter + 1])
                            {
                                num1 = ints[counter];
                                ints[counter] = ints[counter + 1];
                                ints[counter + 1] = num1;
                                swapped = true;

                            }
                        }
                    }
                }
            }
            return ints;
        }

        public int SumDigit(int n1)
        {
            int  sum = 0, m1;
            while (n1 > 0)
            {
                m1 = n1 % 10;
                sum = sum + m1;
                n1 = n1 / 10;
            }
            return sum;
        }
    }
}
