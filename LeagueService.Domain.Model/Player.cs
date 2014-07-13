using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace LeagueService.Domain.Model
{
    [Table("Player")]
    [DataContract]
    public class Player
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string ExternalId { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public virtual List<Score> Scores { get; set; }

        [Required]
        [DataMember(IsRequired = true)]
        public DateTime UtcDateCreated { get; set; }
    }
}
