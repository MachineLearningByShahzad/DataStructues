using DataStructues;
using DataStructues.NonPrimitiveDataStructures.NonPrimitiveNonLinearDataStructures;

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

//Trees
Trees tree = new Trees();
tree.insert(7);
tree.insert(4);
tree.insert(9);
tree.insert(1);
tree.insert(6);
tree.insert(8);
tree.insert(10);
Console.WriteLine(tree.find(11));

Console.WriteLine("preOrder Traversal");
tree.preOrderTraversal();

Console.WriteLine("inOrder Traversal");
tree.inOrderTraversal();

Console.WriteLine("postOrder Traversal");
tree.postOrderTraversal();

Console.WriteLine("Height");
Console.WriteLine(tree.height());

Console.WriteLine("Depth");
Console.WriteLine(tree.Depth());
