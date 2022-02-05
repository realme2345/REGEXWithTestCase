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
            string firstName = "Raja";
            string expected = "Valid";
            UserRegestrationProblem userRegestrationProblem = new UserRegestrationProblem(firstName);//creating a object for a class
            ///Act
            string actual = userRegestrationProblem.ValidatingFirstName();//hear we check for validating firstName
            ///Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
