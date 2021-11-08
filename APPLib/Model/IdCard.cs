using System.ComponentModel.DataAnnotations.Schema;

namespace APPLib.Model
{
    public class IdCard
    {
        [ForeignKey("User")]
        public string UserId { get; set; }
        public string Title { get; set; }
        public User User { get; set; } //Navigation property
    }
}
