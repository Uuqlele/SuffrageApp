using Core.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Chat
{
    public class Message : BaseEntity
    {
        /// <summary>
        /// Текст сообщения
        /// </summary>
        public string TextMessage { get; set; }
        
        /// <summary>
        /// Автор сообщения
        /// </summary>
        public User Author { get; set; }

        /// <summary>
        /// Чат, в котором находится данное сообщение
        /// </summary>
        public Chat Chat { get; set; }

    }
}
