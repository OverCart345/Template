namespace Template
{
    internal class Program
    {
        public class MyGenericArray<T>
        {
            private T[] array;

            public MyGenericArray(int size)
            {
                array = new T[size];
            }

            public T GetElement(int index)
            {
                return array[index];
            }

            public void SetElement(int index, T value)
            {
                array[index] = value;
            }

            public void RemoveElement(int index)
            {
                for (int i = index; i < array.Length - 1; i++)
                {
                    array[i] = array[i + 1];
                }
                Array.Resize(ref array, array.Length - 1);
            }
        }
        static void Main(string[] args)
        {
            MyGenericArray<int> intArray = new MyGenericArray<int>(3);
            intArray.SetElement(0, 1);
            intArray.SetElement(1, 2);
            intArray.SetElement(2, 3);

            Console.WriteLine("(Массив int) Элемент в индексе 1: " + intArray.GetElement(1));
            intArray.RemoveElement(1);
            Console.WriteLine("(Массив int) Элемент в индексе 1, после удаления: " + intArray.GetElement(1));

            Console.WriteLine();

            MyGenericArray<string> strArray = new MyGenericArray<string>(3);
            strArray.SetElement(0, "lol");
            strArray.SetElement(1, "kek");
            strArray.SetElement(2, "cheburek");

            Console.WriteLine("(Массив string) Элемент в индексе 1: " + strArray.GetElement(1));
            strArray.RemoveElement(1);
            Console.WriteLine("(Массив string) Элемент в индексе 1, после удаления: " + strArray.GetElement(1));

            Console.ReadKey();
        }
    }
}