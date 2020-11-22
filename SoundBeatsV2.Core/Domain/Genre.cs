﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SoundBeatsV2.Core.Domain
{
    [Table("Genre")]
    public class Genre
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public Song Song { get; set; }
    }
}
