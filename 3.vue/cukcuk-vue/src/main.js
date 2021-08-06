import Vue from 'vue'
import App from './App.vue'
import axios from "axios"
import VueAxios from "vue-axios"
import BaseDropdown from "./components/base/BaseDropDown.vue"

Vue.use(VueAxios,axios)
Vue.config.productionTip = false
Vue.component('BaseDropdown',BaseDropdown)

new Vue({
  render: h => h(App),
}).$mount('#app')
