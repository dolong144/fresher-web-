import Vue from 'vue'
import App from './App.vue'
import axios from "axios"
import VueAxios from "vue-axios"
import BaseDropdown from "./components/base/BaseDropDown.vue"
import employeeDetail from "./view/employee/EmployeeDetail.vue"
import toast from "./components/base/BaseToast.vue"

Vue.use(VueAxios,axios)
Vue.config.productionTip = false
Vue.component('BaseDropdown',BaseDropdown)
Vue.component('employeeDetail',employeeDetail)
Vue.component('toast',toast)

new Vue({
  render: h => h(App),
}).$mount('#app')
