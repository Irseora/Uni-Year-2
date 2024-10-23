using System;
using System.Collections.Generic;
using System.Data;
using System.Net.NetworkInformation;

namespace DeterministicFiniteAutomata
{
    struct Transition
    {
        public string fromState, toState;
        public char symbol;
    }

    class DFA
    {
        #region Members
        /// <summary>
        /// All possible states: s0, s1, s2, ..., sn
        /// </summary>
        List<string> States;

        /// <summary>
        /// Alphabet used (single characters): a, b, c, ... / 0, 1, ...
        /// </summary>
        List<char> Alphabet;

        /// <summary>
        /// All transitions: fromState, symbol, toState
        /// </summary>
        List<Transition> Transitions;

        string InitialState;

        List<string> FinalStates;
        #endregion

        public DFA(List<string> states, List<char> alphabet, List<Transition> transitions, string initialState, List<string> finalStates)
        {
            States = states;
            Alphabet = alphabet;

            // Validate transitions
            Transitions = new List<Transition>();
            foreach (Transition trans in transitions)
                if (TransitionValid(trans))
                    Transitions.Add(trans);
                else
                    throw new DataException("Invalid transition list");

            // Validate initial state
            if (States.Contains(initialState))
                InitialState = initialState;
            else
                throw new DataException("Invalid initial state");

            // Validate final state
            FinalStates = new List<string>();
            foreach (string state in finalStates)
                if (States.Contains(state))
                    FinalStates.Add(state);
                else throw new DataException("Invalid final state list");
        }

        /// <summary>Check if given transition is valid in current DFA</summary>
        /// <param name="trans">Transition to test</param>
        /// <returns></returns>
        bool TransitionValid(Transition trans)
        {
            // If states don't exist in States
            if (!States.Contains(trans.fromState) || !States.Contains(trans.toState))
                return false;

            // If symbol doesn't exist in Alphabet
            if (!Alphabet.Contains(trans.symbol))
                return false;

            // If transition with same fromState & same symbol already exists (+ same transition already exists)
            foreach (Transition tr in Transitions)
                if (trans.fromState == tr.fromState && trans.symbol == tr.symbol)
                    return false;

            return true;
        }

        /// <summary>Parse a word through the automata, optionally showing steps</summary>
        /// <param name="word">Word to parse</param>
        /// <param name="outputSteps">Show or hide steps taken</param>
        public void Parse(string word, bool outputSteps = false)
        {
            if (outputSteps)
                Console.Write(word + ": " + InitialState);

            string currentState = InitialState;
            for (int i = 0; i < word.Length; i++)
            {
                string nextState = "";

                foreach (Transition trans in Transitions)
                    if (trans.fromState == currentState && trans.symbol == word[i])
                        {
                            nextState = trans.toState;
                            break;
                        }

                // If there is no transition
                if (nextState == "")
                {
                    Console.WriteLine("\nInput not accepted");
                    Console.WriteLine();
                    return;
                }

                if (outputSteps) Console.Write(" -> " + nextState);
                currentState = nextState;
            }

            if (FinalStates.Contains(currentState)) Console.WriteLine("\nInput accepted");
            else Console.WriteLine("\nInput not accepted");
            Console.WriteLine();
        }

        /// <summary> Writes automatas details to console </summary>
        public void WriteAutomataConsole()
        {
            // Write automata type
            Console.WriteLine("Deterministic Finite Automata");
            Console.WriteLine();

            // Write alphabet
            Console.WriteLine("Alphabet:");
            Console.Write("A = { ");
            for (int i = 0; i < Alphabet.Count; i++)
                if (i != Alphabet.Count - 1) Console.Write(Alphabet[i] + ", ");
                else Console.Write(Alphabet[i]);
            Console.WriteLine(" }");
            Console.WriteLine();

            // Write states
            Console.WriteLine("States:");
            Console.Write("S = { ");
            for (int i = 0; i < States.Count; i++)
                if (i != States.Count - 1) Console.Write(States[i] + ", ");
                else Console.Write(States[i]);
            Console.WriteLine(" }");
            Console.WriteLine();

            // Write transitions
            Console.WriteLine("Transitions:");
            foreach(Transition transition in Transitions)
                Console.WriteLine("(" + transition.fromState + ", " + transition.symbol + ") -> " + transition.toState);
            Console.WriteLine();
            
            // Write initial state
            Console.WriteLine("Initial state:");
            Console.WriteLine(InitialState);
            Console.WriteLine();

            // Write final states
            Console.WriteLine("Final states:");
            Console.Write("F = { ");
            for (int i = 0; i < FinalStates.Count; i++)
                if (i != FinalStates.Count - 1) Console.Write(FinalStates[i] + ", ");
                else Console.Write(FinalStates[i]);
            Console.WriteLine(" }");
            Console.WriteLine();
        }
    }
}