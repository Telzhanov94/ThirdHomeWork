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
int OddPosition(int[] array)
{ 
    int number=0;
    for (int i=0;i<array.Length;i++,i++)
    number=number+array[i];
    return number;   
}

Console.Write("Enter size of array: " ); 
int size = int.Parse(Console.ReadLine() ?? "0"); 
int[] array = CreateArray(size,0,999); 
Console.Write("Your array: "); 
PrintArray(array); 
var quant = OddPosition(array);
Console.WriteLine();
Console.WriteLine ($"Sum numbers in odd pisition: {quant}");