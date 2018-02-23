using System;
using System.ComponentModel.DataAnnotations;

namespace ClientGate.Repository.Entities
{
    public class AuthorizationCodesEntity
    {
        [Key]
        public Guid AuthorizationCode { get; set; }
        public Guid ClientId { get; set; }
        public Guid UserId { get; set; }
        public string RedirectUri { get; set; }
        public DateTime Expires { get; set; }
        public Guid IdToken { get; set; }
    }
}
