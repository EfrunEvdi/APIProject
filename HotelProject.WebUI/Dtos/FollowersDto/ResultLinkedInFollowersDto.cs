namespace HotelProject.WebUI.Dtos.FollowersDto
{
    public class ResultLinkedInFollowersDto
    {

        public Data data { get; set; }

        public class Data
        {
            public int connections_count { get; set; }
            public int followers_count { get; set; }
        }
    }
}
