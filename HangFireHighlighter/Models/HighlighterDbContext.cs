using System.Data.Entity;

namespace HangFireHighlighter.Models
{
    public class HighlighterDbContext : DbContext
    {
        public HighlighterDbContext() : base("HighlighterDb")
        { }
        public DbSet<CodeSnippet> CodeSnippets { get; set; }
    }
}