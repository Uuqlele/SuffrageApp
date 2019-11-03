using Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Interfaces.Services
{
    public interface IPollService
    {
        /// <summary>
        /// Получить опрос
        /// </summary>
        /// <param name="id">Идентификатор опроса</param>
        /// <returns></returns>
        PollDto GetPoll(int id);

        /// <summary>
        /// Получить всех пользователей, учавствоваших в опросе
        /// </summary>
        /// <param name="id">Идентификатор опроса</param>
        /// <returns></returns>
        List<User> GetUsersFromPoll(int id);

        /// <summary>
        /// Получить все опросы
        /// </summary>
        /// <returns></returns>
        List<PollDto> GetAllPolls();

        bool UpdatePoll(PollDto dto);

        bool CreatePoll(PollDto dto);

        bool DeletePoll(int id);
    }
}
