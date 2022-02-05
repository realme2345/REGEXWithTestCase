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
            string mobileNumber = "rajakongara";
            string expected = "Valid";
            UserRegestrationProblem userRegestrationProblem = new UserRegestrationProblem(mobileNumber);//creating a object for a class
            ///Act
            string actual = userRegestrationProblem.ValidatePassword();//hear we check validating Password
            ///Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
