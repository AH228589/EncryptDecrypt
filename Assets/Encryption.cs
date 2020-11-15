using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;

public static class Encryption
{
    public static string EncryptDecrypt(string inputText, int key)
    {
        StringBuilder outSB = new StringBuilder(inputText.Length);
        for (int i = 0; i < inputText.Length; i++)
        {
            char ch = (char)(inputText[i] ^ key);
            outSB.Append(ch);
        }
        return outSB.ToString();
    }
}
