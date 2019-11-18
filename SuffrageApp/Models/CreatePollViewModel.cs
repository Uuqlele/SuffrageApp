using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuffrageApp.Models
{
    public class CreatePollViewModel
    {
        public bool IsEdit { get; set; }

        public PollDto PollDto { get; set; }
    }
}
