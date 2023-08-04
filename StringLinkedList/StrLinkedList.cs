using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StringLinkedList
{
    internal class StrLinkedList
    {
        Node head;
        Node tail;
        public int Length
        {
            get
            {
                int length = 0;
                Node tmp = head;
                while (tmp != null)
                {
                    length += tmp.Length;
                    tmp = tmp.next;
                }
                return length;
            }
            //private set { }
        }
        private class Node
        {
            public char[] Data;
            public Node next;
            public int Length { get { return Data.Length; } }
            public Node(char[] data)
            {
                Data = data;
            }
        }
        public StrLinkedList()
        {
            head = null;
        }
        public StrLinkedList(string value)
        {
            head = new Node(value.ToCharArray());
            tail = head;
        }
        public StrLinkedList Append(string data)
        {
            Node newNode = new Node(data.ToCharArray());
            if (tail == null)
            {
                head = newNode;
            }
            else
            {
                tail.next = newNode;
            }
            tail = newNode;
            return this;
        }
        public StrLinkedList InsertAt(int index, string data)
        {
            if (index < 0 || index > Length)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
            }
            if (data.Length == 0)
            {
                return this;
            }
            Node newNode = new Node(data.ToCharArray());
            if (head == null)
            {
                head = newNode;
                return this;
            }
            if (index == 0)
            {
                newNode.next = head;
                head = newNode;
                return this;
            }
            Node current = head;
            Node prev = head;
            int currentIndex = index;
            while (current != null && currentIndex >= current.Length)
            {
                currentIndex -= current.Length;
                prev = current;
                current = current.next;
            }
            if (currentIndex == 0)
            {
                newNode.next = current;
                prev.next = newNode;
                return this;
            }
            char[] result = new char[current.Length + data.Length];
            int resultIndex = 0;
            for (int i = 0; i < current.Length; i++)
            {
                if (i == currentIndex)
                {
                    for (int j = 0; j < data.Length; j++)
                    {
                        result[resultIndex++] = data[j];
                    }
                }
                result[resultIndex] = current.Data[i];
                resultIndex++;
            }
            current.Data = result;
            return this;
        }
        public StrLinkedList RemoveWhitespaces()
        {
            Node current = head;
            while (current != null)
            {
                int targetIndex = 0;
                for (int i = 0; i < current.Length; i++)
                {
                    if (current.Data[i] != ' ' && current.Data[i] != '\n')
                    {
                        current.Data[targetIndex] = current.Data[i];
                        targetIndex++;
                    }
                }
                if (current.Length != targetIndex)
                {
                    char[] newChars = new char[targetIndex];
                    for (int i = 0; i < targetIndex; i++)
                    {
                        newChars[i] = current.Data[i];
                    }
                    current.Data = newChars;
                }
                current = current.next;
            }
            return this;
        }
        public override string ToString()
        {
            if (Length == 0)
            {
                return string.Empty;
            }
            char[] result = new char[Length];
            int index = 0;
            Node current = head;
            while (current != null)
            {
                for (int i = 0; i < current.Length; i++)
                {
                    result[index] = current.Data[i];
                    index++;
                }
                current = current.next;
            }
            return new string(result);
        }
    }
}
