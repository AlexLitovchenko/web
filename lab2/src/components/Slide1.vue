<template>
<div>
        <h1>Отзыв</h1>  
 <img  src="http://fotorelax.ru/wp-content/uploads/2016/03/Beautiful-photos-and-pictures-on-various-subjects-01.jpg" width='50%' height='70%' >
 <p class="Error">{{Error}}</p>
  <v-text-field class="vInput"
                v-model="Name"
                label="Name"
                placeholder="">
            </v-text-field>
            <v-text-field class="vInput"
                v-model="LastName"
                label="LastName"
                placeholder="">
            </v-text-field>
             <v-text-field class="vInput"
                v-model="Information"
                label="Information"
                placeholder="">
            </v-text-field>
            
             <v-btn 
                    class="ml-2 mt-5"
                    outlined
                    rounded
                    small @click="Accept()">Сохранить</v-btn>

       
</div>
    
        
    
</template>
<script>
export default {
   

    methods:{
        Accept: function(){
            if((this.Name== "")||(this.LastName == "")||(this.Information == ""))
                this.Error = "Заполните все поля"
            else{
                this.Error = "",
                this.$emit('Accept',this.Name, this.LastName,this.Information)
            }
        }
    }
}

</script>
<style scoped>
.vInput{
    width: 50%;
}
.Error{
    color: rgb(163, 217, 233);
}

</style>