using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mayk_App.Model
{
    [Table("documents")]
    public class Document
    {
        [PrimaryKey, AutoIncrement]
        [Column("document_id")]
        public int DocumentId { get; set; }

        [NotNull]
        [Column("name")]
        public string Name { get; set; }

        [NotNull]
        [Column("path")]
        public string Path { get; set; }
    }
}
