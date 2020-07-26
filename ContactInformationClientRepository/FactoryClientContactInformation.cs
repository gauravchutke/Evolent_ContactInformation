using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactInformationClientRepository
{
    public static class FactoryClientContactInformation
    {
        public static ClientContactInformation GetClientContactInformationRepository()
        {
            return new ClientContactInformation();
        }
    }
}
