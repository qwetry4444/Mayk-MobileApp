using SQLite;


namespace Mayk_App.Model
{
    [Table("activities")]
    public class Activity
    {
        [PrimaryKey, AutoIncrement]
        [Column("activitiy_id")]
        public int ActivityId { get; set; }

        [NotNull]
        [Column("name")]
        public string Name { get; set; }


        public Activity()
        { }

        public Activity(int eventId, string name)
        {
            ActivityId = eventId;
            Name = name;
        }
    }
}

