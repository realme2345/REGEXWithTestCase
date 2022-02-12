using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using REGEXWithTestCaseProblems;

namespace UserRegistrationTestCase
{
    [TestClass]
    public class RegistrationTestCase
    {
        [TestMethod]
        public void TestCaseHappyMethod()//Test case for first name validation
        {
            //Arrange
            string expected = "Invalid First Name";
            UserRegestrationProblem userRegestrationProblem = new UserRegestrationProblem("aja", "Kongara", "Kongara.raja@gmail.com", "+91 9123234456", "konNaa@143");
            //creating a object for a class
            //Act
            string actual = userRegestrationProblem.ValidateNames(); //hear we check validating password with atleast special character
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestCaseLatMethod()//Test case for last name validation
        {
            //Arrange
            string expected = "Invalid last Name";
            UserRegestrationProblem userRegestrationProblem = new UserRegestrationProblem("Raja", "ongara", "Kongara.raja@gmail.com", "+91 9123234456", "konNaa@143");
            //creating a object for a class
            //Act
            string actual = userRegestrationProblem.ValidateNames(); //hear we check validating password with atleast special character
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestCaseEmailMethod()//Test case for Email validation
        {
            //Arrange
            string expected = "Invalid Email";
            UserRegestrationProblem userRegestrationProblem = new UserRegestrationProblem("Raja", "Kongara", "Kongararaja@gmail.com", "+91 9123234456", "konNaa@143");
            //creating a object for a class
            //Act
            string actual = userRegestrationProblem.ValidateNames(); //hear we check validating password with atleast special character
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestCaseMobileMethod()//Test case for Mobile validation
        {
            //Arrange
            string expected = "Invalid Mobile";
            UserRegestrationProblem userRegestrationProblem = new UserRegestrationProblem("Raja", "Kongara", "Kongara.raja@gmail.com", "+91 123234456", "konNaa@143");
            //creating a object for a class
            //Act
            string actual = userRegestrationProblem.ValidateNames(); //hear we check validating password with atleast special character
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestCasePasswordMethod()//Test case for Password validation
        {
            //Arrange
            string expected = "Invalid Password";
            UserRegestrationProblem userRegestrationProblem = new UserRegestrationProblem("Raja", "Kongara", "Kongara.raja@gmail.com", "+91 9123234456", "konNaa143");
            //creating a object for a class
            //Act
            string actual = userRegestrationProblem.ValidateNames(); //hear we check validating password with atleast special character
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}

 