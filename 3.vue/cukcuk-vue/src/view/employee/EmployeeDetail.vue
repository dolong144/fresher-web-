<template>
    <div class="cover-form" >
        <div class="form">
            <div class="head-form">
                <div class="title">
                    <b>THÔNG TIN NHÂN VIÊN</b>
                </div>
                <div class="close-button" @click="showPopupInForm"></div>
            </div>
            <div class="body">
                <div class="image">
                    <div class="avatar"></div>
                    <div class="require">(Vui lòng chọn ảnh có định dạng .jpg,.jpeg,.png,.gif.)</div>
                </div>
                <div class="form-boby">
                    <div class="modal">
                        <div class="title-modal">
                            <b>A. THÔNG TIN CHUNG:</b> 
                            <div class="underline"></div>
                        </div>
                        <div class="row">
                            <div class="input-field input-binding" id="employeeCode">
                                <Tooltip></Tooltip>
                                <div class="title-input" >Mã nhân viên(<span class="binding">*</span>)</div>
                                <input type="text" class="input-box" id="txtEmployeeCode" v-model="employee.EmployeeCode" autofocus
                                    placeholder="MF953">
                            </div>
                            <div class="input-field input-binding" id="employeeName" >
                                <Tooltip></Tooltip>
                                <div class="title-input" >Họ và tên(<span class="binding">*</span>)</div>
                                <input type="text" class="input-box" id="txtFullName" v-model="employee.FullName" 
                                placeholder="Đỗ Văn Long">
                            </div>
                        </div>
                        <div class="row">
                            <div class="input-field">
                                <div class="title-input">Ngày sinh</div>
                                <input type="date" class="input-box" id="txtDateOfBirth" v-model="employee.DateOfBirth" >
                            </div>
                            <div class="input-field">
                                <div class="title-input" >Giới tính</div>
                                <BaseDropdown ref="Gender"
                                    :value="employee.GenderCode"
                                    id="dropdown__gender"
                                    title="Giới tính"
                                    type="Gender"
                                    @setSelection="setSelection"
                                />
                            </div>
                        </div>
                        <div class="row">
                            <div class="input-field input-binding" id="employeeIdentity">
                                <Tooltip></Tooltip>
                                <div class="title-input" >Số CMTND/Căn cước(<span class="binding">*</span>)</div>
                                <input type="text" class="input-box" id="txtIdentityNumber" v-model="employee.IdentityNumber"
                                placeholder="001200012345">
                            </div>
                            <div class="input-field">
                                <div class="title-input">Ngày cấp</div>
                                <input type="date" class="input-box" id="txtIdentityDate" v-model="employee.IdentityDate">
                            </div>
                        </div>
                        <div class="row">
                            <div class="input-field">
                                <div class="title-input">Nơi cấp</div>
                                <input type="text" class="input-box" id="txtIdentityPlace" v-model="employee.IdentityPlace"
                                placeholder="Hà Nội">
                            </div>
                        </div>
                        <div class="row">
                            <div class="input-field input-binding" id="employeeEmail">
                                <Tooltip></Tooltip>
                                <div class="title-input">Email(<span class="binding">*</span>)</div>
                                <input type="email" class="input-box" id="txtEmail" v-model="employee.Email" placeholder="Example@gmail.com">
                            </div>
                            <div class="input-field input-binding" id="employeePhone">
                                <Tooltip></Tooltip>
                                <div class="title-input">Số điện thoại(<span class="binding">*</span>)</div>
                                <input type="tel" class="input-box" id="txtPhoneNumber" v-model="employee.PhoneNumber" placeholder="012345678">
                            </div>
                        </div>
                        
                    </div>
                    <div class="modal">
                        <div class="title-modal">
                            <b>B. THÔNG TIN CÔNG VIỆC:</b>
                            <div class="underline"></div>
                        </div>
                        <div class="row">
                            <div class="input-field">
                                <div class="title-input">Vị trí</div>
                                <BaseDropdown ref="Position"
                                    :value="employee.PositionId"
                                    id="dropdown__position"
                                    title="Tất cả vị trí"
                                    type="Position"
                                    @setSelection="setSelection"
                                />
                            </div>
                            <div class="input-field">
                                <div class="title-input" >Phòng ban</div>
                            
                                <BaseDropdown ref="Department"
                                    :value="employee.DepartmentId"
                                    id="dropdown__department"
                                    title="Tất cả phòng ban"
                                    type="Department"
                                    @setSelection="setSelection"
                                />  
                            </div>
                        </div>
                        <div class="row">
                            <div class="input-field">
                                <div class="title-input" >Mã số thuế cá nhân</div>
                                <input type="number" class="input-box" id="txtPersonalTaxCode" v-model="employee.PersonalTaxCode" placeholder="0012983173">
                            </div>
                            <div class="input-field">
                                <div class="title-input" >Lương cơ bản</div>
                                <input type="text" class="input-box" id="txtSalary" v-model="employee.Salary" placeholder="12.809.374">
                            </div>
                        </div>
                        <div class="row">
                            <div class="input-field">
                                <div class="title-input">Ngày gia nhập công ty</div>
                                <input type="date" class="input-box" id="txtJoinDate" v-model="employee.JoinDate">
                            </div>
                            <div class="input-field">
                                <div class="title-input">Tình trạng công việc</div>
                                <BaseDropdown ref="WorkStatus"
                                    :value="employee.GenderCode"
                                    id="dropdown__work__status"
                                    title="Tình trạng công việc"
                                    type="WorkStatus"
                                    @setSelection="setSelection"
                                />
                            </div>
                        </div>
                        <div class="row"></div>
                    </div>
                </div>
            </div>
            <div class="footer-form">
                <div class="cancle button" @click="showPopupInForm">Huỷ</div>
                <div class="save button" @click="submitForm">
                    <div class="icon-button">
                        <i class="fas fal fa-save"></i>
                    </div>
                    Lưu
                </div>
            </div>
            
        </div>
        
        
    </div>
</template>
<script>


import Format from "../../utils/Format.js"
import EmployeesAPI from "@/api/components/EmployeesAPI";
import Tooltip from "../../components/base/BaseTooltip.vue"
export default {
    components:{
        Tooltip
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
                PositionId:'',
                Salary:'',
            },
            
            
        }
    },
    mounted(){
        
    },
    methods:{
        //đặt lại employeeId theo option đã chọn
        setSelection(ref,id){
            this.$refs[`${ref}`].value =id;
            this.employee[`${ref}Id`] = id;
        },
        //Đóng form nhập nhân viên
        closeForm(){
            this.employee = {};
            this.$emit('showForm');
            
        },
        //Hiện thoong báo xác nhận xác nhận
        showPopupInForm(){
            this.$emit('showPopup','Bỏ thông tin đang nhập','Bạn có chắc muốn bỏ thông tin đang nhập?','confirm-popup');
        },
        
        //Ấn lưu thông tin nhân viên
        submitForm(){
            let self = this;
            //thêm mới nhân viên
            if(self.typeSubmitForm){
                EmployeesAPI.add(self.employee).then(res=>{
                    console.log(res);
                    self.$emit('showToast','Thêm nhân viên thành công!','success-toast');
                    self.closeForm();
                    self.$emit('loadData');
                }).catch(res=>{
                    console.log(res);
                    self.$emit('showToast','Có lỗi xảy ra!','error-toast');
                    self.closeForm();
                })
            }
            //Sửa 1 nhân viên
            else{
                EmployeesAPI.update(self.employeeId,self.employee).then(res=>{
                    console.log(res);
                    self.$emit('showToast','Sửa nhân viên thành công!','success-toast');
                    self.closeForm();
                    self.$emit('loadData');
                }).catch(res=>{
                    console.log(res);
                    self.$emit('showToast','Có lỗi xảy ra!','error-toast');
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

