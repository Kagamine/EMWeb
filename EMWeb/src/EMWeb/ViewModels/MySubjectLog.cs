﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMWeb.ViewModels
{
    public class MySubjectLog
    {
        public int Id { get; set; }
        public DateTime Time { get; set; }
        public int SNumber { get; set; }//题目Id
        public string STitle { get; set; }
        public string Teacher { get; set; }
        public DateTime DrawTime { get; set; }
        public string Draw { get; set; }
    }
}
