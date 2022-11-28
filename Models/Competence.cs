namespace SB_App.Models
{
    public class Competence
    {
        public int Id { get; set; }
        public string Name{ get; set; }
        public string Description { get; set; }

        public int QuestionId { get; set; }
        public Question Question { get; set; }

        public Competence()
        {

        }

        public Competence(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }
    }
}
