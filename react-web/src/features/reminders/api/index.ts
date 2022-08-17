import axios from 'axios';

export type Reminder = {
    id: string; //TODO: Verificar se o ts fará o cast será automático (Guid p/ string)
    description: string;
    expiresAt: Date;
    createdAt: Date;
}

export const getReminders = async (): Promise<Reminder[]> => {
    const result = await axios.get(' https://edcc-2804-d57-4e0f-8c00-b8ea-50cc-3bce-3ad1.sa.ngrok.io/api/reminders');
    return result.data;
}