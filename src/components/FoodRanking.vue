<template>
  <div v-if='loadingStatus' class='loading-div'>
    <vue-spinner size="250" line-size="20" speed="0.8"></vue-spinner>
    <div class="loading">
      <div class="loading__letter">L</div>
      <div class="loading__letter">o</div>
      <div class="loading__letter">a</div>
      <div class="loading__letter">d</div>
      <div class="loading__letter">i</div>
      <div class="loading__letter">n</div>
      <div class="loading__letter">g</div>
      <div class="loading__letter">.</div>
      <div class="loading__letter">.</div>
      <div class="loading__letter">.</div>
    </div>
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
@import url(https://fonts.googleapis.com/css?family=Audiowide);
  .loading-div {
    position: fixed;
    left: 50%;
    top: 50%;
    transform: translate(-50%, -50%);
    transform: -webkit-translate(-50%, -50%);
    transform: -moz-translate(-50%, -50%);
    transform: -ms-translate(-50%, -50%);
  }
  .loading {
  display: flex;
  flex-direction: row;
  }
  .loading__letter {
  font-size: 88px;
  font-weight: normal;
  letter-spacing: 4px;
  font-family: "Audiowide";
  text-transform: uppercase;
  animation-name: bounce;
  animation-duration: 2s;
  animation-iteration-count: infinite;
  }
  .loading__letter:nth-child(2) {
    animation-delay: .1s; 
  }
  .loading__letter:nth-child(3) {
    animation-delay: .2s;
  }
  .loading__letter:nth-child(4) {
    animation-delay: .3s; 
  }
  .loading__letter:nth-child(5) {
    animation-delay: .4s;
  }
  .loading__letter:nth-child(6) {
    animation-delay: .5s; 
  }
  .loading__letter:nth-child(7) {
    animation-delay: .6s;
  }
  .loading__letter:nth-child(8) {
    animation-delay: .8s;
  }
  .loading__letter:nth-child(9) {
    animation-delay: 1s;
  }
  .loading__letter:nth-child(10) {
    animation-delay: 1.2s;
  }

  @keyframes bounce {
  0% {
    transform: translateY(0px);
  }
  40% {
    transform: translateY(-40px);
  }
  80%,
  100% {
    transform: translateY(0px);
  }
}
</style>