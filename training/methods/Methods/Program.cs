// See https://aka.ms/new-console-template for more information
static bool Increment(out int  x) {
     x=90; // This will cause a compile-time error because 'x' is read-only
     return true;
 }

int n = 5;
Increment(out n);
Console.WriteLine("The value is changed "+n); // 6