using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace TestNinja.Fundamentals
{
    public class Assignment3
    {
        //проверка слово на буквы, то есть ли в нем заглавные буква
        public ActionResult2 Words(string word)
        {
            for (int i = 0; i < word.Length; i++)
                //проверяем слово на большие буквы(берем буквы в слове и сравнываем с большими)
                if (word[i] == word.ToUpper()[i])
                    //Үлкен әріп болса WordIsHaveUpperLetters функциясын шақырамыз
                    return new WordIsHaveUpperLetters();
            // егер жоқ болса WordIsNotHaveUpperLetters
            return new WordIsNotHaveUpperLetters();
        }
    }

    public class ActionResult2
    {
    }

    public class WordIsHaveUpperLetters : ActionResult2
    {
    }

    public class WordIsNotHaveUpperLetters : ActionResult2
    {
    }

    
}