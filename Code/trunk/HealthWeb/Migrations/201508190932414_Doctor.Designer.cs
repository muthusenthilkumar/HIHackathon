// <auto-generated />
namespace HealthWeb.Migrations
{
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Migrations.Infrastructure;
    using System.Resources;
    
    public sealed partial class Doctor : IMigrationMetadata
    {
        private readonly ResourceManager Resources = new ResourceManager(typeof(Doctor));
        
        string IMigrationMetadata.Id
        {
            get { return "201508190932414_Doctor"; }
        }
        
        string IMigrationMetadata.Source
        {
            get { return null; }
        }
        
        string IMigrationMetadata.Target
        {
            get { return Resources.GetString("Target"); }
        }
    }
}
