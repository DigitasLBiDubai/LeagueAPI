using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace LeagueService.Domain.Model
{
    [Table("Match")]
    [DataContract]
    public class Match // Body: { "UtcStartDateTime":"10/10/2014 20:00:00", "UtcEndDateTime":"10/10/2014 20:00:00" }
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public virtual List<Team> Teams { get; set; }

        [Required]
        [DataMember(IsRequired = true)]
        public DateTime UtcStartDateTime { get; set; }

        [DataMember]
        public DateTime UtcEndDateTime { get; set; }
    }
}
