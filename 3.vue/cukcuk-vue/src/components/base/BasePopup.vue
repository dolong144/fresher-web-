<template>
    <div class="popup-container" :class="{'showPopup':isShowPopup}">
        <div class="popup">
            <div class="header-popup">
                <div class="head-title"></div>
                <div class="close-button" @click="closePopup">
                    <i class="fas fal fa-times"></i>
                </div>
            </div>
            <div class="body-popup">
                <div class="icon-popup">
                    <i class="fas far fa-exclamation-triangle"></i>
                </div>
                
            </div>
            <div class="footer-popup">
                <div class="button button-cancle" @click="closePopup">Huỷ</div>
                <div class="button button-yes" @click="hidePopup">Đóng</div>
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
        }
    },
    methods:{
        hidePopup(){
            this.$emit('showPopup');
            this.$emit('closeForm');
        },
        closePopup(){
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