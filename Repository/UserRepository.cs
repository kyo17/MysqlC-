using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using APIElectron.Database;
using APIElectron.Interfaces;
using APIElectron.Models;
using Microsoft.EntityFrameworkCore;

namespace APIElectron.Repository
{
    public class UserRepository : IUser
    {
        private readonly SQLContext db;

        public UserRepository()
        {
        }

        public UserRepository(SQLContext sql)
        {
            this.db = sql;
        }

        public async Task delete(string id)
        {
            var remove = await db.Users.FindAsync(id);
            db.Users.Remove(remove);
            await db.SaveChangesAsync();
        }

        public async Task<IEnumerable<User>> getAll()
        {
            return await db.Users.ToListAsync();
        }

        public async Task<User> getOneById(string id)
        {
            return await db.Users.FindAsync(id); 
        }

        public async Task insert(User user)
        {
            if (string.IsNullOrEmpty(user.idUser))
            {
                db.Users.Add(user);
                await db.SaveChangesAsync();
            }
        }

        public async Task update(User user)
        {
            if (!string.IsNullOrEmpty(user.idUser))
            {
                db.Entry(user).State = EntityState.Modified;
                await db.SaveChangesAsync();
            }
        }
    }
}
