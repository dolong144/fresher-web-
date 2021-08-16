<template>
    <div class="header">
        <div class="header-left">
            <div class="toggle"></div>
            <div class="logo"></div>
        </div>
        <div class="header-right">
            <div class="name-restaurant">
                <b>
                    <!-- <div class="dropdown">
                        <div class="select-button">
                            
                            <div class="title">Nhà hàng Biển Đông</div>
                            <div class="icon-button">
                                <i class="fas fa-solid fa-chevron-down"></i>
                            </div>
                        </div>
                        <div class="option">
                            <div class="value active">
                                <div class="icon-active">
                                    <i class="fas fa-solid fa-check"></i>
                                </div>
                                <div>Nhà hàng Biển Đông</div>
                            </div>

                            <div class="value">
                                <div class="icon-active">
                                    <i class="fas fa-solid fa-check"></i>
                                </div>
                                <div>Nhà hàng CUKCUK</div>
                            </div>
                            <div class="value">
                                <div class="icon-active">
                                    <i class="fas fa-solid fa-check"></i>
                                </div>
                                <div>Nhà hàng Đại dương</div>
                            </div>
                            
                        </div>
                    </div> -->
                    <BaseDropdown
                    id="dropdown__restaurant"
                    title="Nhà hàng Biển Đông"
                    type="restaurant"
                />
                </b>
            </div>
            <div class="user">
                <div class="avatar"></div>
                <div class="name">Đỗ Văn Long</div>
                <div class="option-btn"></div>
            </div>
        </div>
    </div>
</template>
<script>
import BaseDropdown from '../base/BaseDropDown.vue'
export default {
  name: 'TheHeader',
  components:{
      BaseDropdown,
  }
  
}
</script>
<style scoped>
@import url('../../assets/css/layout/header.css');
@import url('../../assets/css/main.css');
@import url('../../assets/css/base/button.css');
@import url('../../assets/css/base/popup.css');
@import url('../../assets/css/base/textbox.css');
@import url('../../assets/css/base/toast.css');
@import url('../../assets/css/base/tooltip.css');

</style>