using System;
using Xunit;
using CommandAPI.Models;

namespace CommandAPI.Tests
{
    public class CommandTests : IDisposable
    {

        Command testCommand;

        public CommandTests(){
            testCommand = new Command
            {
                HowTo = "Do something",
                Platform = "Some Platform",
                CommandLine = "Some CommandLine"
            };
        }

        public void Dispose()
        {
            testCommand = null;
        }

        [Fact]
        public void CanChangeHowTo()
        {
            //Arrange

            //Act
            testCommand.HowTo = "Execute Unit Tests";

            //Assert
            Assert.Equal("Execute Unit Tests", testCommand.HowTo);
        }

        [Fact]
        public void ChangePlatForm(){

            testCommand.Platform = "Change Platform";

            Assert.Equal("Change Platform", testCommand.Platform);
        }

        [Fact]
        public void ChangeCommandLine(){

            testCommand.CommandLine = "Change CommandLine";

            Assert.Equal("Change CommandLin", testCommand.CommandLine);
        }
    }
}