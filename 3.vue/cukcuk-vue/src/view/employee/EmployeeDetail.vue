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
                                <input type="text" class="input-box" id="txtFullName" v-model="employee.EmployeeName" >
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
                                <input type="text" class="input-box" id="txtIdentityPlace" v-model="employee.IdentityNumber">
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
                                <div class="combo-box" id="txtPositionCode">
                                    <div class="select-button">
                                        <div class="title" >Vị trí</div>
                                        <div class="icon-button">
                                            <i class="fas fa-solid fa-chevron-down"></i>
                                        </div>
                                    </div>
                                    <div class="option">
                                    </div>
                                </div>
                            </div>
                            <div class="input-field">
                                <div class="title-input" >Phòng ban</div>
                                <div class="combo-box" id="txtDepartmentCode">
                                    <div class="select-button">
                                        
                                        <div class="title" >Phòng ban</div>
                                        <div class="icon-button">
                                            <i class="fas fa-solid fa-chevron-down"></i>
                                        </div>
                                    </div>
                                    <div class="option">
                                        
                                    </div>
                                </div>
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
                <div class="save button">
                    <div class="icon-button">
                        
                    </div>
                    Lưu</div>
            </div>
            
        </div>
        <popup :class="{'showPopup':isShowPopup}" :isShowPopup="isShowPopup" @showPopup="showPopup" @closeForm="closeForm" />
    </div>
</template>
<script>
import popup from "../../components/base/BasePopup.vue"
import axios from "axios";

export default {
    components:{
        popup
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
        }
    },
    data() {
        return {
            employee:{},
            isShowPopup: false,
            
        }
    },
    methods:{
        closeForm(){
            this.$emit('btnAdd');
        },
        showPopup(){
            this.isShowPopup = !this.isShowPopup ;
        }
    },
    watch: { 
        employeeId(){
            let self = this;
            
            axios.get("http://cukcuk.manhnv.net/v1/Employees/" + self.employeeId).then(res=>{
                
                self.employee = res.data;
                
            }).catch(res=>{
                console.log(res);
            })
        }
    }
    
}
</script>
<style scoped>
    @import url('../../css/layout/form.css');
    @import url('../../css/main.css');
    @import url('../../css/base/button.css');
    @import url('../../css/base/popup.css');
    @import url('../../css/base/textbox.css');
    @import url('../../css/base/toast.css');
    @import url('../../css/base/tooltip.css');
    .showForm{
        display: block;
    }
    .showPopup{
        display: block;
    }
    
</style>

