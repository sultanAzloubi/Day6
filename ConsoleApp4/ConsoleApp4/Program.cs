using System;
using System.Collections;

namespace ConsoleApp4
{
    class Searchable
    {
        private string value;

        public Searchable(string value)
        {
            this.value = value;
        }

        public int numOfWords() { return this.value.Split(' ').Length;}
        public int numOfChars() { return this.value.Length; }
        public int numOfXWord(string word) 
        {
            string[] checkList = this.value.Split(' ');
            int counter = 0;

            foreach (string item in checkList)
            {
                if (item.Equals(word)) counter++;
            }
            return counter;
        }
        public int numOfXChars(char c) {
            int counter = 0;

            foreach (var item in this.value)
            {
                if (item.Equals(c)) counter++;
            }

            return counter; 
        }
        public int lastIndexOf(char c) { return this.value.LastIndexOf(c); }
        public string FrequentWord()
        {
            string[] checkList = this.value.Split(' ');
            int counter = 0,
                maxCounter = 0;
            string frWord = "";

            foreach (var item in checkList)
            {
                for (int i = 0; i < checkList.Length; i++)
                {
                    if(item == checkList[i])
                    {
                        counter++;
                    }
                }

                if (maxCounter < counter)
                {
                    frWord = item;
                    maxCounter = counter;
                    counter = 0;
                }
            }
            return frWord;
        }
        public string WordsSwapper()
        {
            string output = "";

            string[] words = this.value.Split(" ");

            for (int i = 0; i < words.Length; i += 2)
            {
                if (i + 1 == words.Length)
                {
                    output += words[i];
                }
                else
                {
                    output += words[i + 1] + " " + words[i] + " ";
                }
            }
            return output;
        }
    }
    


class Program
    {
        static void Main(string[] args)
        {
            Searchable se = new Searchable("salam alaykm shabab hala wallah");
            //Console.WriteLine(se.numOfChars());
            //Console.WriteLine(se.numOfWords());
            //Console.WriteLine(se.numOfXWord("every"));
            //Console.WriteLine(se.numOfXChars('e'));
            //Console.WriteLine(se.lastIndexOf('e'));
            //Console.WriteLine(se.FrequentWord());
            Console.WriteLine(se.WordsSwapper());

        }
    }
}
