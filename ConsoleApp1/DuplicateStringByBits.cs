using System;

public class DuplicateStringByBit
{
    public virtual bool uniqueCharacters(string str)
    {
        // Assuming string can have 
        // characters a-z this has 
        // 32 bits set to 0 
        int checker = 0;

        for (int i = 0; i < str.Length; i++)
        {
            int bitAtIndex = str[i] - 'a';

            // if that bit is already set 
            // in checker, return false 
            if ((checker & (1 << bitAtIndex)) > 0)
            {
                return false;
            }

            // otherwise update and continue by 
            // setting that bit in the checker 
            checker = checker | (1 << bitAtIndex);
        }

        // no duplicates encountered, 
        // return true 
        return true;
    }

}

public class GFG
{

    // function for decimal to 
    // binary conversion without 
    // using arithmetic operators 
    public static String decToBin(int n)
    {
        if (n == 0)
            return "0";

        // to store the binary 
        // equivalent of decimal 
        String bin = "";

        while (n > 0)
        {

            // to get the last binary digit 
            // of the number 'n' and accumulate 
            // it at the beginning of 'bin' 
            bin = ((n & 1) == 0 ? '0' : '1') + bin;

            // right shift 'n' by 1 
            n >>= 1;
        }

        // required binary number 
        return bin;
    }
}