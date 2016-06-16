using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Talent.Domain.Tests
{
    [TestClass]
    public class PersonTest
    {
        [TestMethod]
        public void Person_Instantiate_CreatedObject()
        {
            // Arrange
            Person p = null;

            // Act
            p = new Person();

            // Assert
            Assert.IsInstanceOfType(p, typeof(Person));
        }

        [TestMethod]
        public void Person_Instantiate_SetsDefaultProperties()
        {
            // Arrange
            Person p = null;

            // Act
            p = new Person();

            // Assert
            Assert.IsTrue(p.Salutation == null);
            Assert.IsTrue(p.FirstName == null);
            Assert.IsTrue(p.MiddleName == null);
            Assert.IsTrue(p.LastName == null);
            Assert.IsTrue(p.Suffix == null);
            Assert.IsTrue(p.DateOfBirth == null);
            Assert.IsTrue(p.Height == null);
            Assert.IsTrue(p.HairColorId == 0);
            Assert.IsTrue(p.EyeColorId == 0);
            Assert.IsNotNull(p.Credits);
            Assert.IsTrue(p.Credits.Count == 0);
            Assert.IsNotNull(p.PersonAttachments);
            Assert.IsTrue(p.PersonAttachments.Count == 0);
            Assert.IsTrue(p.FirstLastName == String.Empty);
            Assert.IsTrue(p.LastFirstName == String.Empty);
            Assert.IsTrue(p.FullName == String.Empty);
            Assert.IsTrue(p.Age == null);
            Assert.IsTrue(p.ToString() == "");
        }

        [TestMethod]
        public void Person_AllNameParts_ComputedNamesAreCorrect()
        {
            // Arrange
            Person p = null;

            p = new Person()
            {
                Salutation = "Mr.",
                FirstName = "George",
                MiddleName = "A",
                LastName = "Jetson",
                Suffix = "Sr."
            };

            // Assert
            Assert.IsTrue(p.FirstLastName == "George Jetson");
            Assert.IsTrue(p.LastFirstName == "Jetson, George");
            Assert.IsTrue(p.FullName == "Mr. George A Jetson, Sr.");
        }

        [TestMethod]
        public void Person_NoFirstName_ComputedNamesAreCorrect()
        {
            // Arrange
            Person p = null;

            p = new Person()
            {
                Salutation = "Mr.",
                MiddleName = "A",
                LastName = "Jetson",
                Suffix = "Sr."
            };

            // Assert
            Assert.IsTrue(p.FirstLastName == "Jetson");
            Assert.IsTrue(p.LastFirstName == "Jetson");
            Assert.IsTrue(p.FullName == "Mr. A Jetson, Sr.");
        }

        [TestMethod]
        public void Person_NoLastName_ComputedNamesAreCorrect()
        {
            // Arrange
            Person p = null;

            p = new Person()
            {
                Salutation = "Mr.",
                FirstName = "George",
                MiddleName = "A",
                Suffix = "Sr."
            };

            // Assert
            Assert.IsTrue(p.FirstLastName == "George");
            Assert.IsTrue(p.LastFirstName == "George");
            Assert.IsTrue(p.FullName == "Mr. George A, Sr.");
        }

        [TestMethod]
        public void Person_NoFirstOrLastName_ComputedNamesAreCorrect()
        {
            // Arrange
            Person p = null;

            p = new Person()
            {
                Salutation = "Mr.",
                MiddleName = "A",
                Suffix = "Sr."
            };

            // Assert
            Assert.IsTrue(p.FirstLastName == "");
            Assert.IsTrue(p.LastFirstName == "");
            Assert.IsTrue(p.FullName == "Mr. A, Sr.");
        }

        [TestMethod]
        public void Person_OnlyFirstName_ComputedNamesAreCorrect()
        {
            // Arrange
            Person p = null;

            p = new Person()
            {
                FirstName = "George"
            };

            // Assert
            Assert.IsTrue(p.FirstLastName == "George");
            Assert.IsTrue(p.LastFirstName == "George");
            Assert.IsTrue(p.FullName == "George");
        }

        [TestMethod]
        public void Person_OnlyLastName_ComputedNamesAreCorrect()
        {
            // Arrange
            Person p = null;

            p = new Person()
            {
                FirstName = "Jetson"
            };

            // Assert
            Assert.IsTrue(p.FirstLastName == "Jetson");
            Assert.IsTrue(p.LastFirstName == "Jetson");
            Assert.IsTrue(p.FullName == "Jetson");
        }

        [TestMethod]
        public void Person_AgeExactly10_Returns10()
        {
            // Arrange
            Person p = null;

            p = new Person()
            {
                DateOfBirth = DateTime.Today.AddYears(-10)
            };

            // Assert
            Assert.IsTrue(p.Age == 10);
        }

        [TestMethod]
        public void Person_AgeLessThan10_Returns9()
        {
            // Arrange
            Person p = null;

            p = new Person()
            {
                DateOfBirth = DateTime.Today.AddYears(-10).AddDays(1)
            };

            // Assert
            Assert.IsTrue(p.Age == 9);
        }

        [TestMethod]
        public void Person_AgeLessThan0_Returns0()
        {
            // Arrange
            Person p = null;

            p = new Person()
            {
                DateOfBirth = DateTime.Today.AddYears(45)
            };

            // Assert
            Assert.IsTrue(p.Age == 0);
        }


        [TestMethod]
        public void Person_Sort_LastNamesInOrder()
        {
            List<Person> people = new List<Person>
            {
                new Person {LastName = "Smithwick" },
                new Person {LastName = "Smith" },
                new Person {LastName = "Rojas" }
            };

            // Act
            people.Sort();

            // Assert
            Assert.IsTrue(people[0].LastName == "Rojas");
            Assert.IsTrue(people[1].LastName == "Smith");
            Assert.IsTrue(people[2].LastName == "Smithwick");
        }

        [TestMethod]
        public void Person_Sort_NullLastNameFirst()
        {
            List<Person> people = new List<Person>
            {
                new Person {LastName = "Smithwick" },
                new Person {LastName = "Smith" },
                new Person {FirstName = "Jose" }
            };

            // Act
            people.Sort();

            // Assert
            Assert.IsTrue(people[0].FirstName == "Jose");
            Assert.IsTrue(people[1].LastName == "Smith");
            Assert.IsTrue(people[2].LastName == "Smithwick");
        }

        [TestMethod]
        public void Person_Sort_LastThenFirst()
        {
            List<Person> people = new List<Person>
            {
                new Person {LastName = "Smith", FirstName ="Bryan" },
                new Person {LastName = "Smith", FirstName = "Brian" },
                new Person {LastName = "Rojas", FirstName = "Jose" }
            };

            // Act
            people.Sort();

            // Assert
            Assert.IsTrue(people[0].FirstName == "Jose");
            Assert.IsTrue(people[1].FirstName == "Brian");
            Assert.IsTrue(people[2].FirstName == "Bryan");
        }

        [TestMethod]
        public void Person_Sort_LastThenFirstThenDateOfBirth()
        {
            List<Person> people = new List<Person>
            {
                new Person {LastName = "Smith", FirstName ="Bryan",
                    DateOfBirth = new DateTime(1993,9,23) },
                new Person {LastName = "Smith", FirstName = "Bryan",
                    DateOfBirth = new DateTime(1958,11,18)},
                new Person {LastName = "Rojas", FirstName = "Jose" }
            };

            // Act
            people.Sort();

            // Assert
            Assert.IsTrue(people[0].FirstName == "Jose");
            Assert.IsTrue(people[1].DateOfBirth.Value == new DateTime(1958, 11, 18));
            Assert.IsTrue(people[2].DateOfBirth.Value == new DateTime(1993, 9, 23));
        }

        [TestMethod]
        public void Person_Sort_NullLastNameVsEmptyStringLastName()
        {
            List<Person> people = new List<Person>
            {
                new Person {LastName = "", FirstName ="Inigo",
                    DateOfBirth = new DateTime(1993,9,23) },
                new Person {LastName = "Smith", FirstName = "Bryan",
                    DateOfBirth = new DateTime(1958,11,18)},
                new Person {LastName = null, FirstName = "Jose" }
            };

            // Act
            people.Sort();

            // Assert
            Assert.IsTrue(people[0].FirstName == "Inigo");
            Assert.IsTrue(people[1].FirstName == "Jose");
            Assert.IsTrue(people[2].FirstName == "Bryan");
        }
    }
}
