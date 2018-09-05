using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkovText
{
    struct CharInstance
    {
        public char chararcter;

        public int occurances;
    }
    struct CharacterFunction
    {
        public CharacterFunction(char current)
        {
            this.current = current;
            this.totalNexts = 0;

            nextChars = new CharInstance[26];
            for (char c = 'a'; c <= 'z'; ++c)
            {
                nextChars[0] = new CharInstance() { chararcter = 'a', occurances = 0 };
            }

        }
        public char current;
       public int totalNexts;

        CharInstance[] nextChars;
    }

    private InitCharacterFunction[] InitCharacterFunctions()
    {
        var cfs = new CharacterFunction[26];
        for (char c = 'a') ;
    }

    class MarkovModel
    {
        CharacterFunction[] firstCharacter = new InitCharacterFunctions();
        CharacterFunction[] middleCharacters = new InitCharacterFunctions();
        CharacterFunction[] finalCharacters = new InitCharacterFunction();

        public void AddWords (string[]words)
        {
            foreach(var word in words)
            {
                this.AddWord(word);
           
            }
        }
       
        

 
        public void AddWord(string word)
        {
         

            if (word.Length > 3)
            {
                var lword = word.ToLower();
                AddFirstCharacter(lword);
                AddMiddleCharacter(lword);
                AddLastCharacter(lword);
            }


        }

        private void AddFirstCharacter(string word)
        {
            if (word.Length >= 2)
            {
                char fst = word[0];
                char snd = word[1];

                firstCharacter[fst-'a'].nextChars[snd-'a']
                firstCharacter[fst - 'a'].totalNexts += 1;
                
            }

        }

        private void AddMiddleCharacter(string word)
        {
            throw new NotImplementedException();
        }

        private void AddLastCharacter()
        {
            throw new NotImplementedException();
        }
    }
}
