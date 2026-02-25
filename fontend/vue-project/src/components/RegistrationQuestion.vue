<template>

    <div class="row g-3 align-items-center">

        <label for="inputQuestion" class="col-sm-2 col-form-label">คำถาม</label>

        <div class="col-sm-10"><input type="text" id="inputQuestion" class="form-control"></div>


    </div>
    <div class="row g-3 align-items-center">

        <label for="inputChoice1" class="col-sm-2 col-form-label">คำตอบ 1</label>

        <div class="col-sm-10"><input type="text" id="inputChoice1" class="form-control"></div>


    </div>
    <div class="row g-3 align-items-center">

        <label for="inputChoice2" class="col-sm-2 col-form-label">คำตอบ 2</label>

        <div class="col-sm-10"><input type="text" id="inputChoice2" class="form-control"></div>


    </div>
    <div class="row g-3 align-items-center">

        <label for="inputChoice3" class="col-sm-2 col-form-label">คำตอบ 3</label>

        <div class="col-sm-10"><input type="text" id="inputChoice3" class="form-control"></div>


    </div>
    <div class="row g-3 align-items-center">

        <label for="inputChoice4" class="col-sm-2 col-form-label">คำตอบ 4</label>

        <div class="col-sm-10"><input type="text" id="inputChoice4" class="form-control"></div>

    </div>
    <div class="row">
        <div class="col-sm-12 offset-sm-2">
            <button type="submit" class="btn btn-primary">บันทึก</button>
            <button type="submit" class="btn btn-danger">ยกเลิก</button>
        </div>
        
    </div>
</template>

<script>
export default {
    name: 'RegistrationQuestion',
    data() {
        return {
            // Define your component data here
        };
    },
    methods: {
        // Define your component methods here
    }
};
</script>

<style scoped>
.registration-question {
    /* Add your styles here */
}
</style>