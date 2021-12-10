import { IAccount } from "./accountSlice";

// A mock function to mimic making an async request for data
export function authenticate(json: string) {
    return fetch('https://localhost:44373/api/Accounts', { mode: 'cors' })
        .then(response => response.json())
        .then(json => {
            console.log(json);
            return json;
        })
        .then(data => data as Promise<IAccount>);
}