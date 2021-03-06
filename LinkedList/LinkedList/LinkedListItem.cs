﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lists
{
    internal class LinkedListItem
    {
        public string Value;
        public LinkedListItem NextValue;


        public LinkedListItem(string value)
        {
            Value = value;
        }

        public void AddItem(string value)
        {
            if (NextValue == null)
            {
                NextValue = new LinkedListItem(value);
            }
            else
            {
                NextValue.AddItem(value);
            }
        }

        public string GetItem(int index)
        {
            if (index == 0)
            {
                return Value;
            }
            else if (index > 0)
            {
                Console.WriteLine($"Value: {Value}, Next Value: {NextValue.Value}");
                return NextValue.GetItem(index - 1);
            }
            else
            {
                return Value;
            }
        }

        public string ReplaceItem(int index, LinkedListItem item)
        {
            if (index == 1)
            {
                Console.WriteLine($"INSIDE REPLACE ITEM METHOD - +1 COND");
                Console.WriteLine($"Value of item.NextValue = {item.NextValue.Value}");
                Console.WriteLine($"Value of NextValue = {NextValue.Value}");
                Console.WriteLine($"Value of item.Value = {item.Value}");

                NextValue = item.NextValue;

                Console.WriteLine($"Value of NextValue = {NextValue.Value}");
                Console.WriteLine($"Value of item.NextValue = {item.NextValue.Value}");

                return NextValue.ReplaceItem(index - 1, item);                
            }
            else if (index == -1)
            {
                Console.WriteLine($"INSIDE REPLACE ITEM METHOD - -1 COND");
                Console.WriteLine($"Value of item.Value = {item.Value}");
                Console.WriteLine($"Value of Value = {Value}");
          

                NextValue = item.NextValue;
                Console.WriteLine($"Value of item.Value = {item.Value}");
                Console.WriteLine($"Value of Value = {Value}");

                return ($"{Value}");
            }
            else
            {
                return ReplaceItem(index - 1, item);                
            }
        }

        public void NextItem()
        {
            var list = new LinkedList();
            list.Add(NextValue.Value);
        }
    }
}
