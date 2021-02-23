export const loadingStatus = (state) => {
  return state.loadingStatus;
}

export const randomFood = (state) => {
  let foods = state.foods;
  let random = foods[Math.floor(Math.random()) * foods.length];
  return random;
}