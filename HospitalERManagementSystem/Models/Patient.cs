namespace HospitalERManagementSystem.Models
{
    public class Patient
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Condition { get; set; }
        public int TriageLevel { get; set; }

        public Patient(string id, string name, int age, string condition, int triageLevel)
        {
            Id = id;
            Name = name;
            Age = age;
            Condition = condition;
            TriageLevel = triageLevel;
        }

        public override string ToString()
        {
            return $"[{Id}] {Name} (Age: {Age}) - {Condition} [Triage: {TriageLevel}]";
        }
    }
}