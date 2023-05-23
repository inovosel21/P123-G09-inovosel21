using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentParser_ {
    public class MoodleStudentParser {

        public List<Student> Parse(String[] rawData) {
            if (rawData == null) return new List<Student>();
            var students = new List<Student>();
            foreach(var stringItem in rawData) {
                if (string.IsNullOrEmpty(stringItem)) continue;

                var studentParsed = stringItem.Split(',');
                if(studentParsed.Count() < 3) throw new InvalidStudentFormatException("Krivo");

                if (studentParsed.Any(el => String.IsNullOrEmpty(el))) throw new InvalidStudentException("Krivo");
                students.Add(new Student {
                    FirstName = studentParsed[0],
                    LastName = studentParsed[1],
                    Email = studentParsed[2]
                });
            }
            return students.Distinct().ToList();
        }
    }
}
