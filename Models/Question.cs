namespace SB_App.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Grade { get; set; }

        public int CompetenceId { get; set; }
        public Competence Competence { get; set; }

        public int InterviewId { get; set; }
        public ICollection<Interview> interviews { get; set; }

        public Question()
        {

        }

        public Question(int id, string description, string grade)
        {
            Id = id;
            Description = description;
            Grade = grade;
        }
    }
}
