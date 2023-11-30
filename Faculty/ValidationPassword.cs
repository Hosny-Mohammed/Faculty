using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faculty
{
    public class ValidationPassword
    {
        public  bool IsValid(String pass)
        {
            bool upper, lower, numeric, sympole;
            sympole = upper = lower = numeric = false;
            string SpecailChars = @"[!@#$%^&*()_+=\[{\]};:<>|./?,-]";
            foreach (char c in pass)
            {
                if (c >= 'A' && c <= 'Z')
                {
                    upper = true;
                    // return upper;
                }
                else if (c >= 'a' && c <= 'z')
                {
                    lower = true;
                    // return lower;
                }
                else if (c >= '0' && c <= '9')
                {
                    numeric = true;
                    //  return numeric;
                }
                else if (SpecailChars.Contains(c))
                {
                    sympole = true;
                    // return true;
                }
            }
            return upper && lower && numeric && sympole;
        }
    }
}
