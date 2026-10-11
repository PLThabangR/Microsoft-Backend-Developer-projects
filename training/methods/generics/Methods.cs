class GenericMethods
{
    public static T Max<T>(T a, T b) where T : IComparable<T>
     => a.CompareTo(b) >= 0 ? a : b;

     int m = Max(3, 5); // m = 5
     string s = Max("apple", "banana"); // s = "banana" 


   //Lambda expression
Func<int, int, int> addLambda = (a, b) => a + b;

}