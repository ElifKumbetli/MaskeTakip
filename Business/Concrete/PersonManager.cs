using Business.Absract;
using Business.Concrete;
using Entities.Concrete;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PersonManager : IApplicantService
    {
        //çıplak class kalmasın
        //encapsulation
        public void ApplyForMask(Entities.Concrete.Person person)
        {

        }


        public List<Person> GetList()
        {
            return null;
        }

        public bool CheckPerson(Person person)
        {
            //mernis kontrolü yapılacak
            KPSPublicSoapClient client = new MernisServiceReference.KPSPublicSoapClient(MernisServiceReference.KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

                return  ClientCertificateOption.TcKimlikDogrulaAsync(new TCKimlikNoDogrulaRequestBody(123,"ENGİN","DEMİROĞ",1985);
           

        }

    }
}


