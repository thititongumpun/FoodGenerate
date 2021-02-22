<template>
  <div v-if='loadingStatus' class='loading-div'>
    <vue-spinner size="88" line-size=12 message="Loading..."></vue-spinner>
  </div>
  <div v-else class='content-dev'>
    <ul>
      <li
        v-for='post in posts' :key='post.id'
      >
        <h3>Foodname: </h3>  {{post.foodName}}
        <h3>Review: </h3> {{post.review}}
        <img v-bind:src="post.imageData" alt="">
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
    posts() {
    return this.$store.state.posts
    }
  },
  mounted() {
    this.$store.dispatch("getPosts");
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