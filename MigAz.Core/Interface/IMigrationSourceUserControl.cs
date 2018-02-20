﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigAz.Core.Interface
{
    public interface IMigrationSourceUserControl
    {
        bool IsSourceContextAuthenticated { get; set; }
        Task UncheckMigrationTarget(MigrationTarget migrationTarget);
    }
}