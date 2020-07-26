using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ContactInformationModels;
using ContactInformationClientRepository;

namespace ContactInformationAPI.Controllers
{
    public class ContactInformationAPIController : ApiController
    {
        // GET api/values
        /// <summary>
        /// Get all contacts information.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public HttpResponseMessage GetAllContactsInformation(string strSearchCriteria = "")
        {
            List<ContactInformation> lstContactInformation = null;
            IClientContactInformation clsClientContactInformation = null;
            try
            {
                using (clsClientContactInformation = FactoryClientContactInformation.GetClientContactInformationRepository())
                {
                    if (string.IsNullOrEmpty(strSearchCriteria))
                    {
                        lstContactInformation = clsClientContactInformation.GetAllContactsInformation();
                    }
                    else
                    {
                        lstContactInformation = clsClientContactInformation.GetContactInformation(strSearchCriteria);
                    }
                }

                return Request.CreateResponse(HttpStatusCode.OK, lstContactInformation);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.ExpectationFailed, ex.Message);
            }
        }

        /// <summary>
        /// Adds new contact information.
        /// </summary>
        /// <param name="clsContactInformation"></param>
        [HttpPost]
        public HttpResponseMessage AddContactInformation(ContactInformation clsContactInformation)
        {
            IClientContactInformation clsClientContactInformation = null;
            try
            {
                if (ModelState.IsValid)
                {
                    using (clsClientContactInformation = FactoryClientContactInformation.GetClientContactInformationRepository())
                    {
                        clsClientContactInformation.AddContactInformation(clsContactInformation);
                    }

                    return Request.CreateResponse(HttpStatusCode.OK, "Contact Information Added Successfully.");
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.ExpectationFailed, ModelState.Values);
                }
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.ExpectationFailed, ex.Message);
            }
        }

        /// <summary>
        /// Updates existing contact information.
        /// </summary>
        /// <param name="clsContactInformation"></param>
        [HttpPut]
        public HttpResponseMessage UpdateContactInformation(ContactInformation clsContactInformation)
        {
            IClientContactInformation clsClientContactInformation = null;
            try
            {
                if (ModelState.IsValid)
                {
                    using (clsClientContactInformation = FactoryClientContactInformation.GetClientContactInformationRepository())
                    {
                        clsClientContactInformation.UpdateContactInformation(clsContactInformation);
                    }

                    return Request.CreateResponse(HttpStatusCode.OK, "Contact Information Updated Successfully.");
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.ExpectationFailed, ModelState.Values);
                }                
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.ExpectationFailed, ex.Message);
            }
        }

        /// <summary>
        /// Deletes existing contact information.
        /// </summary>
        /// <param name="clsContactInformation"></param>
        [HttpDelete]
        public HttpResponseMessage DeleteContactInformation(int intContactInformationId)
        {
            IClientContactInformation clsClientContactInformation = null;
            try
            {
                using (clsClientContactInformation = FactoryClientContactInformation.GetClientContactInformationRepository())
                {
                    clsClientContactInformation.DeleteContactInformation(intContactInformationId);
                }

                return Request.CreateResponse(HttpStatusCode.OK, "Contact Information Deleted Successfully.");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.ExpectationFailed, ex.Message);
            }
        }
    }
}
