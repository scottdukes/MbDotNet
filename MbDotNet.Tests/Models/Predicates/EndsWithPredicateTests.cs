﻿using MbDotNet.Models.Predicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MbDotNet.Tests.Models.Predicates
{
    [TestClass]
    public class EndsWithPredicateTests : PredicateTestBase
    {
        [TestMethod]
        public void EndsWithPredicate_Constructor_SetsFieldObject()
        {
            var expectedFields = new TestPredicateFields();
            var predicate = new EndsWithPredicate<TestPredicateFields>(expectedFields);
            Assert.AreSame(expectedFields, predicate.Fields);
        }

        [TestMethod]
        public void EndsWithPredicate_Constructor_SetsCaseSensitivity()
        {
            var fields = new TestPredicateFields();
            var predicate = new EndsWithPredicate<TestPredicateFields>(fields, true, null, null);
            Assert.IsTrue(predicate.IsCaseSensitive);
        }

        [TestMethod]
        public void EndsWithPredicate_Constructor_SetsExceptExpression()
        {
            const string expectedExceptRegex = "!$";

            var fields = new TestPredicateFields();
            var predicate = new EndsWithPredicate<TestPredicateFields>(fields, false, expectedExceptRegex, null);
            Assert.AreEqual(expectedExceptRegex, predicate.ExceptExpression);
        }

        [TestMethod]
        public void EndsWithPredicate_Constructor_SetsXpathSelector()
        {
            var expectedXPathSelector = new XPathSelector("!$");

            var fields = new TestPredicateFields();
            var predicate = new EndsWithPredicate<TestPredicateFields>(fields, false, null, expectedXPathSelector);
            Assert.AreEqual(expectedXPathSelector, predicate.Selector);
        }
    }
}
