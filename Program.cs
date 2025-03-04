// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

// int[] array = {2,4,3,8,7,1,9,0,3};
// List<int> result = EvenNumbers(array);
// foreach(int item in result)
// {
//     Console.WriteLine(item);
// }

// static List<int> EvenNumbers(int[] array)
// {
//     List<int> evens = new List<int>();
//     foreach(int item in array)
//     {
//         if(item % 2 == 0)
//         {
//             evens.Add(item);
//         }
//     }
//     return evens;
// }

// int number = 4;
// int result = Factorial(number);
// Console.WriteLine(result);
// static int Factorial(int number)
// {
//     int mult = 1;
//     for(int i = 1; i <= number; i++)
//     {
//         mult *= i;
//     }
//     return mult;
// }

// List<int> first = new List<int>
// {
//     5,6,7,8,9
// };
// List<int> second = new List<int>
// {
//     1,2,3,4
// };
// List<int> result = Pour(first, second);
// foreach(int item in result)
// {
//     Console.Write(item + " ");
// }
// static List<int> Pour(List<int> first, List<int> second)
// {
//     List<int> mixed = new List<int>();
//     mixed.AddRange(first);
//     mixed.AddRange(second);
//     return mixed;
// }

int [] first = {1,2,3,4,5};
int[] second = {6,7,8,9};
int[] result = Pour(first,second);
foreach(int item in result)
{
    Console.WriteLine(item);
}
static int[] Pour(int[] first, int[] second)
{
    int size = first.Length + second.Length;
    int[] empty = new int[size];
    for(int i = 0; i < first.Length; i++)
    {
        empty[i] = first[i];
    }
    for(int i = 0; i < second.Length; i++)
    {
        empty[first.Length + i] = second[i];
    }
    return empty;
}
int a = 9;
Console.WriteLine(a);