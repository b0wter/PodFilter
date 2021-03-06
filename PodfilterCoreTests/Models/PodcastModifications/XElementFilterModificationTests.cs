﻿using System;
using System.Linq;
using System.Xml.Linq;
using FakeItEasy;
using PodfilterCore.Models.ContentFilters;
using PodfilterCore.Models.PodcastModification;
using Xunit;

namespace PodfilterCoreTests.Models.PodcastModifications
{
    public class XElementFilterModificationTests
    {
        [Fact]
        public void Modify_WithNullArgument_ThrowsArgumentNullException()
        {
            var fakeFilter = A.Fake<IContentFilter>();
            var filterModification = new XElementFilterModification(fakeFilter);
            
            Assert.Throws<ArgumentNullException>(() => filterModification.Modify(null));
        }

        [Fact]
        public void Modify_WithMatchingElement_ReturnsElement()
        {
            var fakeElement = A.Fake<XElement>(x => x.WithArgumentsForConstructor(() => new XElement("test")));
            var fakeFilter = A.Fake<IContentFilter>();
            A.CallTo(() => fakeFilter.PassesFilter(A<string>.Ignored)).Returns(true);

            var modification = new XElementFilterModification(fakeFilter);
            var result = modification.Modify(fakeElement);

            Assert.Same(fakeElement, result);
        }

        [Fact]
        public void Modify_WithNonMatchingElement_ReturnsNullAndRemovesFromParent()
        {
            var fakeDocument = new XDocument();
            var fakeElement = new XElement("test");
            var rootElement = new XElement("root");
            rootElement.Add(fakeElement);
            fakeDocument.Add(rootElement);
            var fakeFilter = A.Fake<IContentFilter>();
            A.CallTo(() => fakeFilter.PassesFilter(fakeElement.Value)).Returns(false);
            
            var modification = new XElementFilterModification(fakeFilter);
            var result = modification.Modify(fakeElement);
            
            Assert.Null(result);
            Assert.Equal(0, fakeDocument.Descendants().Count());
        }
    }
}