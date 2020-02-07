namespace Adapter2.Domain.Entities
{
    public class Requirement
    {
        public Requirement(int id, string name, int loc)
        {
            ID = id;
            Name = name;
            LOC = loc;
        }

        public string Name { get; set; }
        public int LOC { get; set; }
        public int ID { get; set; }
    }
}
