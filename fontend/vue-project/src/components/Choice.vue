<template>
    <!-- <div class="choice">
        <h1>Choice Component</h1>
    </div> -->
    <div class="form-check">
        <input class="form-check-input" type="radio" :name="ChoiceName" id="radioDefault1">
        <label class="form-check-label" for="radioDefault1">
            {{ ChoiceTitle }}
        </label>
    </div>
</template>

<script>
export default {
    name: 'Choice',
    data() {
        return {
        }
    },
    methods: {
    },
    computed: {
    },
    props: {
        ChoiceTitle: {
            type: String,
            required: true
        },
        ChoiceName: {
            type: String,
            required: true
        }
    },

}
</script>
