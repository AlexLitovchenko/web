<template>
    <div>
      <p> Поздравляем! {{Person.Name}}{{Person.LastName}} </p>
            <v-img
                 :aspect-ratio="16/9"
                 :width="width"
                 src="https://www.meme-arsenal.com/memes/7c1a3d9e7032713ba4047603d218f5f5.jpg"
            ></v-img>
           
       <v-btn @click="Accept()">Далее</v-btn>
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
