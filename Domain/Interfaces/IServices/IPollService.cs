using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Interfaces.Services
{
    public interface IPollService
    {
        /// <summary>
        /// Получить опрос
        /// </summary>
        /// <param name="id">Идентификатор опроса</param>
        /// <returns></returns>
        Poll GetPoll(int id);

        /// <summary>
        /// Получить всех пользователей, учавствоваших в опросе
        /// </summary>
        /// <param name="id">Идентификатор опроса</param>
        /// <returns></returns>
        List<User> GetUsersFromPoll(int id);

    }
}
