using NUnit.Framework;

using System;
using System.Collections.Generic;

namespace TestApp.UnitTests;

public class PersonTests
{
    private Person _person;

    [SetUp]
    public void Setup()
    {
        this._person = new();
    }
    [Test]
    public void Test_AddPeople_ReturnsListWithUniquePeople()
    {
        // Arrange
        string[] peopleData = { "Alice A001 25", "Bob B002 30", "Alice A001 35" };
        var expectedPeopleList = new List<(string Name, string Id, int Age)>
        {
            ("Alice", "A001", 35),
            ("Bob", "B002", 30)
        };

        // Act
        List<Person> resultPeopleList = this._person.AddPeople(peopleData);

        // Assert
        Assert.That(resultPeopleList, Has.Count.EqualTo(2));
        for (int i = 0; i < resultPeopleList.Count; i++)
        {
            Assert.That(resultPeopleList[i].Name, Is.EqualTo(expectedPeopleList[i].Name));
            Assert.That(resultPeopleList[i].Id, Is.EqualTo(expectedPeopleList[i].Id));
            Assert.That(resultPeopleList[i].Age, Is.EqualTo(expectedPeopleList[i].Age));
        }
    }

    [Test]
    public void Test_GetByAgeAscending_SortsPeopleByAge()
    {
        // Arrange
        string[] peopleData = { "Alice A001 25", "Bob B002 30", "James C003 35", "Lora D004 40" };
        string expected =
        "Alice with ID: A001 is 25 years old." + Environment.NewLine +
        "Bob with ID: B002 is 30 years old." + Environment.NewLine +
        "James with ID: C003 is 35 years old." + Environment.NewLine +
        "Lora with ID: D004 is 40 years old.";
        var resultPeopleList = _person.AddPeople(peopleData);

        // Act
        string result = _person.GetByAgeAscending(resultPeopleList);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
