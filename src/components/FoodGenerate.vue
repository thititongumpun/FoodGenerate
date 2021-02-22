<template>
  <div v-if='loadingStatus' class='loading-div'>
    <vue-spinner size="250" line-size="20" speed="0.8"></vue-spinner>
    <h1>{{msg}}</h1>
  </div>
  <div v-else class='div'>
    <v-row>
      <v-col v-for='food in foods' :key='food.id' class="d-flex child-flex" cols="4">
        <img
          :src="food.imageData"
          aspect-ratio="=1"
          class="grey lighten-2"
        >
        <h3>Foodname: {{food.foodName}}</h3>
        <h3>Review {{food.review}}</h3>
      </v-col>
    </v-row>
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
      msg: 'Loading..........'
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