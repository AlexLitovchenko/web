<template>
    <div>
            <h1>Обо мне</h1>

            <p class="Error">{{Error}}</p>
            
            <v-text-field class="vInput"
                v-model="Name"
                label="Имя"
                placeholder="">
            </v-text-field>
            <v-text-field class="vInput"
                v-model="LastName"
                label="Фамилия"
                placeholder="">
            </v-text-field>
            <v-text-field class="vInput"
                v-model="Pol"
                label="Пол"
                placeholder="">
            </v-text-field>
            <v-text-field class="vInput"
                v-model="Bithday"
                label="Дата рождения"
                placeholder="">
            </v-text-field>
            <v-text-field class="vInput"
                v-model="Hobbi"
                label="Хобби"
                placeholder="">
            </v-text-field>
            <v-btn 
                    class="ml-2 mt-5"
                    outlined
                    rounded
                    small
                    @click="Accept()">Далее</v-btn>
            
    </div>
</template>
 
<script>
export default {
    name: 'Step2',
    data: function(){
        return{
            Name: "",
            LastName: "",
            Pol:"",
            Bithday:"",
            Hobbi:"",
            Error: ""
        }
    },
    methods:{
        Accept: function(){
            if((this.Name == "")||(this.LastName == "")|| (this.Pol=="")||(this.Bithday=="")||(this.Hobbi==""))
                this.Error = "Заполните все поля"
            else{
                this.Error = "",
                this.$emit('Accept',this.Name, this.LastName,this.Pol,this.Bithday,this.Hobbi)
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