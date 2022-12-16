using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphLabTask3
{
    internal class Student
    {
        protected readonly int numberOfLession = 20;
        private string fullName;
        private int numberOfVisit;

        public string FullName
        {
            get => fullName;
            set
            {
                if (value.Trim().Split(" ").Length > 1)
                {
                    fullName = value;
                }
            }
        }
        public int NumberOfVisit { get => numberOfVisit; set => numberOfVisit = value >= 0 ? value : 0; }

        public Student(string fullName = "underfinded", int numberOfVisit = 0)
        {
            this.fullName = fullName;
            this.numberOfVisit = Math.Max(0,Math.Min(numberOfVisit, numberOfLession));
        }

        public virtual bool PassExam()
        {
            Random r = new();
            return (numberOfVisit == numberOfLession) && !(numberOfVisit == 0)
                || (r.NextDouble() > 0.5) && ((double)numberOfVisit / numberOfLession > 0.5);
        }

        public string Info()
        {
            return $"{fullName}, кол-во посещений: {numberOfVisit}";
        }
    }
}
