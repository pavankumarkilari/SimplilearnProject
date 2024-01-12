using System.Collections.Generic;

namespace SchoolData
{
    public class Teacher
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }


        private string _subject;

        public string Subject
        {
            get { return _subject; }
            set { _subject = value; }
        }

        public bool Search(string s)
        {
            List<Teacher> teachlist = new List<Teacher>();

            teachlist.Add(new Teacher { Name = "Lokesh", Subject = "Science" });
            teachlist.Add(new Teacher { Name = "Rubhitha", Subject = "English" });
            teachlist.Add(new Teacher { Name = "Satish", Subject = "Mathmetics" });

            var isfound = teachlist.Find(d => d.Name == s);
            return isfound != null;
        }

    }
}