using System;

namespace MobLibrary1
{
    public class PersonTemplate
    {

        public string guidStr;

        public int age;

        public string name, position, team;

        Guid guid;

        public double workHours;

        public PersonTemplate(string name, int age, string position, string team, double workHours, string guidStr = null)
        {
            this.age = age;
            this.name = name;
            this.position = position;
            this.team = team;
            this.workHours = workHours;
            this.guidStr = guidStr;
            if (this.guidStr == null)
            {
                guid = Guid.NewGuid();
                this.guidStr = guid.ToString();
            }
            else
            {
                this.guidStr = guidStr;
            }
        }

        public override string ToString()
        {
            return $"{name}, {age}, {position}, {team}, {workHours}, { this.guidStr}\n";

        }
    }
}
