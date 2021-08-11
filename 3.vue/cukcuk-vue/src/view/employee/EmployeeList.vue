<template>
    <div>
        <div class="content">
            <div class="nav">
                <div class="title">
                    <b>Danh sách nhân viên</b>
                </div>
                <div class="top-button">
                    <div class="button-icon delete-button" :class="{'showButton':isShowButtonDelete}" @click="showPopup('Xoá nhân viên!','Bạn có chắc muốn xoá các bản ghi đã chọn?','alert-popup')">
                        <div class="icon-delete">
                            <i class="fas fa-trash-alt"></i>
                        </div>
                        <div class="text">
                            <p>Xoá nhân viên</p>
                        </div>
                    </div>
                    <div class="button-icon add-button" @click="btnAdd()">
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
                <BaseDropdown
                    id="dropdown__department"
                    title="Tất cả phòng ban"
                    type="Department"
                />
                <BaseDropdown
                    id="dropdown__position"
                    title="Tất cả vị trí"
                    type="Position"
                />

                <div class="textbox-default" @click="loadData()">
                    <div class="refresh"></div>
                </div>
            </div>
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
                        @showForm="showForm"
                        @loadData="loadData"
                        @showToast="showToast"
                        @showPopup="showPopup"
                        @resetNewCode="resetNewCode"/>
        <popup  :class="{'showPopup':isShowPopup}" 
                :isShowPopup="isShowPopup" 
                :titlePopup="titlePopup"
                :typePopup="typePopup"
                :contentPopup="contentPopup"
                @hidePopup="showPopup" 
                @confirmPopup="confirmPopup" />
        <toast  :class="{'showToast':isShowToast}"
                :contentToast="contentToast"
                :typeToast="typeToast"
                :isShowToast="isShowToast"/>
    </div>
</template>
<script>
import axios from "axios";
import employeeDetail from "./EmployeeDetail.vue"
import BaseDropdown from "../../components/base/BaseDropDown.vue"
import Format from "../../utils/Format.js"
import toast from "../../components/base/BaseToast.vue"
import popup from "../../components/base/BasePopup.vue"
import EmployeesAPI from "@/api/components/EmployeesAPI";
export default {
    name: 'employeeList',
  components:{
      employeeDetail, BaseDropdown, toast, popup
  },
  mounted() {
      var self = this;
      self.loadData();
      
  },
  methods:{
      loadData(){
            
            var self = this;
            self.employees = {};
            //Gọi API lấy dữ liệu nhân viên
            EmployeesAPI.getAll().then(res=>{
                self.employees = res.data;
                // self.showToast('Load dữ liệu thành công!','success-toast');
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
                self.showForm();
                self.typeSubmitForm = true;
                
            }).catch(res=>{
                console.log(res);
                this.isShowForm = !this.isShowForm;
            })
                
      },
      //reset new code
      resetNewCode(){
          this.newCode = '';
      },
      //hàm ẩn hiện form
      showForm(){
          this.isShowForm = !this.isShowForm;
      },
      //hiện thông tin chi tiết 1 nhân viên khi nhấn đúp vào 1 hàng
    //   dvlong(3/8/2021)
      rowDbClick(employeeId){
          
          this.typeSubmitForm = false;
          this.employeeId = employeeId;
          this.isShowForm = !this.isShowForm;
          //gọi api
         
      },
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
      popupDelete(){
          this.showPopup('Xoá nhân viên','Bạn có chắc muốn xoá nhân viên?',)
      },
      /* Xoá nhân viên đã chọn khi ấn nút xoá
      dvlong(2/8/2021) 
      */
      deleteEmployee(){
          let self = this;
          let index = 0;
          self.employeesToDelete.forEach((employeeIdDelete) =>{
              EmployeesAPI.delete(employeeIdDelete).then(res =>{
                index ++;
                if (index == self.employeesToDelete.length){
                    self.loadData();
                    self.showToast('Xoá thành công!','success-toast');
                    self.employeesToDelete=[];
                    
                }
                console.log(res);
          }).catch(res =>{
              console.log(res);
              
          })
          })
          
      },
      //Hiện toast
      showToast(content,type){
          this.contentToast =content;
          this.typeToast = type;
          var self = this;
          self.isShowToast = true;
            setTimeout(function(){
                self.isShowToast = false;
            }, 3000);
            
      },
      //Hiện popup thông báo
        showPopup(title,content,type){
            this.isShowPopup = !this.isShowPopup ;
            this.titlePopup = title;
            this.contentPopup =content;
            this.typePopup = type;
        },
        
        //xác nhận popup thông báo
        confirmPopup(){
            this.showPopup();
            this.deleteEmployee();
        }

  },
  data(){
      
      return{
          isShowButtonDelete:false,
          employeesToDelete:[],
          typeSubmitForm:true,
          employeeId :'',
          newCode: '',
          isShowForm : false,
          employees:[],
          isShowToast:false,
          typeToast:'',
          contentToast:'',
          isShowPopup: false,
          typePopup:'',
          titlePopup:'',
          contentPopup:'',
      }
  },
  watch:{
      employeesToDelete: function(){
          if(this.employeesToDelete.length != 0){
              this.isShowButtonDelete = true;
          }
          else{
              this.isShowButtonDelete = false;
          }
      },
      isShowForm:function(){
          if(!this.isShowForm){
              this.employeeId = '';
          }
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