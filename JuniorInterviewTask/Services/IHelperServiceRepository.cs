using System;
using System.Collections.Generic;
using JuniorInterviewTask.Models;

namespace JuniorInterviewTask.Services
{
    interface IHelperServiceRepository
    {
        IEnumerable<HelperService> Get();
        HelperService Get(Guid id);
    }
}
