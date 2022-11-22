using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CorectCodeLibrary;

namespace CorrectCodeLibraryTest
{
    [TestClass]
    public class CorrectCodeClassTests
    {
        /// <summary>
        /// Проверка на пустую строку
        /// </summary>
        [TestMethod]
        public void IsCorrectCode_StringEmpty_ReturnedFalse()
        {
            //Arrange
            string candidate = "";
            //Act
            bool actual = CorrectCodeClass.IsCorrectCode(candidate);
            //Assert
            Assert.IsFalse(actual);
        }
        /// <summary>
        /// Проверка на ввод малого ряда чисел
        /// </summary>
        [TestMethod]
        public void IsCorrectCode_SmallInt_ReturnedFalse()
        {
            //Arrange
            string candidate = "123";
            //Act
            bool actual = CorrectCodeClass.IsCorrectCode(candidate);
            //Assert
            Assert.IsFalse(actual);
        }
        /// <summary>
        /// Проверка на неккоректный ввод ряда чисел
        /// </summary>
        [TestMethod]
        public void IsCorrectCode_UncorrectInt_ReturnedFalse()
        {
            //Arrange
            string candidate = "123123123123123";
            //Act
            bool actual = CorrectCodeClass.IsCorrectCode(candidate);
            //Assert
            Assert.IsFalse(actual);
        }
        /// <summary>
        /// Проверка на ввод некорректных символов
        /// </summary>
        [TestMethod]
        public void IsCorrectCode_UncorrectNotInt_ReturnedFalse()
        {
            //Arrange
            string candidate = "strokasymb";
            //Act
            bool actual = CorrectCodeClass.IsCorrectCode(candidate);
            //Assert
            Assert.IsFalse(actual);
        }
        /// <summary>
        /// Проверка на ввод некорректных символов
        /// </summary>
        [TestMethod]
        public void IsCorrectCode_IntDivide10_ReturnedTrue()
        {
            //Arrange
            string candidate = "1234123400";
            //Act
            bool actual = CorrectCodeClass.IsCorrectCode(candidate);
            //Assert
            Assert.IsTrue(actual);
        }
    }
}
