Console.Write("enter count elements array: ");
bool isParse = int.TryParse(Console.ReadLine(), out int i);

if (!isParse)
{
	Console.WriteLine("Impossible to create an array because entered invalid value");
	return;
}
string[] array = new string[i];
FillArray(array);
int countElements = GetNumberOfMatchingElementsInArray(array);
PrintArray(GetArrayWithDesiredElements(array, countElements));

int GetNumberOfMatchingElementsInArray(string[] array)
{
	int countElements = 0;
	for (int index = 0; index < array.Length; index++)
	{
		if (array[index].Length <= 3)
		{
			countElements++;
		}
	}
	return countElements;
}


void FillArray(string[] array)
{
	for (int index = 0; index < array.Length; index++)
	{
		Console.Write($"entered {index + 1}/{array.Length}: ");
		array[index] = Console.ReadLine();
	}
}

string[] GetArrayWithDesiredElements(string[] array, int countElements)
{
	string[] resultArray = new string[countElements];
	int i = 0;
	for (int index = 0; index < array.Length; index++)
	{
		if (array[index].Length <= 3)
		{
			resultArray[i] = array[index];
			i++;
		}
	}
	return resultArray;
}
void PrintArray(string[] array)
{
	Console.Write("[");
	for (int i = 0; i < array.Length; i++)
	{

		Console.Write($"{array[i]}");
		if (i < array.Length - 1)
		{
			Console.Write(", ");
		}

	}
	Console.Write("]");
}