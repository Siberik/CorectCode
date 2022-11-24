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
        /// Проверка на ввод корректного числа
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
        /// <summary>
        /// Проверка на ввод некоректоного последнего числа
        /// </summary>
        [TestMethod]
        public void IsCorrectCode_IntNotDivide10_ReturnedFalse()
        {
            //Arrange
            string candidate = "1234123401";
            //Act
            bool actual = CorrectCodeClass.IsCorrectCode(candidate);
            //Assert
            Assert.IsFalse(actual);
        }
        /// <summary>
        /// Проверка на ввод некорректных значении
        /// </summary>
        [TestMethod]
        public void IsCorrectCode_IntNotDivide_ReturnedFalse()
        {
            //Arrange
            string candidate = "1234123404";
            //Act
            bool actual = CorrectCodeClass.IsCorrectCode(candidate);
            //Assert
            Assert.IsFalse(actual);
        }
        /// <summary>
        /// Проверка на ввод значении делимых на 3
        /// </summary>
        [TestMethod]
        public void IsCorrectCode_IntDivide3_ReturnedTrue()
        {
            //Arrange
            string candidate = "3000030001";
            //Act
            bool actual = CorrectCodeClass.IsCorrectCode(candidate);
            //Assert
            Assert.IsTrue(actual);
        }
        /// <summary>
        /// Проверка на ввод ряда оканчивающее на 9
        /// </summary>
        [TestMethod]
        public void IsCorrectCode_IntDivide_ReturnedTrue()
        {
            //Arrange
            string candidate = "3000130009";
            //Act
            bool actual = CorrectCodeClass.IsCorrectCode(candidate);
            //Assert
            Assert.IsTrue(actual);
        }
    }
}
