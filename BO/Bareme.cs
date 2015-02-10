using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Bareme
    {
        #region Attributs et Accesseurs

        public String codeGroupement { get; set; }
        public String dateVigueur { get; set; }
        public String typeActe { get; set; }
        public String libelle { get; set; }
        public Decimal tarifFixe { get; set; }
        public Decimal tarifMini { get; set; }
        public Decimal tarifMaxi { get; set; }
        public String codeVaccin { get; set; }
        public Boolean archive { get; set; }

        #endregion

        #region Constructeurs

        public Bareme()
        {
        }

        public Bareme(String CodeGroupement, String DateVigueur, String Type, String Libelle, Decimal TarifFixe, Decimal TarifMini, Decimal TarifMaxi, String CodeVaccin = null, Boolean Archive = false)
        {
            this.codeGroupement = CodeGroupement;
            this.dateVigueur = DateVigueur;
            this.typeActe = Type;
            this.libelle = Libelle;
            this.tarifFixe = TarifFixe;
            this.tarifMini = TarifMini;
            this.tarifMaxi = TarifMaxi;
            this.codeVaccin = CodeVaccin;
            this.archive = Archive;
        }

        #endregion
    }
}
