using Domain.Entity;
using Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
	public class InMemoryUserRepository : IUserRepository
	{
		private readonly List<User> _users = new();
		public  Task<bool> AddUserAsync(User user)
		{
			 _users.Add(user);	
			return Task.FromResult(true);

		}

		public  Task<List<User>> GetAllUsersAsync()
		{
			return	Task.FromResult(_users.ToList());
		}		

		public Task<User?> GetUserByEmailAsync(string email)
		{
			return Task.FromResult(_users.FirstOrDefault(u => u.Email.Equals(email, StringComparison.OrdinalIgnoreCase)));
		}

		public Task<User?> GetUserByIdAsync(int id)
		{
			return Task.FromResult(_users.FirstOrDefault(u => u.Id == id));
		}

		public Task<bool> UpdateUserAsync(int id,User user)
		{
			var existingUser = _users.FirstOrDefault(u => u.Id == id);
			if (existingUser is null)
			{
				return Task.FromResult(false);
			}
			existingUser.Name = user.Name;
			existingUser.Email = user.Email;
			
			return Task.FromResult(true);
		}

		public Task<bool> UserExistsAsync(int id)
		{
			return Task.FromResult(_users.Any(u => u.Id == id));
		}

		public Task<bool> UserExistsByEmailAsync(string email)
		{
			return Task.FromResult(_users.Any(u => u.Email.Equals(email, StringComparison.OrdinalIgnoreCase)));
		}
	}
}
