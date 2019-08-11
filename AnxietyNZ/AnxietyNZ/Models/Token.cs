using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace AnxietyNZ.Models
{
    class Token
    {
        public int Id { get; set; }
        public string access token { get; set; }
        public string error description { get; set; }
        public Dataline expire_date { get; set; }

        public Token() { }
    }
}
