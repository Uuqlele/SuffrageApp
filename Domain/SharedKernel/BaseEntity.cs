using Core.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.SharedKernel
{
    public class BaseEntity
    {
        public int Id { get; set;  }

        public List<BaseEvent> Events = new List<BaseEvent>();
    }
}
