using System;
using System.Collections.Generic;

namespace MobLibrary1
{
    public class ListCreator
    {
            public static List<PersonTemplate> Acc = new List<PersonTemplate>();

            public static void Add(PersonTemplate pers)
            {
                Acc.Add(pers);
            }

            public static void Creator(string line)
            {
                string[] str = line.Split(',');
                var person = new PersonTemplate(str[0], Convert.ToInt32(str[1]), str[2], str[3], Convert.ToDouble(str[4]), str[5]);
                Add(person);
        }
    }
}
