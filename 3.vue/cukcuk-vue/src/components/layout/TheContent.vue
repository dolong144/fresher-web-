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
    @import url('../../css/layout/content.css');
    @import url('../../css/main.css');
    @import url('../../css/base/button.css');
    @import url('../../css/base/popup.css');
    @import url('../../css/base/textbox.css');
    @import url('../../css/base/toast.css');
    @import url('../../css/base/tooltip.css');
</style>