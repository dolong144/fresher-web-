using MISA.Core.MISAAtribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.Core.Entities
{
    public class Employee:BaseEntity
    {
        #region Property

        /// <summary>
        /// Khóa chính
        /// </summary>
        public Guid EmployeeId { get; set; }

        /// <summary>
        /// Mã nhân viên
        /// </summary>
        [MISARequired]
        [MISACode]
        public string EmployeeCode { get; set; }

        /// <summary>
        /// Tên và đệm 
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
        /// Địa chỉ
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Giới tính
        /// </summary>
        public int? Gender { get; set; }

        /// <summary>
        /// Ngày sinh
        /// </summary>
        public DateTime? DateOfBirth { get; set; }

        /// <summary>
        /// Email
        /// </summary>
        [MISARequired]
        [MISAEmail]
        public string Email { get; set; }

        /// <summary>
        /// Số điện thoại
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Số cmt
        /// </summary>
        public string IdentityNumber { get; set; }

        /// <summary>
        /// Ngày làm cmt
        /// </summary>
        public DateTime? IdentityDate { get; set; }

        /// <summary>
        /// Nơi làm cmt
        /// </summary>
        public string IdentityPlace { get; set; }

        /// <summary>
        /// Ngày gia nhập công ty
        /// </summary>
        public DateTime? JoinDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int? MartialStatus { get; set; }


        /// <summary>
        /// Chất lượng
        /// </summary>
        public Guid? QualificationId { get; set; }

        /// <summary>
        /// Id phòng ban
        /// </summary>
        public Guid? DepartmentId { get; set; }

        /// <summary>
        /// Id vị tri
        /// </summary>
        public Guid? PositionId { get; set; }

        /// <summary>
        /// Trạng thái công việc
        /// </summary>
        public int? WorkStatus { get; set; }

        /// <summary>
        /// Mã số thuế
        /// </summary>
        public string PersonalTaxCode { get; set; }

        /// <summary>
        /// Tiền lương 
        /// </summary>
        public double Salary { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int EducationalBackground { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [MISANotMap]
        public string GenderName { get; set; }

        #endregion
    }
}
