﻿using EnumState;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_System.Models
{
    public class SalaryPayment
    {

        public int Id { get; set; }

        public string FileNumber { get; set; }

        public int TotalPerson { get; set; }

        public decimal TotalAmout { get; set; }

        public DateTime RegistTime { get; set; }

        public SalaryPaymentStateEnum FileState { get; set; }

        public ThirdOrg ThirdOrg { get; set; }

        public decimal TotalReal { get; set; }

        public string Registrant { get; set; }

        public string CheckBy { get; set; }

        public DateTime CheckTime { get; set; }

    }
}