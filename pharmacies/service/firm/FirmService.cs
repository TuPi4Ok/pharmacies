using pharmacies.model;
using pharmacies.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacies.service.firm
{
    interface FirmService
    {
        bool saveFirm(Firm firm);

        List<Firm> getAll();
    }
}
