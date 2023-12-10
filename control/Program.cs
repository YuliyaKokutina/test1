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
