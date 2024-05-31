using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;
using Microsoft.AspNetCore.Authorization;
using System.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FinalProject12.Models
{
    public class ScheduleViewModel
    {
        public int ScheduleID { get; set; }
        public string ScheduleDate { get; set; }
        public int DayID { get; set; }
        public string DayDate { get; set; }
    }
}

