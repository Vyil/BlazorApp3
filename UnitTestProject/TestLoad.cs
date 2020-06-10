using BlazorApp3.Server.Controllers;
using Microsoft.AspNetCore.Components.Testing;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Server.HttpSys;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using BlazorApp3.Client.Pages;

namespace UnitTestProject.UnitTests
{
    public class TestLoad
    {
        TestHost host = new TestHost();
        [Fact]
        public void SouldLoadHomePage()
        {
            var component = host.AddComponent<BlazorApp3.Client.Pages.Index>();

            Assert.Equal("Hello, world!", component.Find("h1").InnerText);
        }

        [Fact]
        public void ShouldChangeImageAfterClickingTheButton()
        {
            var component = host.AddComponent<GalleryViewer>();

            Assert.Contains("big1", component.Find("img").Attributes["src"].Value);
            component.Find("button").Click();

            Assert.DoesNotContain("big1", component.Find("img").Attributes["src"].Value);
        }
    }
}
