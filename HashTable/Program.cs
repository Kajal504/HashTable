// See https://aka.ms/new-console-template for more information
using HashTable;

 Console.WriteLine("Program for Hash Table");

MyMapNode<string, string> hash = new(5);
    hash.Add("0", "To");
    hash.Add("1", "be");
    hash.Add("2", "or");
    hash.Add("3", "not");
    hash.Add("4", "to");
    hash.Add("5", "be");

    string hash0 = hash.Get("0");
    Console.WriteLine("0th index value: " + hash0);
    //hash.Remove("2");
   string hash2 = hash.Get("2");
    Console.WriteLine("2th index value: " + hash2);
