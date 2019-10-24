using Core.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public class Answer : BaseEntity
    {
        /// <summary>
        /// Текст варианта ответа
        /// </summary>
        public string Text { get; set; }
    }
}
