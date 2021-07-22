const formCover = $(".cover-form")
const footerNumber = $(".content .footer .page .page-number")
const form = $(".form")

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
    $(".content .nav .button").click(function(){
        formCover.show();
        form.show();
        //xoá dữ liệu cũ
        $(".form input").val(null);

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
    //các trường nhập bắt buộc
    $("#employeeCode .input-box").blur(validataInput)
    $("#employeeName .input-box").blur(validataInput)
    $("#employeeIdentify .input-box").blur(validataInput)
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
    $(".form .head-form .close-button").click(closeForm);
    $(".form .footer-form .cancle").click(closeForm);
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
    $(".form .footer-form .save").click(function(){
        let employee = {
            "EmployeeId": "c74fb376-ea97-11eb-94eb-42010a8c0002",
            "EmployeeCode": "NV03857",
            "FirstName": null,
            "LastName": null,
            "FullName": "Nguyễn Thị My",
            "Gender": 1,
            "DateOfBirth": "2000-02-21T00:00:00",
            "PhoneNumber": "0888886666",
            "Email": "thanhtrung@gmail.com",
            "Address": null,
            "IdentityNumber": "023222222",
            "IdentityDate": "2019-03-12T00:00:00",
            "IdentityPlace": "Hà Nội",
            "JoinDate": "2019-02-22T00:00:00",
            "MartialStatus": null,
            "EducationalBackground": null,
            "QualificationId": null,
            "DepartmentId": "469b3ece-744a-45d5-957d-e8c757976496",
            "PositionId": "548dce5f-5f29-4617-725d-e2ec561b0f41",
            "WorkStatus": 1,
            "PersonalTaxCode": null,
            "Salary": 10000000,
            "PositionCode": "P94",
            "PositionName": "Nhân viên",
            "DepartmentCode": "PB86",
            "DepartmentName": "Phòng Nhân sự",
            "QualificationName": null,
            "GenderName": "Nam",
            "EducationalBackgroundName": null,
            "MartialStatusName": null,
            "CreatedDate": "2021-07-22T02:51:56",
            "CreatedBy": null,
            "ModifiedDate": null,
            "ModifiedBy": null
          };
        employee.FullName = $("#txtFullName").val();
        employee.EmployeeCode= $("#txtEmployeeCode").val();
        employee.IdentifyNumber = $("#txtIdentifyNumber").val();
        employee.GenderName = $("#txtGenderName").text();
        employee.PhoneNumber = $("#txtPhoneNumber").val();
        employee.DepartmentName = $("#txtDepartmentName").text();
        employee.PositionName = $("#txtPositionName").text();
        employee.IdentityDate = $("#txtIdentityDate").val();
        employee.IdentityPlace = $("#txtIdentityPlace").val();
        employee.Email = $("#txtEmail").val();
        // employee.WorkStatus = $("#txtWorkStatus").text();
        employee.JoinDate = $("#txtJoinDate").val();
        employee.PersonalTaxCode = $("#txtPersonalTaxCode").val();
        employee.Salary = $("#txtSalary").val();
        employee.DateOfBirth = $("#txtDateOfBirth").val();
        console.log($("#txtDepartmentName").text());

        //gọi api lưu dữ liệu
        $.ajax({
            url:'http://cukcuk.manhnv.net/v1/Employees',
            method: 'POST',
            data: JSON.stringify(employee),
            dataType: 'json',
            contentType: 'application/json',
            async: false
        }).done(res =>{
            alert("làm tốt đấy! thêm được rồi");
            loadData();

        }).fail(res =>{
            alert("có lỗi xảy ra! code lại đi");
        })
        closeForm();
    });
    //button load lại dữ liệu
    $(".content .search .textbox-default ").click(function(){
        loadData();
    });
})
//load dữ liệu
function loadData(){
    $("tbody").empty();
    // lấy dữ liệu
    $.ajax({
        url:"http://cukcuk.manhnv.net/v1/Employees",
        method:"GET",
        async:false,
    }).done(function(res){
        var data = res;
        //hiển thị dữ liệu lên từng row
        $.each(data, function(index, item){
            var tr = $(`<tr>
                <td>`+ checkData(item.EmployeeCode) +`</td>
                <td>`+ checkData(item.FullName) +`</td>
                <td>`+ checkData(item.GenderName) +`</td>
                <td>`+ checkData(item.DateOfBirth) +`</td>
                <td>`+ checkData(item.PhoneNumber) +`</td>
                <td>`+ checkData(item.Email) +`</td>
                <td>`+ checkData(item.PositionName) +`</td>
                <td>`+ checkData(item.DepartmentName) +`</td>
                <td>`+ checkData(item.Salary) +`</td>
                <td>`+ checkData(item.WorkStatus) +`</td>
            </tr>`);
            if(!item.EmployeeCode) {}
        $('table tbody').append(tr);

        }) 
    }).fail(function(res){
        alert("load data lỗi! F5 đi");
    })
};
function checkData(data){   
    return data ? data :``;
}
//load vị trí
function loadPosition(){
    // lấy dữ liệu vị trí
    $.ajax({
        url:"http://cukcuk.manhnv.net/v1/Positions",
        method:"GET",
        async: false,
    }).done(function(res){
        var data = res;
        //hiển thị dữ liệu vị trí
        $.each(data, function(index, item){
            var selected = `<div class="value">` +checkData(item.PositionName)+ `</div>`;
            if(!item.EmployeeCode) {}
        $('#position .option').append(selected);

        }) 
    }).fail(function(res){
        alert("load data lỗi! F5 đi");
    })
}
//load phòng ban
function loadDepartment(){
    // lấy dữ liệu phòng ban
    $.ajax({
        url:"http://cukcuk.manhnv.net/api/Department",
        method:"GET",
        async:false,
    }).done(function(res){
        var data = res;
        //hiển thị dữ liệu phòng ban
        $.each(data, function(index, item){
            var depaertment = `<div class="value">` +checkData(item.DepartmentName)+ `</div>`;
            if(!item.EmployeeCode) {}
        $('#department .option').append(depaertment);

        }) 
    }).fail(function(res){
        alert("load data lỗi! F5 đi");
    })
}

//ẩn form
function closeForm(){
    form.hide();
    formCover.hide();
}
