// Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.

int[] CreateFillArray()
{
    Console.Write("Введите четное число: ");
    int[] arr = new int[Convert.ToInt32(Console.ReadLine())];
    
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Random.Shared.Next(10);
    }
    return arr;
}
string PrintArray(int[] priarray)
{
    string output = String.Empty;
    for (int i = 0; i < priarray.Length; i++)
    {
        output = output + $"{priarray[i]} ";
    }
    return output;
}
int[] CountMult(int[] colection)
{
    int[] arrMult = new int[colection.Length / 2];
    for (int i = 0; i < colection.Length / 2; i++)
    {
        arrMult[i] = colection[i] * colection[colection.Length - 1 - i];
    }
    return arrMult;
}
int[] arr = CreateFillArray();
string print = PrintArray(arr);
Console.WriteLine(print);
int[] newArr = CountMult(arr);
string newPrint = PrintArray(newArr);
Console.WriteLine(newPrint);
