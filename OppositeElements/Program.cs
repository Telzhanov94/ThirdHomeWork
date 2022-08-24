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
void Opposit(int [] array)
{
    for (int i=0;i<array.Length;i++)
    array[i]=-array[i];
} 
Console.Write("Enter size of array: " ); 
int size = int.Parse(Console.ReadLine() ?? "0"); 
int[] array = CreateArray(size,-90,90); 
Console.Write("Your array: "); 
PrintArray(array); 
Console.WriteLine(); 
Console.Write("Your Opposite array: ");
Opposit(array);
PrintArray(array);