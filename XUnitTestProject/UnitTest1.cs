using Moq;
using System;
using Xunit;
using BlazorApp3.Server.Controllers;

namespace XUnitTestProject
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var mockRepo = new Mock<QuizController>();
            Assert.Equal("2", mockRepo.Name);


        }
    }
}
