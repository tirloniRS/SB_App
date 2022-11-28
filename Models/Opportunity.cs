namespace SB_App.Models
{
    public class Opportunity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Manager { get; set; }
        public DateTime Initial_Date { get; set; }
        public DateTime Final_Date { get; set; }

        public int CompetenceId { get; set; }
        public ICollection<Competence> Competences { get; set; }

        public Opportunity()
        {

        }

        public Opportunity(int id, string name, string manager, DateTime initial_Date, DateTime final_Date)
        {
            Id = id;
            Name = name;
            Manager = manager;
            Initial_Date = initial_Date;
            Final_Date = final_Date;
        }
    }
}
