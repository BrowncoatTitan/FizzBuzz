public static string FizzBuzz(int x)
{
if(int x % 3 == 0 && x % 5 == 0)
return "fizz";
else if (int x % 5 ==0)
return "buzz";
else if (int x % 3 == 0)
return "fizzbuzz";
else return "No fizz, no buzz, and worst of all, no fizzbuzz";
}