/*
Задача 25: 
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

Console.Clear();

Console.Write("Enter num to be powered: ");
string get_string = CheckInput(Console.ReadLine() ?? String.Empty);
int num = Convert.ToInt32(get_string);

Console.Write("Enter power: ");
get_string = CheckInput(Console.ReadLine() ?? String.Empty);
int pow = Convert.ToInt32(get_string);

if (pow > 0) Console.WriteLine($"{num} to the power of {pow} is " + FindPow (num, pow));
else Console.WriteLine($"{num} to the power of {pow} is " + 1 / FindPow (num, pow));

double FindPow (int num, int pow) {
    double res = num;
    for (int i = 2; i <= Math.Abs(pow); i ++) {
        res = res * num;
    }
    return res;
}

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