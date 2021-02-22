<template>
  <div id="app">
    <v-toolbar rounded>
        <v-btn text to="/">Home</v-btn>
      <v-spacer></v-spacer>
        <v-toolbar-items class="hidden-sm-and-down">
        <v-btn text to="/random">Random</v-btn>
        <v-btn text to="/ranking">Ranking</v-btn>
      </v-toolbar-items>
    </v-toolbar>
      <v-main>
        <router-view></router-view>
      </v-main>
  </div>
</template>

<script>
export default {
  name: 'App',
  components: {
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
}
</style>