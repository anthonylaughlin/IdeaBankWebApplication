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
    
    public partial class UserMetaData
    {
        public int UserMetaDataID { get; set; }
        public string Username { get; set; }
        public Nullable<int> NumContributedIdeas { get; set; }
        public Nullable<int> NumVisitedIdeas { get; set; }
        public Nullable<int> NumIdeasAssigned { get; set; }
    
        public virtual User User { get; set; }
    }
}
