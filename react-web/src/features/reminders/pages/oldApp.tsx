import React from 'react';
// import axios from 'axios';

// const baseURL = "https://edcc-2804-d57-4e0f-8c00-b8ea-50cc-3bce-3ad1.sa.ngrok.io/api/reminders";

// interface IPost {
//   title: string;
//   body: string;
// }

// const App = () =>  {
//   const [reminders, setReminders] = React.useState<any>(null);

//   React.useEffect(() => {
//     axios.get(baseURL)
//     .then(res => {
//       const reminders = res.data?.map((obj: { description: any; expiresAt: any; createdAt: any; }) => (
//           {
//             description: obj.description, 
//             expiresAt: obj.expiresAt,
//             createdAt: obj.createdAt
//           }
//         )
//       );
    //       setReminders(reminders);
    //     });
    //   }, []);

//   if (!reminders) return null;

//   return (
//     <div className="App">
//       {reminders.map((r: { createdAt: string | number | boolean | React.ReactElement<any, string | React.JSXElementConstructor<any>> | React.ReactFragment | React.ReactPortal | null | undefined; description: string | number | boolean | React.ReactElement<any, string | React.JSXElementConstructor<any>> | React.ReactFragment | React.ReactPortal | null | undefined; expiresAt: string | number | boolean | React.ReactElement<any, string | React.JSXElementConstructor<any>> | React.ReactFragment | React.ReactPortal | null | undefined; }) => 
//       <div>
//         {r.createdAt} - <strong>{r.description}</strong> - {r.expiresAt}
//       </div>)}

//     </div>
//   );
// }

// export default App;