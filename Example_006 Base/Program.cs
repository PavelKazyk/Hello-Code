int a = 1;
int b = 3;
int c = 2;
int e = 4;
int f = 7;

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (e > max) max = e;
if (f > max) max = f;

Console.Write("max = ");
Console.WriteLine(max);
