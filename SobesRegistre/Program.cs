string str;
string strres = "";

string alphabetMajor = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
string alphabetMinor = "abcdefghijklmnopqrstuvwxyz";

Console.WriteLine("Введите строку:");
str = Console.ReadLine();

foreach(char c in str)
{
    if ((int)c > 64 & (int)c < 91)
    {
        int index = alphabetMajor.IndexOf(c);
        char cres = alphabetMinor[index];
        strres += cres;
    }
    else if ((int)c > 96 & (int)c < 123)
    {
        int index = alphabetMinor.IndexOf(c);
        char cres = alphabetMajor[index];
        strres += cres;
    }
    else
    {
        strres += c;
    }
}

Console.WriteLine(strres);