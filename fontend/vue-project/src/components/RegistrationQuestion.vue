<template>

    <div class="row g-3 align-items-center">

        <label for="inputQuestion" class="col-sm-2 col-form-label">คำถาม</label>

        <div class="col-sm-10"><input type="text" id="inputQuestion" class="form-control"
            v-model="form.QuestionName"></div>


    </div>
    <div class="row g-3 align-items-center">

        <label for="inputChoice1" class="col-sm-2 col-form-label">คำตอบ 1</label>

        <div class="col-sm-10"><input type="text" id="inputChoice1" class="form-control"
            v-model="form.Choice1"
            ></div>


    </div>
    <div class="row g-3 align-items-center">

        <label for="inputChoice2" class="col-sm-2 col-form-label">คำตอบ 2</label>

        <div class="col-sm-10"><input type="text" id="inputChoice2" class="form-control"
            v-model="form.Choice2"></div>


    </div>
    <div class="row g-3 align-items-center">

        <label for="inputChoice3" class="col-sm-2 col-form-label">คำตอบ 3</label>

        <div class="col-sm-10"><input type="text" id="inputChoice3" class="form-control"
            v-model="form.Choice3"></div>


    </div>
    <div class="row g-3 align-items-center">

        <label for="inputChoice4" class="col-sm-2 col-form-label">คำตอบ 4</label>

        <div class="col-sm-10"><input type="text" id="inputChoice4" class="form-control"
            v-model="form.Choice4"
            ></div>

    </div>
    <div class="row">
        <div class="col-sm-12 offset-sm-2">
            <button type="submit" class="btn btn-primary" @click="saveQuestion">บันทึก</button>
            <button type="submit" class="btn btn-danger" @click="toMain">ยกเลิก</button>
        </div>
        
    </div>
</template>

<script>

// import {AddQuestionService} from '@/services/questions'
import { inject } from 'vue';
export default {
    name: 'RegistrationQuestion',
    data() {
        return {
            form: {
               QuestionName: '',
                Choice1: '',
                Choice2: '',
                Choice3: '',
                Choice4: ''
            }
        };
    },
    methods: {
        toMain(){
            this.$router.push('/')
        },
        async saveQuestion() {
            // console.log(this.form)
            // await AddQuestionService(this.form)
            await this.addQuestionService(this.form)
            this.$router.push('/')
        }
        // Define your component methods here
    },
    setup() {
        // Define your component setup logic here
        const addQuestionService = inject('addQuestionService')
        return { addQuestionService }
        
    },
    
};
</script>

<style scoped>
.registration-question {
    /* Add your styles here */
}
</style>