export const SET_FOODS = (state, foods) => {
  state.foods = foods;
}

export const SET_RANDOMFOOD = (state, foods) => {
  state.food = foods;
}

export const loadingStatus = (state, newLoadingStatus) => {
  state.loadingStatus = newLoadingStatus;
}

