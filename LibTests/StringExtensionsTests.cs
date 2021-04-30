using NUnit.Framework;

namespace UnitTests
{
    public class StringExtensionsTests
    {

        [Test]
        public void StringExtensions_RemoveDiacritics_SUCCESS()
        {

            // PREPARE
            string originalStr = "amahã deverá ser çábado";

            // ACT
            string cleanStr = originalStr.RemoveDiacritics();

            // ASSERT
            Assert.AreEqual("amaha devera ser cabado", cleanStr);

        }
    }
}