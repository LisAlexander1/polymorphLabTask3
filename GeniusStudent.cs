using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphLabTask3
{
    internal class GeniusStudent : Student
    {
        public GeniusStudent(string fullName = "underfinded", int numberOfVisit = 0) : base(fullName, numberOfVisit)
        {
        }

        public override bool PassExam()
        {
            return NumberOfVisit > 0;
        }
    }
}
