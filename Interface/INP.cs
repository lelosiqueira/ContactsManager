using ContactsManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactsManager.Interface
{
  public interface INP
  {
    IEnumerable<NaturalPerson> GetAllNP();
    void Insert(NaturalPerson np);
    void Update(NaturalPerson np);
    NaturalPerson GetNP(string cpf);
    void Delete(string cpf);
  }
}
