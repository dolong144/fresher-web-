function checkData(data){   

    return data ? data : ``;
}
//format ngày để hiển thị dữ liệu vào form nhập
//dvlong(26/7/2021)
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
//dvlong(26/7/2021)
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
