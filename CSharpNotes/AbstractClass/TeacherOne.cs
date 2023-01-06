using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpNotes.AbstractClass
{
    public class TeacherOne : School
    {
        public override string GetWorkExperience()
        {
            return "5 years";
        }

        public string GetDepartment()
        {
            return "Maths Department";
        }
    }
}
