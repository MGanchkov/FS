﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.Models;

public interface IEntry
{

    /// <summary>
    /// Уникальный идентификатор
    /// </summary>
    public long ID { get; set; }

}
