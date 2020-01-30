using System.ComponentModel.DataAnnotations.Schema;
using carbon.core.Features;

namespace carbon.core.domain.model.registration.medical
{
    public class Medication : Entity<int>
    {
        [Column("Id")]
        public int ApplicationId { get; private set; }
        
    }
}