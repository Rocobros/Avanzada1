namespace Libraries;

using System.Security.Cryptography;
using System.Text;
public class EncriptionMD5
{
    static string key {get; set;} = "A!9HHhi%XjjYY4YP2@Nob009X";

    public static string Encrypt(string text)
    {
        string hash = key;
        byte[] data = UTF8Encoding.UTF8.GetBytes(text);

        MD5 md5 = MD5.Create();
        TripleDES tripledes = TripleDES.Create();

        tripledes.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
        tripledes.Mode = CipherMode.ECB;

        ICryptoTransform transform = tripledes.CreateEncryptor();
        byte[] result = transform.TransformFinalBlock(data, 0, data.Length);

        return Convert.ToBase64String(result);
    }

    public static string Decrypt(string text)
    {
        string hash = key;
        byte[] data = Convert.FromBase64String(text);

        MD5 md5 = MD5.Create();
        TripleDES tripledes = TripleDES.Create();

        tripledes.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
        tripledes.Mode = CipherMode.ECB;

        ICryptoTransform transform = tripledes.CreateDecryptor();
        byte[] result = transform.TransformFinalBlock(data, 0, data.Length);

        return UTF8Encoding.UTF8.GetString(result);
    }
}