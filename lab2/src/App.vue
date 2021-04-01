<template>
 <v-app>
    <v-main>
      <SplideSlide/>
    </v-main>
  </v-app>
</template>

<script>
import SplideSlide from './components/SplideSlide.vue';

export default {
  name: 'App',

  components: {
    SplideSlide,
  },

  data: () => ({
    //
  }),
};
</script>
