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
bool Find(int [] array,int find)
{
    foreach(var digit in array)
    if (digit == find)
    return true;
    return false;
} 
Console.Write("Enter size of array: " ); 
int size = int.Parse(Console.ReadLine() ?? "0"); 
int[] array = CreateArray(size,-90,90); 
Console.Write("Your array: "); 
PrintArray(array); 
Console.Write("Enter find number: ");
int find=int.Parse(Console.ReadLine() ?? "0");
bool TrueFolse = Find(array,find);
Console.Write(TrueFolse ? "Your contains in array":"Your number don't containts in array");