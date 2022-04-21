using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Model;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class LibTest
    {
        [Test]
        [TestCase("Книга1", 123, "Автор1")]
        [TestCase("Книга2", 0, "Автор2")]
        [TestCase("Книга3", -390, "Автор3")]
        [TestCase("Книга4", 12523624213, "Автор4")]
        [TestCase("Книга5", 03, "Автор5")]
        public void BookTest(string name, int pages, string author)
        {
            var item = new Book(name, pages, author);
        }


        [Test]
        [TestCase("Журнал1", 123, "Автор1")]
        [TestCase("Журнал2", 0, "Автор2")]
        [TestCase("Журнал3", -390, "Автор3")]
        [TestCase("Журнал4", 12523624213, "Автор4")]
        [TestCase("Журнал5", 03, "Автор5")]
        public void JournalTest(string name, int page, string author)
        {
            var item = new Journal(name, page, author);
        }

        [Test]
        [TestCase("Сборник1", 123, "Автор1")]
        [TestCase("Сборник2", 0, "Автор2")]
        [TestCase("Сборник3", -390, "Автор3")]
        [TestCase("Сборник4", 12523624213, "Автор4")]
        [TestCase("Сборник5", 03, "Автор5")]
        public void DigestTest(string name, int page, string author)
        {
            var item = new Journal(name, page, author);
        }
    }
}
