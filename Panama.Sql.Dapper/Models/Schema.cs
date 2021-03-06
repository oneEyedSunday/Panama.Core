﻿using Panama.Core.Entities;
using System;

namespace Panama.Core.Sql.Dapper.Models
{
    public class Schema : IModel
    {
        public string Name { get; set; }
        public string ColumnName { get; set; }
        public Type Type { get; set; }
    }
}
