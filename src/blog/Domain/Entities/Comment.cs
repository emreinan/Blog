using NArchitecture.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;
public class Comment : Entity<Guid>
{
    public string Content { get; set; }
    public Guid PostId { get; set; }
    public Guid UserId { get; set; }

    public virtual Post Post { get; set; }
    public virtual User User { get; set; }
}
