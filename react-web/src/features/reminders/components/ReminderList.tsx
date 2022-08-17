import { useEffect, useState } from "react";
import { getReminders } from "../api";
import { Reminder } from "./Reminder";

export type ReminderDTO = {
    description: string;
    expiresAt: Date;
    createdAt: Date;
}

export const ReminderList = () => {
    const [reminders, setReminders] = useState<ReminderDTO[]>();

    useEffect(() => {
        const fetchData = async () => {
            const reminders = await getReminders();
            const mappedReminders = reminders.map((reminder: ReminderDTO) =>({
                ...reminder
            }));
            setReminders(mappedReminders);
        }
        fetchData();
        }, 
    []);

    if (!reminders) return null;

    return (
        <div>
            <h1>sexo</h1>
            {/* XUNXO ALERT!: Utilizando Data como key... */}
            {reminders.map(reminder => 
                <Reminder 
                    description={reminder.description}
                    //TODO: Verificar o problema ao tentar renderizar o objeto Date...
                    createdAt={reminder.createdAt.toString()} 
                    expiresAt={reminder.expiresAt.toString()}
                />
            )}
        </div>
    );
}