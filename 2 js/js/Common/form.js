
//ẩn form
function closeForm(){
    $(".form").hide();
    $(".cover-form").hide();
    
}
//reset form
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
    hidenTooltip();
}