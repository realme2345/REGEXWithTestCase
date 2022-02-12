﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using REGEXWithTestCaseProblems;

namespace UserRegistrationTestCase
{
    [TestClass]
    public class RegistrationTestCase
    {
        [TestMethod]
        public void TestCaseHappyMethod()
        {
            //Arrange
            string expected = "Happy";
            UserRegestrationProblem userRegestrationProblem = new UserRegestrationProblem("Raja", "Kongara", "Kongara.raja@gmail.com", "+91 9123234456", "konNaa@143");
            //creating a object for a class
            //Act
            string actual = userRegestrationProblem.ValidateNames(); //hear we check validating password with atleast special character
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestCaseSadMethod()
        {
            // Arrange
            string expected = "Sad";
            UserRegestrationProblem userRegestrationProblem = new UserRegestrationProblem("Raja", "ongara", "Kongara.raja@gmail.com", "+91 9123234456", "konNaa@143");
            //creating a object for a class
            //Act
            string actual = userRegestrationProblem.ValidateNames(); //hear we check validating password with atleast special character
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
 