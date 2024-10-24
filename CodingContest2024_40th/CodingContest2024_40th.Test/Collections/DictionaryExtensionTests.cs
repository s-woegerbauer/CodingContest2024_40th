using CodingContest2024_40th.Collections;
using Xunit;
using System.Collections.Generic;

namespace CodingContest2024_40th.Test.Collections
{
    public class DictionaryExtensionTests
    {
        [Fact]
        public void AddOrUpdate_AddsKeyValuePair_WhenKeyDoesNotExist()
        {
            // Arrange
            var dictionary = new Dictionary<string, int>();

            // Act
            dictionary.AddOrUpdate("key1", 1);

            // Assert
            Xunit.Assert.True(dictionary.ContainsKey("key1"));
            Xunit.Assert.Equal(1, dictionary["key1"]);
        }

        [Fact]
        public void AddOrUpdate_UpdatesValue_WhenKeyExists()
        {
            // Arrange
            var dictionary = new Dictionary<string, int> { { "key1", 1 } };

            // Act
            dictionary.AddOrUpdate("key1", 2);

            // Assert
            Xunit.Assert.Equal(2, dictionary["key1"]);
        }
    }
}