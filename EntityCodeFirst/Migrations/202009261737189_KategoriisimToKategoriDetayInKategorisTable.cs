namespace EntityCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class KategoriisimToKategoriDetayInKategorisTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Kategoris", "KategoriDetay", c => c.String());
            Sql("Update Kategoris Set KategoriDetay=Kategoriisim");
            DropColumn("dbo.Kategoris", "Kategoriisim");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Kategoris", "Kategoriisim", c => c.String());
            Sql("Update Kategoris Set Kategoriisim=KategoriDetay");
            DropColumn("dbo.Kategoris", "KategoriDetay");
        }
    }
}
