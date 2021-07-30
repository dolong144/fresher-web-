<template>
    <div class="header">
        <div class="header-left">
            <div class="toggle"></div>
            <div class="logo"></div>
        </div>
        <div class="header-right">
            <div class="name-restaurant">
                <b>
                    <div class="combo-box">
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
                    </div>
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
export default {
  name: 'TheHeader',
  
}
</script>
<style scoped>
@import url('../../css/layout/header.css');
@import url('../../css/main.css');
@import url('../../css/base/button.css');
@import url('../../css/base/popup.css');
@import url('../../css/base/textbox.css');
@import url('../../css/base/toast.css');
@import url('../../css/base/tooltip.css');

</style>