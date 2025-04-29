using TDD.App;

namespace TDD.Tests
{
    internal class PasswordTest
    {
        [Test]
        public void EsSeguroCaso01()
        {
            var password = new Password();

            var result = password.EsSegura("hola123");

            Assert.IsFalse(result);
        }

        [Test]
        public void EsSeguroCaso02()
        {
            var password = new Password();

            var result = password.EsSegura("hola12");

            Assert.IsFalse(result);
        }

        [Test]
        public void EsSeguroCaso03()
        {
            var password = new Password();

            var result = password.EsSegura("hola123");

            Assert.IsFalse(result);
        }

        [Test]
        public void EsSeguroCaso04()
        {
            var password = new Password();

            var result = password.EsSegura("holaaaa");

            Assert.IsFalse(result);
        }

        [Test]
        public void EsSeguroCaso05()
        {
            var password = new Password();

            var result = password.EsSegura("Hola123");

            Assert.IsFalse(result);
        }

        [Test]
        public void EsSeguroCaso06()
        {
            var password = new Password();

            var result = password.EsSegura("C&ps2025");

            Assert.IsTrue(result);
        }
    }
}
