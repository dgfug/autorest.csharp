using System.Linq;
using NUnit.Framework;

namespace AutoRest.CSharp.Utilities
{
    public class StringExtensionsTests
    {
        [TestCase("container", "containers")]
        [TestCase("operation", "operations")]
        [TestCase("containers", "containers", false)]
        [TestCase("operations", "operations", false)]
        [TestCase("test", "tests")]
        [TestCase("boy", "boys")]
        [TestCase("policy", "policies")]
        [TestCase("life", "lives")]
        [TestCase("shoe", "shoes")]
        [TestCase("bus", "buses")]
        [TestCase("bush", "bushes")]
        [TestCase("information", "information")]
        [TestCase("person", "people")]
        [TestCase("sheep", "sheep")]
        [TestCase("people", "people", false)]
        [TestCase("child", "children")]
        public void ValidatePluralize(string noun, string expected, bool inputIsKnownToBeSingle = true)
        {
            var plural = noun.ToPlural(inputIsKnownToBeSingle);
            Assert.AreEqual(expected, plural);
        }

        [TestCase("containers", "container")]
        [TestCase("operations", "operation")]
        [TestCase("container", "container", false)]
        [TestCase("operations", "operation", false)]
        [TestCase("tests", "test")]
        [TestCase("boys", "boy")]
        [TestCase("policies", "policy")]
        [TestCase("lives", "life")]
        [TestCase("shoes", "shoe")]
        [TestCase("buses", "bus")]
        [TestCase("bushes", "bush")]
        [TestCase("information", "information")]
        [TestCase("person", "person", false)]
        [TestCase("sheep", "sheep")]
        [TestCase("people", "person")]
        [TestCase("children", "child")]
        public void ValidateSingularize(string noun, string expected, bool inputIsKnownToBePlural = true)
        {
            var plural = noun.ToSingular(inputIsKnownToBePlural);
            Assert.AreEqual(expected, plural);
        }

        [TestCase("CamelCase", new[] { "Camel", "Case" })]
        [TestCase("IPAddress", new[] { "IP", "Address" })]
        [TestCase("HTTPIsURL", new[] { "HTTP", "Is", "URL" })]
        [TestCase("GetAllByLocation", new[] { "Get", "All", "By", "Location" })]
        public void ValidateSplitByCamelCase(string camelCase, string[] expected)
        {
            var result = camelCase.SplitByCamelCase().ToArray();
            Assert.AreEqual(expected.Length, result.Length);
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }

        [TestCase("PropertyName", false, "propertyName")]
        [TestCase("PropertyName", true, "PropertyName")]
        [TestCase("_propertyName", false, "propertyName")]
        [TestCase("_propertyName", true, "PropertyName")]
        [TestCase("_property_name", false, "propertyName")]
        [TestCase("_property_name", true, "PropertyName")]
        public void ValidateToCleanName(string name, bool camelCase, string expected)
        {
            var result = name.ToCleanName(camelCase);
            Assert.AreEqual(expected, result);
        }
    }
}
