using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGraphQLApi.Query
{
    public static class GraphVariables
    {
        public static object GetDataVariable(int id)
        {
            var data = new
            {
                id = id
            };

            return data;
        }

        public static object AddDataVariable(string userName, 
                                            string userEmail, 
                                            string phoneNumber, 
                                            string dateOfBirth, 
                                            string houseNumber, 
                                            string addressLine1, 
                                            string addressLine2, 
                                            string city, 
                                            string country, 
                                            string postalCode)
        {
            var data = new
            {
                data = new
                {
                    userName = userName,
                    userEmail = userEmail,
                    userPhoneNumber = phoneNumber,
                    userDateOfBirth = dateOfBirth,
                    address = new
                    {
                        houseNumber = houseNumber,
                        addressLine1 = addressLine1,
                        addressLine2 = addressLine2,
                        city = city,
                        country = country,
                        postalCode = postalCode
                    }
                }
            };
            return data;
        }

        public static object UpdateNameDataVariable(int id, string name)
        {
            var data = new
            {
                id = id,
                name = name
            };

            return data;
        }

        public static object DeleteDataVariable(int id)
        {
            var data = new
            {
                id = id
            };

            return data;
        }
    }
}
