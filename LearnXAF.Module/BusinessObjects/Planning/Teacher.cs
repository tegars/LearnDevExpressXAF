using DevExpress.ExpressApp.ConditionalAppearance;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using System;

namespace LearnXAF.Module.BusinessObjects.Planning
{
    [NavigationItem("Semester")]
    [Appearance("Appearance for Teacher.DateOfBirth", TargetItems = "DateofBirth", Enabled = false, Criteria = "EnableDateOfBirth")]
    [Appearance("Appearance for Teacher.TanggalUpdate", TargetItems = "TanggalUpdate", Enabled = false, Criteria = "TRUE")]
    public class Teacher : BaseObject
    {
        public Teacher(Session session) : base(session) { }
        [RuleRequiredField(DefaultContexts.Save)]
        public String FirstName { get; set; }
        [RuleRequiredField(DefaultContexts.Save)]
        public String LastName { get; set; }
        public DateTime DateofBirth { get; set; }
        [Size(255)]
        public String Address { get; set; }
        public DateTime TanggalUpdate { get; set; }
        public int Age
        {
            get
            {
                if (this.DateofBirth != new DateTime())
                {
                    return DateTime.Now.Year - this.DateofBirth.Year;
                }
                else
                {
                    return 0;
                }
            }
        }

        protected override void OnSaving()
        {
            this.TanggalUpdate = DateTime.Now;
            base.OnSaving();
        }

        protected override void OnDeleting()
        {
            base.OnDeleting();
        }

        private bool EnableDateOfBirth
        {
            get
            {
                if (FirstName.Trim() == string.Empty)
                {
                    return false;
                }
                else if (FirstName.Contains("Obama"))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        [Association("Association for Teacher.TeacherSubject"), DevExpress.Xpo.Aggregated()]
        public XPCollection<TeacherSubject> Subjects
        {
            get
            {
                return GetCollection<TeacherSubject>("Subjects");
            }
        }
    }
}
