using System.Collections.Generic;
using ContactRepos.Models;

namespace ContactRepos.ContactList
{
    public interface Icontact
    {
       List<contact> CreateContact();  
    }
}