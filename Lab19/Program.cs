using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Computer> computers = new List<Computer>()
            {
                new Computer(){Id = "A01", NameMark = "AMD", TypeProcessor = "i3", Frequency = 3.2, RAM = 4, VHardDisk = 5000, VRAM = 8, CostComputer = 65000, Quantity = 3},
                new Computer(){Id = "A02", NameMark = "Intel", TypeProcessor = "ryazan 7", Frequency = 3.9, RAM = 8, VHardDisk = 1000, VRAM = 12, CostComputer = 75000, Quantity = 73},
                new Computer(){Id = "A03", NameMark = "Intel", TypeProcessor = "i5", Frequency = 3.8, RAM = 8, VHardDisk = 750, VRAM = 16, CostComputer = 77000, Quantity = 29},
                new Computer(){Id = "A04", NameMark = "Intel", TypeProcessor = "i9", Frequency = 3.9, RAM = 16, VHardDisk = 2000, VRAM = 8, CostComputer = 95000, Quantity = 5},
                new Computer(){Id = "A05", NameMark = "AMD", TypeProcessor = "ryazan 5", Frequency = 3.8, RAM = 8, VHardDisk = 1000, VRAM = 8, CostComputer = 80000, Quantity = 20},
                new Computer(){Id = "A06", NameMark = "Intel", TypeProcessor = "i3", Frequency = 3.2, RAM = 4, VHardDisk = 3000, VRAM = 4, CostComputer = 45000, Quantity = 5},
                new Computer(){Id = "A07", NameMark = "Intel", TypeProcessor = "i5", Frequency = 3.8, RAM = 8, VHardDisk = 750, VRAM = 6, CostComputer = 95000, Quantity = 10},
                new Computer(){Id = "A08", NameMark = "AMD", TypeProcessor = "ryazan 9", Frequency = 3.9, RAM = 16, VHardDisk = 2000, VRAM = 24, CostComputer = 107000, Quantity = 58},
                new Computer(){Id = "A09", NameMark = "AMD", TypeProcessor = "ryazan 7", Frequency = 3.8, RAM = 8, VHardDisk = 1000, VRAM = 24, CostComputer = 70000, Quantity = 4},
            };
            Console.WriteLine("Введите интересующий процессор (Intel или AMD)");
            string typeprocessor = Console.ReadLine();
            List<Computer> computers1 = computers.Where(d => d.TypeProcessor == typeprocessor).ToList();
            Print(computers1);

            Console.WriteLine("Введите объем ОЗУ");
            int ram = Convert.ToInt32(Console.ReadLine());
            List<Computer> computers2 = computers.Where(d => d.RAM >= ram).ToList();
            Print(computers2);

            List<Computer> computers3 = computers.OrderBy(d => d.CostComputer).ToList();
            Console.WriteLine("Сортировка по возрастанию");
            Print(computers3);

            IEnumerable<IGrouping<string, Computer>> computers4 = computers.GroupBy(d => d.TypeProcessor);
            foreach (IGrouping<string, Computer> gr in computers4)
            {
                Console.WriteLine(gr.Key);
                foreach (Computer c in gr)
                {
                    Console.WriteLine($"{c.Id} | {c.NameMark} | {c.Frequency} | {c.RAM} | {c.VHardDisk} | {c.VRAM} | {c.CostComputer} | {c.Quantity}");
                }
            }

            Computer computers5 = computers.OrderBy(d => d.CostComputer).FirstOrDefault();
            Console.WriteLine("\nМинимальная стоимость компьютера");
            Console.WriteLine($"{computers5.Id} | {computers5.NameMark} | {computers5.TypeProcessor} | {computers5.Frequency} | {computers5.RAM} | {computers5.VHardDisk} | {computers5.VRAM} | {computers5.CostComputer} | {computers5.Quantity}");

            Computer computers6 = computers.OrderByDescending(d => d.CostComputer).FirstOrDefault();
            Console.WriteLine("\nМаксимальная стоимость компьютера");
            Console.WriteLine($"{computers6.Id} | {computers6.NameMark} | {computers6.TypeProcessor} | {computers6.Frequency} | {computers6.RAM} | {computers6.VHardDisk} | {computers6.VRAM} | {computers6.CostComputer} | {computers6.Quantity}");

            if (computers.Any(d => d.Quantity >= 30))
            {
                Console.WriteLine("\nИмеется компьютер не менее 30 шт.");
            }
            else
                Console.WriteLine("\nКомпьютер в нужном количестве отсутсвует");

            Console.ReadKey();
        }
        static void Print(List<Computer> computers)
        {
            foreach (Computer c in computers)
            {
                Console.WriteLine($"{c.Id} | {c.NameMark} | {c.TypeProcessor} | {c.Frequency} | {c.RAM} | {c.VHardDisk} | {c.VRAM} | {c.CostComputer} | {c.Quantity}");
            }
            Console.WriteLine();
        }
    }
}
