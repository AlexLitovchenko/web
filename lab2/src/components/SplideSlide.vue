<template>
 <splide align="middle" :options="options" >
     <splide-slide >
       <v-card class="card" elevation="7">
         <Slide1/>
       </v-card>
     </splide-slide>
     <splide-slide>
        <v-card class="card" elevation="7">
         <Slide2/>
        </v-card>
     </splide-slide>
 </splide>
 
</template>
<script>


import '@splidejs/splide/dist/css/themes/splide-skyblue.min.css';
import Slide1 from "./Slide1.vue";
import Slide2 from "./Slide2.vue";
import {Splide, SplideSlide} from '@splidejs/vue-splide';
export default{
  components:{
    Slide1,
    Slide2,
    Splide,
    SplideSlide,
  },
 
data(){
  return{
    options:{
      
      width: '100%',
      height: '50%',
      perPage : 1,
      gap: '5rem',
      focus : 'center',
      
    },

  }
}
}
 


</script>
<style >
.card{
    margin: 3% 3%;
    padding: 5% ;
    width: 50%;
      height: 70%;
}

</style>