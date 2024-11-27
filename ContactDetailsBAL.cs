using ContactDataAccessLayer;
using ContactServiceLayer;
using ContactServiceLayer.Models;

namespace ContactBusinessLayer
{
    public class ContactDetailsBAL : IContactDetailsService
    {
        ContactDetailsDAL _DAL;
        public ContactDetailsBAL(ContactDetailsDAL DAL) { _DAL = DAL; }
        public List<ContactDetails> GetAllContactsList()
        {
            return _DAL.GetAllContactsList();
        }

        public BaseResponseModel AddContact(ContactDetails contactDetails)
        {
            return _DAL.AddContact(contactDetails);
        }

        public BaseResponseModel UpdateContact(ContactDetails contactDetails)
        {
            BaseResponseModel result = new BaseResponseModel();
            result = _DAL.UpdateContact(contactDetails);
            return result;
        }

        public BaseResponseModel DeleteContact(int contactDetailId)
        {
            BaseResponseModel result = new BaseResponseModel();
            result = _DAL.DeleteContact(contactDetailId);
            return result;
        }
    }
}
