export default class DataValidator {
    constructor() {
    }

    //Hàm hiện thông báo lỗi khi nhập sai input
    //@params ô nhập và text thông báo cần hiện
    //Author: NQMinh(23/07/2021)
    static showError = (input, msg) => {
        const errorBubble = document.createElement('div');
        errorBubble.classList.add('misa-bubble--alert');
        errorBubble.textContent = msg;
        input.parentElement.append(errorBubble);
    }

    //Hàm kiểm tra dữ liệu email
    //Author: NQMinh(22/07/2021)
    static validateEmail = () => {
        const self = this;
        const inputEmail = document.getElementById('input-employee-email');
        // eslint-disable-next-line
        const re = /^(([^<>()\[\]\\.,;:\s@"]+(\.[^<>()\[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
        inputEmail.addEventListener('input', () => {
            const email = inputEmail.value;
            if (!re.test(String(email).toLowerCase())) {
                self.showError(inputEmail, 'Email không đúng định dạng');
                return false;
            }
        })
        return true;
    }
    
    //Hàm kiểm tra ô nhập trống
    //Author: NQMinh(21/07/2021)
    static validateRequired = () => {
        const self = this;
        let result = true;
        const requiredFields = document.querySelectorAll('input[required]');
        let checkList = Array(requiredFields.length).fill(false);
        requiredFields.forEach((field, index) => {
            field.addEventListener('blur', () => {
                if (field.value.trim() === '') {
                    checkList[index] = false;
                    field.classList.add('misa-input--alert');
                    field.setAttribute('title', 'Thông tin này bắt buộc nhập!');
                    self.showError(field, 'Thông tin này bắt buộc nhập');
                } else {
                    checkList[index] = true;
                    field.classList.remove('misa-input--alert');
                    field.removeAttribute('title');
                }
            })

            field.addEventListener('input', () => {
                checkList[index] = true;
                const inputField = field.parentElement;
                const lastChild = inputField.lastElementChild;
                if (lastChild.className === 'misa-bubble--alert') {
                    inputField.removeChild(lastChild);
                }
            })
        })

        for (let i = 0; i < checkList.length; i++) {
            if(checkList[i] === false) result = false;
        }
        return result;
    }

    static validateAll = () => {
        // const checkRequired = this.validateRequired();
        // const checkEmail = this.validateEmail();
        return true;
    }
}