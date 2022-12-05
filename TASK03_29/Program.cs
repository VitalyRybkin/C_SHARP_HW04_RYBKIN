/*
Задача 29: 
Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

Console.Clear();

Console.Write("Enter an array size: ");
string get_string = CheckInput(Console.ReadLine() ?? String.Empty);
int arr_size = Convert.ToInt32(get_string);
int[] arr = new int[arr_size];

for (int i = 0; i < arr_size; i ++) {
    arr[i] = new Random().Next(1, 100);
}

//OUTOUT 1
Console.Write("\nYour array is: ");
foreach (int item in arr) Console.Write(item + " ");

//OUTOUT 2
Console.Write("\n\n... or OUTOUT 2 ... \n\n[");
for (int item = 0; item < arr_size; item ++) {
    if (item < arr_size - 1) Console.Write(" " + arr[item] + ", ");
    else Console.Write(arr[item] + " ]");
}

//OUTOUT 3
Console.Write("\n\n... or OUTOUT 3 ... \n\n");
for (int item = 0; item < arr_size; item ++) if (item < arr_size) Console.Write(item + 1 + " -> " + arr[item] + "\n");

//OUTOUT 4
Console.Write("\n... or OUTOUT 4 ... \n\n");
for (int item = 0; item < arr_size; item ++) if (item < arr_size) Console.Write("Index: {0}, Value: {1}\n", item, arr[item]);

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