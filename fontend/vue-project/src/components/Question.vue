<template>

    <div class="row">
        <div class="col-8">
            <h1>{{ QuestionTitle }}</h1>
            <slot></slot>
        </div>
        <div class="col-3">
            <button type="button" class="btn btn-danger" @click="handleDelete">ลบ</button>
        </div>

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
        handleDelete() {
            this.$emit('delete', this.id)
        }
    },
    computed: {
    },
    props: {
        QuestionTitle: {
            type: String,
            default: 'Question Title'
            // required: true
        },
        id:{
            type:String,

        }
    },
}
</script>

<style scoped>
.question {}
</style>