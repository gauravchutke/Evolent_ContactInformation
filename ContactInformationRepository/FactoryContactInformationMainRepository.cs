using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactInformationRepository
{
    public static class FactoryContactInformationMainRepository
    {
        public static ContactInformationRepository GetContactInformationMainRepository()
        {
            return new ContactInformationRepository();
        }
    }
}
