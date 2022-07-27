using System.Security.Cryptography;
using System.Text;

namespace ApiAmaz.Security;
public static class SecurityConfig
{
    static TripleDESCryptoServiceProvider Crypto = new TripleDESCryptoServiceProvider();
    static MD5CryptoServiceProvider Hash = new MD5CryptoServiceProvider();

    static string keygen = "Amaz";
    public static string Encrypt(string password)
    {
        string RTKEY = "";
          try {
              if (password == "")
              {
                  RTKEY = "";
              }
              else {
          
                  Crypto.Key = Hash.ComputeHash((new UnicodeEncoding()).GetBytes(keygen));
                  Crypto.Mode = CipherMode.ECB;
                  ICryptoTransform ENCR = Crypto.CreateEncryptor();
                  byte[] BUFFER = UnicodeEncoding.ASCII.GetBytes(password);
               RTKEY =Convert.ToBase64String(ENCR.TransformFinalBlock(BUFFER,0,BUFFER.Length));
              }
          }

          catch( Exception ex  ){
              throw ex;
          }

          return RTKEY;
    }
    public static string Decrypt(string txt)
      {
          string RTKEY = "";
          try
          {
              if (txt == "")
              {
                  RTKEY = "";
              }
              else
              {

                  Crypto.Key = Hash.ComputeHash((new UnicodeEncoding()).GetBytes(keygen));
                  Crypto.Mode = CipherMode.ECB;
                  ICryptoTransform ENCR = Crypto.CreateDecryptor();
                  byte[] BUFFER = Convert.FromBase64String(txt);
                  RTKEY = UnicodeEncoding.ASCII.GetString (ENCR.TransformFinalBlock(BUFFER, 0, BUFFER.Length));
              }
          }

          catch (Exception ex)
          {
              throw ex;
          }

          return RTKEY;
      }

     public static string ENCRYPTATION_FOR_ASP(string TXT)
      {
          string RTKEY = "";

          try
          {
              if (TXT == "")
              {
                  RTKEY = "";
              }
              else
              {
                  byte[] BYTES = Encoding.Unicode.GetBytes(TXT);
     using (Aes ENCRYPTOR  = Aes.Create ()){
         Rfc2898DeriveBytes RFC = new Rfc2898DeriveBytes(keygen, new byte[] { 0x49, 0x76, 0x61, 0x6E, 0x20, 0x4D, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
         ENCRYPTOR.Key = RFC.GetBytes(32);
         ENCRYPTOR.IV = RFC.GetBytes(16);
         using ( MemoryStream MS = new MemoryStream()){
         using (CryptoStream CS = new CryptoStream(MS,ENCRYPTOR.CreateEncryptor(),CryptoStreamMode.Write)){
             CS.Write(BYTES, 0, BYTES.Length);
             CS.Close();
         }
         RTKEY = Convert.ToBase64String(MS.ToArray());
         }
     
     }
              }
          }

          catch (Exception ex)
          {
              throw ex;
          }

          return RTKEY;
      }
      public static string DECRYPTATION_FOR_ASP(string TXT)
      {
          string RTKEY = "";
          TXT = TXT.Replace(" ", "+");
          try
          {
              if (TXT == "")
              {
                  RTKEY = "";
              }
              else
              {
                  byte[] BYTES = Convert.FromBase64String(TXT);
                  using (Aes DECRYPTOR = Aes.Create())
                  {
                      Rfc2898DeriveBytes RFC = new Rfc2898DeriveBytes(keygen, new byte[] { 0x49, 0x76, 0x61, 0x6E, 0x20, 0x4D, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                      DECRYPTOR.Key = RFC.GetBytes(32);
                      DECRYPTOR.IV = RFC.GetBytes(16);
                      using (MemoryStream MS = new MemoryStream())
                      {
                          using (CryptoStream CS = new CryptoStream(MS, DECRYPTOR.CreateDecryptor(), CryptoStreamMode.Write))
                          {
                              CS.Write(BYTES, 0, BYTES.Length);
                              CS.Close();
                          }
                          RTKEY = Encoding.Unicode.GetString (MS.ToArray());
                      }

                  }
              }
          }

          catch (Exception ex)
          {
              throw ex;
          }

          return RTKEY;
      }
}