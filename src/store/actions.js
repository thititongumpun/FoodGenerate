import axios from 'axios';

export const getFoods = ({ commit }) => {
  commit('loadingStatus', true);
    return axios.get('https://foodgenerateapi.herokuapp.com/api/foods')
    .then(res => {
      commit('SET_FOODS', res.data);
      commit('loadingStatus', false);
      console.log(res.data);
    }).catch(error => {
      throw new Error(`API ${error}`);
    });
}