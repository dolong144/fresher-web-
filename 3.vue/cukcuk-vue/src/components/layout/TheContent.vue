<template>
    <div>
        <employeeList/>
    </div>
    
</template>

<script>
import employeeList from '../../view/employee/EmployeeList.vue';

// import VueAxios from "vue-axios"; 
export default {
  name: 'TheContent',
  components:{
      employeeList,
  },
}
</script>
<style scoped>
    @import url('../../assets/css/layout/content.css');
    @import url('../../assets/css/main.css');
    @import url('../../assets/css/base/button.css');
    @import url('../../assets/css/base/popup.css');
    @import url('../../assets/css/base/textbox.css');
    @import url('../../assets/css/base/toast.css');
    @import url('../../assets/css/base/tooltip.css');
</style>