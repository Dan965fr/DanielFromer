//Console.WriteLine("put string:");
//string input = Console.ReadLine();

//Console.WriteLine($"len:{input.Length}"); 


//Console.WriteLine($"contains admin:{input.Contains("admin")}");
//Console.WriteLine($"start with'user': {input.StartsWith("user")}");

//Console.WriteLine($" in capital letters: {input.ToUpper()}");


//string word = "dal";
//if (word.Length >= 4)
//{
//    string firstTwo = word.Substring(0, 2);
//    string lastTwo = word.Substring(word.Length - 2);
//    Console.WriteLine($"first:{firstTwo} second:{lastTwo}");
//}
//else
//{
//    Console.WriteLine("the word is too short");
//}


Console.WriteLine("enter a number");
int number = int.Parse(Console.ReadLine());
if(number%2==0 && number%10 ==7)
{
    Console.WriteLine("the number check");
}
else
{
    Console.WriteLine("the number is not check");
}