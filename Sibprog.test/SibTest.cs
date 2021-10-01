using System.Collections.Generic;
using NUnit.Framework;
using Sibprog;

namespace Sibprog.test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Input_Validator()
        {
            Assert.That(() => Sibprog.Counter(null), Throws.ArgumentNullException);
        }

        [Test]
        public void Empty_String()
        {
            Assert.That(() => Sibprog.Counter(""), Is.Empty);
        }

        [Test]
        public void nUMBER()
        {
            Assert.That(() => Sibprog.Counter("123456"), Is.Empty);
        }

        [Test]
        public void Hola_mundo()
        {
            Dictionary<char, int> rest = new Dictionary<char, int>
            {
                ['a'] = 1,
                ['o'] = 3,
                ['u'] = 1
            };
            Assert.That(() => Sibprog.Counter("hola@mundo.com"), Is.EquivalentTo(rest));
        }
        
        [Test]
        public void Case_Insensitive()
        {
            Dictionary<char, int> rest = new Dictionary<char, int>
            {
                ['a'] = 5,
                ['e'] = 3,
                ['i'] = 3,
                ['o'] = 4,
                ['u'] = 4
            };
            Assert.That(() => Sibprog.Counter("Murcielago x MURCIELAGO = mUrciElagO cuadrado"), 
            Is.EquivalentTo(rest));
        }
    }
}