<template>
    <div class="mb-2">
        <button type="button" class="btn btn-success" @click="addQuestion">เพิ่มข้อสอบ</button>
    </div>
    
    <Question 
    v-for="question in questions"
        :key="question.id"
        :QuestionTitle="question.QuestionTitle"
        :id="question.id"
        @delete="handleDelete"
    >
        <Choice :ChoiceTitle="question.Choice1" :ChoiceName="`choiceName${question.id}`" 
             /> 
            <Choice :ChoiceTitle="question.Choice2" :ChoiceName="`choiceName${question.id}`"
             /> 
            <Choice :ChoiceTitle="question.Choice3" :ChoiceName="`choiceName${question.id}`"
           /> 
            <Choice :ChoiceTitle="question.Choice4" :ChoiceName="`choiceName${question.id}`"
             /> 
    </Question>

</template>

<script>
import Question from './Question.vue';
import Choice from './Choice.vue';
import {GetQuestionsService,DeleteQuestionService} from '@/services/questions'

export default {
    name: 'QuizPage',
    data() {
        return {
            // Define your data properties here
            questions: []
        };
    },
    methods: {
        // Define your methods here
        addQuestion() {
            // console.log("เพิ่มข้อสอบ");
            this.$router.push('/registration')
        },
        async handleDelete(id){
            await DeleteQuestionService(id)
            await this.RefreshQuestion()
            this.questions = this.questions.filter(q => q.id !== id)
        }
        ,
        async RefreshQuestion(){
            try {
                 console.log(import.meta.env.VITE_API_BASE_URL);
                const response = await GetQuestionsService();
                console.log('response log:',response);
                let data = response;
                this.questions = data;
                console.log(data);
            } catch (error) {
                console.error("Error fetching questions:", error);
            }
        }
    },
    async mounted() {
         await this.RefreshQuestion();
        // Code to run when the component is mounted
    },
    components: {
        Question,
        Choice
        // Choice
    },
};
</script>