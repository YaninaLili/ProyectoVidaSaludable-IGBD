using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ProyectoVidaSaludable_IGBD.Models
{
    public class VidaSaludableContext : IdentityDbContext
    {
   
        public VidaSaludableContext(DbContextOptions<VidaSaludableContext> o) : base(o)
        {

        }
    }
}