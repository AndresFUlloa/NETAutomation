using System.Reflection;
using TechTalk.SpecFlow;
using NUnit.Framework;
using BoDi;
using TechTalk.SpecFlow.Bindings.Discovery;
using TechTalk.SpecFlow.Configuration;
using TechTalk.SpecFlow.Infrastructure;

namespace NETAutomation.runner
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    [Binding]
    public class TestRunner
	{
        [Test, Order(1)]
        [NUnit.Framework.Category("Regression")]
        public void RunSpecFlowTests()
        {
            // Create an instance of ObjectContainer
            var globalContainer = new ObjectContainer();

            // Create TestRunnerManager instance
            var testRunnerManager = new TestRunnerManager(globalContainer);

            // Run the tests
            var currentAssembly = typeof(TestRunner).Assembly;
            testRunnerManager.RunTest(currentAssembly);
        }
    }
}

