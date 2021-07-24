const formCover = $(".cover-form")
const footerNumber = $(".content .footer .page .page-number")
const form = $(".form")
var typeSubmitForm = 0;
var employeeId = null;

$(document).ready(function(){
    loadData();
    loadPosition();
    loadDepartment();
    
    //chọn menu
    $(".menu-item").click(function(){
        $(".menu .menu-item").removeClass("active");
        $(this).addClass("active");
    })
    //chọn trang
    footerNumber.click(function(){
        footerNumber.removeClass("active");
        $(this).addClass("active");
    })
    //mở form nhập nhân viên
    //DVLong(21/7/2021)
    $(".content .nav .button").click(function(){
        typeSubmitForm = 1;
        formCover.show();
        form.show();
        $.ajax({
            url:'http://cukcuk.manhnv.net/v1/Employees/NewEmployeeCode',
            method: 'GET',
            async:false,
        }).done(res=>{
            $("#txtEmployeeCode").val(res);
            $("#txtEmployeeCode").focus();
        }).fail(res=>{

        })
        
    })
    //sửa thông tin nhân viên
    //DVLong(23/7/2021)
    $("#detailEmployee tbody").on('dblclick','tr',function(){
        console.log(1);
        resetForm();
        typeSubmitForm = 2;
        employeeId = checkData($(this).attr("id"));
        formCover.show();
        form.show();
        try {
            $.ajax({
                url:`http://cukcuk.manhnv.net/v1/Employees/`+ employeeId,
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
                alert("có lỗi xảy ra!");
            })
            
        } catch (error) {
            console.log(error);
        }

    })
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
        
    //Đong form
    $(".form .head-form .close-button").click(function(){
        resetForm();
        closeForm();
    });
    $(".form .footer-form .cancle").click(function(){
        resetForm();
        closeForm();
    });
    // đong form khi click ra ngoài form
    $(window).click(function(event){
        if(formCover.css('display') === 'none'){
            return;
        }
        else {
            if(event.target.matches(".cover-form")){
                closeForm();
            }
            
        }
    });
    //lưu dữ liệu khi ấn lưu
    $(".form .footer-form").on('click','.save',function(event){
        let employee = {};
        let url = 'http://cukcuk.manhnv.net/v1/Employees/';
        let method = "POST";
        if(typeSubmitForm == 2){
            url = `http://cukcuk.manhnv.net/v1/Employees/${employeeId}`;
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
            alert("Dữ liệu sai");
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
                alert("làm tốt đấy! thêm được rồi");
                typeSubmitForm = 0;
                employeeId = '';
                loadData();
                resetForm();
                closeForm();
                return;
            }).fail(res =>{
                alert("có lỗi xảy ra! code lại đi");
            })
        } catch (error) {
            console.log(error);
        }
    
        
    });
    
    //button load lại dữ liệu
    $(".content .search .textbox-default ").click(function(){
        loadData();
    });
    

})
//load dữ liệu
//DVLong(21/7/2021)
function loadData(){
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
                var tr = $(`<tr id="`+checkData(item.EmployeeId)+`">
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
            alert("load data lỗi! F5 đi");
        })
    } catch (error) {
        console.log(error);
    }
};
function checkData(data){   

    return data ? data :``;
}
//load vị trí
//DVLong(22/7/2021)
function loadPosition(){
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
                var selected = `<div class="value" code="`+ checkData(item.PositionId) +`">` +checkData(item.PositionName)+ `</div>`;
                if(!item.EmployeeCode) {}
            $('#position .option').append(selected);
            $('#txtPositionCode .option').append(selected);
    
            }) 
        }).fail(function(res){
            alert("load data lỗi! F5 đi");
        })
    } catch (error) {
        console.log(error);
    }
}
//load phòng ban
//DVLong(22/7/2021)
function loadDepartment(){
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
                var depaertment = `<div class="value" code="`+ checkData(item.DepartmentId) +`">` +checkData(item.DepartmentName)+ `</div>`;
                if(!item.EmployeeCode) {}
            $('#department .option').append(depaertment);
            $('#txtDepartmentCode .option').append(depaertment);
    
            }) 
        }).fail(function(res){
            alert("load data lỗi! F5 đi");
        })
    } catch (error) {
        console.log(error);
    }
}

//ẩn form
function closeForm(){
    form.hide();
    formCover.hide();
}
//Hàm định dạng tiền tệ
//DVLong(23/7/2021)
function currencyFormatter(salary){
    
    let result = '';
    if (salary != null) {
        for (let i = String(salary).length; i > 0; i -= 3) {
            if (i > 3) {
                const number = String(salary).slice(i - 3, i);
                result += number.split('').reverse().join('') + '.';
            } else {
                const number = String(salary).slice(0, i);
                result += number.split('').reverse().join('');
            }
        }
        return result.split('').reverse().join('');
    } else {
        return '';
    }
}
//Hàm ngăn chặn các ký tự ngoài ký tự số được nhập vào input
function numericOnly(inputIncome){
    inputIncome.attr('onkeydown', `return ( event.ctrlKey || event.altKey 
                || (47<event.keyCode && event.keyCode<58 && event.shiftKey==false) 
                || (95<event.keyCode && event.keyCode<106)
                || (event.keyCode==8) || (event.keyCode==9) 
                || (event.keyCode>34 && event.keyCode<40) 
                || (event.keyCode==46) )`)
}
//resert form
//DVLong (23/7/2021)
function resetForm(){
    $(".form .input-field .input-box").val('');
    $("#txtGenderCode .title").text('Giới tính');
    $("#txtDepartmentCode .title").text('Phòng ban');
    $("#txtPositionCode .title").text('Vị trí');
    $("#txtWorkStatus .title").text('Tình trạng công việc');
    var errorFields = $(".input-binding .error");
    $.each(errorFields,function(index,errorField){
        $(errorField).removeClass("error");
    })
    $(".form .option .value").removeClass('active');
}
//format ngày để hiển thị dữ liệu vào form nhập
function dobFormatToForm(dob) {
    if (dob != null) {
        var date = new Date(dob);
        var day = date.getDate();
        var mon = date.getMonth() + 1;
        var year = date.getFullYear();
        day = day < 10 ? '0' + day : day;
        mon = mon < 10 ? '0' + mon : mon;
        return year + '-' + mon + '-' + day;
    } else return '';
}
//format ngày để hiển thị lên bảng
function dobFormat(dob) {
    if (dob != '') {
        var date = new Date(dob);
        var day = date.getDate();
        var mon = date.getMonth() + 1;
        var year = date.getFullYear();
        day = day < 10 ? '0' + day : day;
        mon = mon < 10 ? '0' + mon : mon;
        return day + '/' + mon + '/' + year;
    } else return '';
}