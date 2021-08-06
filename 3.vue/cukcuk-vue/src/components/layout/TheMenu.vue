<template>
    <div class="menu">
        <div class="menu-item active" @click="setActive(this)">
            <div class="menu-icon"></div>
            <div class="menu-item-text">Tổng quan</div>
        </div>
        <div class="menu-item">
            <div class="menu-icon"></div>
            <div class="menu-item-text">Báo cáo</div>
        </div>
        <div class="menu-item">
            <div class="menu-icon"></div>
            <div class="menu-item-text">Mua hàng</div>
        </div>
        <div class="menu-item">
            <div class="menu-icon"></div>
            <div class="menu-item-text">Danh mục nhân viên</div>
        </div>
        <div class="menu-item">
            <div class="menu-icon"></div>
            <div class="menu-item-text">Danh mục nhân viên</div>
        </div>
        <div class="menu-item">
            <div class="menu-icon"></div>
            <div class="menu-item-text">Thiết lập hệ thống</div>
        </div>
    </div>
</template>
<script>
export default {
  name: 'TheMenu',
  methods:{
      setActive(){
        
      }
  }
  
}
</script>
<style scoped>
@import url('../../assets/css/layout/menu.css');
@import url('../../assets/css/main.css');
@import url('../../assets/css/base/button.css');
@import url('../../assets/css/base/popup.css');
@import url('../../assets/css/base/textbox.css');
@import url('../../assets/css/base/toast.css');
@import url('../../assets/css/base/tooltip.css');
</style>