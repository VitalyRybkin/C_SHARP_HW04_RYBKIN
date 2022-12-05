/*
Задача 27: 
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Console.Clear();

Console.Write("Enter a number: ");
string get_string = CheckInput(Console.ReadLine() ?? String.Empty);
int num = Convert.ToInt32(get_string);
int res = 0;

while (num != 0) {
    res += num % 10;
    num /= 10;
}

Console.WriteLine($"Sum of digits in {get_string} is " + res);


string CheckInput (string get_string) {
    while (true) {
        if (get_string == "Q") Environment.Exit(0);
        if (int.TryParse(get_string, out int num)) {
        return get_string;
        }
        else {
                Console.Write("\nThis is not an int! ");
                Console.Write("Try again or type 'Q': ");
                get_string = Console.ReadLine() ?? "";
        }
    }
}  