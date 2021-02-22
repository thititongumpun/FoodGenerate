import Home from './components/Home';
import FoodGenerate from './components/FoodGenerate';
import FoodRanking from './components/FoodRanking';
import PageNotFound from './components/PageNotFound';


export default [
  {
    path: '/',
    component: Home
  },
  {
    path: '/random',
    component: FoodGenerate
  },
  {
    path: '/ranking',
    component: FoodRanking
  },
  {
    path: '*',
    component: PageNotFound
  }
];