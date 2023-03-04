string str;
string strres = "";
char cres;

Console.WriteLine("Введите строку:");
str = Console.ReadLine();

foreach (char c in str)
{
    if (Char.IsLetter(c))
    {
        if (Char.IsUpper(c))
        {
            cres = Char.ToLower(c);
        }
        else
        {
            cres = Char.ToUpper(c);
        }
        strres += cres;
    }
    else
    {
        strres += c;
    }

}

Console.WriteLine(strres);