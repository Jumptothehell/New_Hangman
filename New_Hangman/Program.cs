using System;

namespace New_Hangman
{
    enum Menu { GamePage = 1, Exit }
    class Program
    {
        /*ปริ้นเฮดเดอร์หน้าเมนู*/
        static void MenuHeader()
        {
            Console.WriteLine("Welcome to Hangman Game");
            Console.WriteLine("-------------------------");
        }
        /*ปริ้นลิสต์เข้าเลือกในหน้าเมนู*/
        static void ListMenu()
        {
            Console.WriteLine("1. Play game");
            Console.WriteLine("2. Exit");
        }
        /*ปริ้นประโยตในเลือกลิสต์เมนู*/
        static void ShowSelectMenu()
        {
            Console.WriteLine("Please Select Menu");
        }
        /*เลือกลิสต์ในหน้าเมนู*/
        static void InputMenuFromKeyBoard()
        {
            Menu keyFromKeyboard = (Menu)int.Parse(Console.ReadLine());
            PresentMenu(keyFromKeyboard);
        }
        /*เอา Method มารวมกันเป็นหน้า FirstPage*/
        static void FirstPage()
        {
            MenuHeader();
            ListMenu();
            ShowSelectMenu();
            InputMenuFromKeyBoard();
        }
        static void PresentMenu(Menu keyFromKeyboard)
        {
            if (keyFromKeyboard == Menu.GamePage)
            {
                Gaming();
            }
            else if (keyFromKeyboard == Menu.Exit)
            {
                /*ออกจากโปรแกรม*/
                Console.ReadLine();
            }
        }
        static string[] words()
        {
            return new string[] { "tennis", "football", "batminton" };
        }
        /*ใส่ Array คำที่จะทาย แรนด้อมตัวเลข*/
        static int rdm(string[] words)
        {
            Random random = new Random();
            int resultRandom = random.Next(0, words.Length);
            return resultRandom;
        }
        /*เอาตัวเลขจาก rdm มาแปลงเป็นคำ*/
        static string RandomWord(string[] words)
        {
            string word = words[rdm(words)];
            return word;
        }
        static void GameHeader()
        {
            Console.WriteLine("Play Game Hangman");
            Console.WriteLine("------------------");
        }
        static void ShowIncorrectscore(int incorrect)
        {
            Console.WriteLine("Incorrect Score: {0}", incorrect);
        }
        static void Guessword(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                Console.Write("_" + " ");
            }
            Console.WriteLine();
            ShowInputAlphabet();
            PlayerKeyChar();
        }
        static void ShowInputAlphabet()
        {
            Console.WriteLine("Input letter alphabet");
        }
        static char PlayerKeyChar()
        {
            return char.Parse(Console.ReadLine());
        }
        static void AfterKeychar() 
        {
        
        }
        static bool CheckInputChar() 
        {
            bool checkInput = true;
            return checkInput;
        }
        static void Gaming()
        {
            int incorrectchar = 0;
            do
            {
                Console.Clear();
                GameHeader();
                ShowIncorrectscore(incorrectchar);
                Guessword(RandomWord(words()));
            } while (incorrectchar <= 6);
        }

        static void Main(string[] args)
        {
            FirstPage();
        }
    }
}