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
    
    public partial class VISITEUR
    {
        public VISITEUR()
        {
            this.LesRapports = new HashSet<RAPPORT_VISITE>();
            this.LesAffectations = new HashSet<TRAVAILLER>();
        }
    
        public string VIS_MATRICULE { get; set; }
        public string VIS_NOM { get; set; }
        public string Vis_PRENOM { get; set; }
        public string VIS_ADRESSE { get; set; }
        public string VIS_CP { get; set; }
        public string VIS_VILLE { get; set; }
        public System.DateTime VIS_DATEEMBAUCHE { get; set; }
        public string SEC_CODE { get; set; }
        public string LAB_CODE { get; set; }
        public string vis_mdp { get; set; }
    
        public virtual ICollection<RAPPORT_VISITE> LesRapports { get; set; }
        public virtual SECTEUR LeSecteur { get; set; }
        public virtual ICollection<TRAVAILLER> LesAffectations { get; set; }
    }
}
