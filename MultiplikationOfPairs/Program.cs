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
int [] Multi(int[] array)
{ int [] NewArray = new int [array.Length/2];
    int index=0;
    int lastIndex=array.Length-1;
    while (index<lastIndex & index!=lastIndex)
    {
    int multi=array[index]*array[lastIndex];
    NewArray[index]=multi;
    index++;
    lastIndex--;
    }
    return NewArray;
}
Console.Write("Enter size of array: " ); 
int size = int.Parse(Console.ReadLine() ?? "0"); 
int[] array = CreateArray(size,0,10); 
Console.Write("Your array: "); 
PrintArray(array); 
int[] NewArray = Multi(array);
Console.WriteLine();
Console.Write ($"New array with multiplikation of pairs: ");
PrintArray(NewArray);