using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    //Çıplak Class Kalmasın
    public class PersonManager : IApplicantService
    {
        public List<Person> GetList()
        {
            return null;
        }
        public void ApplyForMask(Person person)
        {

        }
        public bool checkPerson(Person person)
        {
            return true;
        }
    }
}
