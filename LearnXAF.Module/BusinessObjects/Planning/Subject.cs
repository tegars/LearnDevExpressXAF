using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using System;

namespace LearnXAF.Module.BusinessObjects.Planning
{
    [NavigationItem("Master Data")]
    public class Subject : BaseObject
    {
        public Subject(Session session) : base(session) { }
        public String Code { get; set; }
        public String Name { get; set; }
    }
}
