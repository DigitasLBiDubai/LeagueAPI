using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace LeagueService.Domain.Model
{
    [Table("Match")]
    [DataContract]
    public class Match
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DataMember]
        public int Id { get; set; }

        [Required]
        [DataMember(IsRequired = true)]
        public DateTime StartDateTime { get; set; }

        [DataMember]
        public DateTime EndDateTime { get; set; }
    }
}
