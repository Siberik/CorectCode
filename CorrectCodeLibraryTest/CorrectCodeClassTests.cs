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
            int num =1 ;
            //Act
            bool actual = CorrectCodeClass.IsCorrectCode(num);
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
            int num = 2;
            //Act
            bool actual = CorrectCodeClass.IsCorrectCode(num);
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
            int num = 3;
            //Act
            bool actual = CorrectCodeClass.IsCorrectCode(num);
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
            int num = 4;
            //Act
            bool actual = CorrectCodeClass.IsCorrectCode(num);
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
            int num = 5;
            //Act
            bool actual = CorrectCodeClass.IsCorrectCode(num);
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
            int num = 6;
            //Act
            bool actual = CorrectCodeClass.IsCorrectCode(num);
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
            int num = 7;
            //Act
            bool actual = CorrectCodeClass.IsCorrectCode(num);
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
            int num = 8;
            //Act
            bool actual = CorrectCodeClass.IsCorrectCode(num);
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
            int num = 9;
            //Act
            bool actual = CorrectCodeClass.IsCorrectCode(num);
            //Assert
            Assert.IsTrue(actual);
        }
    }
}
