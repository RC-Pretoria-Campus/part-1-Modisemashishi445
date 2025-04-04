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

            Console.WriteLine("-----------------------------------------------------");

            static void RespondToQueries()
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Hello! I'm here to help with your cybersecurity questions.");
                Console.Write("You: ");
                Console.ResetColor();

                // Sample user interaction
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("How can I assist you today? (Type 'exit' to quit)");
                Console.WriteLine("---------------------------------------------------------");
                Console.ResetColor();

                string userInput;

                while ((userInput = Console.ReadLine().ToLower()) != "exit")
                {
                    if (userInput.Contains("how are you?"))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("I'm doing great, thank you for asking! How can I help you with your cybersecurity questions today?");
                        Console.WriteLine("----------------------------------------------------------------------------------------------------");
                        Console.ResetColor();
                    }
                    else if (userInput.Contains("what's your purpose?"))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("My purpose is to assist with cybersecurity-related topics, providing guidance on password safety, phishing, safe browsing, and general online security.");
                        Console.WriteLine("-------------------------------------------------------------------------------------------------");
                        Console.ResetColor();
                    }
                    else if (userInput.Contains("what can i ask you about?"))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("You can ask me about a variety of cybersecurity topics like:");
                        Console.WriteLine("------------------------------------------------------------");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("- Password Safety: Tips on creating strong passwords, managing them securely, and using two-factor authentication (2FA).");
                        Console.WriteLine("-------------------------------------------------------------------------------------");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("- Phishing: How to recognize phishing attempts and avoid them.");
                        Console.WriteLine("--------------------------------------------------------------");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("- Safe Browsing: How to browse the web securely and avoid risky links.");
                        Console.WriteLine("-----------------------------------------------------------------------");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("- General Online Security: Including topics like antivirus software and privacy protection.");
                        Console.WriteLine("--------------------------------------------------------------------------------------");
                        Console.ResetColor();
                    }
                    else if (userInput.Contains(" What is phishing?"))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Phishing is a fraudulent attempt to obtain sensitive information like usernames, passwords, or credit card details by pretending to be a trustworthy entity in electronic communication.");
                        Console.WriteLine("---------------------------------------------------------------------------------------");
                        Console.ResetColor();
                    }
                    else if (userInput.Contains("What is password safety?"))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Password safety involves using strong, unique passwords for each account and leveraging tools like password managers. It's also a good idea to enable two-factor authentication (2FA) wherever possible.");
                        Console.WriteLine("----------------------------------------------------------------------------------------");
                        Console.ResetColor();
                    }
                    else if (userInput.Contains("What is safe browsing?"))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Safe browsing practices include using HTTPS websites, avoiding clicking on suspicious links, and being cautious about sharing personal information online.");
                        Console.WriteLine("------------------------------------------------------------------------------------------");
                        Console.ResetColor();
                    }
                    else if (userInput.Contains("dictionary"))
                    {
                        ShowDictionary();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Sorry, I didn't understand that. Please ask a question related to cybersecurity or type 'exit' to quit.");
                    }
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("Ask another question or type 'exit' to quit.");
                }
            }

            static void ShowDictionary()
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Cybersecurity Dictionary:");
                Console.WriteLine("--------------------------");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("- Phishing: A fraudulent attempt to obtain sensitive information by pretending to be a trustworthy entity.");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("- Password Manager: A tool to store and manage passwords securely.");
                Console.WriteLine("------------------------------------------------------------------");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("- Two-Factor Authentication (2FA): A security process that requires two forms of identification to access an account.");
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("- HTTPS: A secure version of HTTP used to encrypt data sent between a web browser and a website.");
                Console.WriteLine("------------------------------------------------------------------------------------------------");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("- Malware: Malicious software designed to damage or gain unauthorized access to systems.");
                Console.WriteLine("----------------------------------------------------------------------------------------");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("- Encryption: The process of encoding data to prevent unauthorized access.");
                Console.WriteLine("--------------------------------------------------------------------------");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("- VPN: A service that creates a secure, encrypted connection to the internet.");
                Console.WriteLine("--------------------------------------------------------------------------");
                Console.ResetColor();
            }

            RespondToQueries();

        string userInput = Console.ReadLine();
            if (userInput.Contains("password"))
            {
                Console.WriteLine("Tip: Use a combination of letters, numbers, and symbols for strong passwords.");
                Console.WriteLine("--------------------------------------------------------------------------");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("You: ");
                Console.ResetColor();
                userInput = Console.ReadLine();
            }
            else if (userInput.Contains("phishing"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Tip: Be cautious of emails or messages asking for personal information.");
                Console.WriteLine("----------------------------------------------------------------------");
                Console.ResetColor();
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Cybersecurity Tip: Always use strong passwords!");
            Console.WriteLine("----------------------------------------------------------------");
            Console.ResetColor();

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
    }
}




