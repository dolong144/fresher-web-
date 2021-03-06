using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MISA.CukCuk.API.Model
{
    public class Position:BaseEntity
    {
        #region Propperty

        /// <summary>
        /// Khóa chính
        /// </summary>
        public Guid PositionId { get; set; }

        /// <summary>
        /// Mã vị trí
        /// </summary>
        public string PositionCode { get; set; }

        /// <summary>
        /// Tên vị trí
        /// </summary>
        public string PositionName { get; set; }

        /// <summary>
        /// Mô tả về vị trí
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Khóa cha
        /// </summary>
        public Guid? ParentId { get; set; }
        #endregion
    }
}
