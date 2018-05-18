﻿using System;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Exam.Data.Conventions
{
    class DateTime2Convention : Convention
    {

        public DateTime2Convention()
        {
            this.Properties<DateTime>().Configure(c => c.HasColumnType("datetime2"));
        }
    }
}
