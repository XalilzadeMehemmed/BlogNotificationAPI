namespace BlogNotificationApi.User.Repositories.Base;

using BlogNotificationApi.User.Models;

public interface IUserRepository
{
    Task<User> GetByIdAsync(Guid id);
    Task UpdateAsync(string email, bool toSend);
}