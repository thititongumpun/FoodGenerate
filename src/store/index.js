import axios from 'axios';
import Vuex from 'vuex';
import Vue from 'vue';

Vue.use(Vuex);

const state = {
  posts: [],
  loadingStatus: false
}

const getters = {
  loadingStatus(state) {
    return state.loadingStatus
  }
}

const actions = {
  getPosts({ commit }) {
    commit('loadingStatus', true)
      return axios.get('https://foodgenerateapi.herokuapp.com/api/foods')
        .then(res => {
          commit('SET_POSTS', res.data)
          commit('loadingStatus', false)
          console.log(res.data)
    })
  }
}

const mutations = {
  SET_POSTS(state, posts) {
    state.posts = posts
  },
  loadingStatus(state, newLoadingStatus) {
    state.loadingStatus = newLoadingStatus
  }
}

export default new Vuex.Store({
  state,
  getters,
  actions,
  mutations
})