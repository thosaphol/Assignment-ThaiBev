import { GetQuestionsService,DeleteQuestionService,AddQuestionService} from '@/services/questions'
export const GetQuestionServiceImpl = () => {
    return {
        GetQuestionsService
    };
};

export const DeleteQuestionServiceImpl = () => {
    return {
        DeleteQuestionService
    };
}

export const AddQuestionServiceImpl = () => {
    return {
        AddQuestionService
    };
}