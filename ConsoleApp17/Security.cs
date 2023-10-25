using System.Text;

namespace ConsoleApp17;

public class Security
{
    public static string EncryptSHA512(string _input)
    {
        StringBuilder builder = new StringBuilder();
        foreach (char symbol in _input)
        {
            builder.Append(symbol + 1);
        }

        return builder.ToString();
    }
}