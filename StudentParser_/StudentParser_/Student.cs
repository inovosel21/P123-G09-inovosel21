using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentParser_ {
    public class Student {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public override bool Equals(object obj) {
            return obj is Student student &&
                   Email == student.Email;
        }

        public override int GetHashCode() {
            return -506688385 + EqualityComparer<string>.Default.GetHashCode(Email);
        }
    }
}
