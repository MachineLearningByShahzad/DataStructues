using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructues.NonPrimitiveDataStructures.NonPrimitiveLinearDataStructures
{
    internal class MyLinkedList
    {
        List<int> list = new List<int>();

        public MyLinkedList() { 
            list.Add(0);
            list.BinarySearch(1);    
            list.Add(2);
            list.Add(3);    
            list.Add(4);
            list.Add(5);
            list.Add(6);
        }
    }
}
