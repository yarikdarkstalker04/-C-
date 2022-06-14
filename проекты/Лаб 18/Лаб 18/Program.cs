using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Лаб_18
{
    class Program
    {
        static void Print_xml(XDocument xdoc)
        {
            foreach (XElement lendingElement in xdoc.Element("Lendings").Elements("Lending"))
            {
                XElement categoryElement = lendingElement.Element("category");
                XElement categoryCElement = categoryElement.Element("category");
                XElement categoryNameElement = categoryElement.Element("name");
                XElement categoryNoteElement = categoryElement.Element("note");

                XElement clientElement = lendingElement.Element("client");
                XElement clientCElement = clientElement.Element("client");
                XElement clientLastNameElement = clientElement.Element("last_name");
                XElement clientFirstNameElement = clientElement.Element("first_name");
                XElement clientMiddleNameElement = clientElement.Element("middle_name");
                XElement clinetNumPaspElement = clientElement.Element("num_pasp");
                XElement clientSeriaPaspElement = clientElement.Element("seria_pasp");
                XElement clientDataElement = clientElement.Element("data_pasp");

                XElement descriptionElement = lendingElement.Element("description");
                XElement lendingDataElement = lendingElement.Element("lending_data");
                XElement returnDataElement = lendingElement.Element("return_data");
                XElement sumElement = lendingElement.Element("sum");
                XElement commissionElement = lendingElement.Element("commission");

                Console.WriteLine("Категория товара: {0}", categoryCElement.Value);
                Console.WriteLine("Название товара: {0}", categoryNameElement.Value);
                Console.WriteLine("Примечания к товару: {0}", categoryNoteElement.Value);

                Console.WriteLine("Клиент: {0}", clientCElement.Value);
                Console.WriteLine("Фамилия: {0}", clientLastNameElement.Value);
                Console.WriteLine("Имя: {0}", clientFirstNameElement.Value);
                Console.WriteLine("Отчество: {0}", clientMiddleNameElement.Value);
                Console.WriteLine("Номер паспорта: {0}", clinetNumPaspElement.Value);
                Console.WriteLine("Серия паспорта: {0}", clientSeriaPaspElement.Value);
                Console.WriteLine("Дата паспорта: {0}", clientDataElement.Value);

                Console.WriteLine("Описание товара: {0}", descriptionElement.Value);
                Console.WriteLine("Дата сдачи: {0}", lendingDataElement.Value);
                Console.WriteLine("Дата возврата: {0}", returnDataElement.Value);
                Console.WriteLine("Сумма: {0}", sumElement.Value);
                Console.WriteLine("Комиссионные: {0}", commissionElement.Value);
                Console.WriteLine();
            }
        }
        static void Add_xml(XDocument xdoc)
        {
            Console.Write("Введите id категории:");
            string category = Console.ReadLine();
            Console.Write("Введите название категории:");
            string categoryName = Console.ReadLine();
            Console.Write("Введите примечание товара:");
            string categoryNote = Console.ReadLine();

            Console.Write("Введите  id клиента:");
            string client = Console.ReadLine();
            Console.Write("Введите Фамилию:");
            string clientLName = Console.ReadLine();
            Console.Write("Введите Имя:");
            string clientFName = Console.ReadLine();
            Console.Write("Введите Отчество:");
            string clientMName = Console.ReadLine();
            Console.Write("Введите номер паспорта:");
            string clientNumPasp = Console.ReadLine();
            Console.Write("Введите серию паспорта:");
            string clientSeriaPasp = Console.ReadLine();
            Console.Write("Введите дату паспорта:");
            string clientDataPasp = Console.ReadLine();

            Console.Write("Введите описание товара:");
            string description = Console.ReadLine();
            Console.Write("Введите дату сдачи:");
            string lendingData = Console.ReadLine();
            Console.Write("Введите дату возврата:");
            string returnData = Console.ReadLine();
            Console.Write("Введите сумму:");
            string sum = Console.ReadLine();
            string commission = Convert.ToString(double.Parse(sum)*0.1);
            Console.WriteLine("Коммиссия: {0}",commission);

            XElement lending = new XElement("Lending",
                new XElement("category",
                    new XElement("category", category),
                    new XElement("name", categoryName),
                    new XElement("note", categoryNote)),
                new XElement("client",
                    new XElement("client", client),
                    new XElement("last_name", clientLName),
                    new XElement("first_name", clientFName),
                    new XElement("middle_name", clientMName),
                    new XElement("num_pasp", clientNumPasp),
                    new XElement("seria_pasp", clientSeriaPasp),
                    new XElement("data_pasp", clientDataPasp)),
               new XElement("description", description),
               new XElement("lending_data", lendingData),
               new XElement("return_data", returnData),
               new XElement("sum", sum),
               new XElement("commission", commission));
            XElement lendings = xdoc.Element("Lendings");
            lendings.Add(lending);
            xdoc.Save("pawnshop.xml");
        }
        static void Main(string[] args)
        {
            var fullpath = AppDomain.CurrentDomain.BaseDirectory + "pawnshop.xml";
            XDocument xdoc = XDocument.Load(fullpath);
            bool run = true;
            int switch_id;
            while (run)
            {
                Console.WriteLine("[1] - Просмотреть сданные предметы в ломбарде");
                Console.WriteLine("[2] - Добавить новый предмет");
                try
                {
                    switch_id = int.Parse(Console.ReadLine());
                }
                catch
                {
                    continue;
                }
                switch (switch_id)
                {
                    case 1:
                        Print_xml(xdoc);
                        break;
                    case 2:
                        try
                        {
                            Add_xml(xdoc);
                        }
                        catch
                        {
                            continue;
                        }
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
