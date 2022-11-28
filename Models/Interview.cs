namespace SB_App.Models
{
    public class Interview
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Initial_date { get; set; }
        public DateTime Final_date { get; set; }

        public int CandidateId { get; set; }
        public Candidate candidate { get; set; }

        public ICollection<Question> Questions { get; set; }

        public Interview()
        {

        }

        public Interview(int id, string name, DateTime initial_date, DateTime final_date)
        {
            Id = id;
            Name = name;
            Initial_date = initial_date;
            Final_date = final_date;
        }
    }
}
