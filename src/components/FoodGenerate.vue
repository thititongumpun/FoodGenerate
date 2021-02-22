<template>
  <div class="hello">
    <h1>{{ msg }} </h1>
    <div v-for='post in posts' :key='post.id'>
      <h3>Post Title: </h3>  {{post.foodName}}
      <h3>Post Body: </h3>{{post.body}}
      <img v-bind:src="post.imageData" alt="">
    </div>
  </div>
</template>

<script>
export default {
  name: 'myStore',
  data () {
    return {
      msg: 'Welcome to my VuexXXX Store'
    }
  },
  computed: {
    posts() {
    return this.$store.state.posts
    }
  },
  mounted() {
    this.$store.dispatch("getPosts");
  }
}
</script>