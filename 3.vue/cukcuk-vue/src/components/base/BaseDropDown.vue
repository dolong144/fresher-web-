<template>
    <div class="combo-box" id="department" :class="Show=isShow" @click="clicKDropdown()" >
        <div class="select-button">
            <div class="title">Tất cả phòng ban</div>
            <div class="icon-button">
                <i class="fas fa-solid fa-chevron-down"></i>
            </div>
        </div>
        <div class="option">
            <div class="value" v-for="department in departments" :key="department.departmentId" :id = department.departmentId >{{department.DepartmentName}}</div>
        </div>
    </div>
</template>
<script>
export default {
    methods(){
        // clickDropDown(){

        // }
    }
    
}
</script>
<style scoped>

</style>
