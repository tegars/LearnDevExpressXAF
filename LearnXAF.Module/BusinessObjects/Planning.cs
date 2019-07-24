using DevExpress.ExpressApp.ConditionalAppearance;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using System;

namespace LearnXAF.Module.BusinessObjects.Planning
{
    [NavigationItem("Planning")]
    public class TeacherSubject : BaseObject
    {
        public TeacherSubject(Session session) : base(session) { }

        [Association("Association for Teacher.TeacherSubject")]
        public Teacher Teacher { get; set; }
        public Subject Subject { get; set; }
    }

    
    [NavigationItem("Planning")]
    public class ClassTeacher : BaseObject
    {
        public ClassTeacher(Session session) : base(session) { }
        public Class Class { get; set; }
        public Teacher Teacher { get; set; }
    }
}