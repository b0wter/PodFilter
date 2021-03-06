﻿using FluentAssertions;
using PodfilterCore.Models.PodcastModification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace PodfilterCoreTests.Models.PodcastModifications
{
    public class XpathPodcastElementProviderTests
    {
        static readonly string DefaultSelector = "//title";
        static readonly Dictionary<string, string> DefaultNamespaces = new Dictionary<string, string>() { { "atom", "http://www.w3.org/2005/Atom" }, { "itunes", "http://www.itunes.com/dtds/podcast-1.0.dtd"}};
        static readonly Dictionary<string, string> AdditionalTestNamespaces = new Dictionary<string, string>() { { "foo", "http://foo.com" }, { "bar", "http://bar.com" } };
        static Dictionary<string, string> MergedNamespaces => DefaultNamespaces.Concat(AdditionalTestNamespaces).ToDictionary(pair => pair.Key, pair => pair.Value);
        //
        //TODO: might be better to restructure this into a Theory with inline data
        //

        private XPathPodcastElementProvider CreateProviderWithXPathAndNamespaces()
        {
            var provider = new XPathPodcastElementProvider(DefaultSelector);
            return provider;
        }

        private XPathPodcastElementProvider CreateProviderWithXPathAndAdditionalNamespaces()
        {
            var provider = new XPathPodcastElementProvider(DefaultSelector, MergedNamespaces);
            return provider;
        }

        //
        // Tests for the constructor using only the selector.
        //
        [Fact]
        public void Constructor_WithXPath_SetsXPath()
        {
            var provider = new XPathPodcastElementProvider(DefaultSelector);

            Assert.Equal(DefaultSelector, provider.XPath);
        }

        [Fact]
        public void Constructor_WithXPath_SetsDefaultNamespaces()
        {
            var provider = new XPathPodcastElementProvider(DefaultSelector);

            provider.NamespaceManager.GetNamespacesInScope(System.Xml.XmlNamespaceScope.ExcludeXml).Should().Equal(DefaultNamespaces);
        }

        //
        // Tests for the constructor using the selector and additional namespaces.
        //
        [Fact]
        public void Constructor_WithXPathAndNamespace_SetsXPath()
        {
            var provider = CreateProviderWithXPathAndAdditionalNamespaces();

            Assert.Equal(DefaultSelector, provider.XPath);
        }

        [Fact]
        public void Constructor_WithXPathAndNamespace_SetsNamespace()
        {
            var provider = CreateProviderWithXPathAndAdditionalNamespaces();

            provider.NamespaceManager.GetNamespacesInScope(System.Xml.XmlNamespaceScope.ExcludeXml).Should().Equal(MergedNamespaces);
        }
    }
}
