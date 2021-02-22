import Vue from 'vue'
import App from './App.vue'
import VueRouter from 'vue-router';
import Spinner from 'vue-simple-spinner';
import store from './store';
import vuetify from './plugins/vuetify';
import routes from './routes';

Vue.config.productionTip = false
Vue.use(VueRouter);

const router = new VueRouter({
  routes: routes,
  base: '/FoodGenerate/',
  mode: 'history'
});

new Vue({
  store,
  router,
  vuetify,
  components: {
    Spinner
  },
  render: h => h(App)
}).$mount('#app')
