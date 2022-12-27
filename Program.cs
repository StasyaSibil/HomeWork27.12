var array = new string[]{"hello", "2", "world", ":-)"};
var res = "[";
var filtered = FilterArray(array);

for (int i = 0; i < filtered.Length; i++)
{
    var last = i+1 == filtered.Length;
    if (last){
        res = res + filtered[i];
    }else{
        res = res + filtered[i] + ",";
    }
    
}

res = res +"]";
Console.WriteLine(res);

string[] FilterArray(string[] fullArray){
    var result = new string[GetCount(fullArray)];

    int index = 0;
    for (int i = 0; i < fullArray.Length; i++)
    {
        if (fullArray[i].Length <= 3){
            result[index] = fullArray[i];
            index++;
        }
    }
    return result;
}

int GetCount(string[] fullArray){
    int count = 0;
    foreach (var item in fullArray)
    {
        if (item.Length <= 3){
            count++;
        }            
    }

    return count;
}