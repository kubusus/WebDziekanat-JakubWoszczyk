using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDziekanat
{
    class Subject
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int ECTS { get; set; }
        public double Grade { get; set; }
        public string Lecturer { get; set; }

        public Subject()
        {

        }

        public Subject(string name, int ECTS, double grade, string lecturer)
        {
            Random rand = new Random();
            this.Id = rand.Next(100000, 999999).ToString();
            this.Name = name;
            this.ECTS = ECTS;
            this.Grade = grade;
            this.Lecturer = lecturer;
        }

    }
}
