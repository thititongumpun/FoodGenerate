<template>
  <div id="app">
    <router-link to="/foodgen">Food Generate</router-link>
    <router-link to="/ranking">Food Ranking</router-link>
    <img alt="Vue logo" src="./assets/logo.png">
    <!-- <FoodGenerate msg="Welcome to Your Vue.js App"/> -->
    <router-view></router-view>
    
  </div>
</template>

<script>
// import FoodGenerate from './components/FoodGenerate.vue';
export default {
  name: 'App',
  components: {
    // FoodGenerate
  }
}
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
</style>