using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using System;

namespace LearnXAF.Module.BusinessObjects.Planning
{
    [NavigationItem("Semester")]
    public class Student : BaseObject
    {
        public Student(Session session) : base(session) { }


        //field
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public DateTime DateofBirth { get; set; }
        [Size(255)]
        public String Address { get; set; }
        [RuleRequiredField(DefaultContexts.Save)]
        [Association("Association for Class.Student")]
        public Class Class { get; set; }
    }
}
