using System;
using static System.Console;
Console.Clear();

string[] Array =  { "hello", "2", "world", ":-)"};
string[] newArray = createNewArray(Array, GetCount(Array));

Write($"[ {String.Join(", ",Array)} ] -> ");
WriteLine("[ {0} ]", String.Join(", ", newArray));
WriteLine();

int GetCount(string[] Array)
{
	int k = 0;
	for(int i = 0; i < Array.Length; i++)
	{
  		if (Array[i].Length <= 3)
  		k = k +1;
  	}
	return k;
}

string[] createNewArray(string[] Array, int k)
{
  	string[] createArray = new string[k];
	int j = 0;
	for(int i = 0; i < Array.Length; i++)
	{
		if (Array[i].Length <= 3)
		{
			createArray[j] = Array[i];
			j= j + 1;
		}
	}
	return createArray;
}