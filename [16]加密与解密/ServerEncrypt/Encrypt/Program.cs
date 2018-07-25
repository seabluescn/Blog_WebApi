using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Encrypt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Study Encrypt!");

            //从前端传来的加密后的密文
            var encryptedMessage = "OhfMWIV+HfaD4LUtK1iQoR+azCWNQoby64/ymGFyAWr5gecNH98FZHAdledW6QMELYqU9r/VpPpeSb+EdxKLSxU4opgdS/JgX2h6TbVpHPWahTXcqWfl7WBkk2X6t5TthwxU74F8yP29rF7aEBM2hK33xhHH6MafAAa8Mx+jrdwx35JniR+cPWW0lkitlznKTpnd2XDE3a/5TdTLe21iqmkxQ/QjtK/XWBrhshOxHNkj1yo3uozPYo4anb5LiRg4kvtx17KBColLnvwrqLKfYRtGZf243FfU4hVInbUD3VEC490EVnEEzaCz3OLHyXJBjyMYm/+L8nzxAqAc3Y4GxA==";
           
            //私钥
            var privateKey = "MIIEpAIBAAKCAQEAtZX5Ov+dIm/AGI85hbEbzUXtCw0MupMar+oePUstRLPFd3DVFH7gLVc7icxWeHEjY6An0sT/nhH4on4iBMgJeJNsgk2+Fxdv2stX223jsTNDn1C0uh9TbuLejslYWCJdliAE/l3O1gwD7/iyaOx9e8pAdm0tM4ynkYtbqQb0FmFFO9QVFDVO5ALMhr1A4+/5J8b1+dAZVOLeqMDlhgOoM2ZvuPRzAyQ2xNZmY8zLgtUquhrq/4UlM5UzYcVtUTJSkaGEN1BUiKqtNXohmtYcH9MF1JxTrKBz5gI+nJSBSFzAA0Svh/9Y3DCsu3+L2En2uLzWkqr7Z03Z1rAIRNrzlwIDAQABAoIBACWqWCouv09XUsdFXi8nD5dCu+qg6FUDEnQO4frgzyEDESC3XNuFfcap44Wvxvfwr+CIZfpINqV5INPDyhanz58dJVLaAWYUzHTb3Pt9Dc/BzHMNcI9y1AGaOYPwq8yMRFFRjvecSb0IfQCX25n8BANbboeiGdApitCb0YV8FcFWTmVNqRyxIUTPaD2W332aalMu34VX6ScSsaq5IkgK7Lr7/Qj8X9P/nLewecYBXV07T94iQtKpos4XEVyFSuDngcCSSO10V7XyeuL4A/eyxrsD+5pBAu5MRbVPDwwx57BpygzzKnCnEIYUPTNzLEwWEdCMVcDrl7tvRwW/dNgyL8ECgYEA3agjoZicGtzgxnwyFhWV9ZoEq3kRvnPVO/svRLAPJnD0UMLFNC7un78G8wqnxNGETed8pVf5/asyNkaZdA09fnd51CsPFVPSBqArvyhVU/zJreDA2GRWkPlczSsnu4TnXNKStH6XfJRpEoD14lRS/baU1DhAEfdq1mi9bQVU85ECgYEA0bhyrMM67oodS7zl10v2NNzxbsTZpt2qmo26XIeEQSsGNtJz7btmRoxvfl/nFM4nTIGGo5H9xmc+upmPClxuNMiJgnrPvoq3Q9bmOhPD0KccDP9VTR6lySH2rU4Ayv4l+9PBjBU9zj96tPAlGtwD9/E0brnBtt+AvYGjAw5HEKcCgYEArUSoRcPkE2OiGcYv6O+Kv+hbyibj5frqLu8Vbh4qWaRmd1MpkLc3NYzAQ/CKYOJfB/7ygtWYx+CxaZgakIthDKEcjOvz6HoTbbZ7O/ytZu/uP4u3c/BLcxxanM8lSgKEUR0SLSHgDTR+Rkak7v13unilMpeeDe1YiK5rlPNcCuECgYEAlJFhE4heiDvpkwznmgSjD0Hx+zGSqsZfpIuAmSobg/sRtOaT37chNhsopNMVpcSBTI55rgivSc08P/6muYVPQS9LUtbjsq0cNP/ZKw1za63mjkKX0EFE2t6nnJAkuakfiW2ysCUgGqsXp3R0JLn2ScBjD4midIWS8y0SKQkFSQMCgYA/fFnoZlMcVPmcHL41uZTeYhvUkqLPkHJC2A3xHP7Qk0EiQMkQtaVIzGMKcep+HahFZDSiUX59NUx3tGW1Vgb3xxa4OdTanxt65RWUdnuGeEVWKgFLutRi2wSo+rg7+/K3SCddMOnfVmP0qfd0xmzDHX5+HjlG+D9ZTjnNZqg2ow==";

            //根据私钥生成RSA提供者
            RSACryptoServiceProvider rsaCryptoServiceProvider = CreateRsaProviderFromPrivateKey(privateKey);

            byte[] decrypted = rsaCryptoServiceProvider.Decrypt(Convert.FromBase64String(encryptedMessage), false);

            Console.WriteLine($"decrypted = {Encoding.UTF8.GetString(decrypted)}");

            Console.ReadLine();
        }

        private static RSACryptoServiceProvider CreateRsaProviderFromPrivateKey(string privateKey)
        {
            var privateKeyBits = System.Convert.FromBase64String(privateKey);

            var RSA = new RSACryptoServiceProvider();
            var RSAparams = new RSAParameters();

            using (BinaryReader binr = new BinaryReader(new MemoryStream(privateKeyBits)))
            {
                byte bt = 0;
                ushort twobytes = 0;
                twobytes = binr.ReadUInt16();
                if (twobytes == 0x8130)
                    binr.ReadByte();
                else if (twobytes == 0x8230)
                    binr.ReadInt16();
                else
                    throw new Exception("Unexpected value read binr.ReadUInt16()");

                twobytes = binr.ReadUInt16();
                if (twobytes != 0x0102)
                    throw new Exception("Unexpected version");

                bt = binr.ReadByte();
                if (bt != 0x00)
                    throw new Exception("Unexpected value read binr.ReadByte()");

                RSAparams.Modulus = binr.ReadBytes(GetIntegerSize(binr));
                RSAparams.Exponent = binr.ReadBytes(GetIntegerSize(binr));
                RSAparams.D = binr.ReadBytes(GetIntegerSize(binr));
                RSAparams.P = binr.ReadBytes(GetIntegerSize(binr));
                RSAparams.Q = binr.ReadBytes(GetIntegerSize(binr));
                RSAparams.DP = binr.ReadBytes(GetIntegerSize(binr));
                RSAparams.DQ = binr.ReadBytes(GetIntegerSize(binr));
                RSAparams.InverseQ = binr.ReadBytes(GetIntegerSize(binr));
            }

            RSA.ImportParameters(RSAparams);
            return RSA;
        }
        private static int GetIntegerSize(BinaryReader binr)
        {
            byte bt = 0;
            byte lowbyte = 0x00;
            byte highbyte = 0x00;
            int count = 0;
            bt = binr.ReadByte();
            if (bt != 0x02)
                return 0;
            bt = binr.ReadByte();

            if (bt == 0x81)
                count = binr.ReadByte();
            else
                if (bt == 0x82)
            {
                highbyte = binr.ReadByte();
                lowbyte = binr.ReadByte();
                byte[] modint = { lowbyte, highbyte, 0x00, 0x00 };
                count = BitConverter.ToInt32(modint, 0);
            }
            else
            {
                count = bt;
            }

            while (binr.ReadByte() == 0x00)
            {
                count -= 1;
            }
            binr.BaseStream.Seek(-1, SeekOrigin.Current);
            return count;
        }
    }
}
