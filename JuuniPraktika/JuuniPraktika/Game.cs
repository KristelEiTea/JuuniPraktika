﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Hangman
{
    class Game
    {
        public string Word { get; private set; }
        public int Lenght { get; private set; }
        private int Stage { get; set; }
        public char[] Alphabet { get; private set; }

        public Game(string word, GameLanguage lang)
        {
            Word = word;
            Lenght = Word.Length;
            Stage = 0;
            InitializeAlphabet(lang);
        }

        private void InitializeAlphabet(GameLanguage lang)
        {

            switch (lang)
            {
                case GameLanguage.En:
                    Alphabet = new char[] {'N', 'O', 'P', 'Q', 'R',
                        'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z','A',
                        'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J',
                        'K', 'L', 'M', '-', ' '};
                    break;

                case GameLanguage.Ru:
                    Alphabet = new char[] {'А', 'Б', 'В', 'Г', 'Д', 'Е',
                        'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О',
                        'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш',
                        'Щ', 'Ъ', 'Ы', 'Ь', 'Э', 'Ю', 'Я'};
                    break;

                case GameLanguage.Ee:
                    Alphabet = new char[] {'А', 'B', 'C', 'D', 'E', 'F',
                        'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P',
                        'Q', 'R', 'S', 'Š', 'Z', 'Ž', 'T', 'U', 'V', 'W',
                        'Õ', 'Ä', 'Ö', 'Ü', 'X', 'Y', '-'};
                    break;

            }
        }

        public BitmapImage GetStageImage()
        {
            return new BitmapImage(
                new Uri(System.IO.Path.Combine(
                    Environment.CurrentDirectory,
                    "Images", Stage + ".png")));
        }

        public int[] TakeCharacter(char ch)
        {
            int[] temp = new int[Word.Length];

            for (int i = 0; i < Word.Length; i++)
            {
                if (Word.ToUpper()[i] == ch)
                {
                    temp[i] = 1;
                }
                else
                {
                    temp[i] = 0;
                }
            }

            if (temp.Count(i => i == 1) == 0)
            {
                Stage++;
            }

            return temp;
        }

        public bool IsGameOver()
        {
            return Stage == 9 ? true : false;
        }
    }
}