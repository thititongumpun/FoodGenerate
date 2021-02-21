import Vue from 'vue'
import App from './App.vue'
import VueRouter from 'vue-router';
import store from './store';
import vuetify from './plugins/vuetify';
import FoodRanking from './components/FoodRanking';
import FoodGenerate from './components/FoodGenerate';

Vue.config.productionTip = false
Vue.use(VueRouter);

const routes = [
  { path: '/foodgen', component: FoodGenerate },
  { path: '/ranking', component: FoodRanking }
  
]

const router = new VueRouter({
  routes
});

new Vue({
  store,
  router,
  vuetify,
  render: h => h(App)
}).$mount('#app')
