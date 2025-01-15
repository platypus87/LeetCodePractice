Console.WriteLine(IsPali(121));
bool IsPali(int testNumber)
{
    string testString = testNumber.ToString();
    char[] reverseString = testString.ToCharArray();
    string finalString = reverseString.ToString();

    Console.WriteLine($"TestString is: {testString}");
    Console.WriteLine($"reverseString is: {reverseString.ToString()}");
    Console.WriteLine($"FinalString is: {finalString}");
    foreach(char c in reverseString) {  Console.WriteLine(c); }

    if (testString == finalString) {  return true; }
    else
    return false;
}