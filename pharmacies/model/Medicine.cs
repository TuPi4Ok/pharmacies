using pharmacies.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacies.model
{
    public class Medicine
    {
        private int id;
        private String name;
        private TypesOfPackaging typeOfPackaging;
        private MethodOfConsumption methodOfConsumption;
        private int cost;
        private String contraindications;
        private DateTime bestBeforeDate;
        List<PharmacyMedicine> pharmacyMedicine;
        private int firmId;
        private Firm firm;
        private Discount discount;


        public int Id { get => id; set => id = value; }
        public int Cost { get => cost; set => cost = value; }
        public string Contraindications { get => contraindications; set => contraindications = value; }
        public DateTime BestBeforeDate { get => bestBeforeDate; set => bestBeforeDate = value; }
        internal TypesOfPackaging TypeOfPackaging { get => typeOfPackaging; set => typeOfPackaging = value; }
        internal MethodOfConsumption MethodOfConsumption { get => methodOfConsumption; set => methodOfConsumption = value; }
        public int FirmId { get => firmId; set => firmId = value; }
        internal Firm Firm { get => firm; set => firm = value; }
        internal Discount Discount { get => discount; set => discount = value; }
        public string Name { get => name; set => name = value; }
        internal List<PharmacyMedicine> PharmacyMedicine { get => pharmacyMedicine; set => pharmacyMedicine = value; }

        public String getFormatTypeOfPackaging()
        {
            switch (TypeOfPackaging)
            {
                case TypesOfPackaging.group:
                    return "Групповая";
                case TypesOfPackaging.Primary:
                    return "Первичная";
                case TypesOfPackaging.Secondary:
                    return "Вторичная";
                case TypesOfPackaging.Tertiary:
                    return "Третичная";
                default:
                    return "";
            }
        }

        public String getFormatMethodOfConsumption()
        {
            switch (methodOfConsumption)
            {
                case MethodOfConsumption.dermalAdministration:
                    return "кожное введение";
                case MethodOfConsumption.inhalation:
                    return "ингаляция";
                case MethodOfConsumption.intranasal:
                    return "интраназальный";
                case MethodOfConsumption.intraocular:
                    return "внутриглазной";
                case MethodOfConsumption.intravenously:
                    return "внутривенно";
                case MethodOfConsumption.rectal:
                    return "ректальный";
                case MethodOfConsumption.sublingual:
                    return "сублингвальный";
                case MethodOfConsumption.throughTheMmouth:
                    return "через рот";
                case MethodOfConsumption.transdermally:
                    return "трансдермально";
                default:
                    return "";
            }
        }
    }
}
