namespace DocumentWorker
{
    internal class DocumentWorker
    {
        public void OpenDocument()
        {
            Console.WriteLine("Документ відкритий");
        }
        public virtual void EditDocument()
        {
            Console.WriteLine("Редагування документа доступне у версії Про");
        }

        public virtual void SaveDocument()
        {
            Console.WriteLine("Збереження документа доступне у версії Про");
        }

        public virtual void Print() 
        {
            OpenDocument();
            EditDocument();
            SaveDocument();
        }
    }
}
