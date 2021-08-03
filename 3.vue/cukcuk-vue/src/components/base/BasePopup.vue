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
                <div class="button button-yes" @click="hidePopupAndForm">Đóng</div>
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
            required: true,
        },
        titlePopup:{
            type: String,
            required: true,
        },
        contentPopup:{
            type: String,
            required: true,
        }
    },
    methods:{
        // Hiện popup thông báo
        // dvlong (28/7/2021)
        
        hidePopupAndForm(){
            this.$emit('showPopup');
            this.$emit('closeForm');
        },
        hidePopup(){
            this.$emit('showPopup');
        }
    }
}
</script>
<style scoped>

@import url('../../css/main.css');
@import url('../../css/base/button.css');
@import url('../../css/base/popup.css');
 .showPopup{
        display: block;
    }

</style>