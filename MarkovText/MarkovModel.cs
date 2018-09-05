using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkovText
{
    class MarkovModel
    {
        FirstCharacter[] firstCharacter = new FirstCharacter[26];
        MiddleCharacter[] middleCharacters = new MiddleCharacter[26];
        FinalCharacter[] finalCharacters = new FinalCharacter[26];

        public void AddWords (string[]words)
        {
            foreach(var word in words)
            {
                this.AddWord(word)
           
            }
        }
        struct FirstCharacter
        {

        }
        struct MiddleCharacter
        {

        }
        struct FinalCharacter
        {

        }
        public void AddWord(string word)
        {
         

            if (word.Length > 3)
            {
                AddFirstCharacter();
                AddMiddleCharacter();
                AddLastCharacter();
            }


        }

        private void AddFirstCharacter()
        {
            throw new NotImplementedException();
        }

        private void AddMiddleCharacter()
        {
            throw new NotImplementedException();
        }

        private void AddLastCharacter()
        {
            throw new NotImplementedException();
        }
    }
}
