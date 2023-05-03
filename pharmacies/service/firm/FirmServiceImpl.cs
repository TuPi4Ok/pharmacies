using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pharmacies.model;
using pharmacies.repository;

namespace pharmacies.service.firm
{
    class FirmServiceImpl : FirmService
    {
        FirmRepository firmRepository = new FirmRepository();

        public bool saveFirm(Firm firm)
        {
            if (firmRepository.findFirmByName(firm.Name) != null)
            {

            }
            firmRepository.save(firm);
            return true;
        }

        public List<Firm> getAll()
        {
            return firmRepository.findAllFirms();
        }
    }
}
