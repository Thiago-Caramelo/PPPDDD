﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTakeawayStore.ReturnEvents.Infrastructure
{
    public interface IEventDispatcher
    {
        void Dispatch<T> (T evnt);
    }
}
