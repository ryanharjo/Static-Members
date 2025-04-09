using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Harjo_Ryan
{
    static class Calculate
    {
        // Static field to hold the result, initialized to 0.0f
        public static float result = 0.0f;

        // Static constructor that initializes the result field
        static Calculate()
        {
            result = 0.0f;
        }

        // Method for adding two integers
        public static int Add(int x, int y)
        {
            return x + y;  // Returns the sum of x and y
        }

        // Method for subtracting two integers
        public static int Sub(int x, int y)
        {
            return x - y;  // Returns the result of x minus y
        }

        // Method for multiplying two integers
        public static int Mult(int x, int y)
        {
            return x * y;  // Returns the result of x multiplying y
        }

        // Method for dividing two integers
        public static int Div(int x, int y)
        {
            return x / y;  // Returns the result of x dividing y
        }


        // Method for adding two floating-point numbers
        public static float Add(float x, float y)  
        {
            return x + y;  // Returns the sum of x and y (as floaters)
        }

        // Method for subtracting two floating-point numbers
        public static float Sub(float x, float y)  
        {
            return x - y; // Returns the result of x minus y (as floaters)
        }

        // Method for multiplying two floating-point numbers
        public static float Mult(float x, float y) 
        {
            return x * y; // Returns the result of x multiplying y (as floaters)
        }

        // Method for dividing two floating-point numbers
        public static float Div(float x, float y)
        {
            return x / y;  // Returns the result of dividing x and y (as floaters)
        }
    }
}