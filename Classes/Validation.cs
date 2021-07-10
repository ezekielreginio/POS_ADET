using POS_ADET.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace POS_ADET.Classes
{
    class Validation
    {
        public bool validate(List<TextField> inputs)
        {
            bool valid = true;

            foreach (TextField item in inputs)
            {

            }

            return valid;
        }

        public bool validate_int(TextField input)
        {
            int n;
            if (int.TryParse(input.getValue(), out n))
                return true;
            else
            {
                input.setInvalid();
                return false;
            }
                
        }

        public bool validate_field(string input, string regex)
        {
            Match match = Regex.Match(input, regex, RegexOptions.IgnoreCase);
            var r = new Regex(regex);
            if (r.IsMatch(input))
            {
                return false;
            }
            else
                return true;
        }

    }
}
