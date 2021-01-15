using ContactsManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactsManager.Interface
{
  public interface ILP
  {
    IEnumerable<LegalPerson> GetAllLP();
    void Insert(LegalPerson lp);
    void Update(LegalPerson lp);
    LegalPerson GetLP(string cpf);
    void Delete(string cpf);
  }
}