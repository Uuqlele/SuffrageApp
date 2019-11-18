using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Dtos
{
    public class OptionDto
    {

        /// <summary>
        /// Идентификатор варианта ответа 
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Текст варианта ответа
        /// </summary>
        public string Text { get; set; }
        
        /// <summary>
        /// Вариант ответа принадлежит этому опросу
        /// </summary>
        public PollDto Poll { get; set; }
    }
}
