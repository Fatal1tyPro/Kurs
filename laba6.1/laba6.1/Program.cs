using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba5._1
{
    internal class Program
    {
            static void Main()
            {
                string[] myArray = { "apple", "banana", "orange" };
                string newValue = "GrapE";

                string[] resultArray = AddValueToArray(myArray, newValue);


                if (resultArray != null)
                {
                    Console.WriteLine(string.Join(", ", resultArray));
                }
                else
                {
                    Console.WriteLine("Invalid parameters.");
                }
            }

            static string[] AddValueToArray(string[] arr, string value)
            {

                if (arr == null || value == null)
                {
                    return null;
                }


                string valueLower = value.ToLower();


                if (arr.Any(x => x.ToLower() == valueLower))
                {
                    return arr;
                }


                if (arr.Length < 10)
                {
                    Array.Resize(ref arr, arr.Length + 1);
                    arr[arr.Length - 1] = value;
                }
                else
                {

                    string[] newArr = new string[arr.Length + 1];
                    Array.Copy(arr, newArr, arr.Length);
                    newArr[arr.Length] = value;
                    arr = newArr;
                }

                return arr;
            }
        }
    }