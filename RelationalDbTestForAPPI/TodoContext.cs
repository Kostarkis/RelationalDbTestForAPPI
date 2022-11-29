using Microsoft.EntityFrameworkCore;

namespace RelationalDbTestForAPPI
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
        {
        }

        public DbSet<TodoItem> TodoItems { get; set; } = null!;
        public DbSet<Name1> Name1Items { get; set; } = null!;
        public DbSet<Name2> Name2Items { get; set; } = null!;
        public DbSet<Name3> Name3Items { get; set; } = null!;
        public DbSet<Name4> Name4Items { get; set; } = null!;
        public DbSet<Name5> Name5Items { get; set; } = null!;
        public DbSet<Name6> Name6Items { get; set; } = null!;
        public DbSet<Name7> Name7Items { get; set; } = null!;
        public DbSet<Name8> Name8Items { get; set; } = null!;
        public DbSet<Name9> Name9Items { get; set; } = null!;
        public DbSet<Name10> Name10Items { get; set; } = null!;
        public DbSet<Name11> Name11Items { get; set; } = null!;
        public DbSet<Name12> Name12Items { get; set; } = null!;
        public DbSet<Name13> Name13Items { get; set; } = null!;
        public DbSet<Name14> Name14Items { get; set; } = null!;
        public DbSet<Name15> Name15Items { get; set; } = null!;
        public DbSet<Name16> Name16Items { get; set; } = null!;

        public DbSet<NameCombined> NamesCombined { get; set; } = null!;
    }
}
