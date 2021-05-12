using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri tcpUri = new Uri("http://localhost:1337/");
            EndpointAddress address = new EndpointAddress(tcpUri);
            BasicHttpBinding binding = new BasicHttpBinding();
            ChannelFactory<INoteService> factory = new ChannelFactory<INoteService>(binding, address);
            INoteService service = factory.CreateChannel();

            int userInput = 123;

            while(userInput != 0)
            {
                Console.Write("1. Добавить запись в блокнот \n2. Удалить запись из блакнота \n3. Изменить запись \n4. Показать все записи \n ->");
                userInput = Convert.ToInt32(Console.ReadLine());
                switch (userInput)
                {
                    case 1:
                        {
                            Console.WriteLine("Введите тему записи");
                            String theme = Console.ReadLine();

                            Console.WriteLine("Введите содержание записи");
                            String text = Console.ReadLine();

                            service.AddNote(new Note(theme, text));
                        }
                        break;
                    case 2:
                        {
                            int i = 0;
                            ICollection<Note> notes = service.GetNotes();
                            if (notes.Count != 0)
                            {
                                foreach (Note note in notes)
                                {
                                    Console.Write(i++ + ". ");
                                    Console.WriteLine(note.ToString());
                                }
                                Console.WriteLine("Введите номер записи, которую хотите удалить");
                                int noteNumber = Convert.ToInt32(Console.ReadLine());
                                service.RemoveNote(noteNumber);
                            }
                            else
                            {
                                Console.WriteLine("Записей нет");
                            }
                        }
                        break;
                    case 3:
                        {
                            int i = 0;
                            ICollection<Note> notes = service.GetNotes();
                            if (notes.Count != 0)
                            {
                                foreach (Note note in notes)
                                {
                                    Console.Write(i++ + ". ");
                                    Console.WriteLine(note.ToString());
                                }
                                Console.WriteLine("Введите номер записи, которую хотите изменить");
                                int noteNumber = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("Введите тему записи");
                                String theme = Console.ReadLine();

                                Console.WriteLine("Введите содержание записи");
                                String text = Console.ReadLine();

                                service.UpdateNote(noteNumber, new Note(theme, text));
                            }
                            else
                            {
                                Console.WriteLine("Записей нет");
                            }
                        }
                        break;

                    case 4:
                        {
                            int i = 0;
                            ICollection<Note> notes = service.GetNotes();
                            if (notes.Count != 0)
                            {
                                foreach (Note note in notes)
                                {
                                    Console.Write(i++ + ". ");
                                    Console.WriteLine(note.ToString());
                                }
                            }
                            else
                            {
                                Console.WriteLine("Записей нет");
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("Такого пункта меню нет");
                        break;
                }
            }

        }
    }
}
