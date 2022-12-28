using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApplication
{
    public class Student
    {
        public int     _studentId { get; set; }
        public string  _firstName { get; set; }
        public string  _lastName { get; set; }
        public decimal _loanAmount { get; set; }
        public char _gender { get; set; }
        public bool _isNew { get; set; }

        public Student(int studentId, string firstname, string lastname, decimal loanAmount,char  gender, bool isNew )
        {
            _studentId = studentId;
            _firstName = firstname;
            _lastName = lastname;
            _loanAmount = loanAmount;
            _gender = gender;
            _isNew = isNew;
                
        }

        public string StudentData()
        {
            string data = $"Student Identity number: {_studentId}, Name: {_firstName} {_lastName}, Your Loan Amount: {_loanAmount}";
            return data;
        }

        public void UpdateLoanAmount(decimal loanAmount)
        {
            _loanAmount = loanAmount;

        }
    }
}