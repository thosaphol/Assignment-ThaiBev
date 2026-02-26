// import './assets/main.css'

import { createApp } from 'vue'
import App from './App.vue'
import router from './router'
import 'bootstrap/dist/css/bootstrap.min.css'
import 'bootstrap/dist/js/bootstrap.bundle.min.js'

import {GetQuestionsService,DeleteQuestionService,AddQuestionService} from '@/services/questions'
import { GetQuestionServiceImpl,DeleteQuestionServiceImpl,AddQuestionServiceImpl } from '@/services/factories/questions'
// import { createQuestionService } from './services/questionService'
import { GetQuestionServiceKey,DeleteQuestionServiceKey,AddQuestionServiceKey } from '@/services/di/keys'

createApp(App)
// .provide('questionService', GetQuestionsService)
.provide(GetQuestionServiceKey, GetQuestionServiceImpl())
.provide(DeleteQuestionServiceKey, DeleteQuestionServiceImpl())
.provide(AddQuestionServiceKey, AddQuestionServiceImpl())
// .provide('addQuestionService', AddQuestionService)
.use(router)
.mount('#app')
