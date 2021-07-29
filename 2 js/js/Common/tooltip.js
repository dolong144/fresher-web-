function showTooltip(id,text){
    var selector = '#' + id + ' .tooltip-alert';
    $(selector).text(text);
    $(selector).css('display','block');
    setTimeout(hidenTooltip,3000);
}
function hidenTooltip(){
    var toolTip = $(".tooltip-alert");
    $.each(toolTip,function(index,item){
        $(item).css('display','none');
    })
}