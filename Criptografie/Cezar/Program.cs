using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Scrieti un program care implementeaza cifrul lui Cezar.
// Cifrul lui Cezar inlocuieste fiecare litera din textul clar cu a treia litera care urmeaza in alfabet. 
// Criptare: "+3"      Decriptare: "-3"
// Obs.: Orice alt caracter diferit de litera ramane nemodificat. 
// Se vor implementa operatiile de criptare/decriptare/criptanaliza.

namespace Cezar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input: ");
            string text = Console.ReadLine();
            
            string encrypted = CaesarCypher.EncryptDecrypt(text, "encrypt");
            Console.WriteLine("Encrypted: " + encrypted);

            string decrypted = CaesarCypher.EncryptDecrypt(encrypted, "decrypt");
            Console.WriteLine("Decrypted: " + decrypted);
        }
    }
}