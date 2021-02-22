import Vuex from 'vuex';
import Vue from 'vue';

Vue.use(Vuex);

import state from './state';
import * as getters from './getters';
import * as actions from './actions';
import * as mutations from './mutations';


export default new Vuex.Store({
  state,
  getters,
  actions,
  mutations
})