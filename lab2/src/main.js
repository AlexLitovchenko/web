import Vue from 'vue'
import App from './App.vue'
import VueSplide from '@splidejs/vue-splide'
import vuetify from './plugins/vuetify'

Vue.use(VueSplide);
Vue.config.productionTip = false

new Vue({
  vuetify,
  render: h => h(App),
}).$mount('#app')
