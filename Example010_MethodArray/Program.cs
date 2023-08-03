int[] array = { 1, 12, 44, 76, 89, 33, 54, 789 };

int n = array.Length;
int find = 44;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
    }
    //index = index + 1
    index++; 

}