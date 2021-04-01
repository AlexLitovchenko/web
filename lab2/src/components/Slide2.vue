<template>
<div>
     <h1>Отзыв </h1>  
        <img  src="https://bipbap.ru/wp-content/uploads/2017/10/0_8eb56_842bba74_XL-640x400.jpg" width='50%' height='70%' >
     <v-card-text   class="vInput"> Имя:{{Name}} </v-card-text>
    
     <v-card-text class="vInput">Фамилия:{{Lastname}} </v-card-text>   
  
     <v-card-text  class="vInput">Отзыв:{{ Information}}  </v-card-text>
     
</div>    
</template>
<script>
export default {
    name: 'Slide2',
    data: function(){
        return{
            Name: "Алексей",
          Lastname: "Литовченко",
            Information:"Работает",
        }
}
}
</script>
<style scoped>
.vInput{
    width: 50%;
    background-color: chartreuse;
    color: rgb(53, 2, 12);
}

</style>