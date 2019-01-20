using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Multidimensional_Arrays
{
    class Program
    {
        // Created a Multidimensional Array that has names of stars for elements
        static void Main(string[] args)
        {
            // 2 dimensional array 
            string[,] Names = 
            {
            {"Chris","Tucker"},
            {"Bill","Murray"},
            {"Jackie","Chan"},
            {"Bruce","Lee"}
            }; //end of Array

            // created a forloop which names gets the Upper bound
            //  which returns the last index in the first dimension of the array
            for (int x = 0; x <= Names.GetUpperBound(0);x++)
            {
                //Declared Strings that equals the array elements
                // [x,0] gets the names which are in element 0
                // [x,1] gets the names which are in element 1
                string F_Name = Names[x, 0];
                string L_Name = Names[x, 1];

                //print out the string with the names of the  elements plugged in the 
                // where {0} = f_name, and {1} = l_name
                Console.Write("\nHello Mr. {0} {1}, it's a pleasure to make your acquaintance!\n", F_Name, L_Name);
            }// end of for loop
        }// end of main Method
    }// end of class
}// end of namespace
