namespace Szyfr.Library;

static public class SzyfrLib
{
    public static readonly string Alphabet = "aąbcćdeęfghijklłmnńoópqrsśtuvwxyzźż";
    public static readonly char[] AllowedChars = Alphabet.ToCharArray();
    public static readonly char[] Numbers = ['0', '1', '2', '3', '4', '5', '6', '7', '8', '9'];
    public static readonly char[,] TabulaRecta = CreateTabulaRecta();
    public static readonly int Len = Alphabet.Length;

    public static string ClearString(string s)
    {
        return new string(s.ToLower().Where(c => AllowedChars.Contains(c)).ToArray());
    }
    public static string ClearStringNum(string s)
    {
        return new string(s.Where(c => Numbers.Contains(c)).ToArray());
    }
    public static char[,] CreateTabulaRecta()
    {
        char[] ac = AllowedChars;
        char[,] tr = new char[ac.Length, ac.Length];
        for (int i = 0; i < ac.Length; i++)
        {
            for (int j = 0; j < ac.Length; j++)
            {
                tr[i, j] = ac[j];
            }
            ac = RotateLeft(ac);
        }
        return tr;
    }
    public static char[] RotateLeft(char[] array)
    {
        char temp = array[0];

        for (int i = 0; i < array.Length - 1; i++)
        {
            array[i] = array[i + 1];
        }

        array[array.Length - 1] = temp;
        return array;
    }

}
