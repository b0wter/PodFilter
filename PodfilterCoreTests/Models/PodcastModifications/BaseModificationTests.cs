﻿using System.Collections.Generic;
using System.Xml.Linq;
using FakeItEasy;
using PodfilterCore.Models.PodcastModification;
using Xunit;

namespace PodfilterCoreTests.Models.PodcastModifications
{
    public class BaseModificationTests
    {
        [Fact]
        public void Modify_WithMatchingElements_CallsElementProviderAndModifier()
        {
            var fakeSelector = A.Fake<IPodcastElementProvider>();
            var elementList = new List<XElement>() { A.Fake<XElement>(x => x.WithArgumentsForConstructor(() => new XElement("test")))};
            A.CallTo(() => fakeSelector.GetElements(A<XDocument>.Ignored)).Returns(elementList);
            var fakeElementModification = A.Fake<XElementActionModification>();
            var modifier = new TestableBaseModification(fakeSelector, fakeElementModification);
            var podcast = new XDocument();
            
            modifier.Modify(podcast);
            
            A.CallTo(() => fakeSelector.GetElements(podcast)).MustHaveHappened().
                Then(A.CallTo(() => fakeElementModification.Modify(A<XElement>.Ignored)).MustHaveHappened());
        }

        [Fact]
        public void Modify_WithoutMatchingElements_CallsElementProvider()
        {
            var fakeSelector = A.Fake<IPodcastElementProvider>();
            // ReSharper disable once CollectionNeverUpdated.Local
            var elementList = new List<XElement>(); 
            A.CallTo(() => fakeSelector.GetElements(A<XDocument>.Ignored)).Returns(elementList);
            var fakeElementModification = A.Fake<XElementActionModification>();
            var modifier = new TestableBaseModification(fakeSelector, fakeElementModification);
            var podcast = new XDocument();
            
            modifier.Modify(podcast);

            A.CallTo(() => fakeSelector.GetElements(podcast)).MustHaveHappened();
            A.CallTo(() => fakeElementModification.Modify(A<XElement>.Ignored)).MustNotHaveHappened();
        }
    }
}