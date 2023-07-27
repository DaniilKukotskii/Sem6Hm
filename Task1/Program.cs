int [] Create_UserArray (int count_nums)
{
    int [] array = new int [count_nums];
    for (int i = array[0]; i <= count_nums - 1; i++)
    {
        Console.WriteLine("Enter number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        array[i] = num;
    }
    return array;
}

int Positive_numbers (int [] user_array)
{
    int count = 0;
    for (int i = 0; i < user_array.Length; i++)
    {
        if (user_array[i] > 0) count++; 
    }
    return count;
}
Console.WriteLine("Enter the length of your array: ");
int userNum = Convert.ToInt32(Console.ReadLine());

int [] array = Create_UserArray(userNum);
int pos_num = Positive_numbers(array);
Console.WriteLine($"Ваш массив:" + "[" + string.Join(",", array)+ "]");
Console.WriteLine($"Count of positive numbers in the array: {pos_num}");