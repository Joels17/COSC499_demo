using COSC499_demoProject;
using NUnit.Framework;

namespace COSC499_demoTest
{
    public class Tests
    {
        private string testString;
        private StringManipulator stringMan;
        [SetUp]
        public void Setup()
        {
            stringMan = new StringManipulator();
            testString = "Hello World!";
        }

        [Test]
        public void String5TimesFunction()
        {
            string output = stringMan.String5Times(testString);
            if (output == "Hello World!Hello World!Hello World!Hello World!Hello World!")
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }

        }
    }
}