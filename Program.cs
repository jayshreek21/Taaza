using System;
using System.Collections.Generic;
using ContactRepos.ContactList;
using ContactRepos.Models;

namespace ContactRepos
{
    class Program
    {
        static void Main(string[] args)
        {
            Icontact obj=new CList();
            List<contact> temp=obj.CreateContact();
            foreach(var i in temp)
            {
                Console.WriteLine(i.CId+""+i.Cname+""+i.CSalary);
            }
            
        }
    }
}
