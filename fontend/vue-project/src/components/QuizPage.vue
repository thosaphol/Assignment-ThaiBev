<template>
    <Question QuestionTitle="What is your favorite programming language?">
        <Choice :ChoiceTitle="`JavaScript ${value}`" :ChoiceName="`programmingLanguage`" v-for="value in [0, 1, 2, 3]"
            :key="value" /> 
    </Question>

</template>

<script>
import Question from './Question.vue';
import Choice from './Choice.vue';

export default {
    name: 'QuizPage',
    data() {
        return {
            // Define your data properties here
        };
    },
    methods: {
        // Define your methods here
    },
    mounted() {
        // Code to run when the component is mounted
    },
    components: {
        Question,
        Choice
        // Choice
    },
};
</script>