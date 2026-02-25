<script setup>
// import Choice from './components/Choice.vue';
// import HelloWorld from './components/HelloWorld.vue'
// import Question from './components/Question.vue';
import QuizPage from './components/QuizPage.vue';
import RegistrationQuestion from './components/RegistrationQuestion.vue';
// import Bootstrap from 'bootstrap';
// import TheWelcome from './components/TheWelcome.vue'


</script>

<template>
  <!-- <header>
    <img alt="Vue logo" class="logo" src="./assets/logo.svg" width="125" height="125" />

    <div class="wrapper">
      <HelloWorld msg="You did it!" />
    </div>
  </header> -->

  <main>
    <!-- <QuizPage /> -->
     <!-- <RegistrationQuestion /> -->
      <router-view />
    <!-- <TheWelcome /> -->
    <!-- <Question QuestionTitle="What is your favorite programming language?">
      <Choice :ChoiceTitle="`JavaScript ${value}`" :ChoiceName="`programmingLanguage`" v-for="value in [0, 1, 2, 3]"
        :key="value" />
    </Question> -->

  </main>
</template>
<!-- 
<style scoped>
header {
  line-height: 1.5;
}

.logo {
  display: block;
  margin: 0 auto 2rem;
}

@media (min-width: 1024px) {
  header {
    display: flex;
    place-items: center;
    padding-right: calc(var(--section-gap) / 2);
  }

  .logo {
    margin: 0 2rem 0 0;
  }

  header .wrapper {
    display: flex;
    place-items: flex-start;
    flex-wrap: wrap;
  }
}
</style> -->
