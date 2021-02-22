<template>
  <div v-if='loadingStatus' class='loading-div'>
    <vue-spinner size="250" line-size="20" speed="0.8" message="Loading..."></vue-spinner>
  </div>
  <div v-else class='content-dev'>
    <ul>
      <li
        v-for='food in foods' :key='food.id'
      >
        <h3>Foodname: </h3>  {{food.foodName}}
        <h3>Review: </h3> {{food.review}}
        <img v-bind:src="food.imageData" alt="">
      </li>
    </ul>
  </div>
</template>

<script>
import Spinner from 'vue-simple-spinner';
export default {
  components: {
    vueSpinner: Spinner
  },
  name: 'myStore',
  data () {
    return {
      msg: 'Welcome to my VuexXXX Store'
    }
  },
  computed: {
    loadingStatus() {
      return this.$store.getters.loadingStatus
    },
    foods() {
    return this.$store.state.foods
    }
  },
  mounted() {
    this.$store.dispatch("getFoods");
  }
}
</script>

<style>
  .loading-div {
    position: fixed;
    left: 50%;
    top: 50%;
    transform: translate(-50%, -50%);
    transform: -webkit-translate(-50%, -50%);
    transform: -moz-translate(-50%, -50%);
    transform: -ms-translate(-50%, -50%);
  }
</style>