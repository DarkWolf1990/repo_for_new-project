void FillaArray(int[]collection)
{
	int Length = collection.Length;
	int index = 0;

	while(index < Length)
  {
		collection[index] = new Random().Next(1, 10);
	//index = index+1;
	index++;
  }
}
int[] Array = new int[10];
void PrintArray(int[] col)
{
int count = col.Length;
int position = 0;
while (position < count)
{
Console.WriteLine(col[position]);
position++;
}
}
int Index0f(int[] collection, int find)
{
	int count = collection.Length;
	int index = 0;
	int position = 0;
	while(index < count)
	{
		if(collection[index] == find)
		{
			position = index;
		}
		index++;
	}
	return position;
}
FillaArray(Array);
PrintArray(Array);
Console.WriteLine();

int pos = Index0f(Array, 4);
Console.WriteLine(pos);