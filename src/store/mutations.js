export const SET_FOODS = (state, foods) => {
  state.foods = foods;
}

export const loadingStatus = (state, newLoadingStatus) => {
  state.loadingStatus = newLoadingStatus;
}