using System.Collections.Generic;

namespace JwtAppNew.Models
{
    public class ProfileConstants
    {
        public static List<ProfileModel> Profile = new List<ProfileModel>()
        {
            new ProfileModel() { Username = "asep", Password = "123", First_Name = "Asep", Last_Name="Maulana",Telephone="08123123123", Profile_Image="image.jpg", Address="Jl. Merdeka Jaya", City="Palembang", Province="South Sumatera", Country="Indonesia" },
        };
    }
}
