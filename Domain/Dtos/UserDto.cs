using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Dtos
{
    public class UserDto
    {
        /// <summary>
        /// Имя пользователя
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Опросы, которые созданы пользователем
        /// </summary>
        public List<PollDto> Polls { get; set; }

        /// <summary>
        /// Все голоса пользователя, которые он выбрал в разных опросах
        /// </summary>
        public List<VoteDto> Votes { get; set; }
    }
}
