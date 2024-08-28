using Microsoft.VisualStudio.TestTools.UnitTesting;
using Us.Alburt.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;

namespace Us.Alburt.Extensions.Tests
{
    [TestClass]
    public class StringExtensionsTests
    {
        [TestMethod]
        public void IsNullOrEmptyOrWordNull_ValueIsNull_ReturnsTrue()
        {
            string? value = null;

            bool actual = value!.IsNullOrEmptyOrWordNull();
            
            actual.Should().BeTrue();
        }

        [TestMethod]
        public void IsNullOrEmptyOrWordNull_ValueIsStringDotEmpty_ReturnsTrue()
        {
            string value = string.Empty;

            bool actual = value.IsNullOrEmptyOrWordNull();

            actual.Should().BeTrue();
        }

        [TestMethod]
        public void IsNullOrEmptyOrWordNull_ValueIsEmptyString_ReturnsTrue()
        {
            string value = "";

            bool actual = value.IsNullOrEmptyOrWordNull();

            actual.Should().BeTrue();
        }

        [TestMethod]
        public void IsNullOrEmptyOrWordNull_ValueIsStringNull_ReturnsTrue()
        {
            string value = "null";

            bool actual = value.IsNullOrEmptyOrWordNull();

            actual.Should().BeTrue();
        }

        [TestMethod]
        public void IsNullOrEmptyOrWordNull_ValueIsMultipleEmptySpaces_ReturnsFalse()
        {
            string value = "  ";

            bool actual = value.IsNullOrEmptyOrWordNull();

            actual.Should().BeFalse();
        }

        [TestMethod]
        public void IsNullOrEmptyOrWordNull_ValueIsNotEmpty_ReturnsFalse()
        {
            string value = "test";

            bool actual = value.IsNullOrEmptyOrWordNull();

            actual.Should().BeFalse();
        }
    }
}