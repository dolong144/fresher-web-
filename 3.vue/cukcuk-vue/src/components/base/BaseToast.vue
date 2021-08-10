<template>
    <div class="toast_container" :class="{'showToast':isShowToast}">
        <div class="toast" :class="typeToast">
            <div class="toast_icon--main">
                <i class="fas fal fa-check" id="success-icon"></i>
                <i class="fas fal fa-exclamation" id="error-icon"></i>
            </div>
            <div class="toast_title">
                {{contentToast}}
            </div>
            <div class="toast_close">
                <i class="fas fal fa-times"></i>
            </div>
        </div>
    </div>
</template>
<script>
export default {
    props:{
        contentToast:{
            type:String,
            required: true,
        },
        typeToast:{
            type:String,
            required: true,
        },
        isShowToast:{
            type:Boolean,
            required:true,
            
        }
    },
    methods:{
        
    }
    
}
</script>
<style scoped>
    
    @import url('../../assets/css/main.css');
    @import url('../../assets/css/base/button.css');
    @import url('../../assets/css/base/toast.css');
    .showToast{
            display: block;
        }
</style>