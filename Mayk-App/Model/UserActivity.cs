using SQLite;


namespace Mayk_App.Model
{
    [Table("users_activities")]
    public class UserActivity
    {
        [PrimaryKey, AutoIncrement]
        [Column("user_activity_id")]
        public int UserActivityId { get; set; }

        [Indexed]
        [NotNull]
        [Column("user_id")]
        public int UserId { get; set; }

        [Indexed]
        [NotNull]
        [Column("activity_id")]
        public int ActivityId { get; set; }


        public UserActivity()
        { }

        public UserActivity(int userActivityId, int userId, int activityId)
        {
            UserActivityId = userActivityId;
            UserId = userId;
            ActivityId = activityId;
        }
    }
}
