//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CommerceIdeaBank.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class AssignmentFile
    {
        public int AssignmentFileID { get; set; }
        public int ProjectAssignID { get; set; }
        public int FileID { get; set; }
    
        public virtual File File { get; set; }
        public virtual ProjectAssignment ProjectAssignment { get; set; }
    }
}
