// src/services/questions.js

export const AddQuestion = async (QuestionName, Choice1, Choice2, Choice3, Choice4) => {
    const questionData = {
        question: QuestionName,
        choices: [Choice1, Choice2, Choice3, Choice4]
    };

    try {
        const response = await fetch('YOUR_API_ENDPOINT_HERE', {
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


export const GetQuestions = async () => {
    try {
        const response = await fetch('YOUR_API_ENDPOINT_HERE', {
            method: 'GET',
            headers: {
                'Content-Type': 'application/json',
            },
        });

        if (!response.ok) {
            throw new Error('Network response was not ok');
        }

        const data = await response.json();
        return data.map(question => ({
            QuestionTitle: question.question,
            Choice1: question.choices[0],
            Choice2: question.choices[1],
            Choice3: question.choices[2],
            Choice4: question.choices[3],
        }));
    } catch (error) {
        console.error('Error fetching questions:', error);
        throw error;
    }
};

