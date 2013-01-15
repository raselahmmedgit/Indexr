/****************** Copyright Notice *****************
 
This code is licensed under Microsoft Public License (Ms-PL). 
You are free to use, modify and distribute any portion of this code. 
The only requirement to do that, you need to keep the developer name, as provided below to recognize and encourage original work:

=======================================================
   
Designed and Implemented By:
Rasel Ahmmed
Software Engineer, I Like .NET
Twitter: http://twitter.com/raselbappi | Blog: http://springsolution.net | About Me: http://springsolution.net/about-me/
   
*******************************************************/

using Indexr.Domain;

namespace Indexr.DomainView
{
    public class EmContactInfo
    {
        public static ContactInfo SetToModel(ContactInfoViewModel contactInfoViewModel)
        {
            var model = new ContactInfo
                            {
                                ContactInfoId = contactInfoViewModel.ContactInfoId,
                                FirstName = contactInfoViewModel.FirstName,
                                LastName = contactInfoViewModel.LastName,
                                Sex = contactInfoViewModel.Sex,
                                DateOfBirth = contactInfoViewModel.DateOfBirth,
                                Email = contactInfoViewModel.Email,
                                PresentAddress = contactInfoViewModel.PresentAddress,
                                PermanentAddress = contactInfoViewModel.PermanentAddress,
                                PhoneNumber = contactInfoViewModel.PhoneNumber,
                                MobileNumber = contactInfoViewModel.MobileNumber,
                                AlternativeMobileNumber = contactInfoViewModel.AlternativeMobileNumber,
                                FacebookProfile = contactInfoViewModel.FacebookProfile,
                                LinkedInProfile = contactInfoViewModel.LinkedInProfile,
                                GooglePlusProfile = contactInfoViewModel.GooglePlusProfile,
                                NationalIdNumber = contactInfoViewModel.NationalIdNumber,
                                PassportNumber = contactInfoViewModel.PassportNumber,
                                ThumbImageUrl = contactInfoViewModel.ThumbImageUrl,
                                SmallImageUrl = contactInfoViewModel.SmallImageUrl
                            };

            return model;
        }

        public static ContactInfoViewModel SetToViewModel(ContactInfo contactInfo)
        {
            var viewModel = new ContactInfoViewModel
                                {
                                    ContactInfoId = contactInfo.ContactInfoId,
                                    FirstName = contactInfo.FirstName,
                                    LastName = contactInfo.LastName,
                                    Sex = contactInfo.Sex,
                                    DateOfBirth = contactInfo.DateOfBirth,
                                    Email = contactInfo.Email,
                                    PresentAddress = contactInfo.PresentAddress,
                                    PermanentAddress = contactInfo.PermanentAddress,
                                    PhoneNumber = contactInfo.PhoneNumber,
                                    MobileNumber = contactInfo.MobileNumber,
                                    AlternativeMobileNumber = contactInfo.AlternativeMobileNumber,
                                    FacebookProfile = contactInfo.FacebookProfile,
                                    LinkedInProfile = contactInfo.LinkedInProfile,
                                    GooglePlusProfile = contactInfo.GooglePlusProfile,
                                    NationalIdNumber = contactInfo.NationalIdNumber,
                                    PassportNumber = contactInfo.PassportNumber,
                                    ThumbImageUrl = contactInfo.ThumbImageUrl,
                                    SmallImageUrl = contactInfo.SmallImageUrl
                                };

            return viewModel;
        }
    }
}
