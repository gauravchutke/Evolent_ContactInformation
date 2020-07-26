using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactInformationModels;

namespace ContactInformationRepository
{
    public interface IContactInformationRepository
    {
        /// <summary>
        /// Get all contacts information.
        /// </summary>
        /// <returns></returns>
        List<ContactInformation> GetAllContactsInformation();

        /// <summary>
        /// Get specific contacts information.
        /// </summary>
        /// <returns></returns>
        List<ContactInformation> GetContactInformation(string strSearchCriteria);

        /// <summary>
        /// Adds new contact information.
        /// </summary>
        /// <param name="clsContactInformation"></param>
        void AddContactInformation(ContactInformation clsContactInformation);

        /// <summary>
        /// Updates existing contact information.
        /// </summary>
        /// <param name="clsContactInformation"></param>
        void UpdateContactInformation(ContactInformation clsContactInformation);

        /// <summary>
        /// Deletes existing contact information.
        /// </summary>
        /// <param name="clsContactInformation"></param>
        void DeleteContactInformation(int intContactInformationId);
    }
}
