using static Library;

string[] Array1 = CreateArrayString(5);
string[] Array2 = CreateArrayString(Array1.Length);

Console.WriteLine("Введите 5 слов или чисел:");
FillArrayString(Array1);
ArrayLength3(Array1, Array2);

Console.WriteLine(" ");
PrintArrayString(Array2);