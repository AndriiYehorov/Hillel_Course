namespace UserInformation
{
    internal class User
    {
        private string login;
        public string Login
        {
            get { return login; }
            set { login = value; }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        
        private string surname;
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        
        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        DateTime date { get; }

        public User(string login, string name, string surname, int age)
        {
            date = DateTime.Now;
            this.login = login;
            this.name = name;
            this.surname = surname;
            this.age = age;
        }

        public void Messege() 
        {
            Console.WriteLine("Анкета пользователя: \n1.Имя: {0}\n2.Фамилия: {1}\n3.Логин: {2}\n4.Возраст: {3}\n5.Дата создания: {4}", this.name,this.surname,this.login,this.age,this.date);
        }
    }
}
