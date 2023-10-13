namespace DocumentWorker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            string key;
            Console.WriteLine("Введіть ключ доступу: ");
            key = Console.ReadLine();
            if (key == "pro")
            {
                ProDocumentWorker docPro = new ProDocumentWorker();
                docPro.Print();
            }
            else if (key == "exp")
            {
                ExpertDocumentWorker docExp = new ExpertDocumentWorker();
                docExp.Print();
            }
            else
            {
                DocumentWorker docBase = new DocumentWorker();
                docBase.Print();
            }
        }

    }
}