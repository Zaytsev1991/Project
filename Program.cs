string[] array1 = {"Hello", "2", "world", ":-)"};
string[] array2 = {"1234", "1567", "12", "computer"};
string[] array3 = {"Russia", "Denmark", "Kazan"};
		
string[] ShortString(string[] array)
{
	int length = array.Length;			
	string[] result = new string[length];
	int count = 0;
			
	for (int i = 0; i < length; i++)
	{
		if(array[i].Length <= 3)
		{
			result[count] = array[i];
			count++;
		}
	}
	Array.Resize(ref result, count);
	
	return result;
}

void PrintArray(string[] array)
{
	if(array.Length == 0)
	{
		Console.WriteLine("Array is empty");
	}
	else
	{
		Array.ForEach(array, (str) => Console.Write($"{str} "));
		Console.WriteLine();
	}
}
		
void PrintTask(string[] array)
{
	Console.WriteLine("Source array:");
	PrintArray(array);
	string[] shortArray = ShortString(array);
	Console.WriteLine($"Result array");
	PrintArray(shortArray);
	Console.WriteLine();
}

PrintTask(array1);
PrintTask(array2);
PrintTask(array3);
