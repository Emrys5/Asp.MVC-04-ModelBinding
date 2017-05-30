using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Emrys.ModelBinding.Models
{
public class UserInfo
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string[] Bobbys { get; set; }
    public Company Company { get; set; }
    public Star[] Star { get; set; }
}
public class Company
{
    public string Name { get; set; }
    public string Address { get; set; }
    public string[] Tel { get; set; }
}

public class Star
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Movie { get; set; }
}
}