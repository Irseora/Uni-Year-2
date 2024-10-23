using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeterministicFiniteAutomata
{
    class Program
    {
        #region Globals
        static List<string> states = new List<string>();
        static List<char> alphabet = new List<char>();
        static List<Transition> transitions = new List<Transition>();
        static string initialState;
        static List<string> finalStates = new List<string>();
        #endregion

        static void Main(string[] args)
        {
            try
            {
                ReadAutomataInputFile(@".\Inputs\C2Ex2.txt");
                DFA example = new DFA(states, alphabet, transitions, initialState, finalStates);
                Console.Clear();
                example.WriteAutomataConsole();

                string input = "";
                while (input != "-")
                {
                    Console.WriteLine("Exit with \"-\"");
                    input = ReadInputWordConsole();

                    if (input != "-") example.Parse(input, true);
                }
            }
            catch (DataException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>Read automata specifications from a file</summary>
        /// <param name="path">Path to file to read from</param>
        static void ReadAutomataInputFile(string path)
        {
            StreamReader sr = new StreamReader(path);
            string inputLine;
            string[] inputSplit;

            // Read alphabet
            inputLine = sr.ReadLine();
            inputSplit = inputLine.Split(' ');
            for (int i = 0; i < inputSplit.Length; i++)
            {
                char[] temp = inputSplit[i].ToCharArray();
                alphabet.Add(temp[0]);
            }

            // Read empty line divider
            sr.ReadLine();

            // Read states
            inputLine = sr.ReadLine();
            inputSplit = inputLine.Split(' ');
            for (int i = 0; i < inputSplit.Length; i++)
                states.Add(inputSplit[i]);

            // Read empty line divider
            sr.ReadLine();

            // Read transitions
            while (!string.IsNullOrEmpty(inputLine = sr.ReadLine()))
            {
                inputSplit = inputLine.Split(' ');

                string fS = inputSplit[0];
                string tS = inputSplit[1];
                char sym = inputSplit[2].ToCharArray()[0];
                
                transitions.Add(new Transition() {fromState = fS, toState = tS, symbol = sym});
            }

            // While stops on divider, no need for empty ReadLine

            // Read starting transition
            initialState = sr.ReadLine();

            // Read empty line divider
            sr.ReadLine();

            // Read final states
            inputLine = sr.ReadLine();
            inputSplit = inputLine.Split(' ');
            for (int i = 0; i < inputSplit.Length; i++)
                finalStates.Add(inputSplit[i]);

            sr.Close();
        }

        /// <summary>Read input word from console</summary>
        /// <returns>Input word</returns>
        static string ReadInputWordConsole()
        {
            Console.Write("Word to parse: ");
            string input = Console.ReadLine();
            return input;
        }
    }
}