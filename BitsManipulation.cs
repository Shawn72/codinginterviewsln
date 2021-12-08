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

        //Method 1:::: To print the decimal part, we can multiply by 2 and check if 2*n is greater than or equal to 1. 
        //This is essentially “shifting” the fractional sum.
        public string _printBinary(double num)
        {
            if (num >= 1 || num <= 0)
            {
                return "ERROR";
            }

            StringBuilder binary = new StringBuilder();

            binary.Append(".");
            while (num > 0)
            {
                /* Setting a limit on length: 32 characters */
                if (binary.Length >= 32)
                {
                    return "ERROR";
                }
                double r = num * 2;
                if (r >= 1)
                {
                    binary.Append(1);
                    num = r - 1;
                }
                else
                {
                    binary.Append(0);
                    num = r;
                }               

            }
            return binary.ToString();
        }
        //Method2:::: multiplying the number by two and compare the number to . 5, then . 25, and so on.
        // convert Binary real number to String
        public string printBinaryPoint5(double num)
        {
            // Check Number is Between 0 to 1 or Not
            if (num >= 1 || num <= 0)
                return "ERROR";

            string binary = "";
            double frac = 0.5;
            binary += ".";

            while (num > 0)
            {
                /* Setting a limit on length: 32 characters,
                If the number cannot be represented
                accurately in binary with at most 32
                characters */
                if (binary.Length >= 32)
                    return "ERROR";

                //  compare the number to . 5.
                if (num >= frac)
                {
                    binary += "1";
                    num -= frac;
                }
                else
                    binary += "0";

                // becomes 0.25
                frac /= 2;
            }
            return binary;
        }

        //Flip Bit to Win: You have an integer and you can flip exactly one bit 
        //from a 0 to a 1. Write code to find the length of the longest sequence of 1 s you could create
        public int flipBit(int a)
        {
            //Time complexity:  O ( b) time and O ( 1) auxillary memory, where b is the length of the sequence in bits.// maxLen + 1 bits

            /* If all bits are l, binary representation of 'a' has all 1s */
            if (~a == 0)
            return 8 * sizeof(int);           

            int currLen = 0, prevLen = 0, maxLen = 0;
            while (a != 0)
            {
                // If Current bit is a 1 then increament currLen++ 
                if ((a & 1) == 1)
                {
                    currLen++;
                }

                // If Current bit is a 0 then  check next bit of a 
                else if ((a & 1) == 0)
                {
                    /* Update prevLen to 0 (if next bit is 0) 
                    or currLen (if next bit is 1). */
                    prevLen = (a & 2) == 0 ? 0 : currLen;

                    // If two consecutively bits are 0  then currLen also will be 0. 
                    currLen = 0;
                }
                // Update maxLen if required 
                maxLen = Math.Max(prevLen + currLen, maxLen);

                // Remove last bit (Right shift) ,shift 1 bit from right
                a >>= 1;
            }
            // We can always have a sequence of  at least one 1, this is fliped bit 
            return maxLen + 1;
        }
        //Next Number: Given a positive integer, print the next smallest and the next largest number that
        //have the same number of 1 bits in their binary representation
        // p ==> Position of rightmost non-trailing 0.
        // c1 ==> Number of ones to the right of p
        // c0 ==> Number of zeros to the right of p.
        // p = c0 + c1

        //  find next smallest number bigger than n
        public int getNext(int n)
        {
            /* Compute c0 and c1 */
            int c = n;
            int c0 = 0;
            int c1 = 0;

            while (((c & 1) == 0) && (c != 0))
            {
                c0++;
                c >>= 1; //shift 1 bit from right
            }
            while ((c & 1) == 1)
            {
                c1++;
                c >>= 1;
            }

            // If there is no bigger number with the same no. of 1's
            if (c0 + c1 == 31 || c0 + c1 == 0)
                return -1;

            // position of rightmost non-trailing zero
            int p = c0 + c1;

            // Flip rightmost non-trailing zero
            n |= (1 << p);

            // Clear all bits to the right of p
            n &= ~((1 << p) - 1);

            // Insert (c1-1) ones on theright.
            n |= (1 << (c1 - 1)) - 1;

            return n;
        }

        //get prev smallest /largest
        /*1. Compute c0 and cl. Note that cl is the number of trailing 0
            immediately to the lef of the trailing ones.
            2. Flip the rightmost non-trailing one to a zero. This will be at po
            3. Clear all bits to the right of bit p.
            4. Insert c1+ 1 ones immediately to the right of position p
        */
        public int getPrev(int n)
        {
            int temp = n;
            int c0 = 0;
            int C1 = 0;
            while ( (temp & 1) == 1) {
                C1++;
                temp >>= 1;
            }
           
             if (temp == 0) return -1;
               
                while (((temp & 1) == 0) && (temp != 0))
                {
                    c0++;
                    temp >>= 1;
                }
             
                int p = c0 + C1; // position of rightmost non-trailing one

                n &= ((~0) << (p + 1)); // clears from bit p onwards
               
                int mask = (1 << (C1 + 1)) - 1; // Sequence of (c1+1) ones

                n  |= mask << (c0 - 1);
                
                return n;
            }

        //Write a function to determine the number of bits you would need to flip to convert
        // integer A to integer B.
        /*
         1. Calculate XOR of A and B.      
             a_xor_b = A ^ B
        2. Count the set bits in the above 
            calculated XOR result.
        countBitsSet(a_xor_b)
        */
        // Function that count set bits
        public int countBitsSet(int n)
        {
            int count = 0;
            while (n != 0)
            {
                count++;
                n &= (n - 1);
            }
            return count;
        }

        // return count of flipped number
        public int FlippedCount(int a, int b)
        {
            // Return count of set
            // bits in a XOR b
            int u = a ^ b;
            return countBitsSet(a ^ b);
        }

        /*
          Write a program to swap odd and even bits in an integer with as few instructions as
            possible (e.g., bit O and bit 1 are swapped, bit 2 and bit 3 are swapped, and so on)
            Every even position bit is swapped with adjacent bit on right side
        */
        public int swapBits(int x)
        {
            for (int i = 0; i < 32; i += 2)
            {
                int i_bit = (x >> i) & 1; // find i th bit..even
                int i_1_bit
                    = (x >> (i + 1)) & 1; // find i+1 th bit..odd

                x = x - (i_bit << i) // remove i_bit
                    - (i_1_bit << (i + 1)) // remove i+1 th bit
                    + (i_bit  << (i + 1)) // put i_bit at i+1 location
                    + (i_1_bit << i); // put i+1 bit at i location
            }
            return x;
        }

    }
}
