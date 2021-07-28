// hiện toast 

function showToast(typeToast,content){
    $(".background_toast").css('display','flex');
    $(".background_toast").css('opacity','1');
    $(".toast").css('display','flex')
    
    $(".toast_container .toast").addClass("toast_active");
    $(".toast_container .toast").addClass(typeToast);
    $(".toast_container .toast .toast_title").text(content);
}


// đóng toast
function hidenToast(){
    $(".background_toast").css('display','none');
    $(".background_toast").css('opacity','0');
    $(".toast_container .toast").removeClass("toast_active");
    $(".toast_container .toast").removeClass("error-toast");
    $(".toast_container .toast").removeClass("success-toast");
}
