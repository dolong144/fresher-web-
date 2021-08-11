<template>
    <div class="popup-container" :class="{'showPopup':isShowPopup}">
        <div class="popup" :class="typePopup">
            <div class="header-popup">
                <div class="head-title">{{titlePopup}}</div>
                <div class="close-button" @click="hidePopup">
                    <i class="fas fal fa-times"></i>
                </div>
            </div>
            <div class="body-popup">
                <div class="icon-popup">
                    <i class="fas far fa-exclamation-triangle"></i>
                </div>
                {{contentPopup}}
            </div>
            <div class="footer-popup">
                <div class="button button-cancle" @click="hidePopup">Huỷ</div>
                <div class="button button-yes" @click="confirmPopup">Đóng</div>
            </div>
        </div>
    </div>
</template>
<script>
export default {
    props:{
        isShowPopup:{
            type : Boolean,
            default:false,
            required : true,
        },
        typePopup:{
            type: String,
            
        },
        titlePopup:{
            type: String,
            
        },
        contentPopup:{
            type: String,
            
        }
    },
    methods:{
        // Hiện popup thông báo
        // dvlong (28/7/2021)

        // xác nhận đồng ý popup
        confirmPopup(){
            this.$emit('confirmPopup');
        },
        // ẩn popup đi
        hidePopup(){
            this.$emit('hidePopup');
        }
    }
}
</script>
<style scoped>

@import url('../../assets/css/main.css');
@import url('../../assets/css/base/button.css');
@import url('../../assets/css/base/popup.css');
 .showPopup{
        display: block;
    }

</style>