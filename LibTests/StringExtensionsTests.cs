using NUnit.Framework;

namespace UnitTests
{
    public class StringExtensionsTests
    {

        [Test]
        public void StringExtensions_RemoveDiacritics_SUCCESS()
        {

            // PREPARE
            string originalStr = "amah� dever� ser ��bado";

            // ACT
            string cleanStr = originalStr.RemoveDiacritics();

            // ASSERT
            Assert.AreEqual("amaha devera ser cabado", cleanStr);

        }
    }
}