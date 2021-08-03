<template>
    <div class="toast_container">
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
        }
    }
    
}
</script>
<style scoped>
    
    @import url('../../css/main.css');
    @import url('../../css/base/button.css');
    @import url('../../css/base/toast.css');
    .showToast{
            display: block;
        }
</style>