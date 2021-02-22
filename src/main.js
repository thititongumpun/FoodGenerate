import Vue from 'vue'
import App from './App.vue'
import VueRouter from 'vue-router';
import Spinner from 'vue-simple-spinner';
import store from './store';
import vuetify from './plugins/vuetify';
import Home from './components/Home';
import FoodRanking from './components/FoodRanking';
import FoodGenerate from './components/FoodGenerate';
import PageNotFound from './components/PageNotFound';

Vue.config.productionTip = false
Vue.use(VueRouter);

const router = new VueRouter({
  base: '/FoodGenerate/',
  mode: 'history',
  routes: [
    { path: '', component: Home },
    { path: '/random', component: FoodGenerate },
    { path: '/ranking', component: FoodRanking },
    { path: '*', component: PageNotFound}
  ]
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
