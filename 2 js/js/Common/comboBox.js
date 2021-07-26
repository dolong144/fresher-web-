
const comboBox = $(".combo-box");
const option = $(".combo-box .option");
//hiển thị các lựa chọn của dropdown

$("body").on('click','.combo-box',function(event){
    
    //nếu ấn vào cái dropdown thì hiện dropdown list

    if(event.target.matches(".combo-box") 
        || event.target.matches(".title") 
        || event.target.matches(".select-button") 
        || event.target.matches(".fa-chevron-down")
        || event.target.matches(".icon-button"))
    {
     //nếu ấn lại vào button select thì tự ẩn đi mà ko chọn giá trị
        if(event.target.matches(".cb-box-active .title")
            || event.target.matches(".cb-box-active .icon-button")
            || event.target.matches(".cb-box-active .fa-chevron-down")
            ||event.target.matches(".cb-box-active .select-button")){
            hideOption();
            
            return;
        }
        
        
        //hiện dropdown list
        hideOption();
        $(this).addClass("cb-box-active");
        $(".cb-box-active .option").addClass("option-active");
        return;
    }
    
})
$(".combo-box ").on('click','.value',function(){
    $(".cb-box-active .option-active .value").removeClass("active");
    $(this).addClass("active");
    $(".cb-box-active .select-button .title").text($(".cb-box-active .option-active .active").text());
    hideOption();
})

$(window).click(function(event){
    //chọn 1 giá trị của dropdown
    // if(event.target.matches(".combo-box .value ")){
    //     $(".cb-box-active .option-active .value").removeClass("active");
    //     $(event.target).addClass("active");
    //     $(".cb-box-active .select-button .title").text($(".cb-box-active .option-active .active").text());
    //     hideOption();
        

    // }

    //nếu ấn ra ngoài thì ẩn dropdown
    if(  !(event.target.matches(".combo-box .title")
        || event.target.matches(".combo-box .icon-button")
        || event.target.matches(".combo-box .fa-chevron-down")
        || event.target.matches(".combo-box .select-button")
        || event.target.matches(".combo-box")
        || event.target.matches(".combo-box .value")))
    {
        
        hideOption();
    }
    
    
});

// $(".combo-box .option .value").click(function(){
    
//     $(".cb-box-active .option-active .value").removeClass("active");
//     $(this).addClass("active");
//     $(".cb-box-active .select-button .title").text($(this).text());
//     hideOption();
    
// })
// ẩn các lựa chọn của dropdown
function hideOption(){
    comboBox.removeClass("cb-box-active");
    option.removeClass("option-active");
} 

