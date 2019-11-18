using Core.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public class User : BaseEntity
    {
        /// <summary>
        /// Имя пользователя
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Опросы, которые созданы пользователем
        /// </summary>
        public List<Poll> Polls { get; set; }

        /// <summary>
        /// Все голоса пользователя, которые он выбрал в разных опросах
        /// </summary>
        public List<Answer> Answers { get; set; }

    }
}
