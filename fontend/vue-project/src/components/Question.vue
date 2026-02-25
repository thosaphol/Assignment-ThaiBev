<template>
    
    <div class="question">
        <h1>{{ QuestionTitle }}</h1>
        <slot></slot>
    </div>
</template>

<script>
export default {
    name: 'Question',
    data() {
        return {
        }
    },
    methods: {
    },
    computed: {
    },
    props: {
        QuestionTitle: {
            type: String,
            default: 'Question Title'
            // required: true
        }
    },
}
</script>

<style scoped>
.question {
}
</style>