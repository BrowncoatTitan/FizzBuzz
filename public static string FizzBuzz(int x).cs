public static string FizzBuzz(int x)
{
if(int x % 3 == 0 && x % 5 == 0)
return "fizzbuzz";
if (int x % 5 ==0)
return "buzz";
if (int x % 3 == 0)
return "fizz";
else return "No fizz, no buzz, and worst of all, no fizzbuzz";
}