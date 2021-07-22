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
        $(".input-field").focus();
        
    })
    //các trường nhập bắt buộc
    $("#employeeCode .input-box").blur(function(){
        
        let value = $("#employeeCode .input-box").val();
        console.log($("#employeeCode .input-box").val());
        if(value == ''){
            $("#employeeCode .input-box").addClass("error");
            $("#employeeCode .input-box").attr('title','thông tin này chưa nhập');
        }
    })
    $("#employeeName .input-box").blur(function(){
        
        let value = $("#employeeName .input-box").val();
        console.log($("#employeeName .input-box").val());
        if(value == ''){
            $("#employeeName .input-box").addClass("error");
            $("#employeeName .input-box").attr('title','thông tin này chưa nhập');
        }
    })
    $("#employeeIdentify .input-box").blur(function(){
        
        let value = $("#employeeIdentify .input-box").val();
        console.log($("#employeeIdentify .input-box").val());
        if(value == ''){
            $("#employeeIdentify .input-box").addClass("error");
            $("#employeeIdentify .input-box").attr('title','thông tin này chưa nhập');
        }
    })
    //Đong form
    $(".form .head-form .close-button").click(closeForm);
    $(".form .footer-form .button").click(closeForm);

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
})
//load dữ liệu
function loadData(){
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
