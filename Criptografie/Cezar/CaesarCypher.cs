using System;
using System.Linq;

class CaesarCypher
{
    static int key = 3;
    static int overflowModifier = 26;

/*
    public static string Encrypt(string text)
    {
        string encrypted = "";

        for (int i = 0; i < text.Length; i++)
        {
            char temp = text[i];

            if (Char.IsLetter(text[i]))
            {
                temp = text[i];
                temp = (char)(temp + offset);

                // Overflow
                if ((temp > 'Z' && temp < 'a') || temp > 'z')
                    temp = (char)(temp - overflowModifier);
            }

            encrypted += temp;
        }

        return encrypted;
    }

    public static string Decrypt(string encrypted)
    {
        string text = "";

        for (int i = 0; i < encrypted.Length; i++)
        {
            char temp = encrypted[i];

            if (Char.IsLetter(temp))
            {
                temp = (char)(temp - offset);

                // Overflow
                if (temp < 'A' || (temp < 'a' && temp > 'Z'))
                    temp = (char)(temp + overflowModifier);
            }

            text += temp;
        }

        return text;
    }
*/

    public static string EncryptDecrypt(string input, string operation)
    {
        string output = "";

        for (int i = 0; i < input.Length; i++)
        {
            char temp = input[i];

            if (Char.IsLetter(temp))
            {
                int modifier;
                if (operation == "encrypt") modifier = key;
                else modifier = -key;

                temp = (char)(temp + modifier);

                //Overflow into non-letter characters: >A, Z-a, z<
                if ((temp < 'A') || (temp > 'Z' && temp < 'a') || temp > 'z')
                {
                    if (modifier > 0) temp = (char)(temp - overflowModifier);
                    else temp = (char)(temp + overflowModifier);
                }
            }

            output += temp;
        }

        return output;
    }
}