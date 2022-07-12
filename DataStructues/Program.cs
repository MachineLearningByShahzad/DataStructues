// See https://aka.ms/new-console-template for more information
using DataStructues;

//Array Data Structures
Arrays item = new Arrays(3);
item.Insert(1);
item.Insert(2);
item.Insert(3); 
item.Insert(4); 
item.Print();
Console.WriteLine("Now removing from index of array");
item.removeAt(2);
item.Print();
Console.WriteLine("Max Value in array:  " + item.max());
Console.WriteLine("Min Value in array:  " + item.min());

int[] revArray = item.reverse();
for (int i= 0; i < revArray.Length; i++){
    Console.WriteLine(revArray[i]);
}

//Link List Data Structures
