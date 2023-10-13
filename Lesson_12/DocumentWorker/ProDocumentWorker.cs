namespace DocumentWorker
{
    internal class ProDocumentWorker : DocumentWorker
    {
        public override void EditDocument()
        {
            Console.WriteLine("Документ відредаговано");
        }

        public override void SaveDocument()
        {
            Console.WriteLine("Документ збережено у старому форматі, збереження в інших форматах доступне у версії Експерт");
        }

        public override void Print()
        {
            base.OpenDocument();
            EditDocument();
            SaveDocument();
        }
    }
}
