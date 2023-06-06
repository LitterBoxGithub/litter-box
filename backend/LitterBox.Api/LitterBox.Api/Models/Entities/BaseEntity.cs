using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace LitterBox.Api.Models.Entities
{
    public class BaseEntity
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [JsonIgnore]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreatedTime { get; set; }

        [JsonIgnore]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime UpdatedTime { get; set; }
    }
}
