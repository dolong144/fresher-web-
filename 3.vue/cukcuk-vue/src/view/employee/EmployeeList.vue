<template>
    <div>
        <div class="content">
            <div class="nav">
                <div class="title">
                    <b>Danh sách nhân viên</b>
                </div>
                <div class="top-button">
                    <div class="button delete-button">
                        <div class="icon-delete">
                            <i class="fas fa-trash-alt"></i>
                        </div>
                        <div class="text">
                            <p>Xoá nhân viên</p>
                        </div>
                    </div>
                    <div class="button add-button" @click="btnAdd()">
                        <div class="icon-button"></div>
                        <div class="text">
                            <p>Thêm nhân viên</p>
                        </div>
                    </div>
                </div>
                
            </div>
            
            <div class="search">
                <div class="combo-search">
                    <div class="search-button">
                        <div class="icon-search"></div>
                        <input type="text" class="input-box" placeholder="Tìm kiếm theo mã, Tên hoặc Số điện thoại">
                    </div>
                    <div class="option">
                        <div class="value">option 1</div>
                        <div class="value">option 2</div>
                    </div>
                </div>
                <div class="combo-box" id="department" >
                    <div class="select-button">
                        <div class="title">Tất cả phòng ban</div>
                        <div class="icon-button">
                            <i class="fas fa-solid fa-chevron-down"></i>
                        </div>
                    </div>
                    <div class="option">
                        <div class="value"  v-for="department in departments" 
                                            :key="department.departmentId" 
                                            :id = department.departmentId >
                                                {{department.DepartmentName}}
                        </div>
                    </div>
                </div>
                <div class="combo-box" id="position">
                    <div class="select-button">
                        <div class="title">Tất cả vị trí</div>
                        <div class="icon-button">
                            <i class="fas fa-solid fa-chevron-down"></i>
                        </div>
                    </div>
                    <div class="option">
                        <div class="value"  v-for="position in positions" 
                                            :key="position.positionId" 
                                            :id = position.positionId >
                                                {{position.PositionName}}
                        </div>
                    </div>
                </div>
                <div class="textbox-default">
                    <div class="refresh"></div>
                </div>
            </div>
            <div class="table">
                <table id="detailEmployee">
                    <thead>
                        <th></th>
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
                    <tbody>
                        
                        <tr v-for="employee in employees" 
                            :key="employee.EmployeeId" 
                            @dblclick="rowDbClick(employee.EmployeeId)" 
                            @click="rowClick()">
                            <td><input type="checkbox" name="" id=""></td>
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
            
            <div class="footer">
                <div class="number">Hiển thị 1-10/1000 nhân viên</div>
                <div class="page">
                    <div class="first-page"></div>
                    <div class="prev-page"></div>
                    <div class="page-number active">1</div>
                    <div class="page-number">2</div>
                    <div class="page-number">3</div>
                    <div class="page-number">4</div>
                    <div class="next-page"></div>
                    <div class="last-page"></div>
                </div>
                <div class="acount">10 nhân viên/trang</div>
            </div>
        </div>
        <employeeDetail :class="{'showForm':isShowForm}" 
                        :isShowForm="isShowForm" 
                        :newCode="newCode" 
                        :typeSubmitForm="typeSubmitForm"
                        :employeeId="employeeId" 
                        @btnAdd="btnAdd"/>
    </div>
</template>
<script>
import axios from "axios";
import employeeDetail from "./EmployeeDetail.vue"
import Format from "../../model/Format.js"
export default {
    name: 'employeeList',
  components:{
      employeeDetail,
  },
  mounted() {
      var self = this;
      self.loadData();
      //Gọi API lấy dữ liệu vị trí
      axios.get("http://cukcuk.manhnv.net/v1/Positions").then(res=>{
          self.positions = res.data;
          console.log(self.positions);
      }).catch(res=>{
          console.log(res);
      })
      //Gọi API lấy dữ liệu phòng ban
      axios.get("http://cukcuk.manhnv.net/api/Department").then(res=>{
          self.departments = res.data;
          console.log(self.departments);
      }).catch(res=>{
          console.log(res);
      })
  },
  methods:{
      loadData(){
            var self = this;
            //Gọi API lấy dữ liệu nhân viên
            axios.get("http://cukcuk.manhnv.net/v1/Employees").then(res=>{
                self.employees = res.data;
            }).catch(res=>{
                console.log(res);
            })
      },
    //   hiện form nhập thông tin nhân viên khi ấn vào btn thêm nhân viên
    //   dvl(29/7/2021)
      btnAdd(){
          
          let self =this;
          
            axios.get('http://cukcuk.manhnv.net/v1/Employees/NewEmployeeCode').then(res=>{
                self.newCode = res.data;
                self.isShowForm = !self.isShowForm;
                self.typeSubmitForm = true;
                
            }).catch(res=>{
                console.log(res);
                this.isShowForm = !this.isShowForm;
            })
        
        self.loadData();
                
      },
      //hiện thông tin chi tiết 1 nhân viên
      rowDbClick(employeeId){
          this.typeSubmitForm = false;
          this.employeeId = employeeId
          this.isShowForm = !this.isShowForm;
          //gọi api
         
      },
      rowClick(){

      }

  },
  data(){
      
      return{
          typeSubmitForm:true,
          employeeId :'',
          newCode: '',
          isShowForm : false,
          employees:[],
          positions:[],
          departments:[],
      }
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
    @import url('../../css/layout/content.css');
    @import url('../../css/main.css');
    @import url('../../css/base/button.css');
    @import url('../../css/base/popup.css');
    @import url('../../css/base/textbox.css');
    @import url('../../css/base/toast.css');
    @import url('../../css/base/tooltip.css');
    .showForm{
        display: block;
    }
</style>