string str;
string strres = "";

string alphabetMajor = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
string alphabetMinor = "abcdefghijklmnopqrstuvwxyz";
string alphabetMajorRus = "АБВГДЕЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
string alphabetMinorRus = "абвгдежзийклмнопрстуфхцчшщъыьэюя";

Console.WriteLine("Введите строку:");
str = Console.ReadLine();

foreach(char c in str)
{
    if ((int)c >= (int)alphabetMajor.First() & (int)c <= (int)alphabetMajor.Last())
    {
        int index = alphabetMajor.IndexOf(c);
        char cres = alphabetMinor[index];
        strres += cres;
    }
    else if ((int)c >= (int)alphabetMinor.First() & (int)c <= (int)alphabetMinor.Last())
    {
        int index = alphabetMinor.IndexOf(c);
        char cres = alphabetMajor[index];
        strres += cres;
    }
    else if ((int)c >= (int)alphabetMajorRus.First() & (int)c <= (int)alphabetMajorRus.Last())
    {
        int index = alphabetMajorRus.IndexOf(c);
        char cres = alphabetMinorRus[index];
        strres += cres;
    }
    else if ((int)c >= (int)alphabetMinorRus.First() & (int)c <= (int)alphabetMinorRus.Last())
    {
        int index = alphabetMinorRus.IndexOf(c);
        char cres = alphabetMajorRus[index];
        strres += cres;
    }
    else
    {
        strres += c;
    }
}

Console.WriteLine(strres);