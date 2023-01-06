using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpNotes.AbstractClass
{
    public abstract class School
    {
        public abstract string GetWorkExperience();
        public string GetSchoolName()
        {
            return "Cheran Matric School";
        }

        public string GetSchoolAddress()
        {
            return "Chennai,TamilNadu";
        }
    }
}
