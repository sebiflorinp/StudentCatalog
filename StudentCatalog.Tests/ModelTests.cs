using StudentCatalog.Models;

namespace StudentCatalog.Tests
{
    public class StudentTests
    {
        [Theory]
        [InlineData(1, "Ionescu", 1, "Ionescu")]
        [InlineData(3, "Angelescu", 3, "Angelescu")]
        public void StudentConstructor_CreatesAnInstancesOfStudent_Student(int id, string name, int expectedId,
            string expectedName)
        {
            //Arrange
            //Act
            Student newStudent = new Student(id, name);
            //Assert
            newStudent.Should().BeOfType(typeof(Student));
            newStudent.Id.Should().Be(expectedId);
            newStudent.Name.Should().Be(expectedName);
        }
    }

    public class SubjectTests
    {
        [Theory]
        [InlineData(1, "ASC", "Alexandru Vancea", 1, "ASC", "Alexandru Vancea")]
        [InlineData(2, "FP", "Gabi Mircea", 2, "FP", "Gabi Mircea")]
        public void SubjectConstructor_CreatesAnInstanceOfSubject_Subject(int id, string name, string teacher,
            int expectedId, string expectedName, string expectedTeacher)
        {
            //Arrange
            //Act
            Subject newSubject = new Subject(id, name, teacher);
            //Assert
            newSubject.Should().BeOfType(typeof(Subject));
            newSubject.Id.Should().Be(expectedId);
            newSubject.Name.Should().Be(expectedName);
            newSubject.Teacher.Should().Be(expectedTeacher);
        }
    }
}

