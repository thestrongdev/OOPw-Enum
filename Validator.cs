using System;
using System.Collections.Generic;
using System.Text;

namespace oopEx64_66
{
    class Validator
    {
        public enum YesNoResponse //you just create lists here 
                                  //represents a group of constants (unchangeable/read-only variables)
        {
            YES = 0,
            NO = 1,
            NOT_RECOGNIZED = 2
        }

        public string ParseYesNo(string word) //need to return enum...is that just an int?
        {
            YesNoResponse getParse;
            bool checkParse = Enum.TryParse(word, out getParse);

            if (checkParse)
            {
                return $"The user entered {getParse.ToString()}";
            }
            else
            {
                return $"The user's response was not recognized";
            }


        }


        public bool IsInt(string input)
        {
            return int.TryParse(input, out int num);
        }

        public bool IsInt(string input, int min, int max)
        {
            bool parsedInRange;

            if (int.TryParse(input, out int number))
            {
                if (number <= max && number >= min)
                {
                    parsedInRange = true;
                }
                else
                {
                    parsedInRange = false;
                }
            }
            else
            {
                parsedInRange = false;
            }

            return parsedInRange;
        }


    }
}
