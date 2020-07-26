using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactInformationModels;
using ContactInformationRepository;

namespace ContactInformationClientRepository
{
    public class ClientContactInformation : IClientContactInformation, IDisposable
    {
        private IContactInformationRepository clsContactInformationRepository = null;

        public ClientContactInformation()
        {
            this.clsContactInformationRepository = FactoryContactInformationMainRepository.GetContactInformationMainRepository();
        }

        /// <summary>
        /// Get all contacts information.
        /// </summary>
        /// <returns></returns>
        public List<ContactInformation> GetAllContactsInformation()
        {
            try
            {
                return clsContactInformationRepository.GetAllContactsInformation();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Get specific contacts information.
        /// </summary>
        /// <returns></returns>
        public List<ContactInformation> GetContactInformation(string strSearchCriteria)
        {
            try
            {
                return clsContactInformationRepository.GetContactInformation(strSearchCriteria);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Adds new contact information.
        /// </summary>
        /// <param name="clsContactInformation"></param>
        public void AddContactInformation(ContactInformation clsContactInformation)
        {
            try
            {
                clsContactInformationRepository.AddContactInformation(clsContactInformation);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Updates existing contact information.
        /// </summary>
        /// <param name="clsContactInformation"></param>
        public void UpdateContactInformation(ContactInformation clsContactInformation)
        {
            try
            {
                clsContactInformationRepository.UpdateContactInformation(clsContactInformation);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Deletes existing contact information.
        /// </summary>
        /// <param name="clsContactInformation"></param>
        public void DeleteContactInformation(int intContactInformationId)
        {
            try
            {
                clsContactInformationRepository.DeleteContactInformation(intContactInformationId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Dispose()
        {
            
        }
    }
}
