using System;

namespace ProiectEAV_Muzee
{
    // Trebuie să fie publică pentru ca XMLSerializer să o poată citi
    public class Muzeu
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public string Program { get; set; }
        public string Localitate { get; set; }
        public string Pret { get; set; }
        public int Rating { get; set; }
        public string Username { get; set; }
    }
}