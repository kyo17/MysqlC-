using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using APIElectron.Models;

namespace APIElectron.Interfaces
{
    public interface IUser
    {
        Task<IEnumerable<User>> getAll();
        Task<User> getOneById(string id);
        Task delete(string id);
        Task insert(User user);
        Task update(User user);
    }
}
