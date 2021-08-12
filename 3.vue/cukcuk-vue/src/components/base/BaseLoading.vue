<template>
    <div class="container">
        <clip-loader :loading="loading" :color="color" :size="size"></clip-loader>
        
    </div>
</template>
<script>
import ClipLoader from 'vue-spinner/src/ClipLoader.vue'
export default {
    components:{
        ClipLoader
    },
    
}
</script>
<style lang="">
    .container{
        position: fixed;
        width: 100vw;
        height: 100vh;
        opacity: 0.2;
        align-items: center;
    }
</style>