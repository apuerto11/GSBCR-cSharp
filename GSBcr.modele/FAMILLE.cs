//------------------------------------------------------------------------------
// <auto-generated>
//    Ce code a été généré à partir d'un modèle.
//
//    Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//    Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GSBcr.modele
{
    using System;
    using System.Collections.Generic;
    
    public partial class FAMILLE
    {
        public FAMILLE()
        {
            this.LesMedicaments = new HashSet<MEDICAMENT>();
        }
    
        public string FAM_CODE { get; set; }
        public string FAM_LIBELLE { get; set; }
    
        public virtual ICollection<MEDICAMENT> LesMedicaments { get; set; }
    }
}
