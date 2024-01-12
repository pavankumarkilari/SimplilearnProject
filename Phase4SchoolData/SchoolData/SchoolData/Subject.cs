using System.Collections.Generic;

namespace SchoolData
{
    public class Subject
    {
        private string _subname;

        public string Name
        {
            get { return _subname; }
            set { _subname = value; }
        }

        private string _subCode;

        public string SubCode
        {
            get { return _subCode; }
            set { _subCode = value; }
        }

        public bool Search(string s)
        {
            List<Subject> sublist = new List<Subject>();

            sublist.Add(new Subject { Name = "Mathematics", SubCode = "1001" });
            sublist.Add(new Subject { Name = "Science", SubCode = "1002" });
            sublist.Add(new Subject { Name = "English", SubCode = "1003" });



            var isfound = sublist.Find(d => d.Name == s);
            return isfound != null;
        }

    }
}
