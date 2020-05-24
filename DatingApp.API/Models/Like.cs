namespace DatingApp.API.Models
{
    public class Like
    {   
        //user who is doing the liking
        public int LikerId { get; set; }
        //user who got liked
        public int LikeeId { get; set; }
        public User Liker { get; set; }
        public User Likee { get; set; }

    }
}