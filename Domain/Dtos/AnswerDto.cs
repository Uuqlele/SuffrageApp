using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Dtos
{
    public class AnswerDto
    {
        /// <summary>
        /// Автор голоса
        /// </summary>
        public UserDto Author { get; set; }

        /// <summary>
        /// Автор выбрал вот этот ответ
        /// </summary>
        public OptionDto Option { get; set; }

    }
}
