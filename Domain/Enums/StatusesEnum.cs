using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Enums
{
    public enum StateEnum
    {
        /// <summary>
        /// Голосование началось 
        /// </summary>
        Active, 

        /// <summary>
        /// Голосование не началось
        /// </summary>
        NotStarted,

        /// <summary>
        /// Голосование закончилось
        /// </summary>
        Ended,

        /// <summary>
        /// Голосование удалено 
        /// </summary>
        Removed,
    }
}
