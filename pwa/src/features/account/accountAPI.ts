import { IAccount } from "./accountSlice";

// A mock function to mimic making an async request for data
export function authenticate(json: string) {
    return fetch('https://localhost:5001/account', { mode: 'cors' })
        .then(response => response.json())
        .then(data => data as Promise<IAccount>);
}