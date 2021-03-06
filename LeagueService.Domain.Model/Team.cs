﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace LeagueService.Domain.Model
{
    [Table("Team")]
    [DataContract]
    public class Team
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public virtual List<Player> Players { get; set; }

        [Required]
        [DataMember(IsRequired = true)]
        public DateTime UtcDateCreated { get; set; }
    }
}
