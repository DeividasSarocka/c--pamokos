﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Topic_11_Aircrafts_project
{
    public class Aircraft
    {
        public int Id { get; set; }
        public int ModelId { get; set; }
        public int CompanyId { get; set; }
        public string TailNumber { get; set; }

        public Aircraft (int id, int modelId, int companyId, string tailNumber)
        {
            Id = id;
            ModelId = modelId;
            CompanyId = companyId;
            TailNumber = tailNumber;
        }
    }
}
