﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Template.Application
{
    /// <summary>
    /// This entityDto includes Id with type int.
    /// </summary>
    public class EntityDto : EntityDto<int>
    {

    }

    /// <summary>
    /// This entityDto includes Id with type T.
    /// </summary>
    /// <typeparam name="T">T is value type.</typeparam>
    public class EntityDto<TPrimaryKey> : IEntityDto<TPrimaryKey>
        where TPrimaryKey : struct
    {
        public TPrimaryKey Id { get; set; }
    }
}
