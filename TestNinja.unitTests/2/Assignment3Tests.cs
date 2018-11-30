using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.unitTests._2
{
    [TestFixture]
    public class Assignment3Tests
    {
        private Assignment3 _math;
        [SetUp]
        public void SetUp()
        {
            _math = new Assignment3();
        }

        [Test]
        [TestCase("Усть-Каменогорск")]//Записываем слова с обычними буквами и заглавными
        [TestCase("город")]

        public void Words_ReturnHaveUpperLetters(string word)
        {
            //отправляем слово на тест
            var result = _math.Words(word); 
            //проверяем есть ли такая функция
            Assert.That(result, Is.TypeOf<WordIsHaveUpperLetters>()); 
            Assert.That(result, Is.InstanceOf<WordIsHaveUpperLetters>());
        }
    }
}