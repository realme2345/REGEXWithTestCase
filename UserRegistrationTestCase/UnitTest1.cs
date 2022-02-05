using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using REGEXWithTestCaseProblems;

namespace UserRegistrationTestCase
{
    [TestClass]
    public class RegistrationTestCase
    {
        [TestMethod]
        public void TestCaseMethod()
        {
            ///Arrange
            string Email = "raja.kongara@gmail.com";
            string expected = "Valid";
            UserRegestrationProblem userRegestrationProblem = new UserRegestrationProblem(Email);//creating a object for a class
            ///Act
            string actual = userRegestrationProblem.ValidatingEmail();//hear we check validating Email
            ///Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
