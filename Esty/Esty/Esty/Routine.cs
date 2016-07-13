﻿using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Esty
{
    class Routine : IObject
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        
        public string Name { get; set; }
        // The period of the transaction: every day, every week, every bi-week, every month, every month, every year
        public int Period { get; set; }

        public DateTime DateStart { get; set; }

        public DateTime DateEnd { get; set; }
        // spending/earning/unknown
        public byte Type { get; set; }


    }
}