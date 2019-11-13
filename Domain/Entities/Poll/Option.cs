using Core.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public class Option : BaseEntity
    {
        /// <summary>
        /// Текст варианта ответа
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Вариант ответа принадлежит этому опросу
        /// </summary>
        public Poll Poll { get; set; }
    }
}
