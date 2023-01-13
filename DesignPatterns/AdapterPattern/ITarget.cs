using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    public interface ITarget
    {
        string TranslateAndTellToOtherPerson(string words, string convertToWhichLanguage);
    }
}
