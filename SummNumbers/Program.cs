void PrintArray(int[] array) 
{ 
foreach(var element in array) 
Console.Write($"{element} "); 
} 
int[] CreateArray(int size, int minimum, int maximum) 
{ 
int[] array= new int[size]; 
var random = new Random(); 
for(int i=0;i<size;i++) 
array[i] = random.Next(minimum,maximum+1); 
return array; 
} 
int sum(int[]array)
{
   int digit=0;
   for (int i=0;i<array.Length;i++)
    if (array[i]>0)
    {
    digit=digit+array[i];
    } 
    return digit;
    }
int NegSum(int[] array)
    {
       int NegDigit=0;
        for(int i=0;i<array.Length;i++)
            if (array[i]<=0)
            {
                NegDigit=NegDigit+array[i];
           }
    return NegDigit;
    } 
Console.Write("Enter size of array: " ); 
int size = int.Parse(Console.ReadLine() ?? "0"); 
int[] array = CreateArray(size, -9,9); 
Console.Write("Your array: "); 
PrintArray(array); 
Console.WriteLine();
Console.Write($"Sum of positive numbers {sum(array)} and Sum of negative numbers {NegSum(array)} ");