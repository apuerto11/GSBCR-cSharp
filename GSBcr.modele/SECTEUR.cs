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
    
    public partial class SECTEUR
    {
        public SECTEUR()
        {
            this.LesRegions = new HashSet<REGION>();
            this.LesVisiteurs = new HashSet<VISITEUR>();
        }
    
        public string SEC_CODE { get; set; }
        public string SEC_LIBELLE { get; set; }
    
        public virtual ICollection<REGION> LesRegions { get; set; }
        public virtual ICollection<VISITEUR> LesVisiteurs { get; set; }
    }
}