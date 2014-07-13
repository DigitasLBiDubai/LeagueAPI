using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace LeagueService.Domain.Model
{
    [Table("Score")]
    [DataContract]
    public class Score
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DataMember]
        public int Id { get; set; }

        [Required]
        [DataMember]
        public int MatchId { get; set; }

        [Required]
        [DataMember]
        public int PlayerId { get; set; }

        [Required]
        [DataMember]
        public int Points { get; set; }

        [Required]
        [DataMember(IsRequired = true)]
        public DateTime UtcDateTime { get; set; }
    }
}
