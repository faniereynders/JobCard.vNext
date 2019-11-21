// Decompiled with JetBrains decompiler
// Type: Reytec.Security.Cryptography.RSACryptography
// Assembly: ReytecCryptoFramework, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 95C7C4B5-0F4F-426B-9613-2C1501F3554A
// Assembly location: C:\dev\Reytec JobCard\Reytec JobCard\ReytecCryptoFramework.dll

using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Reytec.Security.Cryptography
{
  public class RSACryptography
  {
    public static RSACryptoServiceProvider rsa;

    public static void AssignParameter()
    {
      RSACryptography.rsa = new RSACryptoServiceProvider(new CspParameters(1)
      {
        KeyContainerName = "SpiderContainer",
        Flags = CspProviderFlags.UseMachineKeyStore,
        ProviderName = "Microsoft Strong Cryptographic Provider"
      });
    }

    public static string EncryptData(string data2Encrypt)
    {
      RSACryptography.AssignParameter();
      StreamReader streamReader = new StreamReader("c:\\publickey.xml");
      string end = streamReader.ReadToEnd();
      RSACryptography.rsa.FromXmlString(end);
      streamReader.Close();
      byte[] bytes = Encoding.UTF8.GetBytes(data2Encrypt);
      return Convert.ToBase64String(RSACryptography.rsa.Encrypt(bytes, false));
    }

    public static void AssignNewKey()
    {
      RSACryptography.AssignParameter();
      StreamWriter streamWriter1 = new StreamWriter("c:\\privatekey.xml");
      string xmlString1 = RSACryptography.rsa.ToXmlString(true);
      streamWriter1.Write(xmlString1);
      streamWriter1.Close();
      StreamWriter streamWriter2 = new StreamWriter("c:\\publickey.xml");
      string xmlString2 = RSACryptography.rsa.ToXmlString(false);
      streamWriter2.Write(xmlString2);
      streamWriter2.Close();
    }

    public static string DecryptData(string data2Decrypt)
    {
      RSACryptography.AssignParameter();
      byte[] rgb = Convert.FromBase64String(data2Decrypt);
      StreamReader streamReader = new StreamReader("c:\\privatekey.xml");
      string end = streamReader.ReadToEnd();
      RSACryptography.rsa.FromXmlString(end);
      streamReader.Close();
      return Encoding.UTF8.GetString(RSACryptography.rsa.Decrypt(rgb, false));
    }
  }
}
