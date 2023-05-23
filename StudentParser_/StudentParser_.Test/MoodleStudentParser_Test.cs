using System;
using System.Collections.Generic;
using Xunit;

namespace StudentParser_.Test {
    public class MoodleStudentParser_Test {
        [Fact]
        public void Parse_GivenEmptyData_ReturnsEmptyList_() {
            var moodleStudentParser = new MoodleStudentParser();

            List<Student> students = moodleStudentParser.Parse(new String[] { });

            Assert.Empty(students);
        }

        [Fact]
        public void Parse_GivenNull_ReturnsEmptyList_() {
            var moodleStudentParser = new MoodleStudentParser();

            List<Student> students = moodleStudentParser.Parse(null);

            Assert.Empty(students);
        }

        [Fact]
        public void Parse_GivenStudentWithoutEmail_ReturnListWithParsedStudent() {
            var moodleStudentParser = new MoodleStudentParser();

            Action act = () => moodleStudentParser.Parse(new String[] { "Pero,Kos," });

            Assert.Throws<InvalidStudentException>(act);
        }

        [Fact]
        public void Parse_GivenStudentDelimiter_ReturnListWithParsedStudent() {
            var moodleStudentParser = new MoodleStudentParser();

            Action act = () => moodleStudentParser.Parse(new String[] { "Pero,Kos;" });

            Assert.Throws<InvalidStudentFormatException>(act);
        }

        [Fact]
        public void Parse_GivenStudentWithoutEmail2_ReturnListWithParsedStudent() {
            var moodleStudentParser = new MoodleStudentParser();

            Action act = () => moodleStudentParser.Parse(new String[] { "Pero,Kos" });

            Assert.Throws<InvalidStudentFormatException>(act);
        }

        [Fact]
        public void Parse_GivenRawOneEmptyString_ReturnParsedStudentsData() {
            var moodleStudentParser = new MoodleStudentParser();

            List<Student> students = moodleStudentParser.Parse(new String[] { "Daniel,Škrlac,dskrlac20@student.foi.hr", "" });

            Assert.Single(students);
            Assert.Equal("dskrlac20@student.foi.hr", students[0].Email);
        }

        [Fact]
        public void Parse_GivenRawEmptyString_ReturnParsedStudentsData() {
            var moodleStudentParser = new MoodleStudentParser();
      
            List<Student> students = moodleStudentParser.Parse(new String[] {""});

            Assert.Empty(students);
        }

        [Fact]
        public void Parse_GivenRawStudentData_ReturnParsedStudentsData() {
            var moodleStudentParser = new MoodleStudentParser();
            var studentsRaw = new String[] {
                "Daniel,Škrlac,dskrlac20@student.foi.hr",
            };
            List<Student> students = moodleStudentParser.Parse(studentsRaw);

            Assert.Single(students);
            Assert.Equal("Daniel", students[0].FirstName);
        }

        [Fact]
        public void Parse_GivenRawStudentsData_ReturnParsedStudentsData() {
            var moodleStudentParser = new MoodleStudentParser();
            var studentsRaw = new String[] {
                "Daniel,Škrlac,dskrlac20@student.foi.hr",
                "Tin,Tomašiæ,ttomasic20@student.foi.hr",
            };
            List<Student> students = moodleStudentParser.Parse(studentsRaw);

            Assert.Equal(2, students.Count);
            Assert.Equal("Daniel", students[0].FirstName);
        }

        [Fact]
        public void Parse_GivenRawStudentsData_ReturnDistinctParsedStudentsData() {
            var moodleStudentParser = new MoodleStudentParser();
            var studentsRaw = new String[] {
                "Daniel,Škrlac,dskrlac20@student.foi.hr",
                "Tin,Tomašiæ,ttomasic20@student.foi.hr",
                "Daniel,Škrlac,dskrlac20@student.foi.hr",
            };
            List<Student> students = moodleStudentParser.Parse(studentsRaw);

            Assert.Equal(2, students.Count);
            Assert.Equal("Tin", students[1].FirstName);
        }
    }
}