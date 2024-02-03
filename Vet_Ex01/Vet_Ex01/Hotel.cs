namespace Vet_Ex01
{
    internal class Hotel
    {
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public int Room { get; set; }

        public Hotel(string nome, string email, int room) 
        {
            Nome = nome;
            Email = email;
            Room = room;
        }
    }
}
