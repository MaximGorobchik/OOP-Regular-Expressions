using System.ComponentModel;
using System.Text.RegularExpressions;
string pattern = @"^[a-z]+";
string[] input = "ds3bhj y1ter/wfsdg 1nh_jgf ds2c_vbg\\4htref".Split('/','\\',' ');
int[] MaxLength = new int[]
{
    0, 0, 0,
};
for(int i=0;i<input.Length; i++)
{
    for (int j = i+1; j < input.Length;j++)
    {
        if (Regex.IsMatch(input[i],pattern) && input[i].Length >= 3 && input[i].Length <= 25)
        {
            if(Regex.IsMatch(input[j], pattern) && input[j].Length >= 3 && input[j].Length <= 25)
            {
                int sumofLength = input[i].Length + input[j].Length;
                if(sumofLength > 0) //пошук більшої суми двох чисел
                { 
                    MaxLength[0] = sumofLength;
                    MaxLength[1] = i; //індекс першого слова
                    MaxLength[2] = j; //індекс другого слова
                    i++;j++; //зміна індексів
                }
            }
        }
    }
}
Console.WriteLine($"{input[MaxLength[1]]}");
Console.WriteLine($"{input[MaxLength[2]]}");