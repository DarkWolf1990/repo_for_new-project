int max(int arg1, int arg2, int arg3)
{
	int result = arg1;
	if(arg2 > result) result = arg2;
	if(arg3 > result) result = arg3;
	return result;
}

int a1 = 25;
int b1 = 51;
int c1 = 24;
int a2 = 12;
int b2 = 10;
int c2 = 22;
int a3 = 13;
int b3 = 23;
int c3 = 28;
int max1 = max(a1, b1, c1);
Console.WriteLine(max1);
