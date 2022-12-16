using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphLabTask3
{
    internal class SmartStudent : Student
    {
        public SmartStudent(string fullName = "underfinded", int numberOfVisit = 0) : base(fullName, numberOfVisit)
        {
        }

        public override bool PassExam()
        {
            Random r = new();
            return (NumberOfVisit == numberOfLession) && !(NumberOfVisit == 0)
                || (r.NextDouble() > 0.5) && ((double)NumberOfVisit / numberOfLession > 0.3);
        }
    }
}
