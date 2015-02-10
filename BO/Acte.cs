using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Acte
    {
        #region Attributs et Accesseurs

        [Browsable(false)]
        public Guid numConsultation { get; set; }

        [Browsable(false)]
        public Guid numActe { get; set; }

        [DisplayName("Date Vigueur")]
        public String dateVigueur { get; set; }

        [DisplayName("Code Groupement")]
        public String codeGroupement { get; set; }

        [DisplayName("Prix")]
        public Decimal prix { get; set; }

        [Browsable(false)]
        public String typeActe { get; set; }

        [DisplayName("Acte")]
        public String libelle { get; set; }

        #endregion

        #region Constructeurs

        public Acte()
        {
        }

        public Acte(Guid NumConsultation, Guid NumActe, String DateVigueur, String CodeGroupement, Decimal Prix, String TypeActe, String Libelle)
        {
            this.numConsultation = NumConsultation;
            this.numActe = NumActe;
            this.dateVigueur = DateVigueur;
            this.codeGroupement = CodeGroupement;
            this.prix = Prix;
            this.typeActe = TypeActe;
            this.libelle = Libelle;
        }

        #endregion
    }
}
