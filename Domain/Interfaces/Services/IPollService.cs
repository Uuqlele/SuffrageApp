using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Interfaces.Services
{
    interface IPollService
    {
        Poll GetPoll(int id);

    }
}
