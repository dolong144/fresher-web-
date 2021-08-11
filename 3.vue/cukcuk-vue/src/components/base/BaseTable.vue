<template>
    <div class="table">
        <table id="detailEmployee">
            <thead>
                <th class="delete-box">
                        <input type="checkbox" ref="deleteBox">
                        <span class="checkmark"></span>
                </th>
                <th>Mã nhân viên</th>
                <th>Họ và tên</th>
                <th>Giới tính</th>
                <th>Ngày sinh</th>
                <th>Điện thoại</th>
                <th>Email</th>
                <th>Chức vụ</th>
                <th>Phòng ban</th>
                <th>Mức lương cơ bản</th>
                <th>Tình trạng công việc</th> 
            </thead>
            <tbody ref="body">
                <tr v-for="(employee, index) in employees" 
                    :key="employee.EmployeeId" 
                    ref="tableRow"
                    @dblclick="rowDbClick(employee.EmployeeId)" 
                    @click="rowClick(index)">
                    <td class="delete-box">
                        <input type="checkbox" :value="employee['EmployeeId']"  ref="deleteBox">
                        <span class="checkmark"></span>
                    </td>
                    <td>{{employee.EmployeeCode}}</td>
                    <td>{{employee.FullName}}</td>
                    <td>{{employee.GenderName}}</td>
                    <td>{{employee.DateOfBirth | formatDate}}</td>
                    <td>{{employee.PhoneNumber}}</td>
                    <td>{{employee.Email}}</td>
                    <td>{{employee.PositionName}}</td>
                    <td>{{employee.DepartmentName}}</td>
                    <td>{{employee.Salary | formatMoney}}</td>
                    <td>{{employee.WorkStatus }}</td>
                </tr>
            </tbody>
        </table>
    </div>
</template>
<script>
import Format from "../../utils/Format.js"
export default {
    props:{
        employees:{
            type:Array,
            required:true,
        }
    },
    data(){
        return{
            employeesToDelete:[],
        }

    },
    methods: {
        /* check-uncheck khi nhấn vào 1 hàng
      dvlong(2/8/2021)
       */
      rowClick(index){
            this.$refs.deleteBox[index].defaultChecked = !this.$refs.deleteBox[index].defaultChecked;

            this.$refs.tableRow[index].classList.toggle('selected_row');

            if (this.$refs.deleteBox[index].defaultChecked) {
                this.employeesToDelete.push(this.$refs.deleteBox[index].defaultValue);
                
            } else {
                if (this.employeesToDelete.indexOf(this.$refs.deleteBox[index].defaultValue) > -1) {
                this.employeesToDelete.splice(this.employeesToDelete.indexOf(this.$refs.deleteBox[index].defaultValue), 1);
                }
                
            }
            
      },
        //hiện thông tin chi tiết 1 nhân viên khi nhấn đúp vào 1 hàng
        //   dvlong(3/8/2021)
      rowDbClick(employeeId){
          
          this.typeSubmitForm = false;
          this.employeeId = employeeId;
          this.isShowForm = !this.isShowForm;
          //gọi api
         
      },
    },
    filters:{
      formatDate: function(date){
        return Format.dobFormat(date);
      },
        formatMoney: function(money){
            return Format.currencyFormatter(money);
        }
  }
    
}
</script>
<style scoped>
    @import url('../../assets/css/layout/content.css');
    @import url('../../assets/css/main.css');
    @import url('../../assets/css/base/button.css');
    @import url('../../assets/css/base/popup.css');
    @import url('../../assets/css/base/textbox.css');
    @import url('../../assets/css/base/toast.css');
    @import url('../../assets/css/base/tooltip.css');
    .showForm{
        display: block;
    }
    .content .nav .showButton{
        display: flex;
    }
    .showToast{
        display: flex;
    }
    .selected_row{
        background-color: #ebf9f4 !important;
    }
</style>