namespace Vue_ET_Son_Model.Models
{
    public class ViewModel02
    {
        public Personne[] Personnes { get; set; }
        public ViewModel02()
        {
            Personnes = new Personne[] { new Personne { Nom = "Pierre", Age = 44 }, new Personne { Nom = "Pauline", Age = 12 } };
        }
    }
    public class Personne
    {
        public string Nom { get; set; }
        public int Age { get; set; }
    }
}
