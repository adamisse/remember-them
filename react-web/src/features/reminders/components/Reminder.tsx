interface ReminderProps{
    description: string;
    createdAt: string;
    expiresAt: string;
}

export const Reminder = (props: ReminderProps) => {
    return (
        <div>
            <h1>{props.description}</h1>
            <span>{props.expiresAt}|</span>
            <span>{props.createdAt}</span>
        </div>
    )
}