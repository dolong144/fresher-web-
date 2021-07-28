// Hiện popup thông báo
// dvlong (28/7/2021)

function showPopup(typePopup,title,content){
    $(".popup-container").css('display','block');
    $(".popup-container .popup").css('overflow','visible');
    $(".popup-container .popup").addClass(typePopup);
    $(".popup-container .popup .icon-popup").css('display','block');
    $(".popup-container .popup .head-title").text(title);
    $(".popup-container .popup .body-popup").text(content);
    $(".popup-container .notify-popup .footer-popup .button-yes").text("Đóng");
    
    $(".popup-container .alert-popup .footer-popup .button-yes").text("Xoá");
    $(".popup-container .alert-popup .footer-popup .button-cancle").text("Huỷ");

    $(".popup-container .confirm-popup .footer-popup .button-yes").text("Đóng");
    $(".popup-container .confirm-popup .footer-popup .button-cancle").text("Tiếp tục nhập");
}
//  ẩn popup
// dvlong (28/7/2021)
function hidenPopup(){
    $(".popup-container").css('display','none');
    $(".popup-container .popup").css('overflow','hidden');
    $(".popup-container .popup").removeClass("notify-popup");
    $(".popup-container .popup").removeClass("alert-popup");
    $(".popup-container .popup").removeClass("confirm-popup");
}