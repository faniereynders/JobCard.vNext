// Decompiled with JetBrains decompiler
// Type: Reytec.Security.Cryptography.StringCrypography
// Assembly: ReytecCryptoFramework, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 95C7C4B5-0F4F-426B-9613-2C1501F3554A
// Assembly location: C:\dev\Reytec JobCard\Reytec JobCard\ReytecCryptoFramework.dll

using System;
using System.Security.Cryptography;
using System.Text;

namespace Reytec.Security.Cryptography
{
  public sealed class StringCrypography
  {
    public static string EncryptString(string NormalString)
    {
      return Convert.ToBase64String(ProtectedData.Protect(Encoding.Unicode.GetBytes(NormalString), (byte[]) null, DataProtectionScope.CurrentUser));
    }

    public static string DecryptString(string EncryptedString)
    {
      if (EncryptedString == "")
        return "";
      return Encoding.Unicode.GetString(ProtectedData.Unprotect(Convert.FromBase64String(EncryptedString), (byte[]) null, DataProtectionScope.CurrentUser));
    }
  }
}
