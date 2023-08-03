int[] array = { 1, 12, 44, 76, 89, 44, 33, 54, 789 };

int n = array.Length;
int find =44;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        //если одинаковые значения в массиве и нам нужно только первое
        break;
    }
    //index = index + 1;
    index++; 

}