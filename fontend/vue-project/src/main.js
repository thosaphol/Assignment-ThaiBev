// import './assets/main.css'

import { createApp } from 'vue'
import App from './App.vue'
import router from './router'
import 'bootstrap/dist/css/bootstrap.min.css'
import 'bootstrap/dist/js/bootstrap.bundle.min.js'

import {GetQuestionsService,DeleteQuestionService,AddQuestionService} from '@/services/questions'

createApp(App)
.provide('questionService', GetQuestionsService)
.provide('deleteQuestionService', DeleteQuestionService)
.provide('addQuestionService', AddQuestionService)
.use(router)
.mount('#app')
