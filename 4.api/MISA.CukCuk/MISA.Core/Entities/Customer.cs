using MISA.Core.MISAAtribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.Core.Entities
{
    public class Customer : BaseEntity
    {
        #region Property
        /// <summary>
        /// Khoá chính
        /// </summary>
        public Guid CustomerId { get; set; }

        /// <summary>
        /// Mã khách hàng
        /// </summary>
        [MISARequired]
        [MISACode]
        public string CustomerCode { get; set; }

        /// <summary>
        /// Họ và đệm
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Tên
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Họ và tên
        /// </summary>
        [MISARequired]
        public string FullName { get; set; }

        /// <summary>
        /// Giới tính
        /// </summary>
        public int? Gender { get; set; }

        /// <summary>
        /// Địa chỉ
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Ngày sinh
        /// </summary>
        public DateTime? DateOfBirth { get; set; }

        /// <summary>
        /// email
        /// </summary>
        [MISARequired]
        [MISAEmail]
        public string Email { get; set; }

        /// <summary>
        /// Số điện thoại
        /// </summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// Id nhóm khách hàng
        /// </summary>
        public Guid CustomerGroupId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int DebitAmount { get; set; }
        /// <summary>
        /// mã thẻ thành viên
        /// </summary>
        public string MemberCardCode { get; set; }
        /// <summary>
        /// tên công ti
        /// </summary>
        public string CompanyName { get; set; }
        /// <summary>
        /// mã công ti
        /// </summary>
        public string CompanyTaxCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool IsStopFollow { get; set; }
        public List<string> ErrorImport { get; set; } = new List<string>();


        #endregion
    }
}
