<template>
    <div>
            <h1>Вход :</h1>

            <p class="Error">{{Error}}</p>
            
            <v-text-field class="vInput"
                v-model="Log"
                label="Login"
                placeholder="">
            </v-text-field>
            <v-text-field class="vInput"
                v-model="Pas"
                label="Password"
                placeholder="">
            </v-text-field>
            <v-btn 
                    class="ml-2 mt-5"
                    outlined
                    rounded
                    small @click="Accept()">Вход</v-btn>
            
    </div>
</template>
 
<script>
export default {
    name: 'Step1',
     data: function(){
        return{
            Log:"",
            Pas:"",
            Error: ""
        }
     },
    methods:{
        Accept: function(){
            if((this.Log== "")||(this.Pas == ""))
                this.Error = "Заполните все поля"
            else{
                this.Error = "",
                this.$emit('Accept',this.Log, this.Pas)
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
    color: rgb(255, 0, 0);
}
#fon{
    background-color: blueviolet;
}

</style>