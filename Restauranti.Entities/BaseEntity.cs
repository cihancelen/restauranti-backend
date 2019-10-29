﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Restauranti.Entities
{
    public class BaseEntity
    {
        [Key]
        public long Id { get; set; }

        public Guid Guid { get; set; } = Guid.NewGuid();

        public bool IsActive { get; set; } = true;

        public DateTime InsertDate { get; set; } = DateTime.Now;
    }
}
