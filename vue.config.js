module.exports = {
  publicPath: process.env.NODE_ENV === 'production'
    ? '/FoodGenerate/'
    : '/FoodGenerate/',

  transpileDependencies: [
    'vuetify'
  ]
}
