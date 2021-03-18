<template>
    <div>
      <h1 class="text-md-center"> Поздравляем! {{Person.Name}}  {{Person.LastName}} </h1>
            <v-img
                 :aspect-ratio="16/9"
                 :width="width"
                 src="https://www.meme-arsenal.com/memes/7c1a3d9e7032713ba4047603d218f5f5.jpg"
            ></v-img>
           
       <v-btn 
                    class="ml-2 mt-5"
                    outlined
                    rounded
                    small
                    @click="Accept()">Готово</v-btn>
    </div>
    
</template>

<script>
export default {
    name: 'Step3',
    props:['Person'],
    methods:{
       Accept: function(){
            this.$emit('Accept')
            }
        }
}
</script>

<style scoped>
</style>
