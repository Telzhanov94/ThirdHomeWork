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
int Quantity(int[] array, double minimum, double maximum)
{ 
    int Count=0;
    for (int i=0;i<array.Length;i++)
        {
        if (minimum<array[i] & array[i]<maximum) 
        {Count++;}
        }
    return Count;   
}

Console.Write("Enter size of array: " ); 
int size = int.Parse(Console.ReadLine() ?? "0"); 
int[] array = CreateArray(size,0,999); 
Console.Write("Your array: "); 
PrintArray(array); 
Console.WriteLine();
Console.WriteLine("Enter minimum search position: ");
int min=int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Enter maximum search position: ");
int max=int.Parse(Console.ReadLine() ?? "0");
var quant = Quantity(array,min,max);
Console.WriteLine();
Console.WriteLine ($"Quantity numbers in your Range: {quant}");