<template>
    <div class="dropdown" id="department"  @click="clickDropDown()" :value="value" :class="{'cb-box-active':isShowOption}">
        <div class="select-button">
            <div class="title">{{dropdownTitle}}</div>
            <div class="icon-button">
                <i class="fas fa-solid fa-chevron-down"></i>
            </div>
        </div>
        <div class="option" :class="{'showOption':isShowOption}">
            <div class="value" 
                v-for="(option,index) in options" 
                :key="option[`${type}Id`]" 
                :value="option[`${type}Id`]"
                :class="{'active': indexOption === index}"
                @click="selectOption(index)">
                    <div class="icon-active">
                        <i class="fas fa-solid fa-check"></i>
                    </div>
                    {{option[`${type}Name`] }}
            </div>
        </div>
    </div>
</template>
<script>
import axios from "axios";
export default {
    props:{
        type:{
            type: String,
            required: true,
        },
        title:{
            type: String,
            required: true,
        },
        value:{
            
        },
        

    },
    created() {
        
        let apiUrl = '';
        //TODO: Hiện tại đang fix cứng call API của phòng ban và vị trí ở đây
        switch (this.type) {
        case 'Department':
            apiUrl = 'http://cukcuk.manhnv.net/api/Department';
            break;
        case 'Position':
            apiUrl = 'http://cukcuk.manhnv.net/v1/Positions';
            break;
        }
        
        if(this.type == 'Gender'){
            this.options = [
                {
                    GenderId:0,
                    GenderName:'Nữ'
                },
                {
                    GenderId:1,
                    GenderName:'Nam'
                },
                {
                    GenderId:2,
                    GenderName:'Không xác định'
                },
        ]
        }
        else if(this.type == 'WorkStatus'){
            this.options = [
                {
                    WorkStatusId:0,
                    WorkStatusName:'Đã nghỉ việc'
                },
                {
                    WorkStatusId:1,
                    WorkStatusName:'Đang làm việc'
                },
                {
                    WorkStatusId:2,
                    WorkStatusName:'Đang thử việc'
                },
        ]
        }
        else if(this.type == 'restaurant'){
            this.options = [
                {
                    restaurantId:'0',
                    restaurantName:'Nhà hàng Biển Đông'
                },
                {
                    restaurantId:'1',
                    restaurantName:'Nhà hàng CukCuk'
                },
                {
                    restaurantId:'2',
                    restaurantName:'Nhà hàng Hoa mai'
                },
        ]
        }
        else {
            axios.get(apiUrl).then(res => {
            this.options = res.data;
            }).catch(res => {
            console.log(res)
            })
        }
    },
    mounted(){
        
    },
    data(){
        return{
            isShowOption:false,
            options:[],
            indexOption:null,
            dropdownTitle:this.title,
            selectValue:this.value,
            defaultTitle:{
                Department: 'Phòng ban',
                Position: 'Vị trí',
                Gender:'Giới tính',
                WorkStatus:'Tình trạng công việc',
            },
        }
    },
    
    methods:{
        clickDropDown(){
            this.isShowOption = !this.isShowOption;
        },
        selectOption(index){
            this.indexOption = index;
            this.$emit('setSelection',this.type,this.options[index][`${this.type}Id`]);
        }
    },
    watch:{
        indexOption: function(){
            this.dropdownTitle = this.options[this.indexOption][`${this.type}Name`];
            this.selectValue = this.options[this.indexOption][`${this.type}Id`];
        },
        value: function(){
            
            if(this.value!=null){
                this.options.forEach((option,index) => {
                    if(this.value == option[`${this.type}Id`]){
                        this.dropdownTitle = option[`${this.type}Name`];
                        this.indexOption = index;
                    }
                    
                });
            }
            // else{
            //     this.dropdownTitle =this.defaultTitle[`${this.type}`];
            // }
        }
    }
    
}
</script>
<style scoped>
    @import url('../../assets/css/main.css');
    @import url('../../assets/css/base/button.css');
    @import url('../../assets/css/base/button.css');
    .showOption{
            display: block;
            z-index: 5;
        }

</style>
