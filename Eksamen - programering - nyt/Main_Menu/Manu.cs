//using Eksamen_Procjekt___Chris.Main__Menu.Credits;
//using Eksamen_Procjekt___Chris.Main__Menu.Exit;
//using Eksamen_Procjekt___Chris.Main__Menu.intro;
//using Eksamen_Procjekt___Chris.Procjekt;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.Speech;
// made by Christoffer / either

namespace Eksamen_Procjekt___Chris.Main__Menu
{
    internal class Manu
    {
        SpeechSynthesizer synth = new SpeechSynthesizer();
        SpeechRecognitionEngine rec = new SpeechRecognitionEngine();
        List<string> answer = new List<string>();
        public void Menu()
        {
            int choice_start = 0;
            int choice_end = 0;
            do
            {
                synth.Speak("Welcome to my program");
                synth.Speak("There is 4 options and they are as following");
                // her kommer logoet fordi jeg kan :P
                Console.WriteLine("___________________________________________");
                Console.WriteLine("         ***Menu***");
                Console.WriteLine("___________________________________________");
                synth.Speak("number one introduktion and i recomend it just to be safe");
                Console.WriteLine("1.introduktion");
                synth.Speak("number two is my procjekt or eksam");
                Console.WriteLine("2. Procjekt");
                synth.Speak("number three is Credits of who made this program");
                Console.WriteLine("3. Credits");
                synth.Speak("number four exiting the program");
                Console.WriteLine("4. Exit");
                synth.Speak("please chose one");
                choice_start = Convert.ToInt32(Console.ReadLine());
                try
                {
                    rec = new SpeechRecognitionEngine();
                    rec.SetInputToDefaultAudioDevice();
                    rec.LoadGrammar(new DictationGrammar());
                    rec.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(rec_sleep);
                }
                catch (Exception ex)
                {
                }
                switch (choice_start)
                {
                    case 1: // her er introduktionen til selve programmet
                        if (choice_start == 1)
                        {
                            Console.Clear();
                            intro_start_game intro = new intro_start_game(); // her kommer selve introduktionen til programmet
                            intro.intro_start();
                            // grunden til at der ikke er mere er fordi så kommer man dirakte ud til main hub
                        }
                        else
                        {
                            // her ned kommer man hvis man ikke vælger en af mulighederne hvor jeg smider personen ud af progeammet
                            Console.WriteLine("NOT THIS ONE");
                            return;
                        }
                        break;
                    case 2: // her er selve eksamens procjektet
                        if (choice_start == 2)
                        {
                            // her er selve eksamsprocjektet 
                            // her kalder jeg funktionen af eksamens procjktet
                            Main_hub main_Hub = new Main_hub();
                            main_Hub.main();
                        }
                        else
                        {
                            // her kommer man ned hvis man ikke vælger en af mulighederne
                            Console.WriteLine("NOT THIS ONE");
                            return; // og jeg smider dem ud fordi jeg kan
                        }
                        break;
                    case 3: // her kommer creditsende til dem der har lavet programmet 
                        if (choice_start == 3)
                        {
                            Console.Clear();
                            credits credits = new credits(); // her kalder jeg funktionen credits
                            credits.credits_e_G();
                        }
                        else
                        {
                            // her kommer man ned hvis man ikke vælger en af mulighederne
                            Console.WriteLine("NOT THIS ONE");
                            return;
                        }
                        break;
                    case 4: // her kommer exit method
                        if (choice_start == 4)
                        {
                            // her kalder jeg funktionen at forlade programmet
                            Exit_program exit_Program = new Exit_program();
                            exit_Program.Exit_program_s();
                        }
                        else
                        {
                            // her kommer man ned hvis man ikke vælger mulighederne
                            Console.WriteLine("NOT THIS ONE");
                            return;
                        }
                        break;
                }
            } while (choice_start != 9);

        }

        // her kommer vi til genkendnings systemet :: 
        public void rec_sleep(object s, SpeechRecognizedEventArgs e)
        {
            bool one = false;
            bool two = false;
            bool three = false;
            bool four = false;
            string speech = e.Result.Text;
            answer.Add("one");
            answer.Add("two");
            answer.Add("three");
            answer.Add("four");
            answer.Add("1");
            answer.Add("2");
            answer.Add("3");
            answer.Add("4");
            if (speech == "one")
            { // her kommer man ind for mulighed nummer 1
                Menu();
                one = true;
            }
            else
            {
                if (speech == "1")
                { // her er muligheden for nummer 1 igen men dog med et andet tegn og ACSII nummer
                    one = true;
                    Menu();
                }
                else
                {
                    if (speech == "two")
                    { // her er muligheden for nummer 2
                        two = true;
                        Menu();
                    }
                    else
                    {
                        if (speech == "2")
                        {// her er muligheden for nummer 2 bare med tal istedet for
                            two = true;
                            Menu();
                        }
                        else
                        {
                            if (speech == "three")
                            { // her kommer muligheden for nummer 3 med bogtaver
                                three = true;
                                Menu();
                            }
                            else
                            {
                                if (speech == "3")
                                { // her er muligheden for nummer 3, bare med tal
                                    three = true;
                                    Menu();
                                }
                                else
                                {
                                    if (speech == "four")
                                    {
                                        four = true;
                                        Menu();
                                    }
                                    else
                                    {
                                        if (speech == "4")
                                        {
                                            four = true;
                                            Menu();
                                        }
                                        else
                                        {
                                            one = false;
                                            two = false;
                                            three = false;
                                            four = false;
                                            synth.Speak("seems like the audio might not be as good as espectet");

                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }


        }
    }
}
