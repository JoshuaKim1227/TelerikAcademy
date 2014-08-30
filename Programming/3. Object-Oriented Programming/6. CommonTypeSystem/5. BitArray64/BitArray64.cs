using System;
using System.Collections.Generic;
using System.Text;

public class BitArray64 : IEnumerable<int>
{
    private ulong number;
    private byte[] bits;

    // Constructor
    public BitArray64(ulong number)
    {
        this.number = number;
        this.bits = this.ToBitsArray();
    }

    // Property
    public ulong Number
    {
        get 
        {
            return this.number;
        }

        private set 
        { 
            this.number = value; 
        }
    }

    // Indexer
    public int this[int index]
    {
        get
        {
            if (index < 0 || index > 63)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                return this.bits[index];
            }
        }
    }

    // Overriding == operator
    public static bool operator ==(BitArray64 num1, BitArray64 num2)
    {
        for (int index = 0; index < 64; index++)
        {
            if (num1[index] != num2[index])
            {
                return false;
            }
        }

        return true;
    }

    // Overriding != operator
    public static bool operator !=(BitArray64 num1, BitArray64 num2)
    {
        for (int index = 0; index < 64; index++)
        {
            if (num1[index] != num2[index])
            {
                return true;
            }
        }

        return false;
    }

    // Overrinding Equals()
    public override bool Equals(object obj)
    {
        BitArray64 bitArray = (BitArray64)obj;

        for (int index = 0; index < 64; index++)
        {
            if (this.bits[index] != bitArray[index])
            {
                return false;
            }
        }

        return true;
    }

    public byte[] ToBitsArray()
    {
        ulong num = this.Number;
        byte[] bits = new byte[64];
        byte bit = 0;

        // Converting decimal to binary
        while (num != 0)
        {
            bits[bit] = (byte)(num % 2);
            num = num / 2;
            bit++;
        }

        bits[bit] = 0;

        // Adding the remaining zeroes
        while (bit != 63)
        {
            bits[bit] = 0;
            bit++;
        }

        return bits;
    }

    // Implementing IEnumerable<int>
    public IEnumerator<int> GetEnumerator()
    {
        for (int i = 63; i >= 0; i--)
        {
            yield return this[i];
        }
    }

    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }

    // Overriding GetHashCode()
    public override int GetHashCode()
    {
        return this.number.GetHashCode();
    }

    // Overriding ToString()
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        int counter = 1;

        // Initializing new array
        byte[] arrayToReverse = new byte[64];

        for (int index = 0; index < this.bits.Length; index++)
        {
            arrayToReverse[index] = this.bits[index];
        }

        // Reversing the new array
        Array.Reverse(arrayToReverse);

        foreach (byte bit in arrayToReverse)
        {
            sb.Append(bit);

            if (counter % 4 == 0)
            {
                sb.Append(" ");
            }

            counter++;
        }

        return sb.ToString();
    }
}