using pharmacies.enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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
        public DateTime BestBeforeDate { get => bestBeforeDate; set => bestBeforeDate = value; }
        public TypesOfPackaging TypeOfPackaging { get => typeOfPackaging; set => typeOfPackaging = value; }
        public MethodOfConsumption MethodOfConsumption { get => methodOfConsumption; set => methodOfConsumption = value; }
        public int FirmId { get => firmId; set => firmId = value; }
        internal Firm Firm { get => firm; set => firm = value; }
        internal Discount Discount { get => discount; set => discount = value; }
        public string Name { get => name; set => name = value; }
        internal List<PharmacyMedicine> PharmacyMedicine { get => pharmacyMedicine; set => pharmacyMedicine = value; }
        public string Contraindications { get => contraindications; set => contraindications = value; }

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

        internal static TypesOfPackaging getTypeOfPackaging(String type)
        {
            switch (type)
            {
                case "Групповая" :
                    return TypesOfPackaging.group;
                case "Первичная":
                    return TypesOfPackaging.Primary;
                case "Вторичная":
                    return TypesOfPackaging.Secondary;
                case "Третичная":
                    return TypesOfPackaging.Tertiary;
                default:
                    return TypesOfPackaging.Secondary;
            }
        }

        internal static MethodOfConsumption getMethodOfConsumption(String method)
        {
            switch (method)
            {
                case "кожное введение":
                    return MethodOfConsumption.dermalAdministration;
                case "ингаляция":
                    return MethodOfConsumption.inhalation;
                case "интраназальный":
                    return MethodOfConsumption.intranasal;
                case "внутриглазной":
                    return MethodOfConsumption.intraocular;
                case "внутривенно":
                    return MethodOfConsumption.intravenously;
                case "ректальный":
                    return MethodOfConsumption.rectal;
                case "сублингвальный":
                    return MethodOfConsumption.sublingual;
                case "через рот":
                    return MethodOfConsumption.throughTheMmouth;
                case "трансдермально":
                    return MethodOfConsumption.transdermally;
                default:
                    return MethodOfConsumption.intravenously;
            }
        }
    }
}
