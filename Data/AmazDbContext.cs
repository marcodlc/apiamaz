using ApiAmaz.Model;
using Microsoft.EntityFrameworkCore;

namespace ApiAmaz.Data;

public class AmazDbContext : DbContext
{
    public AmazDbContext(DbContextOptions<AmazDbContext> options) : base(options) { } 
    //Set models
    public DbSet<IdentityDocumentType> TypeDocuments {get;set;}
    public DbSet<Role> Roles {get;set;}
    public DbSet<Worker> Workers {get;set;}
    public DbSet<User> Users {get;set;}
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        #region ROLES
        /*Initial data Role*/

        List<Role> rolesInit = new List<Role>();
        
        rolesInit.Add(new Role(){Code = Guid.NewGuid(), Name = "VENDEDOR", Creator = "admin", DateCreated = DateTime.Now, Updater = "admin"});
        rolesInit.Add(new Role(){Code = Guid.NewGuid(), Name = "ESTILISTA", Creator = "admin", DateCreated = DateTime.Now, Updater = "admin"});
        rolesInit.Add(new Role(){Code = Guid.NewGuid(), Name = "MARKETING", Creator = "admin", DateCreated = DateTime.Now, Updater = "admin"});
        rolesInit.Add(new Role(){Code = Guid.NewGuid(), Name = "DESPACHADOR", Creator = "admin", DateCreated = DateTime.Now, Updater = "admin"});
        rolesInit.Add(new Role(){Code = Guid.NewGuid(), Name = "COBRANZA", Creator = "admin", DateCreated = DateTime.Now, Updater = "admin"});
        rolesInit.Add(new Role(){Code = Guid.NewGuid(), Name = "ADMINISTRATIVO", Creator = "admin", DateCreated = DateTime.Now, Updater = "admin"});
        rolesInit.Add(new Role(){Code = Guid.NewGuid(), Name = "GERENTE COMERCIAL", Creator = "admin", DateCreated = DateTime.Now, Updater = "admin"});
        rolesInit.Add(new Role(){Code = Guid.NewGuid(), Name = "GERENTE GENERAL", Creator = "admin", DateCreated = DateTime.Now, Updater = "admin"});
        rolesInit.Add(new Role(){Code = Guid.NewGuid(), Name = "VENDEDOR FREE", Creator = "admin", DateCreated = DateTime.Now, Updater = "admin"});
        rolesInit.Add(new Role(){Code = Guid.NewGuid(), Name = "COORDINADOR", Creator = "admin", DateCreated = DateTime.Now, Updater = "admin"});
        rolesInit.Add(new Role(){Code = Guid.Parse("dcecaf47-895a-4adb-92b5-0a62336619eb"), Name = "SUPERADMIN", Creator = "admin", DateCreated = DateTime.Now, Updater = "admin"});
        
        modelBuilder.Entity<Role>(role => 
        {
            role.ToTable("ROL");
            role.HasKey(c => c.Code);
            role.Property(c => c.Code).HasColumnName("CODIGO");
            role.Property(c => c.Name).HasColumnName("NOMBRE").IsRequired().HasMaxLength(200);
            role.Property(c => c.IsActive).HasColumnName("ESTADO").HasDefaultValue(true);
            role.Property(c => c.Creator).HasColumnName("CREADOR").IsRequired().HasMaxLength(50);
            role.Property(c => c.Updater).HasColumnName("MODIFICADOR").IsRequired().HasMaxLength(50);
            role.Property(c => c.DateCreated).HasColumnName("FECHACREACION");
            role.Property(c => c.DateUpdate).HasColumnName("FECHAMODIFICACION").HasComputedColumnSql("GetUtcDate()");
            role.HasData(rolesInit);
        });
        #endregion
        #region TIPODOCUMENTOIDENTIDAD

        /*Initial data IdentityDocumentType*/

        List<IdentityDocumentType> documentTypesInit = new List<IdentityDocumentType>();

        documentTypesInit.Add(new IdentityDocumentType(){DocumentType = "00", Name = "OTROS", NameShort = "OTROS", Creator = "admin", DateCreated = DateTime.Now, Updater = "admin"});
        documentTypesInit.Add(new IdentityDocumentType(){DocumentType = "01", Name = "LIBRETA ELECTORAL O DNI", NameShort = "L.E / DNI", Creator = "admin", DateCreated = DateTime.Now, Updater = "admin"});
        documentTypesInit.Add(new IdentityDocumentType(){DocumentType = "04", Name = "CARNET DE EXTRANJERIA", NameShort = "CARNET EXT.", Creator = "admin", DateCreated = DateTime.Now, Updater = "admin"});
        documentTypesInit.Add(new IdentityDocumentType(){DocumentType = "06", Name = "REG. UNICO DE CONTRIBUYENTES", NameShort = "RUC", Creator = "admin", DateCreated = DateTime.Now, Updater = "admin"});
        documentTypesInit.Add(new IdentityDocumentType(){DocumentType = "07", Name = "PASAPORTE", NameShort = "PASAPORTE", Creator = "admin", DateCreated = DateTime.Now, Updater = "admin"});
        documentTypesInit.Add(new IdentityDocumentType(){DocumentType = "11", Name = "PART. DE NACIMIENTO-IDENTIDAD", NameShort = "P. NAC.", Creator = "admin", DateCreated = DateTime.Now, Updater = "admin"});

        modelBuilder.Entity<IdentityDocumentType>(documentType => {
            documentType.ToTable("TIPODOCUMENTOIDENTIDAD");
            documentType.HasKey(c => c.DocumentType);
            documentType.Property(c => c.DocumentType).HasColumnName("TIPODOCUMENTO").HasMaxLength(2);
            documentType.Property(c => c.Name).HasColumnName("NOMBRE").HasMaxLength(100);
            documentType.Property(c => c.NameShort).HasColumnName("NOMBRECORTO").HasMaxLength(50);
            documentType.Property(c => c.isActive).HasColumnName("ESTADO").HasDefaultValue(true);
            documentType.Property(c => c.Creator).HasColumnName("CREADOR").IsRequired().HasMaxLength(50);
            documentType.Property(c => c.Updater).HasColumnName("MODIFICADOR").IsRequired().HasMaxLength(50);
            documentType.Property(c => c.DateCreated).HasColumnName("FECHACREACION");
            documentType.Property(c => c.DateUpdate).HasColumnName("FECHAMODIFICACION").HasComputedColumnSql("GetUtcDate()");
            documentType.HasData(documentTypesInit);
        });

        #endregion
        #region TRABAJADOR
        List<Worker> workersInit = new List<Worker>();
        workersInit.Add(new Worker(){Code = Guid.Parse("dcecaf47-895a-4adb-92b5-0a62336619fc"), Email = "marcodlc10@gmail.com", Name = "admin zeus", RoleCode = Guid.Parse("dcecaf47-895a-4adb-92b5-0a62336619eb"),Creator = "admin",DateCreated = DateTime.Now,Updater = "admin" });

        modelBuilder.Entity<Worker>(worker => {
            worker.ToTable("TRABAJADOR");
            worker.HasKey(c => c.Code);
            worker.Property(c => c.Code).HasColumnName("CODIGO");
            worker.HasOne(c => c.Role).WithMany(c => c.Workers).HasForeignKey(c => c.RoleCode);
            worker.Property(c => c.RoleCode).HasColumnName("ROL");
            worker.Property(c => c.Email).HasColumnName("EMAIL").HasMaxLength(50);
            worker.Property(c => c.Name).HasColumnName("NOMBRE").HasMaxLength(200);
            worker.Property(c => c.isActive).HasColumnName("ESTADO").HasDefaultValue(true);
            worker.Property(c => c.Creator).HasColumnName("CREADOR").IsRequired().HasMaxLength(50);
            worker.Property(c => c.Updater).HasColumnName("MODIFICADOR").IsRequired().HasMaxLength(50);
            worker.Property(c => c.DateCreated).HasColumnName("FECHACREACION");
            worker.Property(c => c.DateUpdate).HasColumnName("FECHAMODIFICACION").HasComputedColumnSql("GetUtcDate()");
            worker.HasData(workersInit);
        });
        #endregion
        #region USUARIO
        List<User> UsersInit = new List<User>();
        UsersInit.Add(new User(){Username="admin",SoftwareName="WebAmaz",Password="default",Creator="admin",DateCreated = DateTime.Now,Updater="admin",WorkerCode = Guid.Parse("dcecaf47-895a-4adb-92b5-0a62336619fc")});
        modelBuilder.Entity<User>(user =>
            {
                user.HasKey(c => new {c.Username, c.Password});
                user.ToTable("USUARIO");
                user.Property(c => c.Username).HasColumnName("USUARIO").HasMaxLength(50);
                user.Property(c => c.Password).HasColumnName("CLAVE").HasMaxLength(50).IsUnicode(false);
                user.Property(c => c.SoftwareName).HasColumnName("APLICACION").HasMaxLength(50).IsUnicode(false);
                user.Property(c => c.WorkerCode).HasColumnName("TRABAJADOR");
                user.HasOne(c => c.Worker).WithMany(c => c.Users).HasForeignKey(c => c.WorkerCode);
                user.Property(c => c.IsActive).HasColumnName("ESTADO").HasDefaultValue(true);
                user.Property(c => c.Creator).HasColumnName("CREADOR").IsRequired().HasMaxLength(50);
                user.Property(c => c.Updater).HasColumnName("MODIFICADOR").IsRequired().HasMaxLength(50);
                user.Property(c => c.DateCreated).HasColumnName("FECHACREACION");
                user.Property(c => c.DateUpdate).HasColumnName("FECHAMODIFICACION").HasComputedColumnSql("GetUtcDate()");
                user.HasData(UsersInit);
            });
        #endregion
    }
}