<template>
    <div class="cover-form" >
        <div class="form">
            <div class="head-form">
                <div class="title">
                    <b>THÔNG TIN NHÂN VIÊN</b>
                </div>
                <div class="close-button" @click="showPopup('Bỏ thông tin đang nhập','Bạn có chắc muốn bỏ thông tin đang nhập?','confirm-popup')"></div>
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
                                <Tooltip ref="tooltip"  v-show="arrTooltip[0]"></Tooltip>
                                <div class="title-input" >Mã nhân viên(<span class="binding">*</span>)</div>
                                <input type="text" class="input-box" ref="inputBinding0" v-model="employee.EmployeeCode" autofocus
                                    placeholder="MF953">
                            </div>
                            <div class="input-field input-binding" name="employeeName" >
                                <Tooltip ref="tooltip" v-show="arrTooltip[1]"></Tooltip>
                                <div class="title-input" >Họ và tên(<span class="binding">*</span>)</div>
                                <input type="text" class="input-box" ref="inputBinding1" v-model="employee.FullName" 
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
                                    :value="employee.Gender"
                                    id="dropdown__gender"
                                    title="Giới tính"
                                    type="Gender"
                                    @setSelection="setSelection"
                                />
                            </div>
                        </div>
                        <div class="row">
                            <div class="input-field input-binding" id="employeeIdentity">
                                <Tooltip ref="tooltip" v-show="arrTooltip[2]" ></Tooltip>
                                <div class="title-input" >Số CMTND/Căn cước(<span class="binding">*</span>)</div>
                                <input type="text" class="input-box" ref="inputBinding2" v-model="employee.IdentityNumber"
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
                                <Tooltip ref="tooltip" v-show="arrTooltip[3]"></Tooltip>
                                <div class="title-input">Email(<span class="binding">*</span>)</div>
                                <input type="email" class="input-box" ref="inputBinding3" v-model="employee.Email" placeholder="Example@gmail.com">
                            </div>
                            <div class="input-field input-binding" id="employeePhone">
                                <Tooltip ref="tooltip" v-show="arrTooltip[4]"></Tooltip>
                                <div class="title-input">Số điện thoại(<span class="binding">*</span>)</div>
                                <input type="tel" class="input-box" ref="inputBinding4" v-model="employee.PhoneNumber" placeholder="012345678">
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
                                    :value="employee.WorkStatus"
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
                <div class="cancle button" @click="showPopup('Bỏ thông tin đang nhập','Bạn có chắc muốn bỏ thông tin đang nhập?','confirm-popup')">Huỷ</div>
                <div class="save button-icon" @click="submitForm">
                    <div class="icon-button">
                        <i class="fas fal fa-save"></i>
                    </div>
                    Lưu
                </div>
            </div>
            
        </div>
        <popup  :class="{'showPopup':isShowPopup}" 
                :isShowPopup="isShowPopup" 
                :titlePopup="titlePopup"
                :typePopup="typePopup"
                :contentPopup="contentPopup"
                @hidePopup="showPopup" 
                @confirmPopup="confirmPopup"/>
        
    </div>
</template>
<script>


import Format from "../../utils/Format.js"
import EmployeesAPI from "@/api/components/EmployeesAPI";
import Tooltip from "../../components/base/BaseTooltip.vue"
import popup from "../../components/base/BasePopup.vue"
export default {
    components:{
        Tooltip,popup
    },
    created(){
        

    },
    props:{
        isShowForm:{
            type: Boolean,
            default: false,
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
                FullName:'',
                Email:'',
                PhoneNumber:'',
                DepartmentId:'',
                PositionId:'',
                Salary:'',
            },
            isShowPopup:false,
            titlePopup:'',
            typePopup:'',
            contentPopup:'',
            arrTooltip: [false,false,false,false,false],
            
            
        }
    },
    mounted(){
        
    },
    methods:{
        // showPopup(){
        //     this.isShowPopup = !this.isShowPopup;
        // },
        //đặt lại employeeId theo option đã chọn
        setSelection(ref,id){
            this.$refs[`${ref}`].value =id;
            this.employee[`${ref}Id`] = id;
        },
        //Đóng form nhập nhân viên
        closeForm(){
            this.$emit('resetNewCode')
            this.$emit('showForm');
            this.resetForm();
        },
        //Hiện popup xác nhận
        showPopup(title,content,type){
            this.isShowPopup = !this.isShowPopup ;
            this.titlePopup = title;
            this.contentPopup =content;
            this.typePopup = type;
        },
        confirmPopup(){
            this.showPopup();
            this.closeForm();
        },
        
        
        //Ấn lưu thông tin nhân viên
        submitForm(){
            //validate dữ liệu
           if(this.employee.EmployeeCode == ""){
               this.arrTooltip[0] = true;
           }
           if(this.employee.FullName == ""){
               this.arrTooltip[1] = true;
               return;
           }
           if(this.employee.IdentityNumber == ""){
               this.arrTooltip[2] = true;
           }
           if(this.employee.Email == ""){
               this.arrTooltip[3] = true;
           }
           if(this.employee.PhoneNumber == ""){
               this.arrTooltip[4] = true;
           }
            
            
            

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
                    // self.closeForm();
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
                    // self.closeForm();
                })
            }
            
        },
        //reset form
        resetForm(){
            this.employee = {
                EmployeeCode: this.newCode,
                DepartmentId:'',
                PositionId:'',
                Salary:'',
            };

        }
        
        
    },
    watch: { 
        employeeId(){
            let self = this;
            /* Lấy dữ liệu nhân viên theo mã và hiển thị lên form
            dvlong(2/8/2021)
            */
            if (self.employeeId != ''){
                EmployeesAPI.getById(self.employeeId).then(res=>{
                self.employee = JSON.parse(JSON.stringify(res.data));

                // format các dữ liệu cần thay đổi
                self.employee.DateOfBirth = Format.dobFormatToForm(self.employee.DateOfBirth)
                self.employee.IdentityDate = Format.dobFormatToForm(self.employee.IdentityDate)
                self.employee.JoinDate = Format.dobFormatToForm(self.employee.JoinDate)
                self.employee.Salary = Format.currencyFormatter(self.employee.Salary)
                
            }).catch(res=>{ 
                console.log(res);
                
            })
            }
        },
        /* gán EmployeeCode bằng mã code mới
        dvlong(31/7/2021)
         */
        isShowForm: function(){
            if(this.typeSubmitForm && this.isShowForm){
                
                this.employee.EmployeeCode = this.newCode;
            }
            
        },
        

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
    .show{
        display: block !important;
    }
    
</style>

