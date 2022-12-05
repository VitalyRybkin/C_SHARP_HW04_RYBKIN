/*
Дополнительная задача (задача со звёздочкой): 
Напишите программу, которая на вход принимает радиус круга и находит его площадь округленную до целого числа, необходимо вывести максимальную цифру в полученном округлённом значении площади круга.
10 -> 4
20 -> 7
30 -> 8
*/

Console.Clear();

Console.Write("Enter circle radius: ");
string get_string = CheckInput(Console.ReadLine() ?? String.Empty);
double radius = Convert.ToDouble(get_string);
double s = 0;
int max_digit = 0;

s = Math.Round(Math.PI * Math.Pow(radius, 2));

while (s != 0) {
    if (max_digit < Convert.ToInt32(s % 10)) max_digit = Convert.ToInt32(s % 10);
    s /= 10;
}

Console.WriteLine($"Max digit in circle area of radius equals {get_string} is " + max_digit);


string CheckInput (string get_string) {
    while (true) {
        if (get_string == "Q") Environment.Exit(0);
        if (double.TryParse(get_string, out double num)) {
        return get_string;
        }
        else {
                Console.Write("\nThis is not an int! ");
                Console.Write("Try again or type 'Q': ");
                get_string = Console.ReadLine() ?? "";
        }
    }
}  