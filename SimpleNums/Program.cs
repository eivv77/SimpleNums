using static SimpleNums.Nums;
using SimpleNums;

Console.WriteLine("Enter N ==>");

var n = (Console.ReadLine());
int nNum;
while (!int.TryParse(n, out nNum))
{
    Console.WriteLine(DefErrors.error2);
    n = Console.ReadLine();
}
var nums = new Nums(nNum);

if (nums.N == 0)
{
    Console.WriteLine(DefErrors.error0);
}
else if (nums.N == 1)
{
    Console.WriteLine(DefErrors.error1);
}
else
{
    Console.WriteLine("Simple nums from {0} to {1}", 0, nums.N);

    for (int i = 0; i <= nums.N; i++)
    {
        if (IsSimple(i))
        {
            Console.Write($"{i}| ");
        }
    }
}

Console.ReadLine();