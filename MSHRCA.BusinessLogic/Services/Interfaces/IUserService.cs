using System.Collections.Generic;
using MSHRCA.BusinessLogic.DataModel;

namespace MSHRCA.BusinessLogic.Services.Interfaces
{
	public interface IUserService
	{
		User CheckUserExists(int userId, string password);
		User Get(int userEnum);
		IEnumerable<User> GetAll();
		User Get(string userName);
	}
}
