$(document).ready(function(){
    loadData();
})
//load dữ liệu
function loadData(){
    // lấy dữ liệu
    $.ajax({
        url:"http://cukcuk.manhnv.net/v1/Employees",
        method:"GET",
    }).done(function(res){
        var data = res;
        $.each(data, function(index, item){
            // debugger;
            var tr = $(`<tr>
            <td>`+ item.EmployeeCode +`</td>
            <td>`+ item.FullName +`</td>
            <td>`+ item.GenderName +`</td>
            <td>`+ item.DateOfBirth +`</td>
            <td>`+ item.PhoneNumber +`</td>
            <td>`+ item.Email +`</td>
            <td>`+ item.PositionName +`</td>
            <td>`+ item.DepartmentName +`</td>
            <td>`+ item.Salary +`</td>
            <td>`+ item.WorkStatus +`</td>
        </tr>`);
        $('table tbody').append(tr);

        }) 
    }).fail(function(res){

    })
};
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
//mở form nhập nhân viên
$(".content .nav .button").click(function(){
    $(".cover-form").show();
    $(".form").show();
})
//Đong form
$(".form .head-form .close-button").click(closeForm);
$(".form .footer-form .button").click(closeForm);
function closeForm(){
    $(".form").hide();
    $(".cover-form").hide();
}
$(".combo-box .select-button").click(function(){
    $(this .option).show();
    $(this .option).attr('z-index', '1');
})