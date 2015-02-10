using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Bareme
    {
        #region Attributs et Accesseurs

        [Browsable(false)]
        public String codeGroupement { get; set; }
        [DisplayName("Date en vigueur")]
        public String dateVigueur { get; set; }
        [DisplayName("Type Acte")]
        public String typeActe { get; set; }
        [DisplayName("Libellé")]
        public String libelle { get; set; }
        [DisplayName("Tarif fixe")]
        public Decimal tarifFixe { get; set; }
        [DisplayName("Tarif mini")]
        public Decimal tarifMini { get; set; }
        [DisplayName("Tarif maxi")]
        public Decimal tarifMaxi { get; set; }
        [Browsable(false)]
        public String codeVaccin { get; set; }
        [Browsable(false)]
        public Boolean archive { get; set; }

        #endregion

        #region Constructeurs

        public Bareme()
        {
        }

        public Bareme(String CodeGroupement, String DateVigueur, String Type, String Libelle, Decimal TarifFixe = 0, Decimal TarifMini = 0, Decimal TarifMaxi = 0, String CodeVaccin = null, Boolean Archive = false)
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
