using System.Data.Entity;
namespace MVCproduct.Models
{
    public class Datacontext:DbContext
    {
        public Datacontext():base("DefaultConnection")
        {

        }
    }
}