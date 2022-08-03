using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    [Table("messages")]
    public class Message : Notifies
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("title")]
        [MaxLength(255)]
        public string Title { get; set; }

        [Column("active")]
        public bool Active { get; set; }

        [Column("user_id"), ForeignKey(nameof(ApplicationUser))]
        public string UserId { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }

        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
