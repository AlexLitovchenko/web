<template>
  <v-app>
    <v-main>
      <Stepper/>
    </v-main>
  </v-app>
</template>

<script>

import Stepper from './components/Stepper.vue'
export default {
  name: 'App',
  components: {
    Stepper,
  },
  data: () => ({
    //
  }),
};
</script>