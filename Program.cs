using System;
using System.Collections.Generic;
using System.Media;
using System.Text;
using System.Threading;
using System.Xml.Linq;
using NAudio.SoundFont;
using System.Speech.Synthesis;
using System.Net.Http.Headers;

namespace ChatbotApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Play the voice greeting
            PlayVoiceGreeting();

            // Display ASCII art (Cybersecurity Awareness Bot logo)
            DisplayAsciiLogo();

            // Greet the user and ask for their name
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("*        What is your name?         *");
            Console.WriteLine("--------------------------------------");
            Console.ResetColor();
            Thread.Sleep(500);  // Simulate typing delay
            string userName = Console.ReadLine();
            if (string.IsNullOrEmpty(userName))
            {
                Console.WriteLine("You didn't enter a name. Please try again.");
                return;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Hello, {userName}! Welcome to the Cybersecurity Awareness Bot!");
            Console.ResetColor();
            Thread.Sleep(1000);

            // Simulate typing effect and ask user about how they need help
            Console.ForegroundColor = ConsoleColor.Magenta;
            TypeText("I am here to help you stay safe online by providing some cybersecurity tips...");
            Console.ResetColor();
            Thread.Sleep(1000);

            Console.WriteLine("-----------------------------------------");

            string userInput = Console.ReadLine();
            if (userInput.Contains("password"))
            {
                Console.WriteLine("Tip: Use a combination of letters, numbers, and symbols for strong passwords.");
            }
            else if (userInput.Contains("phishing"))
            {
                Console.WriteLine("Tip: Be cautious of emails or messages asking for personal information.");
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Cybersecurity Tip: Always use strong passwords!");
            Console.ResetColor();

            // Simulate a chatbot conversation
            static void SimulateChat()
            {
                string userInput = "";
                while (true)


                    DisplayDivider();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("You: ");
                Console.ResetColor();
                userInput = Console.ReadLine();


                static void SimulateTyping(string message)
                {
                    foreach (char c in message)
                    {
                        Console.Write(c);
                        Thread.Sleep(100);
                    }
                    Console.WriteLine();
                }


                static void DisplayDivider()
                {
                    Console.WriteLine("\n---------------------------------------");
                }


                static void DisplayGoodbyeMessage()
                {
                    DisplayDivider();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("--------------------------------------");
                    Console.WriteLine("*         Goodbye! See you soon!     *");
                    Console.WriteLine("--------------------------------------");
                    Console.ResetColor();
                }
            }


            RespondToQueries();


            InputValidation();
        }

        // Method to play the voice greeting when the chatbot starts
        static void PlayVoiceGreeting()
        {
            try
            {
                SpeechSynthesizer synth = new SpeechSynthesizer();
                Console.WriteLine("Welcome to the Cybersecurity Awareness chatbot!");
                synth.Speak("Welcome to the Cybersecurity Awareness chatbot!, Ask me anything about online safety.");
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error playing the voice greeting: " + ex.Message);
            }
        }

        // Method to display the ASCII logo or art of the chatbot
        static void DisplayAsciiLogo()
        {
            Console.WriteLine(@"
__       __     __                             __     
\ \     / /__  | |__    __ _ _ __   __ _ _ __  / _|__  
 \ \ /\ / / _ \ | '_ \  / _` | '_ \ / _` | '_ \| |_  | 
  \ V  V /  __/ | | | || (_| | | | | (_| | | | |  _| | 
   \_/\_/ \___| |_| |_| \__,_|_| |_|\__,_|_| |_|\__| |_|
 
");
        }

        
        static void TypeText(string message)
        {
            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(50);
            }
            Console.WriteLine();
        }

        
        static void RespondToQueries()
        {
            Console.WriteLine("Ask me anything about cybersecurity. Type 'exit' to quit.");
            string input;
            while ((input = Console.ReadLine().ToLower()) != "exit")
            {
                if (input == "how are you?")
                {
                    Console.WriteLine("I'm doing well, thank you for asking!");
                }
                else if (input == "what's your purpose?")
                {
                    Console.WriteLine("My purpose is to help you stay safe online by providing cybersecurity tips and answering your questions.");
                }
                else if (input == "what can I ask you about?")
                {
                    Console.WriteLine("You can ask me about topics like password safety, phishing, and safe browsing.");
                }
                else
                {
                    Console.WriteLine("I didn't quite understand that. Could you rephrase?");
                }
            }
        }

        // Method to handle input validation and guide the user if no valid input is entered
        static void InputValidation()
        {
            Console.Write("Please type a question: ");
            string userInput = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(userInput))
            {
                Console.WriteLine("You didn't enter anything. Please type a valid question.");
            }
            else
            {
                Console.WriteLine("Thank you for your input! Now, how else can I help you?");
            }
        }
    }
}




