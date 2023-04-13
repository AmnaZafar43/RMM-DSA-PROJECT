namespace RMM.BL
{
    internal class employee
    {
        private string name;
        private int age;
        private string cnic;
        private string email;
        private string contact;
        private string joinDate;
        private employee previous;
        private employee next;

        public employee(string name,int age,string cnic,string email,string contact,string joinDate)
        {
            this.name = name;
            this.age = age;
            this.email = email;
            this.contact = contact;
            this.joinDate = joinDate;
            this.cnic = cnic;
        }

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string Cnic { get => cnic; set => cnic = value; }
        public string Email { get => email; set => email = value; }
        public string Contact { get => contact; set => contact = value; }
        public string JoinDate { get => joinDate; set => joinDate = value; }
        internal employee Previous { get => previous; set => previous = value; }
        internal employee Next { get => next; set => next = value; }
    }
}
