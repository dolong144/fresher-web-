<template>
  <div id="app">
    
    <TheHeader/>
    <TheMenu/>
    <TheContent/>
  </div>
</template>

<script>
import TheHeader from './components/layout/TheHeader.vue'
import TheMenu from './components/layout/TheMenu.vue'
import TheContent from './components/layout/TheContent.vue'

export default {
  name: 'App',
  components: {
    TheHeader,TheMenu,TheContent
  }
}
</script>

<style>

</style>
