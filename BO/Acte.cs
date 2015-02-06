using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Acte
    {
        #region Attributs et Accesseurs

        public Guid numConsultation { get; set; }
        public Guid numActe { get; set; }
        public String dateVigueur { get; set; }
        public String codeGroupement { get; set; }
        public Decimal prix { get; set; }
        public String typeActe { get; set; }
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
