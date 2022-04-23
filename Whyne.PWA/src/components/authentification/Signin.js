import React, {useEffect, UserState} from 'react'
import { BrowserRouter as Router, Route, Link, Routes } from "react-router-dom"

export default function Signin() {

    // const FooBarForm = () => {
    //   const [formData, updateFormData] = React.useState(initialFormData);
    
    //   const handleChange = (e) => {
    //     updateFormData({
    //       ...formData,
    
    //       // Trimming any whitespace
    //       [e.target.name]: e.target.value.trim()
    //     });
    //   };
    
    //   const handleSubmit = (e) => {
    //     e.preventDefault()
    //     console.log(formData);
    //     // ... submit to API or something
    //   };
    // }
  
    return (     
    <div>
        <Link to="/">⇐ Retour</Link>
        <h1>Créer votre compte</h1>
        <div className="form">
            <form>
                <label>Nom d'utilisateur </label><br />
                <input type="text" name="username" />
                <br />
                <label>Email </label><br />
                <input type="email" name="email" />
                <br />
                <label>Mot de passe:</label><br />
                <input type="password" name="pwd" />
                <br /><br />
                <input type="submit" value="submit"/>
            </form>
        </div>
    </div> 
  );
}