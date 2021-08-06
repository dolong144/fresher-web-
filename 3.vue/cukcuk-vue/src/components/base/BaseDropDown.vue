<template>
    <div class="combo-box" id="department"  @click="clickDropDown()" :value="selectValue">
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
        axios.get(apiUrl).then(res => {
        this.options = res.data;
        }).catch(res => {
        console.log(res)
        })
        if(this.value!=null){
            this.options.forEach(option => {
                if(this.value == option[`${this.type}Id`]){
                    this.dropdownTitle = option[`${this.type}Name`];
                }
                
            });
        }
    },
    data(){
        return{
            isShowOption:false,
            options:[],
            indexOption:null,
            dropdownTitle:this.title,
            selectValue:this.value,
        }
    },
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
            type: String,
        }

    },
    methods:{
        clickDropDown(){
            this.isShowOption = !this.isShowOption;
        },
        selectOption(index){
            this.indexOption = index;
        }
    },
    watch:{
        indexOption: function(){
            this.dropdownTitle = this.options[this.indexOption][`${this.type}Name`];
            this.selectValue = this.options[this.indexOption][`${this.type}Id`];
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
