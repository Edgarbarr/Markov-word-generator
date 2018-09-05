using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkovText
{
    class MarkovModel
    {
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
            FirstCharacter[] firstCharacter = new FirstCharacter[26];
            MiddleCharacter[] middleCharacters = new MiddleCharacter[26];
            FinalCharacter[] finalCharacters = new FinalCharacter[26];

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
