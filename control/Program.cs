string[] array = { "Hello", ").&", "world", "Cg", "Hoi" };
int count = 0;
int n = 0;
for (int i = 0; i < array.Length; i++)
{
    // string m = a[i];
    if (array[i].Length <= 3)
    {
        count ++; // считаем сколько раз встречается строка нужного размера
    }
}
string[] new_array = new string[count]; // создаем новый список размер, которого соответствует количеству строк в массиве заданной длины (меньше или равно 3)

for (int i = 0; i < array.Length; i++)
{
    // string m = a[i];
    if (array[i].Length <= 3)
    {
        new_array[n] = array[i];             
        Console.Write(string.Join(" ,", new_array));
        
        
    }
}