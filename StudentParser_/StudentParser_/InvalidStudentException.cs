using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentParser_ {
    public class InvalidStudentException : ApplicationException {

        public InvalidStudentException(string message) : base(message){
        }
    }

    public class InvalidStudentFormatException : ApplicationException {

        public InvalidStudentFormatException(string message) : base(message) {
        }
    }
}
