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

        public PublisherRepository()
        {
            _context = new LibraryContext();
        }

        public void Create(Publisher publisher)
        {
            _context.Publishers.Add(publisher);
            _context.SaveChanges();
        }

        public Publisher Read(int id)
        {
            return _context.Publishers.Find(id);
        }

        public List<Publisher> Read()
        {
            return _context.Publishers.ToList();
        }

        public void Update(Publisher newPublisher, Publisher oldPublisher)
        {
            newPublisher.Id = oldPublisher.Id;
            _context.Publishers.Remove(oldPublisher);
            _context.Publishers.Add(newPublisher);
            _context.SaveChanges();
        }

        public void Delete(Publisher publisher)
        {
            _context.Publishers.Remove(publisher);
            _context.SaveChanges();
        }
    }
}
