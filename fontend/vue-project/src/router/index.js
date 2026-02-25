import { createRouter, createWebHistory } from 'vue-router'
import QuizPage from '@/components/QuizPage.vue'
import RegistrationQuestion from '@/components/RegistrationQuestion.vue'

const routes = [
  {
    path: '/',
    name: 'Quiz',
    component: QuizPage
  },
  {
    path: '/registration',
    name: 'Registration',
    component: RegistrationQuestion
  }
]

const router = createRouter({
  history: createWebHistory(),
  routes
})

export default router