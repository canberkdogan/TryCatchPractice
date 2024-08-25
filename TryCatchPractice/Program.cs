try
{
    Console.WriteLine("Please enter number---->");
    int number = Convert.ToInt32(Console.ReadLine());

    int square = number * number;

    Console.WriteLine($"your numbers square is ---->{square}");


}
catch
{
    Console.WriteLine("you are enter wrong item. Please try again.");
}