module.exports = {
  publicPath: process.env.NODE_ENV === 'production'
    ? '/FoodGenerate/'
    : '/',

  transpileDependencies: [
    'vuetify'
  ]
}
