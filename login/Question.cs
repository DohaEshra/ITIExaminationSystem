//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace login
{
    using System;
    using System.Collections.Generic;
    
    public partial class Question
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Question()
        {
            this.Choices = new HashSet<Choice>();
            this.Std_Exam_Ques = new HashSet<Std_Exam_Ques>();
        }
    
        public int Ques_ID { get; set; }
        public Nullable<int> Crs_ID { get; set; }
        public string Ques_Content { get; set; }
        public Nullable<int> Ques_Grade { get; set; }
        public string Ques_Type { get; set; }
        public Nullable<int> Model_Answ { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Choice> Choices { get; set; }
        public virtual Choice Choice { get; set; }
        public virtual Course Course { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Std_Exam_Ques> Std_Exam_Ques { get; set; }
    }
}
