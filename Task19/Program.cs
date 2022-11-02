System.Console.WriteLine("Enter a 5-digit number:");
int num = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("The number is: " + num + ". Is it a palindrome? --> " + IfPalindrome(num));
bool IfPalindrome(int number)
{
    int a = (number / 1000) / 10;
    int b = (number / 1000) % 10;
    int z = (number % 100) % 10;
    int y = (number % 100) / 10;
    if (a == z && b == y) return true;
    else return false;
}