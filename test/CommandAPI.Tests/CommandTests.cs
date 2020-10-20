using System;
using Xunit;
using CommandAPI.Models;

namespace CommandAPI.Tests
{
    public class CommandTests
    {
        [Fact]
        public void CanChangeHowTo()
        {
            //Arrange
            var testCommand = new Command{
                HowTo = "Do something awesome",
                Platform = "xUnit",
                CommandLine = "dotnet test"
            };

            //Act
            testCommand.HowTo = "Execute Unit Tests";

            //Assert
            Assert.Equal("Execute Unit Tests", testCommand.HowTo);
        }

        [Fact]
        public void ChangePlatForm(){
            var testCommand = new Command {
                HowTo = "Do something awesome",
                Platform = "xUnit",
                CommandLine = "dotnet test"
            };

            testCommand.Platform = "Change Platform";

            Assert.Equal("Change Platform", testCommand.Platform);
        }

        [Fact]
        public void ChangeCommandLine(){
            var testCommand = new Command {
                HowTo = "Do something awesome",
                Platform = "xUnit",
                CommandLine = "dotnet test"
            };

            testCommand.CommandLine = "Change CommandLine";

            Assert.Equal("Change CommandLine", testCommand.CommandLine);
        }
    }
}