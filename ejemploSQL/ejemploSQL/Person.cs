using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ejemploSQL
{
    public class Person
    {
        [PrimaryKey]
        public int PersonID { get; set; }
        public string Name { get; set; }
    }
}
