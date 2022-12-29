string TableСube(int n)
{
    string answer = string.Empty;

    for (int i = 1; i <= n; i++)
        answer += (i == n)? Math.Pow(i,3).ToString() : Math.Pow(i,3).ToString() + ",";
    
    return answer;
}

int n = 5;
System.Console.WriteLine(TableСube(n));
