using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Content.Persistance
{
    public class Encryptor
    {
        public class Cryptographer
        {
            // an object to use to convert from strings to Unicode byte arrays
            // and vice-versa
            static UnicodeEncoding _unicodeEncoding = new UnicodeEncoding();

            // unique seed value for the RijndaelManaged class to use in
            // encrypting and decrypting values. we must convert the string
            // to an array of bytes.
            static string _key = "&(~nb/+|";
            static byte[] _keyByteArray = _unicodeEncoding.GetBytes(_key);

            /// <summary>
            /// The Encrypt method takes a single ANSI string as input and returns an encrypted, Base-64 version of the
            /// input string as output.
            /// </summary>
            /// <param name="p_inputString">The input string to encrypt</param>
            /// <returns>An excrypted version of the input string</returns>
            public static string Encrypt(string p_inputString)
            {
                MemoryStream encryptedStream;
                RijndaelManaged rijndaelManaged;
                CryptoStream cryptoStream;
                byte[] inputStreamByteArray;
                byte[] encryptedByteArray;

                // create MemoryStream objects for the input text and the encrypted result text
                encryptedStream = new MemoryStream(p_inputString.Length * 2);

                // create a new instance of the RijndaelManaged class
                rijndaelManaged = new RijndaelManaged();

                // create a oCryptoStream, pass it an empty stream to write to and an encryptor created
                // with the RijndaelManaged class
                cryptoStream = new CryptoStream(
                    encryptedStream,
                    rijndaelManaged.CreateEncryptor(_keyByteArray, _keyByteArray),
                    CryptoStreamMode.Write
                );

                // write the input string into the CryptoStream
                inputStreamByteArray = _unicodeEncoding.GetBytes(p_inputString);
                cryptoStream.Write(inputStreamByteArray, 0, inputStreamByteArray.Length);
                cryptoStream.FlushFinalBlock();

                encryptedByteArray = new byte[encryptedStream.Length];
                encryptedStream.Position = 0;
                encryptedStream.Read(encryptedByteArray, 0, (int)encryptedStream.Length);
                cryptoStream.Close();

                return (Convert.ToBase64String(encryptedByteArray));
            }


            /// <summary>
            /// The Decrypt method takes an encrypted, Base-64 string as input and returns the decrypted, ANSI version 
            /// of it as output.
            /// </summary>
            /// <param name="p_insputString">The input string to decrypt</param>
            /// <returns>A decrypted version of the input string</returns>
            public static string Decrypt(string p_insputString)
            {
                MemoryStream inputStream;
                MemoryStream decryptedStream;
                RijndaelManaged rijndaelManaged;
                CryptoStream cryptoStream;
                int currentByteValue;
                string decryptedString;

                // create an empty stream into which the encrypted string will be placed
                inputStream = new MemoryStream(Convert.FromBase64String(p_insputString));
                decryptedStream = new MemoryStream();

                // create a new instance of the RijndaelManaged class
                rijndaelManaged = new RijndaelManaged();

                // position the encrypted input string at the beginning
                inputStream.Seek(0, SeekOrigin.Begin);

                // create a oCryptoStream, pass it the input stream, and a decryptor created
                // with the RijndaelManaged class
                cryptoStream = new CryptoStream(
                    inputStream,
                    rijndaelManaged.CreateDecryptor(_keyByteArray, _keyByteArray),
                    CryptoStreamMode.Read
                );

                // write the decrypted string byte-by-byte into the decrypted stream (oDecryptedStream)
                while ((currentByteValue = cryptoStream.ReadByte()) != -1)
                    decryptedStream.WriteByte((byte)currentByteValue);

                // retrieve the decrypted string through the UnicodeEncoding object's GetString method
                decryptedString = _unicodeEncoding.GetString(decryptedStream.ToArray());

                return decryptedString;

            }
        }
    }
}
