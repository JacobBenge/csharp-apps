using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace JBAssignment5
{
    public class JBModelEntity : DbContext
    {
        // Your context has been configured to use a 'JBModelEntity' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'JBAssignment5.JBModelEntity' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'JBModelEntity' 
        // connection string in the application configuration file.
        public JBModelEntity()
            : base("name=JBModelEntity")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<JellyBelly> JellyBellies { get; set; }
    }

    // NEED using System.ComponentModel.DataAnnotations;
    // AND  using System.ComponentModel.DataAnnotations.Schema;
    /// <summary>
    /// Class for Jelly Belly Table get and sets. This helps build our database
    /// </summary>
    [Table("JellyBellyTable")]
    public class JellyBelly
    {
        [Key]
        public int JellyBellyId { get; set; }

        [StringLength(30)]
        public string jellyBellyFlavor { get; set; }

        [StringLength(30)]
        public string category { get; set; }
    }
}