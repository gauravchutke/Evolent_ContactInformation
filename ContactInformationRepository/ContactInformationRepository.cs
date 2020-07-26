using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactInformationModels;

namespace ContactInformationRepository
{
    public class ContactInformationRepository : IContactInformationRepository
    {
        private ContactInformationDBContext clsDatabaseAccess = null;

        /// <summary>
        /// Get all contacts information.
        /// </summary>
        /// <returns></returns>
        public List<ContactInformation> GetAllContactsInformation()
        {
            List<ContactInformation> lstContactInformation = null;
            try
            {
                using (clsDatabaseAccess = new ContactInformationDBContext())
                {
                    lstContactInformation = clsDatabaseAccess.ContactsInformation.ToList();

                    if (lstContactInformation != null)
                    {
                        if (lstContactInformation.Count > 0)
                        {
                            return lstContactInformation;
                        }
                        else
                        {
                            throw new Exception("Contact Information Not Found.");
                        }
                    }
                    else
                    {
                        throw new Exception("Contact Information Not Found.");
                    }
                }
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
            List<ContactInformation> lstContactInformation = null;
            try
            {
                using (clsDatabaseAccess = new ContactInformationDBContext())
                {
                    lstContactInformation =  clsDatabaseAccess.ContactsInformation.
                                             Where(x => x.intContactInformationId.ToString() == strSearchCriteria || 
                                                        x.strPhoneNumber.ToLower().Contains(strSearchCriteria.ToLower()) ||
                                                        x.strEmailAddress.ToLower().Contains(strSearchCriteria.ToLower()) ||
                                                        x.strFirstName.ToLower().Contains(strSearchCriteria.ToLower()) ||
                                                        x.strLastName.ToLower().Contains(strSearchCriteria.ToLower()) ||
                                                        x.strStatus.ToLower().Contains(strSearchCriteria.ToLower())).
                                             ToList();

                    if (lstContactInformation != null)
                    {
                        if (lstContactInformation.Count > 0)
                        {
                            return lstContactInformation;
                        }
                        else
                        {
                            throw new Exception("Contact Information Not Found.");
                        }
                    }
                    else
                    {
                        throw new Exception("Contact Information Not Found.");
                    }
                }
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
                using (clsDatabaseAccess = new ContactInformationDBContext())
                {
                    clsDatabaseAccess.ContactsInformation.Add(clsContactInformation);
                    clsDatabaseAccess.SaveChanges();
                }
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
            ContactInformation clsExistingContactInformation = null;
            try
            {
                using (clsDatabaseAccess = new ContactInformationDBContext())
                {
                    clsExistingContactInformation = clsDatabaseAccess.ContactsInformation.SingleOrDefault(x => x.intContactInformationId == clsContactInformation.intContactInformationId);

                    if (clsExistingContactInformation != null)
                    {
                        clsExistingContactInformation.strPhoneNumber = clsContactInformation.strPhoneNumber;
                        clsExistingContactInformation.strEmailAddress = clsContactInformation.strEmailAddress;
                        clsExistingContactInformation.strFirstName = clsContactInformation.strFirstName;
                        clsExistingContactInformation.strLastName = clsContactInformation.strLastName;
                        clsExistingContactInformation.strStatus= clsContactInformation.strStatus;

                        clsDatabaseAccess.SaveChanges();
                    }
                    else
                    {
                        throw new Exception("Contact Not Found. Can't update contact information.");
                    }                    
                }
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
            ContactInformation clsExistingContactInformation = null;
            try
            {
                using (clsDatabaseAccess = new ContactInformationDBContext())
                {
                    clsExistingContactInformation = clsDatabaseAccess.ContactsInformation.SingleOrDefault(x => x.intContactInformationId == intContactInformationId);

                    if (clsExistingContactInformation != null)
                    {
                        clsDatabaseAccess.ContactsInformation.Remove(clsExistingContactInformation);
                        clsDatabaseAccess.SaveChanges();
                    }
                    else
                    {
                        throw new Exception("Contact Not Found. Can't delete contact information.");
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
