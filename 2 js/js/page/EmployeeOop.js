$(document).ready(function(){
    var typeSubmitForm = 0;
    var employeeId = null;
    employeePage = new page();
})
class page{
    constructor(){
        //Load dữ liệu
        this.loadData();
        // load các vịt trí công việc
        this.loadDepartment();
        //load các phòng ban
        this.loadPosition();
        //khởi tạo các sựu kiện cho các thành phần
        this.initEvents();
    }
    //các sự kiện
    initEvents(){
        var self = this;
        // mở form nhập nhân viên
        $(".content .nav .add-button").click(function(){
            this.typeSubmitForm = 1;
            $("#txtEmployeeCode").focus();
            $(".cover-form").show();
            $(".form").show();
            try {
                $.ajax({
                    url:'http://cukcuk.manhnv.net/v1/Employees/NewEmployeeCode',
                    method: 'GET',
                    async:false,
                }).done(res=>{
                    $("#txtEmployeeCode").val(res);
                    $("#txtEmployeeCode").focus();
                }).fail(res=>{
                    console.log(res);
        
                })
            } catch (error) {
                console.log(error);
            }
            
        })
        //chọn menu
        $(".menu-item").click(function(){
            $(".menu .menu-item").removeClass("active");
            $(this).addClass("active");
        })
        //chọn trang
        $(".content .footer .page .page-number").click(function(){
            $(".content .footer .page .page-number").removeClass("active");
            $(this).addClass("active");
        })
        //Đong form
        // click vào dấu đóng form
        $(".form .head-form .close-button").click(function(){
            showPopup("confirm-popup",'Đóng form','Bạn có chắc muốn bỏ dữ liệu đã nhập?');
            $(".confirm-popup .footer-popup .button-yes").click(function(){
                hidenPopup();
                resetForm();
                closeForm();
            })
            
        });
        //clisck vào nút huỷ
        $(".form .footer-form .cancle").click(function(){
            showPopup("confirm-popup",'Đóng form','Bạn có chắc muốn bỏ dữ liệu đã nhập?');
            $(".confirm-popup .footer-popup .button-yes").click(function(){
                hidenPopup();
                resetForm();
                closeForm();
            })
        });
        // đong form khi click ra ngoài form
        $(window).click(function(event){
            if($(".cover-form").css('display') === 'none'){
                return;
            }
            else {
                if(event.target.matches(".cover-form")){
                    closeForm();
                }
                
            }
        });
        // click lưu thông tin
        $(".form .footer-form").on('click','.save',function(){
            self.addData(this);
        });
        // double click để sửa thông tin nhân viên
        $("#detailEmployee tbody").on('dblclick','tr',function(){
            self.editData(this);
        });

        //các trường nhập bắt buộc
        $("#employeeCode .input-box").blur(validataInput)
        $("#employeeName .input-box").blur(validataInput)
        $("#employeeIdentity .input-box").blur(validataInput)
        $("#employeePhone .input-box").blur(validataInput);
        //validate dữ liệu nhập
        function validataInput(){
            let value = $(this).val();
            
            if(value == ''){
                $(this).addClass("error");
                $(this).attr('title','thông tin này chưa nhập');
            }
            else{
                $(this).removeClass("error");
                $(this).removeAttr('title');
            }
        }
        //validate email 
        $("#employeeEmail .input-box").blur(function(e) {
            
            let email_address = $(this).val(); 
            let email_regex = /^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[ a-zA-Z]{2,4}$/i;
            if(email_address == ''){
                $(this).addClass("error");
                $(this).attr('title','thông tin này chưa nhập');
            }
            else if(!email_regex.test(email_address)){
                $(this).addClass("error");
                $(this).attr('title','sai định dạng email');
            } else{
                $(this).removeClass("error");
                $(this).removeAttr('title');
            }

        }); 
        // chọn 1 hàng thông tin muốn xoá
        $("#detailEmployee tbody").on('click','tr',function(){
            $(this).addClass("selected-to-delete");
            $(".selected-to-delete input").attr("checked","checked");
        })
        //huỷ chọn 
        $("#detailEmployee tbody").on('click','.selected-to-delete',function(){
            $('.selected-to-delete input').removeAttr('checked');
            $(this).removeClass("selected-to-delete");
            $(".selected-to-delete input").attr("checked","checked");
        })
        // Xoá nhân viên
        $(".content .nav .delete-button").click(function(){

            // xác nhận lại
            if($("table tbody .selected-to-delete").length == 0){
                showPopup('notify-popup','Chưa chọn đối tượng!','Bạn chưa chọn bản ghi nào!');

                $(".popup-container .notify-popup .footer-popup .button-yes").click(hidenPopup);
            }
            else{
                showPopup('alert-popup','Xoá nhân viên','Bạn có chắc muốn xoá bản ghi?');
                // nhân viên
                $(".popup-container .popup .button-yes").click(function(){
                    self.deleteData();
                    hidenPopup();
                })
            }
            console.log($(".popup-container .notify-popup .footer-popup .button-yes"));
            // debugger;
        });

        // ẩn popup
        

        
        $(".popup-container .popup .close-button").click(function(){
            hidenPopup();
        })
        $(".popup-container .popup .button-cancle").click(function(){
            hidenPopup();
        })


        

        //đóng toast
        $(".toast_container .toast_close").click(function(){
            hidenToast();
        });


        //this.addData();

    }
    //load thông tin nhân viên
    //dvlong(26/7/2021)
    loadData(){
        $("tbody").empty();
        // lấy dữ liệu
        try {
            $.ajax({
                url:"http://cukcuk.manhnv.net/v1/Employees",
                method:"GET",
                async:false,
            }).done(function(res){
                var data = res;
                //hiển thị dữ liệu lên từng row
                $.each(data, function(index, item){
                    var tr = $(`<tr id="`+ checkData(item.EmployeeId)+`">
                        <td class="check-box-delete"><input type="checkbox"></input></td>
                        <td>`+ checkData(item.EmployeeCode) +`</td>
                        <td>`+ checkData(item.FullName) +`</td>
                        <td>`+ checkData(item.GenderName) +`</td>
                        <td>`+ dobFormat(checkData(item.DateOfBirth)) + `</td>
                        <td>`+ checkData(item.PhoneNumber) +`</td>
                        <td>`+ checkData(item.Email) +`</td>
                        <td>`+ checkData(item.PositionName) +`</td>
                        <td>`+ checkData(item.DepartmentName) +`</td>
                        <td>`+ currencyFormatter(item.Salary) +`</td>
                        <td>`+ checkData(item.WorkStatus) +`</td>
                    </tr>`);
                    if(!item.EmployeeCode) {}
                $('table tbody').append(tr);
        
                }) 
            }).fail(function(res){
                showToast('error-toast','Load thông tin bị lỗi!');
            })
        } catch (error) {
            console.log(error);
        }
    }

    
    //thêm dữ liệu
    //dvlong(26/7/2021)
    addData(self){
        let employee = {};
        let url = 'http://cukcuk.manhnv.net/v1/Employees/';
        let method = "POST";
        if(this.typeSubmitForm == 2){
            url = `http://cukcuk.manhnv.net/v1/Employees/${this.employeeId}`;
            method = "PUT";
        }
        // check lại dữ liệu
        let checkInput = $(".input-binding .input-box");
        $.each(checkInput,function(index,item) {
            let value = $(item).val();
            if(value == ''){
                $(item).addClass("error");
                $(item).attr('title','thông tin này chưa nhập');
            }
            else{
                $(item).removeClass("error");
                $(item).removeAttr('title');
            }
        });
        
        // //check lại mail

        let email_address = $("#txtEmail").val(); 
        let email_regex = /^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[ a-zA-Z]{2,4}$/i;
        if(email_address == ''){
            $("#txtEmail").addClass("error");
            $("#txtEmail").attr('title','thông tin này chưa nhập');
        }
        else if(!email_regex.test(email_address)){
            $("#txtEmail").addClass("error");
            $("#txtEmail").attr('title','sai định dạng email');
        } else{
            $("#txtEmail").removeClass("error");
            $("#txtEmail").removeAttr('title');
        }
        
        // check xem có trường lỗi thì thông báo

        if($(".error").length != 0){
            // console.log($(".error"));
            showToast('error-toast','Vui lòng xem lại thông tin!');
            return;
        }


        employee.FullName = $("#txtFullName").val();
        employee.EmployeeCode= $("#txtEmployeeCode").val();
        employee.IdentityNumber = $("#txtIdentityNumber").val();
        employee.Gender = $("#txtGenderCode .option .active").attr("code");
        employee.PhoneNumber = $("#txtPhoneNumber").val();
        employee.DepartmentId = $("#txtDepartmentCode .option .active").attr("code");
        employee.PositionId = $("#txtPositionCode .option .active").attr("code");
        employee.IdentityDate = $("#txtIdentityDate").val();
        employee.IdentityPlace = $("#txtIdentityPlace").val();
        employee.Email = $("#txtEmail").val();
        employee.JoinDate = $("#txtJoinDate").val();
        employee.PersonalTaxCode = $("#txtPersonalTaxCode").val();
        employee.Salary = $("#txtSalary").val();
        employee.DateOfBirth = $("#txtDateOfBirth").val();
        //employee.WorkStatus = $("#txtWorkStatus").text();
    
        //gọi api lưu dữ liệu

        try {
            $.ajax({
                url: url,
                method: method,
                data: JSON.stringify(employee),
                dataType: 'json',
                contentType: 'application/json',
                async: false,
            }).done(res =>{
                showToast('success-toast','Thêm nhân viên thành công!');
                this.typeSubmitForm = 0;
                self.employeeId = '';
                this.loadData();
                resetForm();
                closeForm();
                return;
            }).fail(res =>{
                showToast('error-toast','Có lỗi xảy ra!');
            })
        } catch (error) {
            console.log(error);
        }
    
        
    
    }
    //sửa dữ liệu
    //dvlong(26/7/2021)
    editData(self){
        resetForm();
        this.typeSubmitForm = 2;
        this.employeeId = checkData($(self).attr("id"));
        $(".cover-form").show();
        $(".form").show();
        try {
            $.ajax({
                url:`http://cukcuk.manhnv.net/v1/Employees/`+ this.employeeId,
                method:"GET",
                async:false,
            }).done(res=>{
                //dữ liệu của input
                $("#txtFullName").val(res.FullName);
                $("#txtEmployeeCode").val(res.EmployeeCode);
                $("#txtIdentityNumber").val(res.IdentityNumber);
                $("#txtPhoneNumber").val(res.PhoneNumber);
                $("#txtIdentityDate").val(dobFormatToForm(res.IdentityDate));
                $("#txtIdentityPlace").val(res.IdentityPlace);
                $("#txtEmail").val(res.Email);
                $("#txtJoinDate").val(dobFormatToForm(res.JoinDate));
                $("#txtPersonalTaxCode").val(res.PersonalTaxCode);
                $("#txtSalary").val(res.Salary);
                $("#txtDateOfBirth").val(dobFormatToForm(checkData(res.DateOfBirth)));
                // dữ liệu của dropdown
                var departmentOptions = $("#txtDepartmentCode .option .value");
                $.each(departmentOptions,function(index,departmentOption){
                    if ($(departmentOption).attr('code') == res.DepartmentId){
                        $("#txtDepartmentCode .option .value").removeClass('active');
                        $(departmentOption).addClass('active');
                        $("#txtDepartmentCode .title").text($(departmentOption).text());
                        
                    }
                })
                var positionOptions = $("#txtPositionCode .option .value");
                $.each(positionOptions,function(index,positionOption){
                    if ($(positionOption).attr('code') == res.PositionId){
                        $("#txtPositionCode .option .value").removeClass('active');
                        $(positionOption).addClass('active');
                        $("#txtPositionCode .title").text($(positionOption).text());
                        
                    }
                })
                var genderOptions = $("#txtGenderCode .option .value");
                $.each(genderOptions,function(index,genderOption){
                    if ($(genderOption).attr('code') == res.Gender){
                        $("#txtGenderCode .option .value").removeClass('active');
                        $(genderOption).addClass('active');
                        $("#txtGenderCode .title").text($(genderOption).text());
                        
                    }
                })
                
            }).fail(res=>{
                showToast('error-toast','Có lỗi xảy ra!');
            })
            
        } catch (error) {
            console.log(error);
        }
    }
    //xoá dữ liệu
    //dvlong(26/7/2021)
    deleteData(){
        var arrDelete = $("table tbody .selected-to-delete");
        $.each(arrDelete,function(index, item){
            this.EmployeeId = $(item).attr('id');
            try {
                $.ajax({
                    url:'http://cukcuk.manhnv.net/v1/Employees/' + this.EmployeeId,
                    method:'DELETE',
                    async: false,
                }).done(function(res){
                    showToast('success-toast','Đã xoá nhân viên!');
    
                }).fail(function(res){
                    console.log(res);
                })
            } catch (error) {
                console.log(error);
            }
        })
        this.loadData();

    }
    //load vị trí
    //DVLong(22/7/2021)
    loadPosition(){
        // lấy dữ liệu vị trí
        try {
            $.ajax({
                url:"http://cukcuk.manhnv.net/v1/Positions",
                method:"GET",
                async: false,
            }).done(function(res){
                var data = res;
                //hiển thị dữ liệu vị trí
                $.each(data, function(index, item){
                    var selected = `<div class="value" code="`+ checkData(item.PositionId) +`"><div class="icon-active">
                                        <i class="fas fa-solid fa-check"></i>
                                        </div>
                                        <div>` +checkData(item.PositionName)+ `</div></div>`;
                    if(!item.EmployeeCode) {}
                $('#position .option').append(selected);
                $('#txtPositionCode .option').append(selected);
        
                }) 
            }).fail(function(res){
                showToast('error-toast','Có lỗi xảy ra!');
            })
        } catch (error) {
            console.log(error);
        }
    }
    //load phòng ban
    //DVLong(22/7/2021)
    loadDepartment(){
        // lấy dữ liệu phòng ban
        try {
            $.ajax({
                url:"http://cukcuk.manhnv.net/api/Department",
                method:"GET",
                async:false,
            }).done(function(res){
                var data = res;
                //hiển thị dữ liệu phòng ban
                $.each(data, function(index, item){
                                                
                    var depaertment = `<div class="value" code="`+ checkData(item.DepartmentId) +`"><div class="icon-active">
                                            <i class="fas fa-solid fa-check"></i>
                                            </div>
                                            <div>` +checkData(item.DepartmentName)+ `</div></div>`;
                    if(!item.EmployeeCode) {}
                $('#department .option').append(depaertment);
                $('#txtDepartmentCode .option').append(depaertment);
        
                }) 
            }).fail(function(res){
                showErrorToast();
            })
        } catch (error) {
            console.log(error);
        }
    }
    //lọc nhân viên theo phòng ban, vị trí
    filterData(self){
        

    }

}   