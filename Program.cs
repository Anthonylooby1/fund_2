// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


// int[] numArray = {0,1,2,3,4,5,6,7,8,9};

// String[] StringArray = {"Tim","Martin", "Nikki", "Sara"};

// bool[] boolArray = new bool[10];
// for (int idx = 0; idx < boolArray.Length; idx++)
// {
//     if(idx % 2 == 0)
//     {
//         boolArray[idx] = true;
//     } else {
//         boolArray[idx] = false;
//     }
//     Console.Write(boolArray);
// }
// boolArray[0] = true;
// boolArray[1] = false;
// boolArray[2] = true;
// boolArray[3] = false;
// boolArray[4] = true;
// boolArray[5] = false;
// boolArray[6] = true;
// boolArray[7] = false;
// boolArray[8] = true;
// boolArray[9] = false;

List<string> IceCream = new List<String>();
IceCream.Add("chocolate");
IceCream.Add("vanilla");
IceCream.Add("strawberry");
IceCream.Add("moose tracks");
IceCream.Add("peanut butter");
IceCream.RemoveAt(2);

Console.Write(IceCream.Count);
Console.Write(IceCream[2]);
