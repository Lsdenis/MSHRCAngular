using System.Collections.Generic;
using System.Linq;
using MSHRCA.BusinessLogic.DataModel;
using MSHRCA.BusinessLogic.Repository;
using MSHRCA.BusinessLogic.Services.Interfaces;

namespace MSHRCA.BusinessLogic.Services.Classes
{
	public class UserService : IUserService, ISelfDependency
	{
		private readonly IRepository<User> _userRepository;

		public UserService(IRepository<User> userRepository)
		{
			_userRepository = userRepository;
		}

		public User CheckUserExists(int userId, string password)
		{
			return _userRepository.FirstOrDefault(user => user.Id == userId && user.Password.Equals(password));
		}

		public User Get(int userEnum)
		{
			return _userRepository.GetAll().First(user => user.Id == userEnum);
		}

		public IEnumerable<User> GetAll()
		{
			return _userRepository.GetAll();
		}

		public User Get(string userName)
		{
			return _userRepository.GetAll().First(user => user.Name == userName);
		}
	}
}
