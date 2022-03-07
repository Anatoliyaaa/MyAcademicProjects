using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР_5
{
    class Program
    {
        static void Main(string[] args)
        {

            //string Bin = "1";
            //string Oct = "1";
            //long Dec = 15;
            //long Hex = 0xf;
            //long temp;

            /////*из восьмеричной в шестнадцатеричную ВНИМАНИЕ! вначале переводим
            ////в десятичную по основанию 2, а затем в восьмеричную*/
            //temp = Convert.ToInt64(Bin, 2);
            //Console.WriteLine("{0} : восьмеричная : {1}", Oct, Convert.ToString(temp, 16));//

            Console.WriteLine(SS_8_16.Convert("10"));


            Console.ReadKey();
        }
    }
        public class SS_8_16
        {
            private static string S = "";
            public static string Convert(string input)
            {
                input = sign(input);
                int num = ConvertForm8To10(input);
                return S+ConvertTo16(num);
            }

            private static string sign(string input)
            {
                if (input[0] == '-')
                { input = input.Remove(0,1); S = "-"; }
                    
                return input;
            }

            private static int ConvertForm8To10(string input)
            {
                input = input.ToUpper();
                int result = 0;
                for (int i = 0; i < input.Length; i++)
                {
                    int pow = (int)Math.Pow(8, input.Length - 1 - i);
                    if (pow < 1) pow = 1;
                    int a = -1;
                    switch (input[i])
                    {
                        case '0':
                            a = 0;
                            break;
                        case '1':
                            a = 1;
                            break;
                        case '2':
                            a = 2;
                            break;
                        case '3':
                            a = 3;
                            break;
                        case '4':
                            a = 4;
                            break;
                        case '5':
                            a = 5;
                            break;
                        case '6':
                            a = 6;
                            break;
                        case '7':
                            a = 7;
                            break;
                    }
                    //if (a == -1) 
                    result += a * pow;
                }
                return result;
            }

            private static string ConvertTo16(int input)
            {
                string result = string.Empty;
                int b = GetHighRank(input);
                for (int i = 0; i < b; i++)
                {
                    int high16 = 1;
                    while (high16 * 16 < input)
                        high16 *= 16;
                    string a = (input / high16).ToString();
                    switch (a)
                    {
                        case "8":
                            a = "8";
                            break;
                        case "9":
                            a = "9";
                            break;
                        case "10":
                            a = "A";
                            break;
                        case "11":
                            a = "B";
                            break;
                        //case "12":
                        //    a = "C";
                        //    break;
                        //case "13":
                        //    a = "D";
                        //    break;
                        //case "14":
                        //    a = "E";
                        //    break;
                        //case "15":
                        //    a = "F";
                        //    break;
                    }
                    result += a;
                    input = input - (int)input / (int)high16 * high16;
                }
                return result;
            }

            private static int GetHighRank(int input)
            {
                if (input == 0 || input == 1) return 1;
                int res = 0, a = 1;
                while (input > a)
                {
                    a *= 16;
                    res++;
                }
                return res;
            }
        }

    
}
