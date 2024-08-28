using Moq.AutoMock;

namespace SimpleService.Tests
{
    public class Tests
    {
        private AutoMocker _mocker;
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestGetForecast()
        {
            var service = _mocker.CreateInstance<SimpleServiceLayer>();

            var result = service.GetForecast();
            Assert.That(result, Is.Not.Null);
        }
    }
}