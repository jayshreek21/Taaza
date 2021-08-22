using System;
using System.Collections.Generic;
using ContactRepos.Models;

namespace ContactRepos.ContactList
{
    public class CList:Icontact
    {
        List<contact> list;
        public CList()
        {
           list= new List<contact>();
        }
        public List<contact> CreateContact()
        {
            list.Add(new contact{
                CId=101,
                Cname="jayshree",
                CSalary=1000
            });
            list.Add(new contact{
                CId=102,
                Cname="Divya",
                CSalary=2000
            });
            list.Add(new contact{
                CId=103,
                Cname="singh",
                CSalary=3000
            });
            return list;

        }
    }
}