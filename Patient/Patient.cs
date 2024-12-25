namespace data
{
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"ID : {Id}, Name : {Name}, Age : {Age}, Gender : {Gender}";
        }
    }
}