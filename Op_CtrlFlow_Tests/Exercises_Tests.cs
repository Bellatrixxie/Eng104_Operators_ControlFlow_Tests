using NUnit.Framework;
using Op_CtrlFlow;
using System.Collections.Generic;

namespace Op_CtrlFlow_Tests
{
    public class Exercises_Tests
    {     
        // write unit test(s) for MyMethod here
        [TestCase(7, 7, false)]
        [TestCase(10000, 10000, false)]
        [TestCase(7, 6, true)]
        [TestCase(0, 0, false)]
        [TestCase(-1, -1, false)]
        [TestCase(0, -1, true)]
        [TestCase(-11000, 11000, true)]
        public void GivenTwoIntegers_ReturnFalseIfEqual(int num1, int num2, bool expected)
        {
            Assert.That(Exercises.MyMethod(num1, num2), Is.EqualTo(expected));
        }
        [Test]
        public void Average_ReturnsCorrectAverage()
        {
            var myList = new List<int>() { 3, 8, 1, 7, 3 };
            Assert.That(Exercises.Average(myList), Is.EqualTo(4.4));
        }

        [Test]
        public void WhenListIsEmpty_Average_ReturnsZero()
        {
            var myList = new List<int>() {};
            Assert.That(Exercises.Average(myList), Is.EqualTo(0.0));
        }

        [TestCase(100, "OAP")]
        [TestCase(60, "OAP")]
        [TestCase(59, "Standard")]
        [TestCase(18, "Standard")]
        [TestCase(17, "Student")]
        [TestCase(13, "Student")]
        [TestCase(12, "Child")]
        [TestCase(5, "Child")]
        [TestCase(4, "Free")]
        [TestCase(0, "Free")]
        public void TicketTypeTest(int age, string expected)
        {
            var result = Exercises.TicketType(age);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(81, "Pass with Distinction")]
        [TestCase(70, "Pass with Merit")]
        [TestCase(50, "Pass")]
        [TestCase(30, "Fail")]
        public void GradeTest(int testMark, string expected)
        {
            Assert.That(Exercises.Grade(testMark), Is.EqualTo(expected));
        }

        [TestCase(4, 20)]
        [TestCase(3, 50)]
        [TestCase(2, 50)]
        [TestCase(1, 100)]
        [TestCase(0, 200)]
        public void WeddingAttendeesTest(int covidLevel, int expected)
        {
            Assert.That(Exercises.GetScottishMaxWeddingNumbers(covidLevel), Is.EqualTo(expected));
        }

        [TestCase(-1)]
        [TestCase(5)]
        [TestCase(100)]

        public void ScottishWeddingMaxException_Test(int covidLevel)
        {
            Assert.That(() => Exercises.GetScottishMaxWeddingNumbers(covidLevel), Throws.TypeOf<ScottishWeddingMaxException>()
                .With.Message.Contain("Invalid input.Allowed covidLevels: 4, 3, 2, 1, 0"));
        }
    }
}
