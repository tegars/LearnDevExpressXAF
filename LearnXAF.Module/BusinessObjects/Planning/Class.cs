using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using System;

namespace LearnXAF.Module.BusinessObjects.Planning
{
    [NavigationItem("Master Data")]
    public class Class : BaseObject
    {
        public Class(Session session) : base(session) { }
        public String Code { get; set; }
        public String Name { get; set; }

        [Association("Association for Class.Student")]
        public XPCollection<Student> Students
        {
            get
            {
                return GetCollection<Student>("Students");
            }
        }
    }
}
