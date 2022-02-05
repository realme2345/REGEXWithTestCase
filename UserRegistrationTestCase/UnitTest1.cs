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
            string mobileNumber = "+91 8918734234";
            string expected = "Valid";
            UserRegestrationProblem userRegestrationProblem = new UserRegestrationProblem(mobileNumber);//creating a object for a class
            ///Act
            string actual = userRegestrationProblem.ValidateMobileNum();//hear we check validating Email
            ///Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
