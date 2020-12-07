using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieRentalSystem;

namespace MRSUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSignUp()
        {
            SignUp signUp = new SignUp();
            int result = signUp.NewUserSingUp("user@gmail.com", "dffbhQdf2sdg");

            Assert.AreEqual(0, result, 0.001, "Error");
        }

        [TestMethod]
        public void TestSignUpUsernameBadEmail1()
        {
            SignUp signUp = new SignUp();
            int result = signUp.NewUserSingUp("@gmail.com", "dffbhQdf2sdg");

            Assert.AreEqual(-1, result, 0.001, "Error");
        }

        [TestMethod]
        public void TestSignUpUsernameBadEmail2()
        {
            SignUp signUp = new SignUp();
            int result = signUp.NewUserSingUp("usergmail.com", "dffbhQdf2sdg");

            Assert.AreEqual(-1, result, 0.001, "Error");
        }

        [TestMethod]
        public void TestSignUpUsernameBadEmail3()
        {
            SignUp signUp = new SignUp();
            int result = signUp.NewUserSingUp("user@gmail", "dffbhQdf2sdg");

            Assert.AreEqual(-1, result, 0.001, "Error");
        }

        [TestMethod]
        public void TestSignUpUsernameBadEmail4()
        {
            SignUp signUp = new SignUp();
            int result = signUp.NewUserSingUp("user", "dffbhQdf2sdg");

            Assert.AreEqual(-1, result, 0.001, "Error");
        }

        [TestMethod]
        public void TestSignUpPasswordWithoutUpperCase()
        {
            SignUp signUp = new SignUp();
            int result = signUp.NewUserSingUp("user@gmail.com", "dffbhqdf2sdg");

            Assert.AreEqual(-2, result, 0.001, "Error");
        }

        [TestMethod]
        public void TestSignUpPasswordWithoutNumeric()
        {
            SignUp signUp = new SignUp();
            int result = signUp.NewUserSingUp("user@gmail.com", "dffbhQdfdsdg");

            Assert.AreEqual(-2, result, 0.001, "Error");
        }

        [TestMethod]
        public void TestSignUpPasswordWithoutLowerCase()
        {
            SignUp signUp = new SignUp();
            int result = signUp.NewUserSingUp("user@gmail.com", "DFFBHQDF2SDG");

            Assert.AreEqual(-2, result, 0.001, "Error");
        }
    }
}
