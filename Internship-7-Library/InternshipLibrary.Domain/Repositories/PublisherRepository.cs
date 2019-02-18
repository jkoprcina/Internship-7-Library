using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InternshipLibrary.Data.Entities;
using InternshipLibrary.Data.Entities.Models;
using InternshipLibrary.Extensions.Extensions;

namespace InternshipLibrary.Domain.Repositories
{
    public class PublisherRepository
    {
        private readonly LibraryContext _context;

        public PublisherRepository() => _context = new LibraryContext();

        public string Create(Publisher publisher)
        {
            if (publisher.Name == "")
                return "Please enter a name";
            if (Read().FirstOrDefault(x => x.Name == publisher.Name) != null)
                return "A publisher with the same name already exists, enter a unique name";
            _context.Publishers.Add(publisher);
            _context.SaveChanges();
            return "Successfully added";
        }

        public Publisher Read(int id) => _context.Publishers.Find(id);

        public List<Publisher> Read() => _context.Publishers.ToList();

        public string Update(Publisher newPublisher, Publisher oldPublisher)
        {
            if (newPublisher.Name == "")
                return "Please enter a name";
            if (Read().FirstOrDefault(x => x.Name == newPublisher.Name) != null)
                return "You haven't made any changes";

            oldPublisher.Name = newPublisher.Name;
            _context.SaveChanges();
            return "Successfully updated";
        }

        public string Delete(Publisher publisher)
        {
            if (_context.Books.Any(x => x.Publisher == publisher))
                return "You must first delete all of the books which have that publisher";
            _context.Publishers.Remove(publisher);
            _context.SaveChanges();
            return "Successfully removed";
        }
    }
}
