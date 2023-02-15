Console.Clear();
string[] array = {"-ne", "two", "t, 6", "6ы", "4u,5r", "!ve", "sixx"};
Console.Write($"[\"{String.Join("\", \"", array)}\"] --> ");
string[] array2 = GetThreeElem(array);
if (array2.Length == 0)
{
    Console.Write("[]");
}
else
{
    Console.Write($"[\"{String.Join("\", \"", array2)}\"]");
}

string[] GetThreeElem(string[] list) 
    { 
        int count = 0; 
        for (int i = 0; i < list.Length; i++) 
        { 
            if (list[i].Length <= 3) count++; 
        }
        string[] result = new string[count];  
        int j = 0;  
        for (int i = 0; i < list.Length; i++)  
        {  
            if (list[i].Length <= 3)  
            {  
                result[j] = list[i];  
                j++;  
            }  
        }  
        return result; 
    }    
