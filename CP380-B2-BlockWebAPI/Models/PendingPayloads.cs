﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CP380_B1_BlockList;
using CP380_B1_BlockList.Models;

namespace CP380_B2_BlockWebAPI.Models
{
    public class PendingPayloads
    {
        // TODO
        public List<Payload> payloads { get; set; }

        public PendingPayloads()
        {
            payloads = new() { };
        }
    }
}
