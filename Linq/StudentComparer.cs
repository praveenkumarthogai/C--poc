using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Linq
{
    internal class StudentComparer : IEqualityComparer<Student>
    {
        public bool Equals([AllowNull] Student x, [AllowNull] Student y)
        {
            if(x.StudentId == y.StudentId && x.StudentName == y.StudentName)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public int GetHashCode([DisallowNull] Student obj)
        {
            return obj.StudentId.GetHashCode();
        }
    }
}
