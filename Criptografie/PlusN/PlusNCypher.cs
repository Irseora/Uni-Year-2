using System;

class PlusNCypher
{
    public static string EncryptDecrypt(string input, int key, string operation)
    {
        if (key == 0) return input;

        string output = "";
        int overflowModifier = (int)'Z' + key - (int)'A';

        for (int i = 0; i < input.Length; i++)
        {
            char temp = input[i];

            if (Char.IsLetter(temp))
            {
                if (temp >= 'A' && temp <= 'Z')
                {
                    if (operation == "encrypt")
                    {
                        if (temp + key > 'Z') temp = (char)(temp + (key - overflowModifier));
                        else temp = (char)(temp + key);
                    }
                    else
                    {
                        if (temp - key < 'A') temp = (char)(temp - (key + overflowModifier));
                        else temp = (char)(temp - key);
                    }
                }
                else if (temp >= 'a' && temp <= 'z')
                {
                    if (operation == "encrypt")
                    {
                        if (temp + key > 'z') temp = (char)(temp + (key - overflowModifier));
                        else temp = (char)(temp + key);
                    }
                    else
                    {
                        if (temp - key < 'a') temp = (char)(temp - (key + overflowModifier));
                        else temp = (char)(temp - key);
                    }
                }
            }

            output += temp;
        }

        return output;
    }
}