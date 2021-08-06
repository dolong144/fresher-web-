<template>
    <div class="cover-form" >
        <div class="form">
            <div class="head-form">
                <div class="title">
                    <b>THÔNG TIN NHÂN VIÊN</b>
                </div>
                <div class="close-button" @click="showPopup"></div>
            </div>
            <div class="body">
                <div class="image">
                    <div class="avatar"></div>
                    <div class="require">(Vui lòng chọn ảnh có định dạng .jpg,.jpeg,.png,.gif.)</div>
                </div>
                <div class="form-boby">
                    <div class="modal">
                        <div class="title">
                            <b>A. THÔNG TIN CHUNG:</b>
                        </div>
                        <div class="row">
                            <div class="input-field input-binding" id="employeeCode">
                                <div class="tooltip-alert">Thông tin bắt buộc!</div>
                                <div class="title-input" >Mã nhân viên(<span class="binding">*</span>)</div>
                                <input type="text" class="input-box" id="txtEmployeeCode" v-model="employee.EmployeeCode">
                            </div>
                            <div class="input-field input-binding" id="employeeName" >
                                <div class="tooltip-alert">Thông tin bắt buộc!</div>
                                <div class="title-input" >Họ và tên(<span class="binding">*</span>)</div>
                                <input type="text" class="input-box" id="txtFullName" v-model="employee.FullName" >
                            </div>
                        </div>
                        <div class="row">
                            <div class="input-field">
                                <div class="title-input">Ngày sinh</div>
                                <input type="date" class="input-box" id="txtDateOfBirth" v-model="employee.DateOfBirth" >
                            </div>
                            <div class="input-field">
                                <div class="title-input" >Giới tính</div>
                                <div class="combo-box" id="txtGenderCode">
                                    <div class="select-button">
                                        <div class="title" >Giới tính</div>
                                        <div class="icon-button">
                                            <i class="fas fa-solid fa-chevron-down"></i>
                                        </div>
                                    </div>
                                    <div class="option">
                                        <div class="value" code = "1">
                                            <div class="icon-active">
                                                <i class="fas fa-solid fa-check"></i>
                                            </div>
                                            <div>Nam</div>
                                        </div>
                                        <div class="value" code = "0">
                                            <div class="icon-active">
                                                <i class="fas fa-solid fa-check"></i>
                                            </div>
                                            <div>Nữ</div>
                                        </div>
                                        <div class="value" code ="2">
                                            <div class="icon-active">
                                                <i class="fas fa-solid fa-check"></i>
                                            </div>
                                            <div>Không xác định</div>
                                        </div>
                                        
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="input-field input-binding" id="employeeIdentity">
                                <div class="tooltip-alert">Thông tin bắt buộc!</div>
                                <div class="title-input" >Số CMTND/Căn cước(<span class="binding">*</span>)</div>
                                <input type="text" class="input-box" id="txtIdentityNumber" v-model="employee.IdentityNumber">
                            </div>
                            <div class="input-field">
                                <div class="title-input">Ngày cấp</div>
                                <input type="date" class="input-box" id="txtIdentityDate" v-model="employee.IdentityDate">
                            </div>
                        </div>
                        <div class="row">
                            <div class="input-field">
                                <div class="title-input">Nơi cấp</div>
                                <input type="text" class="input-box" id="txtIdentityPlace" v-model="employee.IdentityPlace">
                            </div>
                        </div>
                        <div class="row">
                            <div class="input-field input-binding" id="employeeEmail">
                                <div class="tooltip-alert">Thông tin bắt buộc!</div>
                                <div class="title-input">Email(<span class="binding">*</span>)</div>
                                <input type="email" class="input-box" id="txtEmail" v-model="employee.Email">
                            </div>
                            <div class="input-field input-binding" id="employeePhone">
                                <div class="tooltip-alert">Thông tin bắt buộc!</div>
                                <div class="title-input">Số điện thoại(<span class="binding">*</span>)</div>
                                <input type="tel" class="input-box" id="txtPhoneNumber" v-model="employee.PhoneNumber">
                            </div>
                        </div>
                        
                    </div>
                    <div class="modal">
                        <div class="title">
                            <b>B. THÔNG TIN CÔNG VIỆC:</b>
                        </div>
                        <div class="row">
                            <div class="input-field">
                                <div class="title-input">Vị trí</div>
                                <BaseDropdown
                                    :value="employee.PositionId"
                                    id="dropdown__position"
                                    title="Tất cả vị trí"
                                    type="Position"
                                />
                            </div>
                            <div class="input-field">
                                <div class="title-input" >Phòng ban</div>
                            
                                <BaseDropdown
                                    :value ="employee.DepartmentId"
                                    id="dropdown__department"
                                    title="Tất cả phòng ban"
                                    type="Department"
                                />
                                    
                                
                            </div>
                        </div>
                        <div class="row">
                            <div class="input-field">
                                <div class="title-input" >Mã số thuế cá nhân</div>
                                <input type="number" class="input-box" id="txtPersonalTaxCode" v-model="employee.PersonalTaxCode">
                            </div>
                            <div class="input-field">
                                <div class="title-input" >Lương cơ bản</div>
                                <input type="text" class="input-box" id="txtSalary" v-model="employee.Salary">
                            </div>
                        </div>
                        <div class="row">
                            <div class="input-field">
                                <div class="title-input">Ngày gia nhập công ty</div>
                                <input type="date" class="input-box" id="txtJoinDate" v-model="employee.JoinDate">
                            </div>
                            <div class="input-field">
                                <div class="title-input">Tình trạng công việc</div>
                                <div class="combo-box">
                                    <div class="select-button">
                                        
                                        <div class="title" id="txtWorkStatus">Tình trạng công việc</div>
                                        <div class="icon-button">
                                            <i class="fas fa-solid fa-chevron-down"></i>
                                        </div>
                                    </div>
                                    <div class="option">
                                        <div class="value">
                                            <div class="icon-active">
                                                <i class="fas fa-solid fa-check"></i>
                                            </div>
                                            <div>Đang đi làm</div>
                                        </div>
                                        <div class="value">
                                            <div class="icon-active">
                                                <i class="fas fa-solid fa-check"></i>
                                            </div>
                                            <div>Đang nghỉ làm</div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="row"></div>
                    </div>
                </div>
            </div>
            <div class="footer-form">
                <div class="cancle button" @click="showPopup">Huỷ</div>
                <div class="save button" @click="submitForm">
                    <div class="icon-button">
                        
                    </div>
                    Lưu</div>
            </div>
            
        </div>
        <popup  :class="{'showPopup':isShowPopup}" 
                :isShowPopup="isShowPopup" 
                :titlePopup="titlePopup"
                :typePopup="typePopup"
                :contentPopup="contentPopup"
                @showPopup="showPopup" 
                @closeForm="closeForm" />
        <toast  :class="{'showToast':isShowToast}"
                :contentToast="contentToast"
                :typeToast="typeToast"/>
    </div>
</template>
<script>
import popup from "../../components/base/BasePopup.vue"
import toast from "../../components/base/BaseToast.vue"

import Format from "../../utils/Format.js"
import EmployeesAPI from "@/api/components/EmployeesAPI";
export default {
    components:{
        popup,toast
    },
    created(){
        

    },
    props:{
        isShowForm:{
            type: Boolean,
            // default: true,
            required: true,
        },
        employeeId:{
            type: String,
            default: '',
            required: true,
        },
        newCode:{
            type:String,
            required:false,
        },
        typeSubmitForm:{
            type:Boolean,
            required:true,
        }
    },
    data() {
        return {
            employee:{
                EmployeeCode: this.newCode,
                DepartmentId:'',
                PositionId:''
            },
            isShowPopup: false,
            typePopup:'',
            titlePopup:'',
            contentPopup:'',
            isShowToast:false,
            typeToast:'',
            contentToast:'',
        }
    },
    mounted(){
        
    },
    methods:{
        //Đóng form nhập nhân viên
        closeForm(){
            this.employee = {EmployeeCode:''};
            this.$emit('btnAdd');
            
        },
        //Hiện popup thông báo
        showPopup(){
            this.isShowPopup = !this.isShowPopup ;
            this.titlePopup ='Đóng form?';
            this.contentPopup ='Bạn có chắc muốn đóng form?';
            this.typePopup = 'confirm-popup';
        },
        //Ấn lưu thông tin nhân viên
        submitForm(){

            let self = this;
            //thêm mới nhân viên
            if(self.typeSubmitForm){
                EmployeesAPI.add(self.employee).then(res=>{
                    console.log(res);
                    alert("thêm thành công");
                    self.closeForm();
                }).catch(res=>{
                    console.log(res);
                    console.log("error")
                    self.closeForm();
                })
            }
            //Sửa 1 nhân viên
            else{
                EmployeesAPI.update(self.employeeId,self.employee).then(res=>{
                    console.log(res);
                    alert("sửa thành công");
                    self.closeForm();
                }).catch(res=>{
                    console.log(res);
                    console.log("error")
                    self.closeForm();
                })
            }
            
        },
        
        
    },
    watch: { 
        employeeId(){
            let self = this;
            /* Lấy dữ liệu nhân viên theo mã và hiển thị lên form
            dvlong(2/8/2021)
            */
            EmployeesAPI.getById(self.employeeId).then(res=>{
                
                self.employee = res.data;
                self.employee.DateOfBirth = Format.dobFormatToForm(self.employee.DateOfBirth)
                self.employee.IdentityDate = Format.dobFormatToForm(self.employee.IdentityDate)
                self.employee.JoinDate = Format.dobFormatToForm(self.employee.JoinDate)
                self.employee.Salary = Format.currencyFormatter(self.employee.Salary)
                
            }).catch(res=>{ 
                console.log(res);
                
            })
        },
        /* gán EmployeeCode bằng mã code mới
        dvlong(31/7/2021)
         */
        isShowForm: function(){
            if(this.typeSubmitForm){
                this.employee.EmployeeCode = this.newCode;
            }
            
        }
    }
}
</script>
<style scoped>
    @import url('../../assets/css/layout/form.css');
    @import url('../../assets/css/main.css');
    @import url('../../assets/css/base/button.css');
    @import url('../../assets/css/base/popup.css');
    @import url('../../assets/css/base/textbox.css');
    @import url('../../assets/css/base/toast.css');
    @import url('../../assets/css/base/tooltip.css');
    .showForm{
        display: block;
    }
    .showPopup{
        display: block;
    }
    .showToast{
        display: flex;
    }
    
</style>

