// hiện toast 

function showToast(typeToast,content){
    
    $(".toast").css('display','flex')
    
    $(".toast_container .toast").addClass("toast_active");
    $(".toast_container .toast").addClass(typeToast);
    $(".toast_container .toast .toast_title").text(content);
    
    setTimeout(hidenToast,5000);
    ;
}


// đóng toast
function hidenToast(){
    $(".background_toast").css('display','none');
    $(".background_toast").css('opacity','0');
    $(".toast_container .toast").removeClass("toast_active");
    $(".toast_container .toast").removeClass("error-toast");
    $(".toast_container .toast").removeClass("success-toast");
}
