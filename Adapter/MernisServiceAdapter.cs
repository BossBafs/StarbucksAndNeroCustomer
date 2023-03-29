using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using MernisServiceReference;

namespace InterfaceAbstractDemo.Adapter
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public async Task<bool> CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            {
                var deger = await client.TCKimlikNoDogrulaAsync(Convert.ToInt64(customer.NationalityId),
                    customer.FirstName.ToUpper(), customer.LastName.ToUpper(), customer.DateOfBirth.Year);
                Console.WriteLine(deger.Body.TCKimlikNoDogrulaResult);
                return deger.Body.TCKimlikNoDogrulaResult;
            }

        }
    }
}
