using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Scrieti un program care implementeaza cifrul "+n".
// Cifrul "+n" inlocuieste fiecare litera din textul clar cu a n-a litera care urmeaza in alfabet.
// Criptare: "+n"      Decriptare: "-n"
// Obs.: Orice alt caracter diferit de litera ramane nemodificat.
// n este un numar natural. 
// Spatiul cheilor este format din 26 de chei distincte (0..25).
// Se vor implementa operatiile de criptare/decriptare/criptanaliza.
// Criptanaliza = incercarea de a decripta un mesaj criptat fara a cunoaste cheia folosita la criptare.
// CRIPTANALIZA: Se da doar textul criptat MJQQT si trebuie gasit plaintextul (fara a cunoaste de la inceput cheia n).

namespace Criptografie
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "The quick brown fox jumps over the lazy dog.";
            int key = 3;

            string enc = PlusNCypher.EncryptDecrypt(text, key, "encrypt");
            Console.WriteLine("Encrypted: " + enc);

            string dec = PlusNCypher.EncryptDecrypt(enc, key, "decrypt");
            Console.WriteLine("Decrypted: " + dec);
        }
    }
}