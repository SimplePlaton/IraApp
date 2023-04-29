using BlazorApp.Data;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp.Services
{
    public class TitanicService
    {
        protected readonly ApplicationDbContext _context;
        public TitanicService(ApplicationDbContext _db)
        {
            _context = _db;
        }

        public List<TitanicClass> GetTitanic(string? value = null)
        {
            var passengers = new List<TitanicClass>();
            if (string.IsNullOrEmpty(value))
                passengers = _context.Titanic.ToList();
            else
                passengers = _context.Titanic.Where(it=> it.Name.ToUpper().Contains(value.ToUpper()) 
                    || it.Sex.ToUpper().Contains(value.ToUpper()) 
                    || it.Ticket.ToUpper().Contains(value.ToUpper()) 
                    || it.Cabin.ToUpper().Contains(value.ToUpper())
                    || it.Age.ToString().Equals(value))
                        .ToList();
            return passengers;
        }

        public void Delete(TitanicClass passenger)
        {
            //var passenger = _context.Titanic.FirstOrDefault(it => it.Id == Id);
            if (passenger != null) 
            { 
                _context.Titanic.Remove(passenger); 
                _context.SaveChanges();
            }
           
        }
    }   
}
