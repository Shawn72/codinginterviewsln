using System;
using System.Collections.Generic;
using System.Text;

namespace Datastructures
{
    public class BitsManipulation
    {

        public int updateBits(int n, int m, int i, int j)
        {

            //input  n = 10000000000, m = 10011, i = 2, j = 6
            // output n = 10001001100

            // Create a mask to clear bits i through j in n.EXMPLE: i = 2, j = 4.
            //Result should be 11100011.For simplicity, we'll use just 8 bits for the example.

            int all_Ones = ~0; // will equal sequence of all ls

            // ls before position j, then 0s.left = 11100000
            int left = all_Ones << (j + 1);
          
            // l's after position i. right = 00000011
            int right = ((1 << i) - 1);
   
            // All ls, except for 0s between i and j.mask 11100011
            int mask = left | right;

             /* Clear bits j through i then put min there */
            int n_cleared = n & mask; // Clear bits j through i.
            int m_shifted = m << i; // Move m into correct position.          

            return n_cleared | m_shifted; // OR them, and we're done!
         }
    }
}
