import Vue from 'vue'
import App from './App.vue'
import VueRouter from 'vue-router';
import store from './store';
import vuetify from './plugins/vuetify';
import Home from './components/Home';
import FoodRanking from './components/FoodRanking';
import FoodGenerate from './components/FoodGenerate';

Vue.config.productionTip = false
Vue.use(VueRouter);

const router = new VueRouter({
  mode: 'history',
  routes: [
    { path: '', component: Home },
    { path: '/foodgenerate', component: FoodGenerate },
    { path: '/ranking', component: FoodRanking }
  ]
});

new Vue({
  store,
  router,
  vuetify,
  render: h => h(App)
}).$mount('#app')
