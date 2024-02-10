namespace ToDoDemo.Models
{
    public class Filters
    {
        public Filters(string filterstring)
        {
            Filterstring = filterstring ?? "all-all-all";
            string[] filters = Filterstring.Split('-');
            CategoryId = filters[0];
            Due = filters[1];
            StatusId = filters[2];
        }
        public string Filterstring { get; set; }
        public string CategoryId { get; set; }
        public string Due { get; set; }
        public string StatusId { get; set; }
        public bool HasCategory => CategoryId.ToLower() != "all";
        public bool HasDue => Due.ToLower() != "all";
        public bool HasStatus => StatusId.ToLower() != "all";
        public static Dictionary<string, string> DueFilterValues =>
            new Dictionary<string, string>
            {
                {"futuro", "Futuro" },
                {"passado", "Passado" },
                {"hoje", "Hoje" }
            };
        public bool IsPast => Due.ToLower() == "passado";
        public bool IsFuture => Due.ToLower() == "futuro";
        public bool IsToday => Due.ToLower() == "hoje";
    }
}
