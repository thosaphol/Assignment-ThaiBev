// src/services/questions.js

export const AddQuestionService = async ({QuestionName, Choice1, Choice2, Choice3, Choice4}) => {
    const questionData = {
        Title: QuestionName,
        Choice1, Choice2, Choice3, Choice4
    };

    try {
        const response = await fetch('http://localhost:5208/api/Questions', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json',
            },
            body: JSON.stringify(questionData),
        });

        if (!response.ok) {
            throw new Error('Network response was not ok');
        }

        const data = await response.json();
        return data;
    } catch (error) {
        console.error('Error adding question:', error);
        throw error;
    }
};


export const GetQuestionsService = async () => {
    try {
        const response = await fetch('http://localhost:5208/api/Questions', {
            method: 'GET',
            headers: {
                'Content-Type': 'application/json',
            },
        });

        if (!response.ok) {
            throw new Error('Network response was not ok');
        }

        const data = await response.json();
        console.log('raw data:',data)
        let afterMap = data.map(question => ({
            id:question.id,
            QuestionTitle: question.title,
            Choice1: question.choice1,
            Choice2: question.choice2,
            Choice3: question.choice3,
            Choice4: question.choice4,
        }));
        console.log('afterMap data:',afterMap)
        return afterMap;
    } catch (error) {
        console.error('Error fetching questions:', error);
        throw error;
    }
};

export async function DeleteQuestionService(id) {
    try {
        console.log('delete id:',id)
        const response = await fetch(`http://localhost:5208/api/Questions/${id}`, {
            method: 'DELETE',
            headers: {
                'Content-Type': 'application/json'
            }
        });

        if (!response.ok) {
            throw new Error('Failed to delete');
        }

        console.log("Delete success");
    } catch (error) {
        console.error("Error deleting question:", error);
    }
}

