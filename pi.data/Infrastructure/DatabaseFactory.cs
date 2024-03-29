﻿
using pi.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crm_pi.pi.data.Infrastructure
{
    public class DatabaseFactory : Disposable, IDatabaseFactory
    {
        private Context dataContext;
        public Context DataContext { get { return dataContext; } }

        public DatabaseFactory()
        {
            dataContext = new Context();
        }
        protected override void DisposeCore()
        {
            if (DataContext != null)
                DataContext.Dispose();
        }
    }

}
