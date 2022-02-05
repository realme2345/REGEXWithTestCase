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
            string lastName = "Raja";
            string expected = "Valid";
            UserRegestrationProblem userRegestrationProblem = new UserRegestrationProblem(lastName);//creating a object for a class
            ///Act
            string actual = userRegestrationProblem.ValidatingLastName();//hear we check for Validating Last name
            ///Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
