namespace EnumIndexerTask
{
    public class SimpleStringColllection
    {
        private string[] items;

        public SimpleStringColllection(int size)
        {
            if(size <= 0)
                Console.WriteLine("Size musbet olmalidir");

            items = new string[size];
        }

        public string this[int index]
        { 
            get
            {
                if(index < 0 || index >= items.Length)
                    Console.WriteLine("Index etibarsizdir");
                return items[index];
            }
            set
            {
                if (index < 0 || (index >= items.Length))
                    Console.WriteLine("Index etibarsizdir");
                items[index] = value;

            }
        }
        public int Length 
        { get 
            { 
                return items.Length; 
            } 
        }


    }
}
