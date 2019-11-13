using Core.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    /// <summary>
    /// Опрос
    /// </summary>
    public class Poll : BaseEntity
    {
        /// <summary>
        /// Заголовок
        /// </summary>
        public string Title { get; set; }
        
        /// <summary>
        /// Описание
        /// </summary>
        public string Description { get; set; }
        
        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreationDate { get; set; }
        
        /// <summary>
        /// Дата начала опроса
        /// </summary>
        public DateTime StartDate { get; set; }
        
        /// <summary>
        /// Дата конца опроса
        /// </summary>
        public DateTime EndDate { get; set; }
        
        /// <summary>
        /// Голоса пользователей в опросе
        /// </summary>
        public List<Answer> Answers { get; set; }

        /// <summary>
        /// Возможные варианты ответов пользователем
        /// </summary>
        public List<Option> Options { get; set; }

        /// <summary>
        /// Закончился ли опрос
        /// </summary>
        public bool IsEnded()
        {
            return EndDate < DateTime.Now;
        }
    }
}
