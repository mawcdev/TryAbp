using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryAbp.App.Client
{
    public class CreateClientDto
    {
        [Required]
        [MaxLength(32, ErrorMessage = "Max length is 32 characters.")]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(32, ErrorMessage = "Max length is 32 characters.")]
        public string LastName { get; set; }
        [Required]
        [MaxLength(512, ErrorMessage = "Max length is 512 characters.")]
        public string Address { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
