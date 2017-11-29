using NUnit.Framework;
using StringsCE;
using FluentAssertions;
using System.IO;

namespace StringsCE.tests
{
    [TestFixture]
    public class StringFileTest
    {

        string originalfile = @"C:\Work\Training\StringsCE\originalbooks.dat";
        string createdfile = @"C:\Work\Training\StringsCE\books.dat";

        [Test]
        public void FileShouldBeIdentical()
        {
            FileAssert.AreEqual(originalfile, createdfile);
        }
    }
}
