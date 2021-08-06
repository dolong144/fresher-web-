<template>
  <div class="misa-dropdown" :id="id" :value="value">
    <button
        class="dropdown__button"
        @click="showDropdownOptions"
    >
      <span class="dropdown__title">{{ dropdownTitle }}</span>
      <i class="fas fa-chevron-down" :class="{'misa-rotate180': iconRotate}"></i>
    </button>
    <MisaDropdownOptions
        :contentHidden="contentHidden"
        :dropdownTitle="title"
        :dropdownType="dropdownType"
        @dropdown-item-active="assignDropdown"
    />
  </div>
</template>

<script>
import MisaDropdownOptions from "../dropdown/BaseOption.vue";
export default {
  name: "MisaDropdown",
  data() {
    return {
      contentHidden: true,
      dropdownTitle: this.title,
      dropdownType: this.type,
      iconRotate: false,
      value: ''
    }
  },
  props: {
    id: {
      type: String,
      required: true
    },
    title: {
      type: String,
      required: true
    },
    type: {
      type: String,
      required: true
    }
  },
  components: {
    MisaDropdownOptions
  },
  methods: {
    //Hàm xổ dropdown content khi click (click lần 2 để đóng)
    showDropdownOptions() {
      this.contentHidden = !this.contentHidden;
      this.iconRotate = !this.iconRotate;
    },
    hideDropdownOptions() {
      return this.contentHidden = true;
    },
    //Hàm chuyển title của button dropdown
    assignDropdown(item) {
      //nếu có chọn item thì chuyển title thành tên item
      if (item) {
        this.dropdownTitle = item[`${this.type}Name`];
        this.value = item[`${this.type}Id`];
      } else {
        this.dropdownTitle = this.title;
        this.value = '';
      }
      //ẩn dropdown content vaf xoay mũi tên
      this.contentHidden = !this.contentHidden;
      this.iconRotate = false;
    }
  }
}
</script>

<style lang="scss">
.misa-dropdown {
  width: 200px;
  height: 40px;
  position: relative;
  background-color: #ffffff;
  border-radius: 4px;
  & .dropdown__button {
    width: 100%;
    height: 100%;
    display: flex;
    align-items: center;
    justify-content: space-between;
    color: var(--color-black);
    background-color: transparent;
    padding: 0 12px 0 16px;
    border-radius: 4px;
    box-sizing: border-box;
    border: 1px solid #BBB;
    cursor: pointer;
    & i {
      margin-left: 12px;
      transition: 0.2s all ease-in-out;
    }
    &:focus {
      border-color: #019160;
    }
  }
}
</style>