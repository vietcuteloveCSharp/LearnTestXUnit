using Domain.Entity;
using Domain.Interface;

namespace Services
{
	public class UserService
	{
		private readonly IUserRepository _repository;
		public UserService(IUserRepository repository)
		{
			this._repository = repository;
		}
		public async Task<bool> RegisterUserAsync(string name, string email)
		{
			var user = new User
			{
				Id = new Random().Next(1, 10000), // chỉ để demo in-memory
				Name = name,
				Email = email
			};

			return await _repository.AddUserAsync(user);
		}
		public async Task<User?> GetUserAsync(int id)
		{
			return await _repository.GetUserByIdAsync(id);
		}

		public async Task<List<User>> GetAllUsersAsync()
		{
			return await _repository.GetAllUsersAsync();
		}
		public async Task<bool> UpdateUserAsync(int id, User user)
		{
			var userUpdate = new User
			{
				Name = user.Name,
				Email = user.Email
			};

			return await _repository.UpdateUserAsync(id, userUpdate);
		}
	}
}
