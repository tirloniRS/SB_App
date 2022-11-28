namespace SB_App.Models
{
    public class Candidate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Cel_number { get; set; }
        public string Linkedin { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public int InterviewID { get; set; }        
        public Interview Interview { get; set; }

        public Candidate()
        {
        }

        public Candidate(int id, string name, string email, string cel_number, string linkedin, string city, string state)
        {
            Id = id;
            Name = name;
            Email = email;
            Cel_number = cel_number;
            Linkedin = linkedin;
            City = city;
            State = state;
        }
    }


}
