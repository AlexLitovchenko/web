<template>
    <div>
        <v-stepper v-model="numStep">
            <v-stepper-header>
                <v-stepper-step :complete="numStep > 1" step="1">
                     Вход в аккаунт
                </v-stepper-step>
                 <v-divider></v-divider>
                <v-stepper-step :complete="numStep > 2" step="2">
                    Данные пользователя
                </v-stepper-step>
                 <v-divider></v-divider>
                <v-stepper-step :complete="numStep > 3" step="3">
                    Все готово
                </v-stepper-step>
                
                
            </v-stepper-header>
            <v-stepper-items>
                <v-stepper-content step="1">
                    <v-card  class="card"
                        elevation="15">
                        <Step1  @Accept="next"/>
                    </v-card>
                </v-stepper-content>
                <v-stepper-content step="2">
                    <v-card  class="card"
                        elevation="15">
                        <Step2  @Accept="AcceptName"/>
                    </v-card>
                </v-stepper-content>
                <v-stepper-content step="3">
                    <v-card  class="card"
                        elevation="15">
                        <Step3  :Person="Person"/>
                    </v-card>
                </v-stepper-content>
            </v-stepper-items>
        </v-stepper>
        
    </div>    
</template>

<script>
import Step1 from './Steps/Step1.vue'
import Step2 from './Steps/Step2.vue'
import Step3 from './Steps/Step3.vue'
export default {
    name: 'Stepper',
    components:{
        Step1,
        Step2,
        Step3
    },
    data:function(){
        return{
            Person: {
                Name:"",
                LastName:""
            },
           
            numStep: 1
        }
    },
    methods:{
        AcceptName: function(Name, LastName){
            this.Person.Name = Name
            this.Person.LastName = LastName

           

            this.numStep = this.numStep+1
        },
        next: function(){
            this.numStep = this.numStep+1
        },
        
    }
}
</script>

<style scoped>
.card{
    margin: 5% 10%;
    padding: 5% ;
}
#fon{
    background-color: blueviolet;
}
</style>