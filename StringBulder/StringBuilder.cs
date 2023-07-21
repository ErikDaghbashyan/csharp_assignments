using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBulder
{
    internal class StringBuilder
    {
        char[] Chars;
        public const int DefualtCapacity= 16;
        public int Length { get; private set; }
        public int Capacity { get; private set; }
        public StringBuilder() : this(DefualtCapacity) { }
        public StringBuilder(int capacity):this (String.Empty,capacity) { }
        public StringBuilder(string value):this (value, DefualtCapacity) { }
        public StringBuilder(String value, int capacity)
        {
            Capacity = value.Length > capacity ? ResizeCapacity(value.Length) : capacity;
            Chars = new char[Capacity];
            Chars = value.ToCharArray();
            Length = value.Length;
        }
        private int ResizeCapacity(int requredCapacity)
        {
            int newCapacity=DefualtCapacity;
            while (requredCapacity > newCapacity)
            {
                newCapacity*=2;
            }
            return newCapacity;
        }
        public StringBuilder Append(string str)
        {
            EnsureCapacity(Length + str.Length);
            for (int i = 0; i < str.Length; i++)
            {
                Chars[Length + i] = str[i];
            }
            Length += str.Length;
            return this;
        }
        public StringBuilder Append(char ch)
        {
            EnsureCapacity(Length + 1);
            Chars[Length++] = ch;
            return this;
        }
        public StringBuilder InsertAt(int index, string str)
        {
            if (index < 0 || index > Length)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
            }
            EnsureCapacity(Length + str.Length);
            for (int i = Length - 1; i >= index; i--)
            {
                Chars[i + str.Length] = Chars[i];
            }
            for (int i = 0; i < str.Length; i++)
            {
                Chars[index + i] = str[i];
            }
            Length += str.Length;
            return this;
        }
        public StringBuilder RemoveDuplicates()
        {
            int targetIndex = 0;
            for (int i = 0; i < Length; i++)
            {
                char currentChar = Chars[i];
                bool isDuplicate = false;
                for (int j = 0; j < targetIndex; j++)
                {
                    if (Chars[j] == currentChar)
                    {
                        isDuplicate = true;
                        break;
                    }
                }
                if (!isDuplicate)
                {
                    Chars[targetIndex] = currentChar;
                    targetIndex++;
                }
            }
            Length = targetIndex;
            char[] newChars = new char[Capacity];
            for (int i = 0; i < Length; i++)
            {
                newChars[i] = Chars[i];
            }
            Chars = newChars;
            return this;
        }
        public StringBuilder RemoveWhitespaces()
        {
            int targetIndex = 0;
            for (int i = 0; i < Length; i++)
            {
                char currentChar = Chars[i];

                if (currentChar!=' ' && currentChar!='\n')
                {
                    Chars[targetIndex] = currentChar;
                    targetIndex++;
                }
            }

            Length = targetIndex;
            char[] newChars = new char[Capacity];
            for (int i = 0; i < Length; i++)
            {
                newChars[i] = Chars[i];
            }
            Chars = newChars;
            return this;
        }
        public bool IsBlank()
        {
            if(Chars==null) return true;
            if(Chars.Length==0) return true;
            for (int i = 0; i < Length; i++)
            {
                if (Chars[i] != ' ' && Chars[i] != '\n')
                {
                    return false;
                }
            }
            return true;
        }
        public StringBuilder OnBlank(string s)
        {
            if (IsBlank())
            {
                Length = 0;
                Append(s);
            }
            return this;
        }
        private void EnsureCapacity(int requiredCapacity)
        {
            if (requiredCapacity > Chars.Length)
            {
                int newCapacity = Chars.Length * 2;
                if (newCapacity < requiredCapacity)
                {
                    newCapacity = requiredCapacity;
                }
                Capacity = ResizeCapacity(newCapacity);
                char[] newChars = new char[Capacity];
                for (int i = 0; i < Length; i++)
                {
                    newChars[i] = Chars[i];
                }
                Chars = newChars;
            }
        }
        public override string ToString()
        {
            return new string(Chars);
        }

    }
}
