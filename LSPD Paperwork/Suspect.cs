namespace LSPD_Paperwork
{
    class Suspect
    {
        public Suspect(string name, string phone)
        {
            Name = name;
            Phone = phone;
        }

        public string Name { get; }
        public string Phone { get; set; }

        public override string ToString()
        {
            return Name + "__" + Phone;
        }
    }
}
