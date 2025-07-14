using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface
{
	public interface IUserRepository
	{
		Task<List<User>> GetAllUsersAsync();
		Task<User?> GetUserByIdAsync(int id);
		Task<User?> GetUserByEmailAsync(string email);
		Task<bool> AddUserAsync(User user);
		Task<bool> UpdateUserAsync(int id,User user);
		Task<bool> UserExistsAsync(int id);
		Task<bool> UserExistsByEmailAsync(string email);

	}
}
