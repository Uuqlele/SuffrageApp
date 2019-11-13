using Core.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    /// <summary>
    /// Выбранный пользователем вариант для какого-то опроса
    /// </summary>
    public class Answer : BaseEntity
    {
        /// <summary>
        /// Автор голоса
        /// </summary>
        public User Author { get; set; }

        /// <summary>
        /// Голос принадлежит данному вопросу
        /// </summary>
        public Option Option { get; set; }
    }
}
